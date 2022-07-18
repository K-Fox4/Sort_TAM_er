using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sort_TAM.structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_TAM.structure.Tests
{
    [TestClass()]
    public class TAMSorterTests
    {
        private char[] TAMUK_1 = new char[3] { 'M', 'A', 'T' };
        private char[] TAMUK_2 = new char[3] { 'M', 'T', 'M' };
        private char[] TAMUK_3 = new char[3] { 'M', 'A', 'A' };
        private char[] TAMUK_4 = new char[6] { 'M', 'A', 'T', 'M', 'A', 'T' };
        private char[] TAMUK_5 = new char[6] { 'A', 'A', 'T', 'M', 'A', 'T' };
        private char[] TAMUK_6 = new char[6] { 'A', 'A', 'T', 'A', 'A', 'T' };
        private char[] TAMUK_7 = new char[6] { 'A', 'A', 'M', 'M', 'A', 'M' };
        private char[] TAMUK_8 = new char[6] { 'A', 'T', 'T', 'M', 'A', 'T' };
        private char[] TAMUK_9 = new char[6] { 'A', 'A', 'T', 'T', 'A', 'T' };
        private char[] TAMUK_10 = new char[9] { 'A', 'A', 'T', 'T', 'A', 'T', 'M', 'M', 'M' };
        private char[] TAMUK_11 = new char[9] { 'A', 'A', 'T', 'T', 'A', 'T', 'T', 'T', 'M' };
        private char[] TAMUK_12 = new char[9] { 'A', 'A', 'T', 'T', 'A', 'T', 'A', 'M', 'A' };
        private char[] TAMUK_13 = new char[12] { 'A', 'A', 'T', 'T', 'A', 'T', 'M', 'T', 'M', 'A', 'A', 'A' };
        private char[] TAMUK_14 = new char[12] { 'A', 'A', 'T', 'T', 'A', 'T', 'T', 'T', 'T', 'T', 'T', 'A' };
        private char[] TAMUK_15 = new char[12] { 'A', 'A', 'T', 'T', 'A', 'T', 'M', 'M', 'M', 'M', 'A', 'M' };

        // Positive test cases

        [TestMethod()]
        public void Sort_TAMTest1()
        {
            string expected = "TAM";
            var result = TAMSorter.Sort_TAM(this.TAMUK_1);
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void Sort_TAMTest2()
        {
            string expected = "TMM";
            var result = TAMSorter.Sort_TAM(this.TAMUK_2);
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void Sort_TAMTest3()
        {
            string expected = "AAM";
            var result = TAMSorter.Sort_TAM(this.TAMUK_3);
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void Sort_TAMTest4()
        {
            string expected = "TTAAMM";
            var result = TAMSorter.Sort_TAM(this.TAMUK_4);
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void Sort_TAMTest5()
        {
            string expected = "TTAAAM";
            var result = TAMSorter.Sort_TAM(this.TAMUK_5);
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void Sort_TAMTest6()
        {
            string expected = "TTAAAA";
            var result = TAMSorter.Sort_TAM(this.TAMUK_6);
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void Sort_TAMTest7()
        {
            string expected = "AAAMMM";
            var result = TAMSorter.Sort_TAM(this.TAMUK_7);
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void Sort_TAMTest8()
        {
            string expected = "TTTAAM";
            var result = TAMSorter.Sort_TAM(this.TAMUK_8);
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void Sort_TAMTest9()
        {
            string expected = "TTTAAA";
            var result = TAMSorter.Sort_TAM(this.TAMUK_9);
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void Sort_TAMTest10()
        {
            string expected = "TTTAAAMMM";
            var result = TAMSorter.Sort_TAM(this.TAMUK_10);
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void Sort_TAMTest11()
        {
            string expected = "TTTTTAAAM";
            var result = TAMSorter.Sort_TAM(this.TAMUK_11);
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void Sort_TAMTest12()
        {
            string expected = "TTTAAAAAM";
            var result = TAMSorter.Sort_TAM(this.TAMUK_12);
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void Sort_TAMTest13()
        {
            string expected = "TTTTAAAAAAMM";
            var result = TAMSorter.Sort_TAM(this.TAMUK_13);
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void Sort_TAMTest14()
        {
            string expected = "TTTTTTTTAAAA";
            var result = TAMSorter.Sort_TAM(this.TAMUK_14);
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void Sort_TAMTest15()
        {
            string expected = "TTTAAAAMMMMM";
            var result = TAMSorter.Sort_TAM(this.TAMUK_15);
            Assert.AreEqual(expected, result);
        }

        // Negative test cases

        [TestMethod()]
        public void Sort_TAMTest16()
        {
            string notExpected = "TTTAAAAMMMMA";
            var result = TAMSorter.Sort_TAM(this.TAMUK_15);
            Assert.AreNotEqual(notExpected, result);
        }

        [TestMethod()]
        public void Sort_TAMTest17()
        {
            string notExpected = "TTTTTTTTAAAM";
            var result = TAMSorter.Sort_TAM(this.TAMUK_14);
            Assert.AreNotEqual(notExpected, result);
        }

        [TestMethod()]
        public void Sort_TAMTest18()
        {
            string notExpected = "TTTTAAAAAAMT";
            var result = TAMSorter.Sort_TAM(this.TAMUK_13);
            Assert.AreNotEqual(notExpected, result);
        }

        [TestMethod()]
        public void Sort_TAMTest19()
        {
            string notExpected = "TTTAAAAAT";
            var result = TAMSorter.Sort_TAM(this.TAMUK_12);
            Assert.AreNotEqual(notExpected, result);
        }

        [TestMethod()]
        public void Sort_TAMTest20()
        {
            string notExpected = "TTTTTAAAA";
            var result = TAMSorter.Sort_TAM(this.TAMUK_11);
            Assert.AreNotEqual(notExpected, result);
        }

        [TestMethod()]
        public void Sort_TAMTest21()
        {
            string notExpected = "TTTAAAMMA";
            var result = TAMSorter.Sort_TAM(this.TAMUK_10);
            Assert.AreNotEqual(notExpected, result);
        }

        [TestMethod()]
        public void Sort_TAMTest22()
        {
            string notExpected = "TTTAAM";
            var result = TAMSorter.Sort_TAM(this.TAMUK_9);
            Assert.AreNotEqual(notExpected, result);
        }

        [TestMethod()]
        public void Sort_TAMTest23()
        {
            string notExpected = "TTTAAA";
            var result = TAMSorter.Sort_TAM(this.TAMUK_8);
            Assert.AreNotEqual(notExpected, result);
        }

        [TestMethod()]
        public void Sort_TAMTest24()
        {
            string notExpected = "AAAMMT";
            var result = TAMSorter.Sort_TAM(this.TAMUK_7);
            Assert.AreNotEqual(notExpected, result);
        }

        [TestMethod()]
        public void Sort_TAMTest25()
        {
            string notExpected = "TTAAMM";
            var result = TAMSorter.Sort_TAM(this.TAMUK_6);
            Assert.AreNotEqual(notExpected, result);
        }

        [TestMethod()]
        public void Sort_TAMTest26()
        {
            string notExpected = "TTAAMA";
            var result = TAMSorter.Sort_TAM(this.TAMUK_5);
            Assert.AreNotEqual(notExpected, result);
        }

        [TestMethod()]
        public void Sort_TAMTest27()
        {
            string notExpected = "TATAMM";
            var result = TAMSorter.Sort_TAM(this.TAMUK_4);
            Assert.AreNotEqual(notExpected, result);
        }

        [TestMethod()]
        public void Sort_TAMTest28()
        {
            string notExpected = "MAA";
            var result = TAMSorter.Sort_TAM(this.TAMUK_3);
            Assert.AreNotEqual(notExpected, result);
        }

        [TestMethod()]
        public void Sort_TAMTest29()
        {
            string notExpected = "MMT";
            var result = TAMSorter.Sort_TAM(this.TAMUK_2);
            Assert.AreNotEqual(notExpected, result);
        }

        [TestMethod()]
        public void Sort_TAMTest30()
        {
            string notExpected = "MAT";
            var result = TAMSorter.Sort_TAM(this.TAMUK_1);
            Assert.AreNotEqual(notExpected, result);
        }
    }
}