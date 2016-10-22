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

namespace Assignment6Group6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int userChoice = 0;
        int computeChoice = 0;
        public MainWindow()
        {
            InitializeComponent();            
        }

        private void btnBegin_Click(object sender, RoutedEventArgs e)
        {
            Random ran = new Random();
            int num = ran.Next(1, 4);
            computeChoice = num;
            if(userChoice == 0 || computeChoice == 0)
            {
                MessageBox.Show("Please follow correct steps.");
                lblResult.Content = "";
            }
            if (userChoice == 1)
            {
                if (computeChoice == 1)
                {
                    lblResult.Content = "Its a tie!!!";
                }
                else if (computeChoice == 2)
                {
                    lblResult.Content = "Computer Wins";
                }
                else if (computeChoice == 3)
                {
                    lblResult.Content = "Computer Wins";
                }
            }
            else if (userChoice == 2)
            {
                if (computeChoice == 1)
                {
                    lblResult.Content = "You Win!!!";
                }
                else if (computeChoice == 2)
                {
                    lblResult.Content = "It's a tie";
                }
                else if (computeChoice == 3)
                {
                    lblResult.Content = "Computer Wins";
                }
            }
            else if (userChoice == 3)
            {
                if (computeChoice == 1)
                {
                    lblResult.Content = "You Win!!!";
                }
                else if (computeChoice == 2)
                {
                    lblResult.Content = "You Win!!!";
                }
                else if (computeChoice == 3)
                {
                    lblResult.Content = "It's a tie";
                }
            }
        }

        private void btnRock_Click(object sender, RoutedEventArgs e)
        {
            userChoice = 1;
        }

        private void btnPaper_Click(object sender, RoutedEventArgs e)
        {
            userChoice = 2;
        }

        private void btnScissor_Click(object sender, RoutedEventArgs e)
        {
            userChoice = 3;
        }
        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            userChoice = 0;
            computeChoice = 0;
            lblResult.Content = null;
        }
    }
}
