namespace LB2_Task1_Forms
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int a, b, nsd, nsk;
            if (!string.IsNullOrWhiteSpace(tbxA.Text) || !string.IsNullOrWhiteSpace(tbxB.Text))
            {
                if (int.TryParse(tbxA.Text, out a) && int.TryParse(tbxB.Text, out b))
                {
                    if (a > 0 && b > 0)
                    {
                        int a1 = a;
                        int b1 = b;
                        while (b1 != 0)
                        {
                            int num = b1;
                            b1 = a1 % b1;
                            a1 = num;
                        }
                        nsd = a1;
                        lblNSD.Text = nsd.ToString();
                        nsk = (a * b) / nsd;
                        lblNSK.Text = nsk.ToString();
                    }
                    else if (a < 0 || b < 0)
                    {
                        MessageBox.Show("Вiд'ємнi числа не можуть бути використанi!\nСпробуйте знову.", "Помилка!");
                    }
                }
                else
                {
                    MessageBox.Show("Введено некоректні значення!\nСпробуйте знову.", "Помилка!");
                }
            }
            else
            {
                MessageBox.Show("Заповніть усі поля!", "Помилка!");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}