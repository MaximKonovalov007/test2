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
    public partial class add_house_form : Form
    {
        public add_house_form()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source = DESKTOP-6IK02MC\\MSSQLSERVER3; Initial Catalog = jk; Integrated Security = true";
            using (SqlConnection connection = new SqlConnection(@connectionString))
            {
                    connection.Open();
                    SqlCommand com = new SqlCommand($"INSERT INTO [dbo].[houses]([street],[house_number],[house_building_cost],[added_cost_ap],[lc_id],[lc_name],[build_status],[count_selled_ap],[count_selling_count])VALUES('{street_field.Text}', '{number_house_field.Text}', '{home_building_cost_field.Text}', '{added_cost_field.Text}', '{lc_id_filed.Text}', '{lc_name_field.Text}', '{building_status_field.Text}', '{count_selled_field.Text}', '{count_selling_field.Text}')", connection);
                    SqlDataReader reader = com.ExecuteReader();
                    reader.Read();
                    reader.Close();
            }
        }

        private void add_house_form_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source = DESKTOP-6IK02MC\\MSSQLSERVER3; Initial Catalog = jk; Integrated Security = true";
            using (SqlConnection connection = new SqlConnection(@connectionString))
            {
                connection.Open();
                SqlCommand com = new SqlCommand("SELECT [jk_id] FROM [jk].[dbo].[live_complex]", connection);
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    if (!lc_id_filed.Items.Contains(reader[0]))
                    {
                        lc_id_filed.Items.Add(reader[0]);
                    }
                }
                reader.Close();
            }
        }

        private void lc_id_filed_SelectedIndexChanged(object sender, EventArgs e)
        {
            String lc = lc_id_filed.SelectedItem.ToString();
            string connectionString = "Data Source = DESKTOP-6IK02MC\\MSSQLSERVER3; Initial Catalog = jk; Integrated Security = true";
            using (SqlConnection connection = new SqlConnection(@connectionString))
            {
                connection.Open();
             
                SqlCommand com = new SqlCommand($"SELECT [name_lc] FROM [jk].[dbo].[live_complex] WHERE [jk_id] = '{lc}'", connection);
                SqlDataReader reader = com.ExecuteReader();
                reader.Read();
                lc_name_field.Text = reader[0].ToString();
                reader.Close();
            }
        }
    }
}
