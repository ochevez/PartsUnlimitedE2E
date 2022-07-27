using System;
using System.ComponentModel.DataAnnotations;

namespace PartsUnlimited.Models
{
    // test02
    public class CartItem : ILineItem
    {
        // primer cambio oscar chevez
        [Key]
        public int CartItemId { get; set; }
        
        [Required]
        public string CartId { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateCreated { get; set; }

        public virtual Product Product { get; set; }
    }
}
