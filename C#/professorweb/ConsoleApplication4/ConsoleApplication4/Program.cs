using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApplication4
{
    class Program
    {


        private const int Index = 1;

        static void Main(string[] args)
        {
            var vulnersList = GetVulnerabilities(@"C:\Program Files (x86)\Positive Technologies\ApplicationInspector\ApplicationInspector.Services.Resources.VulnerabilityResourceDictionary.dll");
            vulnersList.Sort();
            foreach (var VARIABLE in vulnersList)
            {
                Console.WriteLine(VARIABLE);
            }

            Console.ReadKey();
        }
        private static List<string> GetVulnerabilities(string file)
        {
            var fileSourceCode = File.ReadAllText(file);
            var vulnerabilitiesAsXml = string.Format("<Vulnerabilities>{0}</Vulnerabilities>",
                GetXml(fileSourceCode, Index));
            var xdoc = new XmlDocument();
            xdoc.LoadXml(vulnerabilitiesAsXml);
            var vulnersList = new List<string>();
            if (xdoc.DocumentElement != null)
            {
                var xmlNodes = xdoc.SelectNodes("/Vulnerabilities/VulnerabilityInfo");
                if (xmlNodes != null)
                    foreach (XmlNode node in xmlNodes)
                    {
                        var xmlElement = node["Identity"];
                        if (xmlElement != null && !xmlElement.InnerText.ToLower().Contains("conf ") &&
                            !xmlElement.InnerText.ToLower().Contains("fp"))
                        {
                            var element = node["Header"];
                            if (element != null) vulnersList.Add(element.InnerText);
                        }
                    }
            }
            return vulnersList.Distinct().ToList();
        }

        private static string GetXml(string content, int index)
        {
            var stringSeparators = new[] { "<Vulnerabilities>", "</Vulnerabilities>" };
            var result = content.Split(stringSeparators, StringSplitOptions.None);
            if (result.Count() > index)
            {
                return result[index];
            }
            return string.Empty;
        }
    }
}
