
namespace ProductReviewManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product Review Management Program");
            List<product> productreviewlist = new List<product>()
            {
                 new product() { ProductID = 1, Userid = 1, rating = 5.0, Review = "Good", Islike = true },
                 new product() { ProductID = 2, Userid = 2, rating = 4.0, Review = "fine", Islike = false },
                 new product() { ProductID = 3, Userid = 3, rating = 3.0, Review = "very good", Islike = true },
                 new product() { ProductID = 4, Userid = 4, rating = 2.0, Review = "bad", Islike = false },
                 new product() { ProductID = 5, Userid = 5, rating = 1.0, Review = "Excellent", Islike = true },
                 new product() { ProductID = 6, Userid = 6, rating = 2.5, Review = "Wrost", Islike = false },
                 new product() { ProductID = 7, Userid = 7, rating = 3.5, Review = "Good", Islike = true },
                 new product() { ProductID = 8, Userid = 8, rating = 2.8, Review = "Bad", Islike = true },
                 new product() { ProductID = 9, Userid = 9, rating = 5.0, Review = "Very Good", Islike = false },
                 new product() { ProductID = 10, Userid = 10, rating = 4.5, Review = "Excellent", Islike = true }
            };
            bool check = true;
            while(check)
            {
                Console.WriteLine("1) Display All The Product Details\n" +
                                  "2) Retrieve top 3 records from the list who’s rating is high");
                int option = int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        foreach (var products in productreviewlist)
                        {
                            Console.WriteLine("------------------------------------");
                            Console.WriteLine(products.ProductID + " | " + products.Userid + " | " + 
                                              products.rating + " | " + products.Review + " | " + products.Islike);
                        }
                        break;
                    case 2:
                        productmanagement.Top3Records(productreviewlist);
                        break;
                }
            }
        }
    }
}