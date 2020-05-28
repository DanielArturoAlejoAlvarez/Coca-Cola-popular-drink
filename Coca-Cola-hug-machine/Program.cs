using System;

namespace Coca_Cola_hug_machine
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vm = new VendingMachine();
            CocaColaProduct prod = new CocaColaProduct();
            Console.WriteLine("Welcome to Coca-Cola Hug Machine");
            while (true)
            {
                Console.WriteLine(vm.ListProduct());
                Console.WriteLine("1. ADD PRODUCT");
                Console.WriteLine("2. UPDATE PRODUCT");
                Console.WriteLine("3. DELETE PRODUCT");
                Console.WriteLine("4. BUY PRODUCT");

                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.Write("Enter code: ");
                        prod.Code = Console.ReadLine();
                    
                        Console.Write("Enter name: ");
                        prod.Name = Console.ReadLine();

                        Console.Write("Enter category: ");
                        prod.Category = Console.ReadLine();

                        Console.Write("Enter quantity: ");
                        prod.QTY = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter price: ");
                        prod.Price = Convert.ToDouble(Console.ReadLine());

                        vm.AddProduct(prod);

                        break;
                    case "2":
                        Console.Write("Enter code: ");
                        string code = Console.ReadLine();

                        Console.Write("Update name: ");
                        prod.Name = Console.ReadLine();

                        Console.Write("Update category: ");
                        prod.Category = Console.ReadLine();

                        Console.Write("Update price: ");
                        prod.Price = Convert.ToDouble(Console.ReadLine());

                        vm.UpdProduct(code,prod);

                        break;
                    case "3":
                        Console.Write("Enter code: ");
                        string code_deleted = Console.ReadLine();

                        vm.DeleteProduct(code_deleted);
                        break;
                    case "4":
                        Console.Write("Enter code: ");
                        string code_order = Console.ReadLine();
                        Console.Write("Enter coins $USD(100-50-20-10): ");
                        vm.Payment = Console.ReadLine();
                        CocaColaProduct prod_buy = vm.Order(code_order);
                        if (prod_buy == null)
                        {
                            Console.WriteLine("There is no required product!");
                        }
                        else
                        {
                            Console.WriteLine("You are enjoying a delicious {0} with code {1} and its balance is ${2}", prod_buy.Name, prod_buy.Code, prod_buy.Balance);
                        }
                        break;                    
                }

                Console.Write("Do you want to continue Y/N?: ");
                if (Console.ReadLine() == "N")
                {
                    break;
                }
            }
        }
    }
}
