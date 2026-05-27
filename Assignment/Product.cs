using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    internal class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public string Brand { get; set; }

        public string Category { get; set; }

        public float Rating { get; set; }

        public bool IsAvailable => this.Quantity > 0;

        public decimal DiscountPercent { get; set; }

        public decimal DiscountedPrice { get; set; }


        public void Discount(byte discountPercent)
        {
            if (discountPercent > 100)
            {
                Console.WriteLine("Discount can't exceed 100%");
                return;
            }
            this.DiscountPercent = discountPercent;
            this.DiscountedPrice = this.Price - this.Price * discountPercent / 100;
        }

        public void AddQuantity(int quantity)
        {
            this.Quantity += quantity;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Product: " + this.Name);
            Console.WriteLine("Price: " + this.Price);
            Console.WriteLine($"Discount: {this.DiscountPercent}%");
            Console.WriteLine($"Last Price: {this.DiscountedPrice}$");
            Console.WriteLine("In Stock: " + this.IsAvailable);
        }

    }
}