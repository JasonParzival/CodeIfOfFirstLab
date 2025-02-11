using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheFirstCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirstCode.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void ValuesAreEquelTest()
        {
            var smth = 523325;
            var first_eq = Logic.Get_sum(smth, 0);
            var second_eq = Logic.Get_sum(smth, 3);
            string message = Logic.Message(smth, first_eq, second_eq);

            Assert.AreEqual("Заданное число: 523325 является счастливым!  Первая сумма: 10 равна второй сумме: 10", message);
        }

        [TestMethod()]
        public void ValueIsGreaterTest()
        {
            var smth = 583325;
            var first_eq = Logic.Get_sum(smth, 0);
            var second_eq = Logic.Get_sum(smth, 3);
            string message = Logic.Message(smth, first_eq, second_eq);

            Assert.AreEqual("Заданное число: 583325 не является счастливым!  Первая сумма: 16 больше второй суммы: 10", message);
        }

        [TestMethod()]
        public void ValueIsLessTest()
        {
            var smth = 523595;
            var first_eq = Logic.Get_sum(smth, 0);
            var second_eq = Logic.Get_sum(smth, 3);
            string message = Logic.Message(smth, first_eq, second_eq);

            Assert.AreEqual("Заданное число: 523595 не является счастливым!  Первая сумма: 10 меньше второй суммы: 19", message);
        }
    }
}