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

namespace WelcomeWpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBoxName_LostFocus(object sender, RoutedEventArgs e)
        {
            labelFirstStatement.Content = "Welcome " + textBoxName.Text + " " + textBoxSurrname.Text;
        }

        private void TextBoxSurrname_LostFocus(object sender, RoutedEventArgs e)
        {
            labelFirstStatement.Content = "Welcome " + textBoxName.Text + " " + textBoxSurrname.Text;
        }

        private void TextBoxAge_LostFocus(object sender, RoutedEventArgs e)
        {
            int age = Convert.ToInt32(textBoxAge.Text);
            if (age < 67)
            {
                labelSecondStatement.Content = string.Format("You will become pensioner in {0} years", 67 - age);
            }
            else
                labelSecondStatement.Content = "You are pensioner already";
        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            textBoxName.Text = "";
            textBoxSurrname.Text = "";
            textBoxAge.Text = "";
            labelFirstStatement.Content = "";
            labelSecondStatement.Content = "";
        }
    }
}
