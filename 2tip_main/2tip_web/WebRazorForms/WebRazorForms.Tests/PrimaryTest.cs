using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebRazorForms.Models;

namespace WebRazorForms.Tests
{
    [TestClass]
    public class PrimaryTest
    {
        [TestMethod]
        public void IsPrimaryOne() {
            bool actual = Tools.IsPrimal(1);
            bool expected = false;
            Assert.AreEqual(expected,actual);
            Assert.IsFalse(Tools.IsPrimal(1));
        }
        [TestMethod]
        public void IsPrimaryTwentyOne()
        {
            bool actual = Tools.IsPrimal(21);
            bool expected = false;
            Assert.AreEqual(expected, actual);
            Assert.IsFalse(Tools.IsPrimal(1));
        }
        //metoda sprawdzajaca ile jest liczb pierwszych <2,10>

        [TestMethod]
        public void CountNumbers() {
            int actual = GetAllPrimals(1, 10).Count;
            int expected = 4;
            Assert.AreEqual(expected,actual);
        }
        private List<int> GetAllPrimals(int a, int b) {
            List<int> list = new List<int>();
            for (int i = a; i <= b; i++) {
                if (Tools.IsPrimal(i)) {
                    list.Add(i);
                }
            }
            return list;
        }
    }
}
