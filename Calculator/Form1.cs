using static System.Net.Mime.MediaTypeNames;

namespace Calculator
{
    public partial class Form1 : Form
    {
        List<string> operators = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void FormCalculation(string value)
        {

            try
            {
                int number = int.Parse(value);
                textBox1.Text += number;
            }
            catch
            {
                try 
                {
                    int.Parse(textBox1.Text[textBox1.Text.Length - 1].ToString());
                }
                catch {
                    return;
                }

                if (value == "=")
                {
                    string[] parts = textBox1.Text.Split(new char[] { '+', '-', '*', '/' });
                    int[] numbers = parts.Select(p => int.Parse(p)).ToArray();

                    foreach (int n in numbers)
                    {
                        textBox2.Text += n.ToString();
                        textBox2.Text += ",";
                    }

                    foreach (string op in operators)
                    {
                        textBox2.Text += op;
                    }


                    int currentValue = numbers[0];

                    for (int i = 0; i < operators.Count; i++)
                    {
                        if (operators[i] == "+")
                        {

                            currentValue += numbers[i + 1];
                        }

                        else if (operators[i] == "-")
                        {
                            currentValue -= numbers[i + 1];
                        }

                        else if (operators[i] == "*")
                        {
                            currentValue *= numbers[i + 1];
                        }

                        else if (operators[i] == "/")
                        {
                            currentValue /= numbers[i + 1];
                        }
                    }



                    textBox1.Text = currentValue.ToString();
                    numbers = [];
                    operators = [];
                    return;
                }


                else
                {

                    operators.Add(value);

                }
                textBox1.Text += value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCalculation("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCalculation("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormCalculation("3");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormCalculation("4");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormCalculation("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormCalculation("6");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FormCalculation("7");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FormCalculation("8");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FormCalculation("9");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            FormCalculation("0");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormCalculation("/");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormCalculation("*");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FormCalculation("+");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            FormCalculation("-");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            FormCalculation("=");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
        }
    }
}
