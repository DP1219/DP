using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Linq;


namespace XmlDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // geTXmlBookContent();

            Console.ReadKey();

        }

        private static void geTXmlBookContent()
        {
            XmlDocument xmldoc = new XmlDocument();
            XmlNodeList xmlnode;
            int i = 0;
            string str = null;
            FileStream fs = new FileStream(@"D:\DP\XmlDemo\XmlDemo\dp.xml", FileMode.Open, FileAccess.Read);
            xmldoc.Load(fs);
            xmlnode = xmldoc.GetElementsByTagName("book");
            for (i = 0; i <= xmlnode.Count - 1; i++)
            {
                xmlnode[i].ChildNodes.Item(0).InnerText.Trim();
                str = xmlnode[i].ChildNodes.Item(0).InnerText.Trim() + "\t" +
                    xmlnode[i].ChildNodes.Item(1).InnerText.Trim() + "\t" +
                    xmlnode[i].ChildNodes.Item(2).InnerText.Trim() + "\t" +
                    xmlnode[i].ChildNodes.Item(3).InnerText.Trim();
                Console.WriteLine(str);
            }
        }
    }
}
