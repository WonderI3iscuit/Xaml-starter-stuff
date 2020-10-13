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

namespace SekolWpfWalkthrogh
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string yourNameOutput;
        double mathNumber1;
        double mathNumber2;
        double mathNumathFinalAnswer;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void onClick(object sender, RoutedEventArgs e)
        {
            yourNameOutput = yourName.Text;

            printed_Response.Text = yourNameOutput;

            mathNumber1 = double.Parse(numberOne.Text);
            mathNumber1 = double.Parse(numberTwo.Text);
            mathNumathFinalAnswer = mathNumber1 + mathNumber2;

            mathAnswer.Text = Convert.ToString(mathNumathFinalAnswer);
        }

        private void onClear(object sender, RoutedEventArgs e)
        {
            yourName.Text = "";
            printed_Response.Text = "";
            numberTwo.Text = "";
            numberOne.Text = "";
        }

        private void onExit(object sender, RoutedEventArgs e)
        {
            this.Close();

            //you could also do environment.exit(0);
        }
    }
}
