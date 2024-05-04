using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.IO;

namespace Test4
{
    public partial class FormHome : Form
    {
        private string connection_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Tonoy\source\repos\Test4\Test4\Project_DB\TestDB.mdf;Integrated Security=True;Connect Timeout=30";
        public FormHome()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connection_string;
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from users";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = table;
            conn.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string uid = uidtb.Text.ToString();
            string name = nametb.Text.ToString();
            string email = emailtb.Text.ToString();
            string phone = phonetb.Text.ToString();
            string address = addresstb.Text.ToString();
            string password = passwordtb.Text.ToString();

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connection_string;
            conn.Open();

            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = conn;
            cmd1.CommandText = "delete from users where user_id = " + uid;
            cmd1.ExecuteNonQuery();
            MessageBox.Show("Row Updated");

            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uid = uidtb.Text.ToString();
            string name = nametb.Text.ToString();
            string email = emailtb.Text.ToString();
            string phone = phonetb.Text.ToString();
            string address = addresstb.Text.ToString();
            string password = passwordtb.Text.ToString();

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connection_string;
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from users where u_email = '" + email + "'";
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                MessageBox.Show("The email already exist.\nEnter a different valid email");
            }
            else
            {
                reader.Close();
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = conn;
                cmd1.CommandText = "insert into users (u_name, u_phone, u_email, u_address, u_password) values (@name, @phone, @email, @address, @password)";
                cmd1.Parameters.AddWithValue("@name", name);
                cmd1.Parameters.AddWithValue("@phone", phone);
                cmd1.Parameters.AddWithValue("@email", email);
                cmd1.Parameters.AddWithValue("@address", address);
                cmd1.Parameters.AddWithValue("@password", password);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Data Inserted");
            }


            conn.Close();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            uidtb.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            nametb.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            phonetb.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            emailtb.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            addresstb.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            passwordtb.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string uid = uidtb.Text.ToString();
            string name = nametb.Text.ToString();
            string email = emailtb.Text.ToString();
            string phone = phonetb.Text.ToString();
            string address = addresstb.Text.ToString();
            string password = passwordtb.Text.ToString();

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connection_string;
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from users where u_email = '" + email + "' and user_id <> " + uid + ";";
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                MessageBox.Show("The email already exist.\nEnter a different valid email");
            }
            else
            {
                reader.Close();
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = conn;
                cmd1.CommandText = "update users set u_name = @name, u_phone = @phone, u_email = @email, u_address = @address, u_password = @password where user_id = " + uid;
                cmd1.Parameters.AddWithValue("@name", name);
                cmd1.Parameters.AddWithValue("@phone", phone);
                cmd1.Parameters.AddWithValue("@email", email);
                cmd1.Parameters.AddWithValue("@address", address);
                cmd1.Parameters.AddWithValue("@password", password);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Row Updated");
            }


            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
