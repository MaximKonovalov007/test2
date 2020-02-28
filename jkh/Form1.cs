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

    public partial class Form1 : Form
    {
        public static DataGridViewRow current_row; 

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source = 303-19\\MSSQLSERVER2; Initial Catalog = jk; Integrated Security = true";
            using (SqlConnection connection = new SqlConnection(@connectionString)) {
                connection.Open();
                SqlCommand com = new SqlCommand("SELECT TOP (1000) [jk_id], [name_lc], [build_status_lc], [house_count], [city] FROM[jk].[dbo].[live_complex]", connection);
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4]);
                }
                reader.Close();
            }
            using (SqlConnection connection = new SqlConnection(@connectionString))
            {
                connection.Open();
                SqlCommand com = new SqlCommand("SELECT TOP (1000) [city] FROM[jk].[dbo].[live_complex]", connection);
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    if (!city_box.Items.Contains(reader[0]))
                    {
                        city_box.Items.Add(reader[0]);
                    }
                }
                reader.Close();
            }
        }

        private void filter_Click(object sender, EventArgs e)
        {

            String city = city_box.SelectedItem.ToString();
            dataGridView1.Rows.Clear();
            string connectionString = "Data Source = 303-19\\MSSQLSERVER2; Initial Catalog = jk; Integrated Security = true";
            using (SqlConnection connection = new SqlConnection(@connectionString))
            {
                connection.Open();
                SqlCommand com = new SqlCommand($"SELECT TOP (1000) [jk_id], [name_lc], [build_status_lc], [house_count], [city] FROM[jk].[dbo].[live_complex] WHERE [city] = '{city}'", connection);
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4]);
                }
                reader.Close();
            }
        }

        private void tolc_Click(object sender, EventArgs e)
        {
            current_row = this.dataGridView1.CurrentRow;
            LC_initerface i = new LC_initerface();
            i.Show();
        }
    }
}
