using System.IO;
using System.Xml.Serialization;

namespace Travel
{
    public static class TravelHelper
    {
        private static readonly XmlSerializer Xs = new XmlSerializer(typeof(RideRequestDto));
        public static void WriteToFile(string fileName, RideRequestDto data)
        {
            using (var fileStream = File.Create(fileName))
            {
                Xs.Serialize(fileStream, data);
            }
        }

        public static RideRequestDto LoadFromFile(string fileName)
        {
            using (var fileStream = File.OpenRead(fileName))
            {
                return (RideRequestDto)Xs.Deserialize(fileStream);
            }
        }
    }
}