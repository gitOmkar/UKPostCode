using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UKPostCode;
using System.Collections.Generic;
using System.Linq;

namespace UKPostCodeTest
{
    [TestClass]
    public class UnitTest1
    {
        //TestData
        private Dictionary<string, string> testData = new Dictionary<string, string>();
        private List<string> listPostCodes;

        [TestInitialize]
        public void Initialize()
        {            
            testData.Add("$%± ()()", "Junk");
            testData.Add("XX XXX", "Invalid");
            testData.Add("A1 9A", "Incorrect inward code length");
            testData.Add("LS44PL", "No space");
            testData.Add("Q1A 9AA", "'Q' in first position");
            testData.Add("V1A 9AA", "'V' in first position");
            testData.Add("X1A 9BB", "'X' in first position");
            testData.Add("LI10 3QP", "'I' in second position");
            testData.Add("LJ10 3QP", "'J' in second position");
            testData.Add("LZ10 3QP", "'Z' in second position");
            testData.Add("A9Q 9AA", "'Q' in third position with 'A9A' structure");
            testData.Add("AA9C 9AA", "'C' in fourth position with 'AA9A' structure");
            testData.Add("FY10 4PL", "Area with only single digit districts");
            testData.Add("SO1 4QQ", "Area with only double digit districts");
            testData.Add("EC1A 1BB", "None");
            testData.Add("W1A 0AX", "None");
            testData.Add("M1 1AE", "None");
            testData.Add("B33 8TH", "None");
            testData.Add("CR2 6XH", "None");
            testData.Add("DN55 1PT", "None");
            testData.Add("GIR 0AA", "None");
            testData.Add("SO10 9AA", "None");
            testData.Add("FY9 9AA", "None");
            testData.Add("WC1A 9AA", "None");
            listPostCodes = testData.Keys.ToList();
        }


        [TestMethod]
        public void TestMethod1()
        {
         Assert.AreEqual(true, Program.IsPostCode(listPostCodes[0]), testData[listPostCodes[10]].ToString());           
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(true, Program.IsPostCode(listPostCodes[1]), testData[listPostCodes[1]].ToString());
        }

        [TestMethod]
        public void TestMethod3()
        {            
            Assert.AreEqual(true, Program.IsPostCode(listPostCodes[2]), testData[listPostCodes[2]].ToString());
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(true, Program.IsPostCode(listPostCodes[3]), testData[listPostCodes[3]].ToString());
        }


        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual(true, Program.IsPostCode(listPostCodes[4]), testData[listPostCodes[4]].ToString());
        }

        [TestMethod]
        public void TestMethod6()
        {           
            Assert.AreEqual(true, Program.IsPostCode(listPostCodes[5]), testData[listPostCodes[5]].ToString());
        }

        [TestMethod]
        public void TestMethod7()
        {
            Assert.AreEqual(true, Program.IsPostCode(listPostCodes[6]), testData[listPostCodes[6]].ToString());
        }

        [TestMethod]
        public void TestMethod8()
        {           
            Assert.AreEqual(true, Program.IsPostCode(listPostCodes[7]), testData[listPostCodes[7]].ToString());
        }


        [TestMethod]
        public void TestMethod9()
        {           
            Assert.AreEqual(true, Program.IsPostCode(listPostCodes[8]), testData[listPostCodes[8]].ToString());
        }

        [TestMethod]
        public void TestMethod10()
        {           
            Assert.AreEqual(true, Program.IsPostCode(listPostCodes[9]), testData[listPostCodes[9]].ToString());
        }

        [TestMethod]
        public void TestMethod11()
        {            
            Assert.AreEqual(true, Program.IsPostCode(listPostCodes[10]), testData[listPostCodes[10]].ToString());
        }

        [TestMethod]
        public void TestMethod12()
        {           
            Assert.AreEqual(true, Program.IsPostCode(listPostCodes[11]), testData[listPostCodes[11]].ToString());
        }


        [TestMethod]
        public void TestMethod13()
        {          
            Assert.AreEqual(true, Program.IsPostCode(listPostCodes[12]), testData[listPostCodes[12]].ToString());
        }

        [TestMethod]
        public void TestMethod14()
        {          
            Assert.AreEqual(true, Program.IsPostCode(listPostCodes[13]), testData[listPostCodes[13]].ToString());
        }

        [TestMethod]
        public void TestMethod15()
        {
            Assert.AreEqual(true, Program.IsPostCode(listPostCodes[14]), testData[listPostCodes[14]].ToString());
        }

        [TestMethod]
        public void TestMethod16()
        {            
            Assert.AreEqual(true, Program.IsPostCode(listPostCodes[15]), testData[listPostCodes[15]].ToString());
        }

        [TestMethod]
        public void TestMethod17()
        {
            Assert.AreEqual(true, Program.IsPostCode(listPostCodes[16]), testData[listPostCodes[16]].ToString());
        }

        [TestMethod]
        public void TestMethod18()
        {
            Assert.AreEqual(true, Program.IsPostCode(listPostCodes[17]), testData[listPostCodes[17]].ToString());
        }

        [TestMethod]
        public void TestMethod19()
        {
            Assert.AreEqual(true, Program.IsPostCode(listPostCodes[18]), testData[listPostCodes[18]].ToString());
        }

        [TestMethod]
        public void TestMethod20()
        {
            Assert.AreEqual(true, Program.IsPostCode(listPostCodes[19]), testData[listPostCodes[19]].ToString());
        }


        [TestMethod]
        public void TestMethod21()
        {
            Assert.AreEqual(true, Program.IsPostCode(listPostCodes[20]), testData[listPostCodes[20]].ToString());
        }

        [TestMethod]
        public void TestMethod22()
        {
            Assert.AreEqual(true, Program.IsPostCode(listPostCodes[21]), testData[listPostCodes[21]].ToString());
        }

        [TestMethod]
        public void TestMethod23()
        {
            Assert.AreEqual(true, Program.IsPostCode(listPostCodes[22]), testData[listPostCodes[22]].ToString());
        }

        [TestMethod]
        public void TestMethod24()
        {
            Assert.AreEqual(true, Program.IsPostCode(listPostCodes[23]), testData[listPostCodes[23]].ToString());
        }


    }
}
