using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DojoDevRioClaro.Lib;

namespace DojoDevRioClaro_1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Quando_Numero_01_Retorna_1()
        {
            var resultado = LibFizzBuzz.VerifiqueFizzBuzz(1);

            Assert.AreEqual("1", resultado);
        }

        [TestMethod]
        public void Quando_Numero_02_Retorna_2()
        {
            var resultado = LibFizzBuzz.VerifiqueFizzBuzz(2);

            Assert.AreEqual("2", resultado);
        }

        [TestMethod]
        public void Quando_Numero_03_Retorna_Fizz()
        {
            var resultado = LibFizzBuzz.VerifiqueFizzBuzz(3);

            Assert.AreEqual("Fizz", resultado);
        }

        [TestMethod]
        public void Quando_Numero_04_Retorna_4()
        {
            var resultado = LibFizzBuzz.VerifiqueFizzBuzz(4);

            Assert.AreEqual("4", resultado);
        }

        [TestMethod]
        public void Quando_Numero_05_Retorna_Buzz()
        {
            var resultado = LibFizzBuzz.VerifiqueFizzBuzz(5);

            Assert.AreEqual("Buzz", resultado);
        }

        [TestMethod]
        public void Quando_Numero_06_Retorna_Fizz()
        {
            var resultado = LibFizzBuzz.VerifiqueFizzBuzz(6);

            Assert.AreEqual("Fizz", resultado);
        }

        [TestMethod]
        public void Quando_Numero_07_Retorna_7()
        {
            var resultado = LibFizzBuzz.VerifiqueFizzBuzz(7);

            Assert.AreEqual("7", resultado);
        }

        [TestMethod]
        public void Quando_Numero_15_Retorna_FizzBuzz()
        {
            var resultado = LibFizzBuzz.VerifiqueFizzBuzz(15);

            Assert.AreEqual("FizzBuzz", resultado);
        }

        [TestMethod]
        public void Quando_Numero_30_Retorna_FizzBuzz()
        {
            var resultado = LibFizzBuzz.VerifiqueFizzBuzz(30);

            Assert.AreEqual("FizzBuzz", resultado);
        }

        [TestMethod]
        public void Quando_Numero_60_Retorna_FizzBuzz()
        {
            var resultado = LibFizzBuzz.VerifiqueFizzBuzz(60);

            Assert.AreEqual("FizzBuzz", resultado);
        }

        
    }
}
