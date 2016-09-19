using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        Random RandomClass = new Random();
        int randomNumber; 
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (randomNumber == 1)
                    label2.Text = "You win!!";
                else
                    label2.Text = "Sorry - you lose";
                disable();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (randomNumber == 2)
                label2.Text = "You win!!";
            else
                label2.Text = "Sorry - you lose";
            disable();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (randomNumber == 3)
                label2.Text = "You win!!";
            else
                label2.Text = "Sorry - you lose";
            disable();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (randomNumber == 4)
                label2.Text = "You win!!";
            else
                label2.Text = "Sorry - you lose";
            disable();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (randomNumber == 5)
                label2.Text = "You win!!";
            else
                label2.Text = "Sorry - you lose";
            disable();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            randomNumber = RandomClass.Next(1, 5);
            radioButton6.Checked = true;
            label2.Text = "";
        }
        private void disable()
        {
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            radioButton4.Enabled = false;
            radioButton5.Enabled = false;
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            if (randomNumber == 1)
                label4.Text = "It's not 3";
            else
                label4.Text = "It's not " + (randomNumber - 1);
        }
    }
}