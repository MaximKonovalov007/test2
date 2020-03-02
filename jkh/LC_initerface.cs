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
    public partial class LC_initerface : Form
    {
        public LC_initerface()
        {
            InitializeComponent();
        }

        private void LC_initerface_Load(object sender, EventArgs e)
        {
            Update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cr = Form1.current_row;
            String[] possibleValues = { "build", "plan", "realize"};
            string connectionString = "Data Source = DESKTOP-6IK02MC\\MSSQLSERVER3; Initial Catalog = jk; Integrated Security = true";
            using (SqlConnection connection = new SqlConnection(@connectionString))
            {
                connection.Open();
                SqlCommand com = new SqlCommand($"SELECT * FROM[jk].[dbo].[apartaments] WHERE [lc_id] = '{cr}' AND [sell_status] = 'sold' ", connection);
                SqlDataReader reader = com.ExecuteReader();
         
                if (possibleValues.Contains<String>(dataGridView1.Rows[0].Cells[2].Value.ToString()))
                {
                    if ((reader.FieldCount == 0 && dataGridView1.Rows[0].Cells[2].Value.ToString() == "plan")||(dataGridView1.Rows[0].Cells[2].Value.ToString() != "plan"))
                    {
                        reader.Close();
                        com = new SqlCommand($"UPDATE [dbo].[live_complex] SET[name_lc] = '{dataGridView1.Rows[0].Cells[0].Value}', [city] = '{dataGridView1.Rows[0].Cells[4].Value}', [build_status_lc] = '{dataGridView1.Rows[0].Cells[2].Value}', [added_cost_lc] = '{dataGridView1.Rows[0].Cells[1].Value}', [buildidn_cost_lc] = '{dataGridView1.Rows[0].Cells[3].Value}' WHERE [jk_id] = '{cr}'", connection);
                        reader = com.ExecuteReader();
                        reader.Read();
                        reader.Close();
                        MessageBox.Show("Success");
                    }
                    else
                    {
                        MessageBox.Show("ERROR");
                    }

                }
                else
                {
                    MessageBox.Show("ERROR");
                }
                
            }
        }
        public void Update()
        {
            int cr = Form1.current_row;

            string connectionString = "Data Source = DESKTOP-6IK02MC\\MSSQLSERVER3; Initial Catalog = jk; Integrated Security = true";
            using (SqlConnection connection = new SqlConnection(@connectionString))
            {
                connection.Open();
                SqlCommand com = new SqlCommand($"SELECT [name_lc],[added_cost_lc],[build_status_lc],[buildidn_cost_lc],[city] FROM[jk].[dbo].[live_complex] WHERE[jk_id] = '{cr}'", connection);
                using (SqlDataReader reader = com.ExecuteReader())
                {

                    reader.Read();
                    lc_label.Text = reader[0].ToString();

                    dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4]);


                }
            }
        }
    }
}
