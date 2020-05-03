using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Domain.Dto
{
    public class ProductDto
    {
        [JsonProperty("id")]
        public Guid ProductIdentifier { get; set; }
        [JsonProperty("ProdctName")]
        public string ProductName { get; set; }
        [JsonProperty("ProductCategory")]
        public string ProductCatName { get; set; }
        [JsonProperty("ProductTransport")]
        public string ProductTransport { get; set; }
        [JsonProperty("IsPerish")]
        public bool IsProductPerishable { get; set; }
        [JsonProperty("Notes")]
        public string Notes { get; set; }

    }
}
