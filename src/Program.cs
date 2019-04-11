using System;
using OCP_Filters.Filters;
using OCP_Filters.Specifications;

namespace OCP_Filters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var apple = new Product("Apple", Color.Green, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Blue, Size.Large);            

            //teste
                                    
            Product[] products = { apple, tree, house };
            
            var fs = new FilterService();
            
            Console.WriteLine("Green products (new):");            
            var specification = new ColorSpecification(Color.Green);
            var filtered = fs.Filter(products, specification);
            foreach (var p in filtered)
                Console.WriteLine($" - {p.Name} is green");

            Console.WriteLine("Large products");
            foreach (var p in fs.Filter(products, new SizeSpecification(Size.Large)))
                Console.WriteLine($" - {p.Name} is large");

            Console.WriteLine("Medium Red products");
            var redSpec = new ColorSpecification(Color.Red);
            var mediumSpec = new SizeSpecification(Size.Medium);
            var andSpecification = new AndSpecification<Product>(redSpec, mediumSpec);
            var mediumRedFiltered = fs.Filter(products, andSpecification);
            foreach(var p in mediumRedFiltered)
                Console.WriteLine($" - {p.Name} is large");

            Console.WriteLine("Large blue items");
            foreach (var p in fs.Filter(products,
              new AndSpecification<Product>(
                  new ColorSpecification(Color.Blue), 
                  new SizeSpecification(Size.Large)))
            )
            {
                Console.WriteLine($" - {p.Name} is big and blue");
            }
        }
    }
}
