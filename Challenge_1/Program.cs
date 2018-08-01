using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodRepository foodRepo = new FoodRepository();
            List<Food> MenuItems = foodRepo.GetList();

            Food omelette = new Food(1, "Omelette", "folded eggs", "two eggs, cheese, salt and pepper", 4);
            Food pancakes = new Food(2, "Panckes", "fluffy skillet dough", "eggs, flour, maple syrup, butter", 5);
            Food blt = new Food(3, "BLT", "sandwich", "bacon, lettuce, tomato, bread", 6);
            Food parfait = new Food(4, "Yogurt Parait", "layered yougurt and granola", "fruit, yogurt, granola", 5);
            Food salad = new Food(5, "Chef's Salad", "salad with ham, turkey and cheese", "lettuce, tomato, turkey, cheese", 6);
            Food sub = new Food(6, "Cheese Steak Sub", "sub with cheesey steak", "bread, steak, cheese", 6);

            foodRepo.AddMenuItemToList(omelette);
            foodRepo.AddMenuItemToList(pancakes);
            foodRepo.AddMenuItemToList(blt);
            foodRepo.AddMenuItemToList(parfait);
            foodRepo.AddMenuItemToList(salad);
            foodRepo.AddMenuItemToList(sub);
            
            
            Console.WriteLine("Welcome to Danielle's Diner");
            Console.WriteLine("\n");
            Console.WriteLine("Would you like to 1.Add an Item, 2. Remove an Item, or 3. List the items?");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                while (true)
                {

                    Console.WriteLine("What is the meal number:");
                    int foodMealNumber = int.Parse(Console.ReadLine());

                    Console.WriteLine("What is the meal name:");
                    var foodMealName = Console.ReadLine();

                    Console.WriteLine("Describe the meal:");
                    string foodDescription = Console.ReadLine();

                    Console.WriteLine("what is the meal's ingredients:");
                    string foodIngredients = Console.ReadLine();

                    Console.WriteLine("What will the meal price be?");
                    int foodPrice = int.Parse(Console.ReadLine());

                    Food userFood = new Food(foodMealNumber, foodMealName, foodDescription, foodIngredients, foodPrice);
                    foodRepo.AddMenuItemToList(userFood);




                    Console.WriteLine("Do you want to add annother menu item?");
                    string theAnswer = Console.ReadLine();
                    if(theAnswer == "y")
                   {
                        continue;
                    }
                   else if (theAnswer == "n")
                    {
                        foodRepo.printList(foodRepo.GetList());

                        break;
                    }
                }

              
            }
            
            else if (choice == "2")
            {
                Console.WriteLine("What menu item do you want to remove?");
                string item = Console.ReadLine();
                foodRepo.removeMenuItemFromList(item);
                foodRepo.printList(foodRepo.GetList());
            }

            else if (choice =="3")
            {
                foodRepo.printList(foodRepo.GetList());
              
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

