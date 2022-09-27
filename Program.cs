namespace ProductReviewManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Product Review Management Program");
            List<product> productreviewlist = new List<product>()
            {
                new product() { ProductID = 1, Userid = 1, rating = 5, Review = "Good", Islike = true },
                new product() { ProductID = 2, Userid = 2, rating = 5, Review = "fine", Islike = false },
                new product() { ProductID = 3, Userid = 3, rating = 5, Review = "very good", Islike = true },
                new product() { ProductID = 4, Userid = 4, rating = 5, Review = "bad", Islike = false },
                new product() { ProductID = 5, Userid = 5, rating = 5, Review = "Excellent", Islike = true },
                new product() { ProductID = 6, Userid = 6, rating = 5, Review = "Wrost", Islike = false },
                new product() { ProductID = 7, Userid = 7, rating = 5, Review = "Good", Islike = true },
                new product() { ProductID = 8, Userid = 8, rating = 5, Review = "Bad", Islike = true },
                new product() { ProductID = 9, Userid = 9, rating = 5, Review = "Very Good", Islike = false },
                new product() { ProductID = 10, Userid = 10, rating = 5, Review = "Excellent", Islike = true }
            };
            foreach (var products in productreviewlist)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine(products.ProductID + " | " + products.Userid + " | " + products.rating + " | " + products.Review + " | " + products.Islike);
            }
        }
    }
}