using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    public class Food
    {

        public int mealNumber { get; set; }
        public string mealName { get; set; }
        public string descripiton { get; set; }
        public string ingredients { get; set; }
        public int price { get; set; }

        public Food(int theMealNumber, string theMealName, string theDescription, string theIngredients, int thePrice)
        {
            mealNumber = theMealNumber;
            mealName = theMealName;
            descripiton = theDescription;
            ingredients = theIngredients;
            price = thePrice;
        }

       
        public Food()
        {
        }

        public override string ToString()
        {
            string stringToReturn = $"{mealNumber}\n{mealName}\t{descripiton}\t{ingredients}\t{price}";
            return stringToReturn;
        }

    }

}
