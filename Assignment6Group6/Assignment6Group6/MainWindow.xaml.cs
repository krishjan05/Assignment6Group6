/* File: MainWindow.xaml.cs
 * Created by: Krishna Kanhaiya
 * Created on: 21 October 2016
 * Title: Rock Paper Scissor Game
    */

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
            // Following is the logic to decide the winner of the game
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
        //Logic for assigning user choice for Rock selection
        private void btnRock_Click(object sender, RoutedEventArgs e)
        {
            userChoice = 1;
        }
        //Logic for assigning user choice for Paper selection
        private void btnPaper_Click(object sender, RoutedEventArgs e)
        {
            userChoice = 2;
        }
        //Logic for assigning user choice for Scissor selection
        private void btnScissor_Click(object sender, RoutedEventArgs e)
        {
            userChoice = 3;
        }
        //Logic for reset button
        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            userChoice = 0;
            computeChoice = 0;
            lblResult.Content = null;
        }
    }
}
