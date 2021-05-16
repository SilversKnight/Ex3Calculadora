using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Testes
{
    [TestClass]
    public class Testes
    {
        //TESTES DE UNIDADE MSTest
        [TestInitialize]
        public void IniciarTestes()
        {

        }

        [TestMethod]
        public void TestSoma()
        {
            string[] array = { "1", "1", "1" };
            Assert.AreEqual(2, Ex3Calculadora.Program.Main(array));
        }

        [TestMethod]
        public void TestSubtracao()
        {
            string[] array = { "1", "1", "2" };
            Assert.AreEqual(0, Ex3Calculadora.Program.Main(array));
        }

        [TestMethod]
        public void TestMultiplicacao()
        {
            string[] array = { "1", "1", "3" };
            Assert.AreEqual(1, Ex3Calculadora.Program.Main(array));
        }

        [TestMethod]
        public void TestDivisao()
        {
            string[] array = { "2", "2", "4" };
            Assert.AreEqual(1, Ex3Calculadora.Program.Main(array));
        }

        [TestMethod]
        public void TestIUnitMedia()
        {
            var input = new StringReader(@"5 
            2
            5
            2
            5
            1");

            Console.SetIn(input);

            string[] array = { "2", "2", "5" };
            Assert.AreEqual(5, Ex3Calculadora.Program.Main(array));
        }

        [TestMethod]
        public void TestFibbonaciRecursivo()
        {
            var input = new StringReader(@"10");

            Console.SetIn(input);

            string[] array = { "2", "2", "6" };
            Assert.AreEqual(55, Ex3Calculadora.Program.Main(array));
        }

        [TestMethod]
        public void TestFibbonaciIterativo()
        {
            var input = new StringReader(@"10");

            Console.SetIn(input);

            string[] array = { "2", "2", "7" };
            Assert.AreEqual(55, Ex3Calculadora.Program.Main(array));
        }

        [TestMethod]
        public void TestOpcaoInexistente()
        {
            string[] array = { "2", "2", "-1" };
            Assert.AreEqual(0, Ex3Calculadora.Program.Main(array));
        }

        [TestMethod]
        public void TestOpcaoInvalida()
        {
            string[] array = { "2", "2", "a" };
            Assert.ThrowsException<FormatException>(() => Ex3Calculadora.Program.Main(array));
        }

        [TestMethod]
        public void TestNum1Invalido()
        {
            string[] array = { "a", "2", "1" };
            Assert.ThrowsException<FormatException>(() => Ex3Calculadora.Program.Main(array));
        }

        [TestMethod]
        public void TestNum2Invalido()
        {
            string[] array = { "2", "a", "1" };
            Assert.ThrowsException<FormatException>(() => Ex3Calculadora.Program.Main(array));
        }

        [TestMethod]
        public void TestMedia()
        {

            var input = new StringReader(@"10 
            2 
            10 
            2
            10 
            1");

            var expectedOutput = 10;

            Console.SetIn(input);

            Assert.AreEqual(expectedOutput, Ex3Calculadora.Program.calcularMedia());
        }

        [TestMethod]
        public void TestIFibboIterativo()
        {
            var expectedOutput = 55;

            Assert.AreEqual(expectedOutput, Ex3Calculadora.Program.fibonacciIterativo(10));
        }

        [TestMethod]
        public void TestIFibboRecursivo()
        {
            var expectedOutput = 55;

            Assert.AreEqual(expectedOutput, Ex3Calculadora.Program.fibonacciRecursivo(10));
        }

        //TESTES DE CARGA
        [TestMethod]
        public void TestCFibboRecursivo()
        {
            var e = new StackOverflowException();

            Assert.AreEqual(e,Ex3Calculadora.Program.fibonacciRecursivo(1000000));
        }
    }
}
