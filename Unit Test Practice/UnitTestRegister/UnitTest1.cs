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
        public void AddUpItems_AddingMultipleItems_ReturnsAccurateTotal()
        {
            // Arrange
            // Member variables, instantiate objects, set "expected" value

            // Bringing in my instance of Register      
            Register register = new Register();

            // Creating item objects
            Item CatFood = new Item("Cat Food", 12.50);
            Item HotPockets = new Item("Hot Pockets", 2.99);

            // Creating list of objects
            List<Item> items = new List<Item>();
            items.Add(CatFood);
            items.Add(HotPockets);

            // set expected value (not accounting for sales tax)
            double expected = 15.49;
 
            // Act
            // Call method that we are testing
            double actual = register.AddUpItems(items);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Method_ChangeThisName()
        {
            // Assert
            
            // Act

            // Assert
        }
    }
}
