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

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
            c1.Items.Add("C");
            c1.Items.Add("CPP");
            c1.Items.Add("DS");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lblres.Content = c1.SelectedItem.ToString();
        }
    }
}
