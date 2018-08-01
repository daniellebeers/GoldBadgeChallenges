using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenge_1;

namespace Challenge_1_Tests
{
    public class MenuTests
    {
        [TestMethod]
        public void Food_AddItem_CountShouldIncrease()
        {
            FoodRepository Repo = new FoodRepository();
            Food item = new Food(6, "Waffles", "Breakfast", "Syrup", 5);

            Repo.AddMenuItemToList(item);

            int Expected = 1;
            int Actual = Repo.Count();

            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod]
        public void Food_RemoveItem_CountShouldDecrease()
        {
            FoodRepository Repo = new FoodRepository();
            Food item = new Food(6, "Waffles", "Breakfast", "Syrup", 5);

            Repo.AddMenuItemToList(item);
            Repo.removeMenuItemFromList("Waffles");

            int Expected = 0;
            int Actual = Repo.Count();

            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod]
        public void Food_GetList_ShouldPrintList()
        {
            List<Food> list = new List<Food>();
            Food item = new Food(6, "Waffles", "Breakfast", "Syrup", 5);

            FoodRepository Repo = new FoodRepository();
            Repo.AddMenuItemToList(item);
            list = Repo.GetList();

            int Expected = 1;
            int Actual = list.Count;

            Assert.AreEqual(Expected, Actual);
        }
    }

}