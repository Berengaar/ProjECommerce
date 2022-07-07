using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Comment : BaseEntity
    {
        public int Point { get; set; }
        public string Content { get; set; }
        public string ProductId { get; set; }
        public Product Product { get; set; }
    }
}
