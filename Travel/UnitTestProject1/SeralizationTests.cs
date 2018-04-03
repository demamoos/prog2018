using System;
using System.Collections.Generic;
using System.IO;
using Travel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class SeralizationTests
    {
        [TestMethod]
        public void End2EndSerializationTest()
        {
            var dto = new RideRequestDto
            {
                Filled = DateTime.Now,
                FullName = "Savva Baranovsky",
                Price = 25500,
                Currency = Currency.Rubles,
                Tr = new TravelRequirements()
                {
                    Baby = new List<BabyRequirements>()
                    {
                        new BabyRequirements() { Age = 8 },
                        new BabyRequirements() { Age = 7 },
                    },
                    NoSmoking = true
                },
                WayPoints = new List<WayPoint>()
                {
                    new WayPoint
                    {
                        Address = "Ленина 54",
                        Type = WayPointType.Start
                    },
                    new WayPoint
                    {
                        Address = "Куйбышева 90",
                        Type = WayPointType.Pickpoint,
                        Latitude = null,
                        Longtitude = 1
                    },
                    new WayPoint()
                    {
                        Address = "Гагарина 20",
                        Type = WayPointType.Stop
                    }
                }
            };
            var tempFileName = Path.GetTempFileName();
            try
            {
                TravelHelper.WriteToFile(tempFileName, dto);
                var readDto = TravelHelper.LoadFromFile(tempFileName);
                Assert.AreEqual(dto.WayPoints.Count, readDto.WayPoints.Count);
                Assert.AreEqual(dto.Filled, readDto.Filled);
            }
            finally
            {
                File.Delete(tempFileName);
            }
        }
    }
}
