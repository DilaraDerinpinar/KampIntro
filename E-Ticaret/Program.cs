using System;

namespace E_Ticaret
{
    class Program
    {
        //2.hafta odevi
        static void Main(string[] args)
        {

            Product product1 = new Product()
            {
                productName = "skirt",productType = "women",productPrice = 100,productStock = 10
            };

            Product product2 = new Product()
            {
                productType = "men",productName = "jacket",productPrice = 200,productStock = 50
            };

            Product product3 = new Product()
            {
                productType = "children", productName = "sweatshirt", productPrice = 55, productStock = 10
            };


            Product[] products = new Product[3] {product1, product2, product3};

            //for ile görüntüleme:
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"Product name: {products[i].productName}");
                Console.WriteLine($"Product price: {products[i].productPrice}");
                Console.WriteLine($"Product stock: {products[i].productStock}");
                Console.WriteLine($"Product type: {products[i].productType}");
                Console.WriteLine(" ");
            }

            //foreach ile görüntüleme
            foreach (var item in products)
            {
                Console.WriteLine($"Product name : {item.productName}");
                Console.WriteLine($"Product type : {item.productType}");
                Console.WriteLine($"Product stock : {item.productStock}");
                Console.WriteLine($"Product price : {item.productPrice}");
                Console.WriteLine(" ");
            }

            //while ile görüntüleme
            int x = 0;
            while (x < products.Length)
            {
                Console.WriteLine($"Product name : {products[x].productName}");
                Console.WriteLine($"Product type : {products[x].productType}");
                Console.WriteLine($"Product price : {products[x].productPrice}");
                Console.WriteLine($"Product stock : {products[x].productStock}");
                Console.WriteLine(" ");
                x += 1;
            }


            Console.ReadLine();
        }
    }
    class Product
    {
        public string productName { get; set; }
        public string productType { get; set; }
        public int productPrice { get; set; }
        public int productStock { get; set; }
    }
}
