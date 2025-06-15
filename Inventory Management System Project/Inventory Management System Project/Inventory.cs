using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System_Project
{
    public class Inventory
    {
        private List<Product> Products=new List<Product>();
        public void AddProduct()
        {
            Console.WriteLine("\n Enter Product details. ");
            Console.Write("ID :");
            int id= int.Parse(Console.ReadLine());
            Console.Write("Name :");
            string name = Console.ReadLine();
            Console.Write("Price :");
            decimal price = decimal.Parse(Console.ReadLine());
            Console.Write("Quantity :");
            int quantity = int.Parse(Console.ReadLine());
            Products.Add(new Product(id, name, price, quantity));
            Console.WriteLine("✅ Product added successfully!");

        }
        public void UpdateProductQuantity()
        {
            Console.WriteLine("\nEnter product ID to update");
            int id = int.Parse(Console.ReadLine());
            Product product=Products.FirstOrDefault(p=>p.Id == id);
            if (product != null)
            {
                Console.WriteLine("Enter new Quantity: ");
                product.Quantity= int.Parse(Console.ReadLine());
                Console.WriteLine("✅ Quantity updated successfully!");
            }
            else
            {
                Console.WriteLine("❌ Product not found.");
            }

        }
        public void DeleteProduct() 
        {
            Console.WriteLine("\nEnter product ID to delete ");
            int id=int.Parse(Console.ReadLine());
            Product product = Products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                Products.Remove(product);
                Console.WriteLine("✅ Product deleted successfully!");
            }

            else
            {
                Console.WriteLine("❌ Product not found.");
            }
        }
        public void SearchProduct()
        {
            Console.WriteLine("\nEnter product name to search: ");
            string name = Console.ReadLine();
            var found = Products.Where(p => p.Name.ToLower().Contains(name.ToLower())).ToList();
            if (found.Count==0) 
            {
                Console.WriteLine("❌ No products found.");
            }
            else
            {
                foreach (var product1 in Products)
                {
                    Console.WriteLine(product1);
                }
            }

        }
        public void ViewAllProducts()
        {
            if (Products.Count == 0)
            {
                Console.WriteLine("\n No products in inventory. ");
            }
            else
            {
                Console.WriteLine("\nAll Products:");
                foreach (var product in Products)
                {
                    Console.WriteLine(product);
                }
            }

        }
       
    }
}
