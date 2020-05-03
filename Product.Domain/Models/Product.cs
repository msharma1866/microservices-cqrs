using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Domain.Models
{
    public class Product : ModelBase
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductCategory { get; set; }
        public string ProductTransport { get; set; }
        public bool   IsProductPerishable { get; set; }
        public string Notes { get; set; }

        public Product()
        {
           // ProductId = Guid.NewGuid();
        }
        public Product(string prodName, string prodCategory, string prodTransport, bool isProdPerishable, string notes)
        {
            ProductId = Guid.NewGuid(); 
            ProductName = prodName;
            ProductCategory = prodCategory;
            ProductTransport = prodTransport;
            IsProductPerishable = isProdPerishable;
            Notes = notes;
        }
    }
}
