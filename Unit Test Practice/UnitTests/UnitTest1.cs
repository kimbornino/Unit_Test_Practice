using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using uni



namespace UnitTests
{
    //This is the attribute that tells the compiler you're writing test code
    [TestClass]
    public class UnitTest1
    {
        //You need this attribute for every test method you write.
        [TestMethod]

        //Remember your naming conventions: Unit of Work, Conditions, outcome?
        public void TestMethod1()
        {
            //Arrange- Member variables, instanitate instances of classes, expected and actual
            Customer customer = new customer();
            //Act - call the function

            //Assert- use "areEqual" or other test method to compare expected with actual.
        }
    }
}
