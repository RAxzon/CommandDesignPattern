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
            Console.WriteLine($"The price for {Name} has increased with {amount}$");
        }

        public bool DecreasePrice(int amount)
        {
            if (amount < Price)
            {
                Price -= amount;
                Console.WriteLine($"The price for {Name} has decreased with {amount}$");
                return true;
            }
            
            throw new Exception("Price cannot be less than 0");
        }

        public override string ToString() => $"Current price for the {Name} product is {Price}$";
    }
}
