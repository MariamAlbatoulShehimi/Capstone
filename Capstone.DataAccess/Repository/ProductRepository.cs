using Capstone.DataAccess.Data;
using Capstone.DataAccess.Repository.IRepository;
using Capstone.DataAccess.Repository;
using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Product obj)
        {
            var objFromDb = _db.Products.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.Name = obj.Name;
                objFromDb.Description = obj.Description;
                objFromDb.QuantityAvailable = obj.QuantityAvailable;
                objFromDb.Location = obj.Location;
                objFromDb.ListPrice = obj.ListPrice;
               // objFromDb.IsNew = obj.IsNew;
                objFromDb.CategoryId = obj.CategoryId;
               // objFromDb.IsDonated = obj.IsDonated;
                objFromDb.AddedDate = obj.AddedDate;
                //objFromDb.IsActive = obj.IsActive;
                objFromDb.Condition = obj.Condition;
                if (obj.ImageUrl != null)
                {
                    objFromDb.ImageUrl = obj.ImageUrl;
                }
            }
        }
    }
}
