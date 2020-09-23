using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3pt2
{
    public partial class Form1 : Form
    {
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //YES button
                switch(counter)
                {
                    case 0:
                        label1.Text = "Is Lamp plugged in?";
                        counter=counter+1;
                        break;
                    case 1:
                        counter = 3;
                        label1.Text = "is Bulb burned out?";
                        break;
                    case 2:
                        counter++;
                        break;
                    case 3:
                        counter = 4;
                        label1.Text = "Replace bulb";
                        break;
                    case 4:
                        counter = 5;
                        label1.Text = "Repair the lamp";
                        break;
                    case 5:
                        counter = 6;
                        label1.Text = "Repair the lamp";
                        break;
                    /*
                    case 3:
                        label1.Text = "is Bulb burned out?";
                        counter = counter + 1;
                        break;
                    case 4:
                        label1.Text = "Replace bulb!";
                        break;
                    case 5:
                        label1.Text = "Repair lamp!";
                        break;
                    */
                }
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //NO button
            switch (counter)
            {
                case 0:
                    label1.Text = "Is Lamp plugged in?";
                    counter++;
                    break;
                case 1:
                    label1.Text = "Plug in lamp!";
                    counter = counter + 1;
                    break;
                case 2:
                    label1.Text = "is Bulb burned out?";
                    counter++;
                    break;
                case 3:
                    label1.Text = "Repair lamp!";
                    counter=6;
                    break;
            }

        }
    }
}
