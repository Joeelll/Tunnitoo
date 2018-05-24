using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Märkmed
{
    class Create
    {
        public void CreateMethod()
        {
            if (!File.Exists("notes.xml"))
            {
                XmlWriter xmlWriter = XmlWriter.Create("notes.xml");
                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement("Notes");
                xmlWriter.WriteEndElement();
                xmlWriter.Close();
            }
        }
    }
}
