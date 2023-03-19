using Product_Web.Data.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Product_Web_App.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Stock { get; set; }

        //[ForeignKey(nameof(User))]
        //public int UserId { get; set; }

    }
}
