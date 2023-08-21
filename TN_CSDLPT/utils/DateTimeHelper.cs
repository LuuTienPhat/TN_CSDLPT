using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TN_CSDLPT.utils
{
    internal class DateTimeHelper
    {
        public static string DateTimeToString(DateTime dateTime, string format)
        {
            string dateTimeString = null;
            try
            {
                dateTime.ToString(format);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return dateTimeString;
        }

        public static string ConvertObjectToXMLString(object classObject)
        {
            string xmlString = null;
            XmlSerializer xmlSerializer = new XmlSerializer(classObject.GetType());
            using (MemoryStream memoryStream = new MemoryStream())
            {
                xmlSerializer.Serialize(memoryStream, classObject);
                memoryStream.Position = 0;
                xmlString = new StreamReader(memoryStream).ReadToEnd();
            }
            return xmlString;
        }
    }
}
