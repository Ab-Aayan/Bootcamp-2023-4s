namespace Login_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var userName = uName.Text; 
            var passWord= password.Text;
            if (userName == "" || passWord == "")
            {
                MessageBox.Show("Please Enter both username and Password");

            }
            else if (userName == "aayan" && passWord == "khhan") 
            {
                MessageBox.Show("Successfully Login");
                Form2 newForm = new Form2();
                newForm.Show();
                this.Hide(); 
            }else
            {
                MessageBox.Show("Please enter correct username or password");
            }
        }
    }
}