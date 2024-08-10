using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.ComponentModel.Design.Serialization;

namespace SHIELD
{
    internal class ConfigTool
    {
        private dynamic xml = Data.test;
        public Dictionary<string, string> nme_conf = new Dictionary<string, string>();

        private void impConfig(string fileName)
        {
            XDocument xDoc;

            if (File.Exists(xml))
            {
                xDoc = XDocument.Load(xml);
            }
            else
            {
                xDoc = new XDocument(new XElement("root"));
            }

            XElement xElm = new XElement(fileName,
                new XElement("ID", ""),
                new XElement("Name", fileName.ToString()),
                new XElement("pIP", ""),
                new XElement("sIP", "")
                );

            xDoc.Root.Add(xElm);
            xDoc.Save(xml);
        }

        public void expConfig(string file)
        {
            nme_conf.Add("Test", "is test");

            XDocument xDoc = XDocument.Load(xml);

            if (file != null && nme_conf.Count > 0)
            {
                foreach (XElement xElm in xDoc.Descendants(nme_conf["Test"]))
                {
                    File.WriteAllText(file, xElm.ToString());
                }
            }
        }

        private void repConfig()
        {
            XDocument xDoc = XDocument.Load(xml);

            foreach (XElement element in xDoc.Descendants(""))
            {

            }
        }

        private void delConfig()
        {

        }

        public void List(dynamic x)
        {
            XDocument xDoc = XDocument.Load(xml);

            foreach (XElement xElm in xDoc.Descendants("Root"))
            {
                string name = xElm.Element("Name").Value;
                string id = xElm.Element("ID").Value;

                nme_conf.Add(id, name);
            }

            for (int i = 0; i < nme_conf.Count; i++)
            {
                foreach (var radio in nme_conf)
                {
                    RadioButton radioButton = new RadioButton();

                    radioButton.ForeColor = Color.White;
                    radioButton.Location = new System.Drawing.Point(10, 30 * i + 1);
                    radioButton.Size = new System.Drawing.Size(300, 30);
                    radioButton.Text = radio.Value;
                    radioButton.Name = radio.Value;
                }


                Config config = new Config();

                
            }
        }
    }
}
