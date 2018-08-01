`using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerRepository customerRepo = new CustomerRepository();
            List<Customer> CustomerRepository = customerRepo.GetList();

            Customer customer = new Customer("Jim", "Jones", "Potential");

            Console.WriteLine("Welcome to Komodo Insurance");
            Console.WriteLine("\n");
            Console.WriteLine("Would you like to 1.Add a Customer, 2. Remove an Customer, or 3. List all Customers?");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                while (true)
                {

                    Console.WriteLine("Enter the customer's first name:");
                    int firstName = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the customer's last name:");
                    var lastName = Console.ReadLine();

                    Console.WriteLine("Is this a potential, previous or current customer?");
                    string type = Console.ReadLine();

                   
                    //Food userFood = new Food(foodMealNumber, foodMealName, foodDescription, foodIngredients, foodPrice);
                    //foodRepo.AddMenuItemToList(userFood);


                    Console.WriteLine("Do you want to add annother customer?");
                    string theAnswer = Console.ReadLine();
                    if (theAnswer == "y")
                    {
                        continue;
                    }
                    else if (theAnswer == "n")
                    {
                        customerRepo.printList(customerRepo.GetList());

                        break;
                    }
                }


            }

            else if (choice == "2")
            {
                Console.WriteLine("What customer do you want to remove?");
                string item = Console.ReadLine();
                customerRepo.removeMenuItemFromList(item);
                customerRepo.printList(customerRepo.GetList());
            }

            else if (choice == "3")
            {
                customerRepo.printList(customerRepo.GetList());

            }
            Console.ReadLine();


            foodRepo.AddMenuItemToList(omelette);
            foodRepo.AddMenuItemToList(pancakes);
            foodRepo.AddMenuItemToList(blt);
            foodRepo.AddMenuItemToList(parfait);
            foodRepo.AddMenuItemToList(salad);
            foodRepo.AddMenuItemToList(sub);

        }
    }
}
