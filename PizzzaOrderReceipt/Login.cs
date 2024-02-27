using PizzaOrderReceipt;

namespace PizzzaOrderReceipt
{
    public partial class Login1 : Form
    {
        public Login1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            LoginBtn.BackColor = Color.Green;


            if (UNameTb.Text == "" || PwdTb.Text == "")
            {
                MessageBox.Show("Please Enter Correct Username & Password!");
            }else if((UNameTb.Text == "User") && PwdTb.Text == "Pass")
            {
                Billing obj = new Billing();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username Or Password!");
            }


            System.Windows.Forms.Timer revertColorTimer = new System.Windows.Forms.Timer();
            revertColorTimer.Interval = 500; // 500 milliseconds (adjust as needed)
            revertColorTimer.Tick += (s, args) =>
            {
                LoginBtn.BackColor = Color.OrangeRed; // Revert to the default color
                revertColorTimer.Stop();
            };

            revertColorTimer.Start();
        }

        private void Login1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PwdTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}