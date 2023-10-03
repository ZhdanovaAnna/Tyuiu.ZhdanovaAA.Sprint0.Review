using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZhdanovaAA.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.ZhdanovaAA.Sprint0.TaskReview.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            Assert.AreEqual(45, DataService.Calc(2, 3, 4));
        }
    }
} 
   