using System;
using System.Collections.Generic;
using System.IO;
using Electronic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class SeralizationTests
    {
        [TestMethod]
        public void End2EndSerializationTest()
        {
            var electro = new Choice
            {
                dateTime = DateTime.Now,
                FullName = "Savva Baranovsky",
                Price = 50000,
                Currency = Currency.Rubles,
                Laptop = new ElectronicRequirements()
                {
                   
                   
                },
                
            };
            var tempFileName = Path.GetTempFileName();
            try
            {
                ElectronicHelper.WriteToFile(tempFileName, electro);
                var readElectro = ElectronicHelper.LoadFromFile(tempFileName);
                Assert.AreEqual(electro.WayPoints.Count, readElectro.WayPoints.Count);
                Assert.AreEqual(electro.d, readElectro.dateTime);
            }
            finally
            {
                File.Delete(tempFileName);
            }
        }
    }
}
