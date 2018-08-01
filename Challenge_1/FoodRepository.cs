using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    public class FoodRepository
    {


        public List<Food> _FoodMenuItems = new List<Food>();


        public void AddMenuItemToList(Food MenuItem)
        {
            _FoodMenuItems.Add(MenuItem);
        }


        public List<Food> GetList()
        {
            return _FoodMenuItems;
        }


        public Food FindMenuItemByName(string name)
        {
            Food mealName = new Food();

            foreach (Food FoodMenuItem in _FoodMenuItems)
            {
                if (name == FoodMenuItem.mealName)
                    mealName = FoodMenuItem;
                break;
            }

            return mealName;

        }


        public List<Food> FindMenuItemByDescription(string description)
        {
            List<Food> Item = new List<Food>();

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

        public int Count()
        {
            return _FoodMenuItems.Count;
        }
    }

    }


    








