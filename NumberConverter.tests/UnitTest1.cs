using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using numberConverter;

namespace NumberConverter.tests
{
//-----------------------------------------------------------------------------------
    [TestClass]
    public class ArabicToRomanNumeralTests
    {
        [TestMethod]
        public void when_1_is_passed_I_should_be_returned()
        {
            //arrange()
            var converter = new RomanNumeralConverter();
            //act()
            var result = converter.Convert(1);

            //assert(check to see the result as we exepecting)
            Assert.AreEqual("I",result);
        }
//----------------------------------------------------------------------------
        [TestMethod]
        public void when_3_is_passed_III_should_be_returned()
        {
            //arrange( setup content of your test )
            var converter = new RomanNumeralConverter();
            //act(acll the function )
            var result = converter.Convert(3);

            //assert(check to see the result as we exepecting)
            Assert.AreEqual("III", result);
        }
//------------------------------------------------------------------------------------
        [TestMethod]
        public void when_4_is_passed_IV_should_be_returned()
        {
            var converter = new RomanNumeralConverter();

            var result = converter.Convert(4);

            Assert.AreEqual("IV", result);
        }
//---------------------------------------------------------------------------------------
        [TestMethod]
        public void when_5_is_passed_V_should_be_returned()
        {
            var converter = new RomanNumeralConverter();

            var result = converter.Convert(5);

            Assert.AreEqual("V", result);
        }
//---------------------------------------------------------------------------------------
        [TestMethod]
        public void when_8_is_passed_VIII_should_be_returned()
        {
            var converter = new RomanNumeralConverter();

            var result = converter.Convert(8);

            Assert.AreEqual("VIII", result);
        }
//---------------------------------------------------------------------------------------------------

        [TestMethod]
        public void when_9_is_passed_IX_should_be_returned()
        {
            var converter = new RomanNumeralConverter();

            var result = converter.Convert(9);

            Assert.AreEqual("IX", result);
        }
//---------------------------------------------------------------------------------------------------
        [TestMethod]
        public void when_13_is_passed_XIII_should_be_returned()
        {
            var converter = new RomanNumeralConverter();

            var result = converter.Convert(13);

            Assert.AreEqual("XIII", result);
        }
//---------------------------------------------------------------------------------------
        [TestMethod]
        public void when_99_is_passed_XCIX_should_be_returned()
        {
            var converter = new RomanNumeralConverter();

            var result = converter.Convert(99);

            Assert.AreEqual("XCIX", result);
        }
//---------------------------------------------------------------------------------------
        [TestMethod] 
        public void when_166_is_passed_CLXVI_should_be_returned()
        {
            var converter = new RomanNumeralConverter();

            var result = converter.Convert(166);

            Assert.AreEqual("CLXVI", result);
        }
        //-------------------------------------------------------------------------------------------
        [TestMethod]
        public void when_1066_is_passed_MLXVI_should_be_returned()
        {
            var converter = new RomanNumeralConverter();

            var result = converter.Convert(1066);

            Assert.AreEqual("MLXVI", result);
        }
//--------------------------------------------------------------------------------------------------
        [TestMethod]
        public void when_1989_is_passed_MCMLXXXIX_should_be_returned()
        {
            var converter = new RomanNumeralConverter();

            var result = converter.Convert(1989);

            Assert.AreEqual("MCMLXXXIX", result);
        }
    }
}
