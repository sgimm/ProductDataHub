using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductDataHub.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductIdentifier {get;set;}
        public string EAN { get; set; }        
    }
}
