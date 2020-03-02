using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace jkh
{
    public partial class house_list : Form
    {
        public house_list()
        {
            InitializeComponent();
        }

        private void house_list_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source = DESKTOP-6IK02MC\\MSSQLSERVER3; Initial Catalog = jk; Integrated Security = true";


            using (SqlConnection connection = new SqlConnection(@connectionString))
            {
                connection.Open();
                SqlCommand com = new SqlCommand("SELECT [lc_name] FROM [jk].[dbo].[houses]", connection);
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    if (!comboBox2.Items.Contains(reader[0]))
                    {
                        comboBox2.Items.Add(reader[0]);
                    }
                }
                reader.Close();
            }

            using (SqlConnection connection = new SqlConnection(@connectionString))
            {
                connection.Open();
                SqlCommand com = new SqlCommand("SELECT [house_id],[lc_name],[street],[house_number],[build_status],[count_selled_ap],[count_selling_count]FROM [jk].[dbo].[houses]", connection);
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6]);
                }
                reader.Close();
            }
        }

        private void street_filter_button_Click(object sender, EventArgs e)
        {
            String street = comboBox1.SelectedItem.ToString();
            dataGridView1.Rows.Clear();
            string connectionString = "Data Source = DESKTOP-6IK02MC\\MSSQLSERVER3; Initial Catalog = jk; Integrated Security = true";

            using (SqlConnection connection = new SqlConnection(@connectionString))
            {
                connection.Open();
                SqlCommand com = new SqlCommand($"SELECT [house_id],[lc_name],[street],[house_number],[build_status],[count_selled_ap],[count_selling_count]FROM [jk].[dbo].[houses] WHERE [street] = '{street}'", connection);
                SqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4]);
                    }
                reader.Close();
            }
        }

        private void lc_filter_button_Click(object sender, EventArgs e)
        {
            String lc = comboBox2.SelectedItem.ToString();
            dataGridView1.Rows.Clear();
            string connectionString = "Data Source = DESKTOP-6IK02MC\\MSSQLSERVER3; Initial Catalog = jk; Integrated Security = true";

            using (SqlConnection connection = new SqlConnection(@connectionString))
            {
                connection.Open();
                SqlCommand com = new SqlCommand($"SELECT [house_id],[lc_name],[street],[house_number],[build_status],[count_selled_ap],[count_selling_count]FROM [jk].[dbo].[houses] WHERE [lc_name] = '{lc}'", connection);
                SqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4]);
                    }
                reader.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source = DESKTOP-6IK02MC\\MSSQLSERVER3; Initial Catalog = jk; Integrated Security = true";
            using (SqlConnection connection = new SqlConnection(@connectionString))
            {
                connection.Open();
                for(int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    SqlCommand com = new SqlCommand($"UPDATE [dbo].[houses] SET [street] = '{dataGridView1.Rows[i].Cells[2].Value}',[house_number] = '{dataGridView1.Rows[i].Cells[3].Value}', [lc_name] = '{dataGridView1.Rows[i].Cells[1].Value}',[build_status] = '{dataGridView1.Rows[i].Cells[4].Value}',[count_selled_ap] = '{dataGridView1.Rows[i].Cells[5].Value}',[count_selling_count] = '{dataGridView1.Rows[i].Cells[6].Value}' WHERE [house_id] = '{dataGridView1.Rows[i].Cells[0].Value}'", connection);
                    SqlDataReader reader = com.ExecuteReader();
                    reader.Read();
                    reader.Close();
                }

            }
        }

        private void add_house_button_Click(object sender, EventArgs e)
        {
            add_house_form ahf = new add_house_form();
            ahf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source = DESKTOP-6IK02MC\\MSSQLSERVER3; Initial Catalog = jk; Integrated Security = true";
            using (SqlConnection connection = new SqlConnection(@connectionString))
            {
                connection.Open();
                    SqlCommand com = new SqlCommand($"DELETE FROM [dbo].[houses] WHERE[house_id] = '{dataGridView1.CurrentRow.Cells[0].Value}'", connection);
                    SqlDataReader reader = com.ExecuteReader();
                    reader.Read();
                    reader.Close();

            }
        }
        public void Update()
        {
            string connectionString = "Data Source = DESKTOP-6IK02MC\\MSSQLSERVER3; Initial Catalog = jk; Integrated Security = true";

            using (SqlConnection connection = new SqlConnection(@connectionString))
            {
                connection.Open();
                SqlCommand com = new SqlCommand("SELECT [street] FROM [jk].[dbo].[houses]", connection);
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    if (!comboBox1.Items.Contains(reader[0]))
                    {
                        comboBox1.Items.Add(reader[0]);
                    }
                }
                reader.Close();
            }
        }
    }
}
