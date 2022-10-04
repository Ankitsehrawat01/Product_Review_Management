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
        public static void GetData(List<product> productreview)
        {
            var productdata = from products in productreview
                              where (products.ProductID == 1 && products.rating > 3) ||
                              (products.ProductID == 4 && products.rating > 3) ||
                              (products.ProductID == 9 && products.rating > 3)
                              select products;
            foreach (var products in productdata)
            {
                Console.WriteLine(products.ProductID + " | " + products.Userid + " | " +
                                  products.rating + " | " + products.Review + " | " + products.Islike);
            }
        }
        public static void GetCount(List<product> productreview)
        {
            var productdata = productreview.GroupBy(x => x.ProductID).Select(x=> new {ProductID=x.Key, Count=x.Count()});
            foreach (var products in productdata)
            {
                Console.WriteLine(products.ProductID +" " +products.Count);
            }
        }
        public static void GetProductIDandReview(List<product> productreview)
        {
            var productdata = from products in productreview select new { products.ProductID, products.Review };
            foreach (var products in productdata)
            {
                Console.WriteLine(products.ProductID + " | " + products.Review);
            }
        }
    }
}

