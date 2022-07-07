using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO_s.ProductDtos
{
    public class ProductListDto
    {
        public string Name { get; set; }
        public string Property { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
    }
}
