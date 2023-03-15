using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TestDomeSolutions
{
    public class LogParser
    {
        public static IEnumerable<long> GetTimestampsByDescription(string xml, string description)
        {
            var testDoc = new XmlDocument();
            testDoc.LoadXml(xml);
            string xpath = "log/event";
            var nodes = testDoc.SelectNodes(xpath);
            List<long> result = new List<long>();
            foreach (XmlNode node in nodes)
            {
                if (node.InnerText.Contains(description))
                {
                    var val = node.Attributes.GetNamedItem("timestamp").Value;
                    result.Add(Convert.ToInt32(val));
                }
            }
            return result; // match every element
        }

        public static void Main(string[] args)
        {
            string xml =
                    "<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n" +
                    "<log>\n" +
                    "    <event timestamp=\"1614285589\">\n" +
                    "        <description>Intrusion detected</description>\n" +
                    "    </event>\n" +
                    "    <event timestamp=\"1614286432\">\n" +
                    "        <description>Intrusion ended</description>\n" +
                    "    </event>\n" +
                    "</log>";

            foreach (long timestamp in LogParser.GetTimestampsByDescription(xml, "Intrusion ended"))
                Console.WriteLine(timestamp);
        }
    }
}
