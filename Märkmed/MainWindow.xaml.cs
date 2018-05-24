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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Märkmed
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var create = new Create();
            create.CreateMethod();
        }

        private void btnWrite_Click(object sender, RoutedEventArgs e)
        {
            var writeWindow = new WriteWindow { Owner = this };
            writeWindow.ShowDialog();
        }

        private void btnRead_Click(object sender, RoutedEventArgs e)
        {
            var readWindow = new ReadWindow { Owner = this };
            readWindow.ShowDialog();
        }
    }
}
