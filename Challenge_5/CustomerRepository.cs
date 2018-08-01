using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5
{
    class CustomerRepository
    {
        public List<Customer> _FoodMenuItems = new List<Customer>();


        public void AddMenuItemToList(Customer MenuItem)
        {
            _FoodMenuItems.Add(MenuItem);
        }


        public List<Customer> GetList()
        {
            return _FoodMenuItems;
        }


        public Customer FindMenuItemByName(string name)
        {
            Customer customer = new Customer();

            foreach (Customer FoodMenuItem in _FoodMenuItems)
            {
                if (name == FoodMenuItem.mealName)
                    mealName = FoodMenuItem;
                break;
            }

            return mealName;

        }


        public List<Customer> FindMenuItemByDescription(string description)
        {
            List<Customer> Item = new List<Customer>();

            foreach (var MenuItem in _FoodMenuItems)
            {
                if (description == MenuItem.descripiton)
                {
                    Item = _FoodMenuItems;
                    break;
                }
            }
            return Item;
        }

        public void removeMenuItemFromList(string theMealName)
        {
            int theIndex = _FoodMenuItems.FindIndex(item => item.mealName == theMealName);
            _FoodMenuItems.RemoveAt(theIndex);
        }


        public void printList(List<Food> theList)
        {
            foreach (Food menuItem in theList)
            {
                Console.WriteLine(menuItem);
            }
            Console.WriteLine("\n\n");
        }
    }
}
}
