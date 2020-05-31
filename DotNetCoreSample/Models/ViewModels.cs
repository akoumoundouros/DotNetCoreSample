using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreSample.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public int ItemId { get; set; }
        public string Item { get; set; }
        public int Quantity { get; set; }
    }
}
