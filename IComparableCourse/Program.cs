using System;
using System.Numerics;

namespace GenercisCourse
{
    public class Program
    {
        static void Main()
        {
            try
            {
                List<Product> listProducts = new List<Product>();

                Console.Write("Enter many values: ");
                int number = int.Parse(Console.ReadLine());

                for (int i = 0; i < number; i++)
                {
                    Console.Write("Name: ");
                    string nameProduct = Console.ReadLine();

                    Console.Write("Value: ");
                    double valueProduct = double.Parse(Console.ReadLine());

                    listProducts.Add(new Product(nameProduct, valueProduct));
                }

                CalculationService calculationService = new CalculationService();

                Product product = calculationService.MaxValue(listProducts);
                Console.WriteLine("Most Expensive: ");
                Console.WriteLine(product.ToString());
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}