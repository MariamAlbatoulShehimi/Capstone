using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;


namespace Capstone.Models
{
    public class Product
    {
        public Product() {

            AddedDate = DateTime.UtcNow;

        }
        [Key]
        public int Id { get; set; } // Primary key for the product

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters")]
        public string Name { get; set; } // e.g., "Blanket", "Food Package"

        public string Description { get; set; } // Detailed description of the item

        // Availability and Location
        [Required(ErrorMessage = "Quantity Available is required")]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be a positive number")]
        public int QuantityAvailable { get; set; } // How many items are available

        [Required(ErrorMessage = "Location is required")]
        [StringLength(100, ErrorMessage = "Location name cannot exceed 100 characters")]
        public string Location { get; set; } // e.g., "Beirut", "Tripoli"

        //// Specifications and Details
        //[Required]
        //public DateTime ExpiryDate { get; set; } // Nullable: For food or perishable items
        //public bool IsNew { get; set; } // Whether the item is new or second-hand (for clothing, blankets, etc.)

        ////// Donation and Support Information
        //[Required]
        //public bool IsDonated { get; set; } // Indicates if the item was donated
        //[Required]
        
        public DateTime AddedDate { get; set; } // Date when the item was added to the system
        public string Condition { get; set; }  // e.g., "New", "Good", "Used"

        //// Administrative Fields
        //[Required]
        //public bool IsActive { get; set; } // Whether the item is currently available for distribution

        // Price Information
        [Required(ErrorMessage = "List Price is required")]
        [Range(1, 1000, ErrorMessage = "Price must be between 1 and 1000")]
        [Display(Name = "List Price")]
        public double ListPrice { get; set; } // Price of the item
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        [ValidateNever]
        public Category Category { get; set; }
        [ValidateNever]
        public string ImageUrl { get; set; }
    }
}
