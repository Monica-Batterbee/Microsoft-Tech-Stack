namespace LoopConstructs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 70; i++)
            {
                progressBar1.Value = i;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] fibarray = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };


            foreach (int element in fibarray)
            {
                progressBar2.Value = element;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < 70)
            {
                progressBar3.Value = i;
                i++;
            }
        }
            

        private void button4_Click(object sender, EventArgs e)
        {
            int i = 0;
            do
            {
                progressBar4.Value = i;
                i++;
            } while (i < 70);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                progressBar1.Value = i;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                progressBar1.Value = i;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int[] fibarray = new int[50];

            for (int i = 0; i < 50; i++)
            {
                fibarray[i] = i;
            }

            foreach (int element in fibarray)
            {
                progressBar2.Value = element;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int[] fibarray = new int[100];

            for (int i = 0; i < 100; i++)
            {
                fibarray[i] = i;
            }

            foreach (int element in fibarray)
            {
                progressBar2.Value = element;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int i = 0;
            do
            {
                progressBar4.Value = i;
                i++;
            } while (i < 50);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int i = 0;
            do
            {
                progressBar4.Value = i;
                i++;
            } while (i < 100);
        }

    }
}
