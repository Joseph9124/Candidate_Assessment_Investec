using Investec_Assessment;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Investec_Assessment_Test
{
    [TestClass]
    public class StringManupulationTest
    {
        [TestMethod]
        public void TestDuplicates()
        {
            String str = "I like to eat apples";
            String options = "1";

            StringManupulation sm = new StringManupulation(str, options);

            sm.performOperations();
        }

        [TestMethod]
        public void TestDuplicatesMultipleOptions()
        {
            String str = "I like to eat apples";
            String options = "12";

            StringManupulation sm = new StringManupulation(str, options);

            sm.performOperations();
        }

        [TestMethod]
        public void TestDuplicatesMultipleOptionsTwo()
        {
            String str = "I like to eat apples";
            String options = "123";

            StringManupulation sm = new StringManupulation(str, options);

            sm.performOperations();
        }

        [TestMethod]
        public void TestDuplicatesTwo()
        {
            String str = "I like eating apples";
            String options = "1";

            StringManupulation sm = new StringManupulation(str, options);

            sm.performOperations();
        }

        [TestMethod]
        public void TestDuplicatesThree()
        {
            String str = "abcd4";
            String options = "1";

            StringManupulation sm = new StringManupulation(str, options);

            sm.performOperations();
        }

        [TestMethod]
        public void TestVowels()
        {
            String str = "I like eating apples";
            String options = "2";

            StringManupulation sm = new StringManupulation(str, options);

            sm.performOperations();
        }

        [TestMethod]
        public void TestVowelsTwo()
        {
            String str = "jkl kkjh";
            String options = "2";

            StringManupulation sm = new StringManupulation(str, options);

            sm.performOperations();
        }

        [TestMethod]
        public void TestVowelsAndNonVowels()
        {
            String str = "I eat";
            String options = "3";

            StringManupulation sm = new StringManupulation(str, options);

            sm.performOperations();
        }

        [TestMethod]
        public void TestVowelsAndNonVowelsTwo()
        {
            String str = "that dog";
            String options = "3";

            StringManupulation sm = new StringManupulation(str, options);

            sm.performOperations();
        }

        [TestMethod]
        public void TestVowelsAndNonVowelsThree()
        {
            String str = "3 a";
            String options = "3";

            StringManupulation sm = new StringManupulation(str, options);

            sm.performOperations();
        }
    }
}
