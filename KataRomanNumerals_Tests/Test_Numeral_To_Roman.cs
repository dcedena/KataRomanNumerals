using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace KataRomanNumerals_Tests
{
    [TestFixture]
    public class Test_Numeral_To_Roman
    {
        private RomanNumber roman = new RomanNumber();

        [Test]
        public void Test_Basics_RomanNumerals()
        {
            Assert.AreEqual("I", roman.ToRoman(1));
            Assert.AreEqual("V", roman.ToRoman(5));
            Assert.AreEqual("X", roman.ToRoman(10));
            Assert.AreEqual("L", roman.ToRoman(50));
            Assert.AreEqual("C", roman.ToRoman(100));
            Assert.AreEqual("D", roman.ToRoman(500));
            Assert.AreEqual("M", roman.ToRoman(1000));
        }

        [Test]
        public void Test_SpecialNumbers()
        {
            Assert.AreEqual("IV", roman.ToRoman(4));
            Assert.AreEqual("CM", roman.ToRoman(900));
            Assert.AreEqual("CD", roman.ToRoman(400));
            Assert.AreEqual("XC", roman.ToRoman(90));
            Assert.AreEqual("XL", roman.ToRoman(40));
            Assert.AreEqual("IX", roman.ToRoman(9));
        }

        [Test]
        public void Test_Numeral_2()
        {
            Assert.AreEqual("II", roman.ToRoman(2));
        }

        [Test]
        public void Test_Numeral_3()
        {
            Assert.AreEqual("III", roman.ToRoman(3));
        }

        [Test]
        public void Test_Numeral_6()
        {
            Assert.AreEqual("VI", roman.ToRoman(6)); 
        }

        [Test]
        public void Test_Numeral_11()
        {
            Assert.AreEqual("XI", roman.ToRoman(11));
        }

        [Test]
        public void Test_Numeral_27()
        {
            Assert.AreEqual("XXVII", roman.ToRoman(27));
        }

        [Test]
        public void Test_Numeral_123()
        {
            Assert.AreEqual("CXXIII", roman.ToRoman(123));
        }

        [Test]
        public void Test_Numeral_555()
        {
            Assert.AreEqual("DLV", roman.ToRoman(555));
        }

        [Test]
        public void Test_Numeral_1982()
        {
            Assert.AreEqual("MCMLXXXII", roman.ToRoman(1982));
        }


        //[Test, Ignore]
        //public void Test_Numeral_()
        //{
        //    Assert.AreEqual("", roman.ToRomanNumeral(0));
        //}

        //[Test, Ignore]
        //public void Test_Numeral_()
        //{
        //    Assert.AreEqual("", roman.ToRomanNumeral(0));
        //}

        //[Test, Ignore]
        //public void Test_Numeral_()
        //{
        //    Assert.AreEqual("", roman.ToRomanNumeral(0));
        //}

    }
}
