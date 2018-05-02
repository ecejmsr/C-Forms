using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Resturant.Infrastructure;
using Resturant.Data;
using Resturant.Infrastructure.VO;

namespace TestsSuite.Resturant.Data.DAO
{
    /// <summary>
    /// Summary description for ResturantDataTest
    /// </summary>
    [TestClass]
    public class ResturantDataTest
    {
        [TestMethod]
        public void InsertResturantTest()
        {
            resturant_info testResturant = new resturant_info
            {
                rest_name = "Burger King"
            };
            string restTestName = testResturant.rest_name;
            TsqlCrud testeTsqlCrud = new TsqlCrud();
            testResturant = testeTsqlCrud.AddResturant(testResturant);
            Assert.AreEqual(restTestName, testResturant.rest_name);



        }
    }
}
