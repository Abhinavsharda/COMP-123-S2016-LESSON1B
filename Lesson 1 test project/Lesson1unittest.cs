using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static COMP123_S2016_lESSON1B.Program;


namespace Lesson_1_test_project
{
    /**
     * This classis to test lesson 1 project
     * @class lessonunit test1
     * 
     */
    [TestClass]
    public class Lesson1unittest
    {
        /**
         * unitr test for  output stringtoconsole method  of program class
         * 
         * @method OutPutStringToConsoleTestMethod
         */
        [TestMethod]
        public void OutPutStringToConsoleTestMethod()
        {
            // Arrange
            string outputString = "Enter User Name";
            bool hasNewLine = false;
            string actualResult;
            string expectedResult = "Enter Name";

            // Act
            actualResult = OutPutStringToConsoleMethod(outputString, hasNewLine);
            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
