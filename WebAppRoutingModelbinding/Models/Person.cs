using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppRoutingModelbinding.Models
{
    public class PersonBindingModel
    {
        [Required]
        public string Name { get; set; } = "Bot bot";
        public UInt16 Age { get; set; } = 18;
        public double Height { get; set; } = 1.80;
    }
}
