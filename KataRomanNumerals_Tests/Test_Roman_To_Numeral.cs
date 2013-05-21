using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace KataRomanNumerals_Tests
{
    [TestFixture]
    public class Test_Roman_To_Numeral
    {
        RomanNumber roman = new RomanNumber();

        #region Números Básicos
        [Test]
        public void Test_Numero_I_Es_1_Basico()
        {
            Assert.AreEqual(1, roman.ToNumeral("I"));
        }

        [Test]
        public void Test_Numero_V_Es_5_Basico()
        {
            Assert.AreEqual(5, roman.ToNumeral("V"));
        }

        [Test]
        public void Test_Numero_X_Es_10_Basico()
        {
            Assert.AreEqual(10, roman.ToNumeral("X"));
        }

        [Test]
        public void Test_Numero_L_Es_50_Basico()
        {
            Assert.AreEqual(50, roman.ToNumeral("L"));
        }

        [Test]
        public void Test_Numero_C_Es_100_Basico()
        {
            Assert.AreEqual(100, roman.ToNumeral("C"));
        }

        [Test]
        public void Test_Numero_D_Es_500_Basico()
        {
            Assert.AreEqual(500, roman.ToNumeral("D"));
        }

        [Test]
        public void Test_Numero_M_Es_1000_Basico()
        {
            Assert.AreEqual(1000, roman.ToNumeral("M"));
        }
        #endregion

        #region Números del 1 al 15
        [Test]
        public void Test_Numero_I_Es_1()
        {
            Assert.AreEqual(1, roman.ToNumeral("I"));
        }

        [Test]
        public void Test_Numero_II_Es_2()
        {
            Assert.AreEqual(2, roman.ToNumeral("II"));
        }

        [Test]
        public void Test_Numero_III_Es_3()
        {
            Assert.AreEqual(3, roman.ToNumeral("III"));
        }

        [Test]
        public void Test_Numero_IV_Es_4()
        {
            Assert.AreEqual(4, roman.ToNumeral("IV"));
        }

        [Test]
        public void Test_Numero_V_Es_5()
        {
            Assert.AreEqual(5, roman.ToNumeral("V"));
        }

        [Test]
        public void Test_Numero_VI_Es_6()
        {
            Assert.AreEqual(6, roman.ToNumeral("VI"));
        }

        [Test]
        public void Test_Numero_VII_Es_7()
        {
            Assert.AreEqual(7, roman.ToNumeral("VII"));
        }

        [Test]
        public void Test_Numero_VIII_Es_8()
        {
            Assert.AreEqual(8, roman.ToNumeral("VIII"));
        }

        [Test]
        public void Test_Numero_IX_Es_9()
        {
            Assert.AreEqual(9, roman.ToNumeral("IX"));
        }

        [Test]
        public void Test_Numero_X_Es_10()
        {
            Assert.AreEqual(10, roman.ToNumeral("X"));
        }

        [Test]
        public void Test_Numero_XI_Es_11()
        {
            Assert.AreEqual(11, roman.ToNumeral("XI"));
        }

        [Test]
        public void Test_Numero_XII_Es_12()
        {
            Assert.AreEqual(12, roman.ToNumeral("XII"));
        }

        [Test]
        public void Test_Numero_XIII_Es_13()
        {
            Assert.AreEqual(13, roman.ToNumeral("XIII"));
        }

        [Test]
        public void Test_Numero_XIV_Es_14()
        {
            Assert.AreEqual(14, roman.ToNumeral("XIV"));
        }

        [Test]
        public void Test_Numero_XV_Es_15()
        {
            Assert.AreEqual(15, roman.ToNumeral("XV"));
        }
        #endregion

        #region Romanos Erroneos
        [Test, ExpectedException("System.ArgumentException")]
        public void Test_Error_VXX()
        {
            roman.ToNumeral("VXX");
        }

        [Test, ExpectedException("System.ArgumentException")]
        public void Test_Error_XM()
        {
            roman.ToNumeral("XM");
        }
        #endregion
    
        [Test]
        public void Test_Iteracion_1_al_4999()
        {
            int max = 4999;
            for (int i = 1; i <= max; i++)
            {
                string strRoman = roman.ToRoman(i);

                Assert.AreEqual(i, roman.ToNumeral(strRoman));
                Assert.AreEqual(strRoman, roman.ToRoman(i));
            }
        }
    }
}