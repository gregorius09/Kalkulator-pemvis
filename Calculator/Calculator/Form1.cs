using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_pressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0")||(operation_pressed))
                result.Clear();

            operation_pressed = false;
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void OperatorClick(object sender, EventArgs e)
        {

            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse (result.Text);
            operation_pressed = true;
            label1.Text = value + " " + operation;
        }

        private void buttonSamadengan_Click(object sender, EventArgs e)
        {
            operation_pressed = false;
            label1.Text = "";
            switch(operation)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)). ToString();
                    break;
                case "*":
                    result.Text = (value * Double.Parse(result.Text)). ToString();
                    break;
                case "/":
                    result.Text = (value / Double.Parse(result.Text)). ToString();
                    break;
                default:
                    break;
            } //akhir switch
            operation_pressed = false;


        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            result.Clear();
            value = 0;
        }

        private void btn1_Click(object sender, EventArgs e)
        {

        }
    }
}
