using System;
using System.Net.Http.Headers;

namespace CommandDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var modifyPrice = new ModifyPrice();
            var product = new Product("Phone", 500);

            Execute(product, modifyPrice, new ProductCommand(product, PriceAction.Decrease, 200));
            Console.WriteLine(product);

            modifyPrice.UndoActions();
            Console.WriteLine(product);

            Console.ReadLine();
        }

        private static void Execute(Product product, ModifyPrice modifyPrice, ICommand productCom)
        {
            modifyPrice.SetCommand(productCom);
            modifyPrice.Invoke();
        }
    }
}
