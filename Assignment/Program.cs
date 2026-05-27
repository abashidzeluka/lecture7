namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product
            {
                Name = "Laptop",
                Brand = "Lenovo",
                Price = 2500,
                Category = "Computers",
                Description = "A lightweight, ultra-portable",
                Id = 45513,
                Rating = 4.5f,
                Quantity = 2000,
            };

           
            product.AddQuantity(4);
            product.Discount(10);

            product.DisplayInfo();

        }
    }
}
