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

namespace Märkmed
{
    /// <summary>
    /// Interaction logic for WriteWindow.xaml
    /// </summary>
    public partial class WriteWindow : Window
    {
        public WriteWindow()
        {
            InitializeComponent();
        }

        private void btn_Clear_Click(object sender, RoutedEventArgs e)
        {
            Title.Text = "";
            Text.Text = "";
        }

        private void btn_Save_Click(object sender, RoutedEventArgs e)
        {
            var write = new Write();
            write.WriteMethod(Title.Text, Text.Text);
            Title.Text = "";
            Text.Text = "";
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Text.IsEnabled = true;
        }
    }
}
