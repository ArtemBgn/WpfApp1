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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //MessageBox.Show("Open this one windows!");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a = -1;// = Int32.Parse(textbox1.Text) + Int32.Parse(textbox2.Text);
            switch (combobox1.SelectedIndex)
            {
                case (0):
                    a = Int32.Parse(textbox1.Text) + Int32.Parse(textbox2.Text);
                    break;
                case (1):
                    a = Int32.Parse(textbox1.Text) - Int32.Parse(textbox2.Text);
                    break;
                case (2):
                    a = Int32.Parse(textbox1.Text) * Int32.Parse(textbox2.Text);
                    break;
                case (3):
                    a = Int32.Parse(textbox1.Text) / Int32.Parse(textbox2.Text);
                    break;
                case (4):
                    a = Int32.Parse(textbox1.Text) % Int32.Parse(textbox2.Text);
                    break;
            }
            label1.Content = a.ToString();
        }
    }
}
