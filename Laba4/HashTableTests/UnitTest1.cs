using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HashTable;
using System.Collections.Generic;
namespace HashTableTests
{
    [TestClass]
    public class HashTableTests
    {
        [TestMethod]
        public void ElementsTest()
        {
            var t = new HashTable.HashTable(3);

            t.PutPair("dd", 231);
            t.PutPair("dfg", 3224);
            t.PutPair("aaas", 4422);

            Assert.AreEqual(t.GetValueByKey("dd"), 231);
            Assert.AreEqual(t.GetValueByKey("dfg"), 3224);
            Assert.AreEqual(t.GetValueByKey("aaas"), 4422);
        }

        [TestMethod]
        public void TwoEquialsElementsTest()
        {
            var h = new HashTable.HashTable(3);

            h.PutPair("a", 3232);
            h.PutPair("a", 342);

            Assert.AreEqual(h.GetValueByKey("a"), 342);
        }

        [TestMethod]
        public void ElementsTest2()
        {
            var h = new HashTable.HashTable(10000);

            for (int i = 1; i < 10000; i++)
            {
                h.PutPair(i, i+1);
            }

            Assert.AreEqual(h.GetValueByKey(15), 16);
        }

        [TestMethod]
        public void ElementsSearchTests()
        {
            var h = new HashTable.HashTable(10000);

            for (int i = 1; i < 10000; i++)
            {
                h.PutPair(i, i+1);
            }

            for (int j = 10000; j <= 11000; j++)
            {
                Assert.AreEqual(h.GetValueByKey(j), null);
            }
        }
    }
}

