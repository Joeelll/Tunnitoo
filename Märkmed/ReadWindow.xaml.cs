using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml;

namespace Märkmed
{
    /// <summary>
    /// Interaction logic for ReadWindow.xaml
    /// </summary>
    public partial class ReadWindow : Window
    {
        public ReadWindow()
        {
            InitializeComponent();
            XmlDocument doc = new XmlDocument();
            doc.Load("notes.xml");
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                NotesListBox.Items.Add(new Note
                {
                    Title = node.Attributes["Title"].InnerText
                });
            }
        }

        
        private void btnView_Click(object sender, RoutedEventArgs e)
        {
            if (NotesListBox.HasItems == true)
            {
                XmlDocument xml = new XmlDocument();
                xml.Load("notes.xml");

                XmlNodeList xnList = xml.SelectNodes("/Notes/Note");
                var index = NotesListBox.SelectedIndex;
                MessageBox.Show(Convert.ToString(xnList.Item(index).InnerText));
            }
        }
    }
}
