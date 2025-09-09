using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SimkinOA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.SimkinOA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Олег";
            var res = DataService.GetMessage(name);


            Assert.AreEqual("Привет..., Олег", res);
        }
    }
}
