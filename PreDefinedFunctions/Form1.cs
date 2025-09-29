using System;
using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PreDefinedFunctions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = label1.Text;
            string reversed = new string(text.Reverse().ToArray());
            label1.Text = reversed;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mainString = label2.Text;

            int position = mainString.IndexOf("b");
            if (position != -1)
            {
                label2.Text = $"letter b found at position: {position + 1}";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = label3.Text.Length.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4.Text = Math.Sqrt(Double.Parse(label4.Text)).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label5.Text = Math.Floor(Double.Parse(label5.Text)).ToString();
        }
    }
}
