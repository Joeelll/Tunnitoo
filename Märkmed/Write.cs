using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Märkmed
{
    class Write
    {
        public void WriteMethod(string Title, string Text)
        {
            XDocument xml = XDocument.Load("notes.xml");
            XElement root = new XElement("Note");
            root.Add(new XAttribute("Title", Title));
            root.Add(new XElement("Text", Text));
            xml.Element("Notes").Add(root);
            xml.Save("notes.xml");
        }


    }
}
