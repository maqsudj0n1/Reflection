using System.Reflection;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Product product = new Product()
            {
                Name = "AAA",
                Description = "BBB"
            };
            Print(product);
        }
        static void Print(dynamic obj)
        {
            PropertyInfo[] properties = obj.GetType().GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.GetValue(obj));
            }
        }
    }
}