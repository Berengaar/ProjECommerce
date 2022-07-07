using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Basket : BaseEditableEntity
    {
        public IList<Product> Products { get; set; }
        public string CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
