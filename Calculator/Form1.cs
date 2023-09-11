namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string Total;
        int fNum;
        int secNum;
        string operation;
        int result;

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn9.Text;
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            operation = "+";
            fNum = int.Parse(txtDisplay.Text);
            txtDisplay.Clear();

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn6.Text;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            operation = "-";
            fNum = int.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn3.Text;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnDot.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btn0.Text;
        }



        private void btnDiv_Click(object sender, EventArgs e)
        {
            operation = "/";
            fNum = int.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            operation = "*";
            fNum = int.Parse(txtDisplay.Text);
            txtDisplay.Clear();
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            secNum = int.Parse(txtDisplay.Text);

            if (operation == "+")
                result = fNum + secNum;

            if (operation == "-")
                result = fNum - secNum;

            if (operation == "*")
                result = fNum * secNum;

            if (operation == "/")
                result = fNum / secNum;

            txtDisplay.Text = result + "";
        }
        private void btnDEL_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            fNum = 0;
            secNum = 0;
        }

        private void btnbackspace_Click(object sender, EventArgs e)
        {
            int length = txtDisplay.Text.Length - 1;
            string text = txtDisplay.Text;
            txtDisplay.Clear();
            for (int i = 0; i < length; i++)
            {
                txtDisplay.Text = txtDisplay.Text + text[i];
            }
        }
    }
}