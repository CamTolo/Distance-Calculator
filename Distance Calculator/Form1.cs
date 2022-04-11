using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distance_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //This program calculates the speed and hours to discover the distance after time


            int speed, time, distance;

            //create a loop to calc ---- hour & distance will be calculated with information entered by user
            if (int.TryParse(vehicleSpeedTextBox.Text, out speed) && int.TryParse(hoursTraveledTextBox.Text, out time))
            {
                //create a loop to calc ---- hour & distance will be calculated with information entered by user
                for (int i = 1; i <= time; i++)
                {
                    distance = speed * i;
                    outputListBox.Items.Add("After hour " + i + " the distance is " + distance.ToString());
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clears the inputs from the screen
            vehicleSpeedTextBox.Clear();
            hoursTraveledTextBox.Clear();
            outputListBox.Items.Clear();

            //focuses on the vehicle speed after clear
            this.ActiveControl = vehicleSpeedTextBox;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //This button closes the application
            MessageBox.Show("Designed By: Cam Tolo");
            this.Close();
        }
    }
}
