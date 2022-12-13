using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static ce205_hw4_algorithms_cs.Class1;


namespace ce205_hw4_test_cs
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Open_Addressing_LinearProbing_Test1()
        {
            HashOps hashOps = new HashOps();
            hashOps.OpenTable();
            string LoremText = "Sed eu tristique est. Class aptent taciti sociosqu ad litora.";
            string[] LoremArray = LoremText.Split();
            for (int i = 0; i < LoremArray.Length; i++)
                hashOps.LinearInsert(i + 1, LoremArray[i]);
            string result = hashOps.GetDataLinearProbing(1);
            string expected = "Sed";
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Open_Addressing_QuadraticProbing_Test1()
        {
            HashOps hashOps = new HashOps();
            hashOps.OpenTable();
            string LoremText = "Vestibulum et urna velit. Aenean vitae porttitor mi. Phasellus at.";
            string[] LoremArray = LoremText.Split();
            for (int i = 0; i < LoremArray.Length; i++)
                hashOps.QuadraticInsert(i + 1, LoremArray[i]);
            string result = hashOps.GetDataQuadraticProbing(1);
            string expected = "Vestibulum";
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void Open_Addressing_DoubleHashing_Test1()
        {
            HashOps hashOps = new HashOps();
            hashOps.OpenTable();
            string LoremText = "Donec augue arcu, venenatis interdum blandit at, pretium sed arcu.";
            string[] LoremArray = LoremText.Split();
            for (int i = 0; i < LoremArray.Length; i++)
                hashOps.DoubleHashing(i + 1, LoremArray[i]);
            string result = hashOps.GetDataDoubleHashing(8);
            string expected = "pretium";
            Assert.AreEqual(expected, result);
        }
    }
}
