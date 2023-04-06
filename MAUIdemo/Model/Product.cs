using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIdemo.Model
{
    public class Product
    {

        public int id { get; set; }

        public string productName { get; set; }

        public string imageURL { get; set; }
         public int price { get; set; } 

        public string productDescription { get; set; }


        public int categoryID { get; set; }
    }
}
