using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServerApp.Models
{
    public class Products
    {

        public long ProductId { get; set; } // primary key
        public string name { get; set; }        // regular property that stores simple data
        public string Category { get; set; }    // regular property that stores simple data
        public string Description { get; set; } // regular property that stores simple data

        [Column(TypeName = "decimal(8, 2)")]
        public decimal Price { get; set; }      // regular property that stores simple data

        // Objects accessed through a navigation property are referred to as related data

        public Supplier Supplier { get; set; }      // Navigation Properties that Entity Framework Core uses to associate a Product object with other data in the database
        public List<Rating> Ratings { get; set; }   // Navigation Properties that Entity Framework Core uses to associate a Product object with other data in the database

    }
}