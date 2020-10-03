using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QEqLibrary;

namespace TestProject
{
    [TestClass]
    public class Test_QuadEquation
    {
        [TestMethod]
        public void Test1_2_6_9()
        {
            double a = 2, b = 6, c = 9;
            double actError, expError = -2;
            string expResult = "Действительных корней нет";
            QuadDecision q = new QuadDecision(a, b, c);
            string actResult="";
            actError = q.Answer[0];
            if (q.Answer[0] == -2)
            {
                actResult = "Действительных корней нет";
            }
            Assert.AreEqual(expError, actError, "Полученное сообщение (" + actError + ") об ошибке не совпадает с ожидаемым (" + expError + ")");
            Assert.AreEqual(expResult.Length, actResult.Length);
            for (int i = 0; i < expResult.Length; i++)
            {
                Assert.AreEqual(expResult[i], actResult[i]);
            }
        }
    }
}
