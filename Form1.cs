namespace Calculator_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string caltotal;
        int n1;
        int n2;
        string option;
        int result;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //txtTotal.Text = txtTotal.Text + btn1.Text; (Both are Correct)

            txtTotal.Text = txtTotal.Text + "1";


        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "2";

            //txtTotal.Text = txtTotal.Text + btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "3";

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "4";

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "5";

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "7";

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "8";

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "9";

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "0";

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            option = "-";
            n1 = int.Parse(txtTotal.Text);

            txtTotal.Clear();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            option = "+";
            n1 = int.Parse(txtTotal.Text);

            txtTotal.Clear();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            option = "*";
            n1 = int.Parse(txtTotal.Text);

            txtTotal.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            option = "/";
            n1 = int.Parse(txtTotal.Text);

            txtTotal.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            option = "Clear";
            txtTotal.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            n2=int.Parse(txtTotal.Text);  

            if(option == "-" )
            {
                result =n1 - n2;
            }
            if(option == "+" ) 
            {
                result = n1 + n2;
            }
            if(option == "*")
            {
                result = n1 * n2;
            }
            if(option == "/" )
            {
                result = n1 / n2;
            }

            txtTotal.Text = result + "";

        }
    }
}