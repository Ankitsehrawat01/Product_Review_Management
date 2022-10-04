
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
                 new product() { ProductID = 1, Userid = 8, rating = 2.8, Review = "Bad", Islike = true },
                 new product() { ProductID = 9, Userid = 9, rating = 5.0, Review = "Very Good", Islike = false },
                 new product() { ProductID = 10, Userid = 10, rating = 4.5, Review = "Excellent", Islike = true }
            };
            bool check = true;
            while(check)
            {
                Console.WriteLine("1) Display All The Product Details\n" +
                                  "2) Retrieve top 3 records from the list who’s rating is high\n" +
                                  "3) Retrieve all record from the list who’s rating are greater then 3 and productID is 1 or 4 or 9\n" +
                                  "4) Retrieve count of review present for each productID\n" +
                                  "5) Retrieve only productID and review from the list for all records\n" +
                                  "6) Skip Top 5 records from list and Display others\n" +
                                  "7) Retrieve only productID and review from the list for all records\n");
                Console.WriteLine("-------------------------------");
                int option = int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        foreach (var products in productreviewlist)
                        {
                            Console.WriteLine("------------------------------------");
                            Console.WriteLine(products.ProductID + " | " + products.Userid + " | " + 
                                              products.rating + " | " + products.Review + " | " + products.Islike);
                            Console.WriteLine("------------------------------------");
                        }
                        break;
                    case 2:
                        Console.WriteLine("------------------------------------");
                        productmanagement.Top3Records(productreviewlist);
                        Console.WriteLine("------------------------------------");
                        break;
                    case 3:
                        Console.WriteLine("------------------------------------");
                        productmanagement.GetData(productreviewlist);
                        Console.WriteLine("------------------------------------");
                        break;
                    case 4:
                        Console.WriteLine("------------------------------------");
                        productmanagement.GetCount(productreviewlist);
                        Console.WriteLine("------------------------------------");
                        break;
                    case 5:
                        Console.WriteLine("------------------------------------");
                        productmanagement.GetProductIDandReview(productreviewlist);
                        Console.WriteLine("------------------------------------");
                        break;
                    case 6:
                        Console.WriteLine("------------------------------------");
                        productmanagement.SkipTop5(productreviewlist);
                        Console.WriteLine("------------------------------------");
                        break;
                    case 7:
                        Console.WriteLine("------------------------------------");
                        productmanagement.RetriveProductIDandReview(productreviewlist);
                        Console.WriteLine("------------------------------------");
                        break;
                }
            }
        }
    }
}