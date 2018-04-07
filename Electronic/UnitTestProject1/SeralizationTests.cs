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
                ElectronicRequirements = new ElectronicRequirements()
                    { 
                        NameLaptop = new List<NameLaptop>()
                        {
                            
                            new NameLaptop () {Name = "MSI" },
                        },
                      
                    },
                Additions = new List<Addition>()
                        {
                            new Addition () {Memory = 8 },
                            new Addition () {VideoCard = "Nvidia" },
                            new Addition () {Processor = "Intel Core I7" },

                        }

            };
            var tempFileName = Path.GetTempFileName();
            try
            {
                ElectronicHelper.WriteToFile(tempFileName, electro);
                var readElectro = ElectronicHelper.LoadFromFile(tempFileName);
                Assert.AreEqual(electro.Additions.Count, readElectro.Additions.Count);
                Assert.AreEqual(electro.dateTime, readElectro.dateTime);
            }
            finally
            {
                File.Delete(tempFileName);
            }
        }
    }
}
