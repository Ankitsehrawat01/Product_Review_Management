using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class productmanagement
    {
        public static void Top3Records(List<product> productreview)
        {
            var productdata = (from products in productreview orderby products.rating descending select products).Take(3);
            foreach (var products in productdata)
            {
                Console.WriteLine(products.ProductID + " | " + products.Userid + " | " + 
                                  products.rating + " | " + products.Review + " | " + products.Islike);
            }
        }
    }
}

