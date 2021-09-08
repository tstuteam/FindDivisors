using FindDivisorsLibrary;
using System;
using System.Windows.Forms;

namespace DividersWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Calculation of divisors.
        /// Processing user input.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Clear();

            var divisors = new Divisors();

            var isN1Int = int.TryParse(textBox1.Text, out int n1);
            var isN2Int = int.TryParse(textBox2.Text, out int n2);

            if (!IsCorrectInput(isN1Int, ref n1, isN2Int, ref n2))
            {
                MessageBox.Show("The input values ​​were specified incorrectly.", "Error");
                return;
            }

            textBox3.Text = divisors.StrDict(divisors.TwoDivisors(n1, n2));
        }

        /// <summary>
        /// Checks the correctness of the input,
        /// if possible, then makes it correct.
        /// </summary>
        /// <param name="isN1Int"></param>
        /// <param name="n1"></param>
        /// <param name="isN2Int"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        private bool IsCorrectInput(bool isN1Int, ref int n1, bool isN2Int, ref int n2)
        {
            if (isN1Int && isN2Int)
            {
                if (n1 < 0 || n2 < 0)
                {
                    n1 = Math.Abs(n1);
                    n2 = Math.Abs(n2);
                }

                if (n1 > n2)
                    Swap(ref n1, ref n2);

                return true;
            }

            return false;
        }

        /// <summary>
        /// Swaps two integers with a pointer
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        private void Swap(ref int n1, ref int n2)
        {
            var buffer = n1;
            n1 = n2;
            n2 = buffer;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
