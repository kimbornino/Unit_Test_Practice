using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//bring in the reference to the project
using RegisterSystem;

namespace UnitTestRegister
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddUpItems_CheckExpectedTotal()
        {
        //ARRANGE
            //member variables, instantiate objects, set "expected" value

            //bringing in my instance of Register
      
            Register register = new Register();

            //Creating item objects
            Item CatFood = new Item("Cat Food", 12.50);
            Item HotPockets = new Item("Hot Pockets", 2.99);

            //creating list of objects
            List<Item> items = new List<Item>();
            items.Add(CatFood);
            items.Add(HotPockets);

            //set expected value (not accounting for sales tax)
            double expected = 15.49;
 d

        //ACT 
            //call method
            double actual = register.AddUpItems(items);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
