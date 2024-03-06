using System;

class Product
{
    // memers of class product
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public double Price { get; set; }
}

class Products
{
    static void Main()
    {
        Product[] products = new Product[10];

        
        for (int i = 0; i < 10; i++) // for loop for accepting 10 products 
        {
            Console.WriteLine($"Enter info of  Product {i + 1}:");

            Console.Write("Product ID: ");
            int productId = int.Parse(Console.ReadLine());

            Console.Write("Product Name: ");
            string productName = Console.ReadLine();

            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine());

            products[i] = new Product
            {
                ProductId = productId,
                ProductName = productName,
                Price = price
            };
        }

        
        for (int i = 0; i < 10 - 1; i++)
        {
            int limit = i;

            for (int j = i + 1; j < 10; j++)
            {
                if (products[j].Price < products[limit].Price)
                {
                    limit = j;
                }
            }

            
            Product temp = products[i];
            products[i] = products[limit];
            products[limit] = temp;
        }

       //display the products based on price
        Console.WriteLine("\n My Sorted Products based on Price:");
        

        foreach (var product in products)
        {
            Console.WriteLine($"Product ID: {product.ProductId}, Product Name: {product.ProductName}, Price: {product.Price}");
        }
        Console.ReadLine();
    }
}
