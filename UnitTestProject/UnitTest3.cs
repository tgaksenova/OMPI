using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using _1pract.Pages;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod3()
        {
           
            var page = new AuthPage();
            Assert.IsTrue(page.Auth("Deniska", "Denis05"));
            Assert.IsTrue(page.Auth("Omarchik", "Madinka"));
            Assert.IsTrue(page.Auth("Pimenov", "Denisloh05"));
            Assert.IsTrue(page.Auth("Madinat", "Madinat05"));
        }

       
    }
}
