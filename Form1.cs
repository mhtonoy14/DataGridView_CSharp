using System.Data.SqlClient;
using System.Data;
namespace Test4
{
    public partial class Form1 : Form
    {
        private string connection_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tonoy\source\repos\Test4\Test4\Project_DB\TestDB.mdf;Integrated Security=True;Connect Timeout=30";
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = emailtb.Text.ToString();
            string password = passwordtb.Text.ToString();
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                DialogResult dialogResult = MessageBox.Show("No empty fields allowed", "You cannot continue", MessageBoxButtons.OK);
            }
            else
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = connection_string;
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from users where u_email = '" + email + "' and u_password = '" + password + "'";
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    FormHome formhome = new FormHome();
                    formhome.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid email or password!");
                }
                conn.Close();
            }
        }
    }
}
