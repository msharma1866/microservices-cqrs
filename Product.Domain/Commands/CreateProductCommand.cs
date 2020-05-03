//using Newtonsoft.Json;
using Product.Domain.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Domain.Commands
{
    public class CreateProductCommand : CommandBase<ProductDto>
    {
        public Guid ProductId { get; set; }
       // [JsonProperty("name")]
        [Required]
        [MaxLength(255)]
        public string ProductName { get; set; }

//[JsonProperty("name")]
        [Required]
        [MaxLength(255)]
        public string ProductCategory { get; set; }
        public string ProductTransport { get; set; }
        public bool IsProductPerishable { get; set; }
        public string Notes { get; set; }

        public CreateProductCommand()
        {
            // ProductId = Guid.NewGuid();
        }

       // [JsonConstructor]
        public CreateProductCommand(string prodName, string prodCategory, string prodTransport, bool isProdPerishable, string notes)
        {         
            ProductName = prodName;
            ProductCategory = prodCategory;
            ProductTransport = prodTransport;
            IsProductPerishable = isProdPerishable;
            Notes = notes;
        }
    }
}

