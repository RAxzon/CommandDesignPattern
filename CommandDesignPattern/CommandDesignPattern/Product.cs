using System;

namespace CommandDesignPattern
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public void IncreasePrice(int amount)
        {
            Price += amount;
            Console.WriteLine($"The price for {Name} has changed to +{amount}$");
        }

        public void DecreasePrice(int amount)
        {
            Price += amount;
            Console.WriteLine($"The price for {Name} has changed to -{amount}$");
        }

        public override string ToString() => $"Current price for the {Name} product is {Price}$";
    }
}
