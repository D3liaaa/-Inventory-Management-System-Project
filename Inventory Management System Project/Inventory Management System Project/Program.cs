namespace Inventory_Management_System_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            bool running =true;
            // wlcome user
            Console.WriteLine("\n====== Inventory Management ======");
            while (running) 
            {
                Console.WriteLine("choose what you want to do?" +
                    "\n" +
                     "1. View All Products. " +
                     "\n" +
                     "2. Add Product. " +
                     "\n" +
                     "3. Update Product Quantity. " +
                     "\n" +
                     "4. Delete Product. " +
                     "\n" +
                     "5. Search Product. " +
                     "\n" +
                     "6. Exit. ");
                int choose =int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        inventory.ViewAllProducts();
                        break;
                    case 2:
                        inventory.AddProduct();
                        break;
                    case 3:
                        inventory.UpdateProductQuantity();
                        break;
                    case 4:
                        inventory.DeleteProduct();
                        break;
                    case 5:
                        inventory.SearchProduct();
                        break;
                    case 6:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("❌ Invalid option. Try again.");
                        break;

                }
                
            }
            Console.WriteLine("\n👋 Thanks for using the Inventory System!");

        }
    }
}
