using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Resturant.Library.Models;

namespace TestsSuite.Resturant.Library
{
    /// <summary>
    /// Summary description for LibraryTest
    /// </summary>
    [TestClass]
    public class LibraryTest
    {

        [TestMethod]
        public void MyAddToRatingsTest()
        {
            global::Resturant.Library.Models.Resturant r = new global::Resturant.Library.Models.Resturant();

            var result = r.AddToRatings(4.32);

            Assert.AreEqual(4.32, result);
        }

        [TestMethod]
        public void MyAddToReviewsMethod()
        {
            global::Resturant.Library.Models.Resturant r = new global::Resturant.Library.Models.Resturant();

            var result = r.AddToReviews("GREAT TIME");

            Assert.AreEqual("GREAT TIME", result);
        }

        [TestMethod]
        public void MyReturnRateMethod()
        {
            global::Resturant.Library.Models.Resturant r = new global::Resturant.Library.Models.Resturant();

            var result = r.ReturnRate();

            Assert.AreEqual(0, result);
        }
    }
}
