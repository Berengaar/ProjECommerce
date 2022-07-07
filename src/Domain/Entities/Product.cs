using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Property { get; set; }
        public decimal Price { get; set; }
        public int PercentDiscount { get; set; }
        public decimal LastPrice { get; set; }  // Price - (Price * PercentDiscount)
        public string ColorId { get; set; }
        public Color Color { get; set; }
        public string BrandId { get; set; }
        public Brand Brand { get; set; }
        public string CategoryId { get; set; }
        public Category Category { get; set; }
        public string? BasketId { get; set; }
        public Basket? Basket { get; set; }
        public string? OrderId { get; set; }
        public Order? Order { get; set; }
        public IList<Comment> Comments { get; set; }
    }
}
