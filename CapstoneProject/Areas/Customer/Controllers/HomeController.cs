using Capstone.DataAccess.Data;
using Capstone.DataAccess.Repository.IRepository;
using Capstone.Models;
using Capstone.Models.ViewModels;
using Capstone.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Security.Claims;

namespace CapstoneProject.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        private readonly ApplicationDbContext _db;
        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork, ApplicationDbContext db)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
            _db = db;
        }

        //public IActionResult Index()
        //{
        //    IEnumerable<Product> productList = _unitOfWork.Product.GetAll(includeProperties: "Category");
        //    return View(productList);
        //}
        public IActionResult Index(int categoryId = 0)
        {
            var viewModel = new HomeVM
            {
                Categories = _db.Categories.ToList(),
                Products = categoryId == 0
                    ? _db.Products.Include(p => p.Category).ToList()
                    : _db.Products.Include(p => p.Category).Where(p => p.CategoryId == categoryId).ToList()
            };

            return View(viewModel);
        }

        public IActionResult Details(int productId)
        {
            ShoppingCart cart = new()
            {
                Product = _unitOfWork.Product.Get(u => u.Id == productId, includeProperties: "Category"),
                Count = 1,
                ProductId = productId
            };
            return View(cart);
        }
        [HttpPost]
        [Authorize]
        public IActionResult Details(ShoppingCart shoppingCart)
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value;
            shoppingCart.ApplicationUserId = userId;
            ShoppingCart cartFromDb = _unitOfWork.ShoppingCart.Get(u => u.ApplicationUserId == userId &&
            u.ProductId == shoppingCart.ProductId);

            if (cartFromDb != null)
            {
                //shopping cart exists
                cartFromDb.Count += shoppingCart.Count;
                _unitOfWork.ShoppingCart.Update(cartFromDb);
                
            }
            else
            {
                //add cart record
                _unitOfWork.ShoppingCart.Add(shoppingCart);
                //_unitOfWork.Save();
                //HttpContext.Session.SetInt32(SD.SessionCart,
                //_unitOfWork.ShoppingCart.GetAll(u => u.ApplicationUserId == userId).Count());
            }
            TempData["success"] = "Cart updated successfully";
            _unitOfWork.Save();
            return RedirectToAction(nameof(Index));
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new Capstone.Models.ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
       

    }

}
