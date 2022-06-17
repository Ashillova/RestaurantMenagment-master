using Microsoft.Data.SqlClient;
using RestaurantMenagment.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RestaurantMenagment
{
    public partial class Form3 : Form
    {
        SqlConnection con;
        private object btnTabel1;

        public Form3()
        {
            InitializeComponent();
            string ConString = "Data Source=DESKTOP-P9JRO53;Initial Catalog=restaurant;Integrated Security=True";
            con = new SqlConnection(ConString);
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Amount amount = new Amount() { TopLevel = false, TopMost = true };
            amount.FormBorderStyle = FormBorderStyle.None;
            pMenu.Controls.Add(amount);
            amount.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Amount amount = new Amount() { TopLevel = false, TopMost = true };
            amount.FormBorderStyle = FormBorderStyle.None;
            pMenu.Controls.Add(amount);
            amount.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Amount amount = new Amount() { TopLevel = false, TopMost = true };
            amount.FormBorderStyle = FormBorderStyle.None;
            pMenu.Controls.Add(amount);
            amount.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            Amount amount = new Amount() { TopLevel = false, TopMost = true };
            amount.FormBorderStyle = FormBorderStyle.None;
            pMenu.Controls.Add(amount);
            amount.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            Amount amount = new Amount() { TopLevel = false, TopMost = true };
            amount.FormBorderStyle = FormBorderStyle.None;
            pMenu.Controls.Add(amount);
            amount.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Amount amount = new Amount() { TopLevel = false, TopMost = true };
            amount.FormBorderStyle = FormBorderStyle.None;
            pMenu.Controls.Add(amount);
            amount.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Amount amount = new Amount() { TopLevel = false, TopMost = true };
            amount.FormBorderStyle = FormBorderStyle.None;
            pMenu.Controls.Add(amount);
            amount.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            Amount amount = new Amount() { TopLevel = false, TopMost = true };
            amount.FormBorderStyle = FormBorderStyle.None;
            pMenu.Controls.Add(amount);
            amount.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            Amount amount = new Amount() { TopLevel = false, TopMost = true };
            amount.FormBorderStyle = FormBorderStyle.None;
            pMenu.Controls.Add(amount);
            amount.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {

            Amount amount = new Amount() { TopLevel = false, TopMost = true };
            amount.FormBorderStyle = FormBorderStyle.None;
            pMenu.Controls.Add(amount);
            amount.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void btnBILL_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Tables";
            DataTable dt = new DataTable();
            
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            con.Open();
            dataadapter.Fill(ds, "Tables");
            con.Close();
            dataGridView2.DataSource = ds;
            dataGridView2.DataMember = "Tables";

            

            
            dataadapter.Fill(ds);
            DataRow row = ds.Tables["Tables"].NewRow();
            ds.Tables["Tables"].Rows.Add(row);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView2.SelectedRows[0].Index;
                string sqlquery;
                string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                int rowID = int.Parse(dataGridView2[0, selectedIndex].Value.ToString());
                sqlquery = "DELETE FROM Tables WHERE Oreder_Id = Oreder_Id";

                try
                {
                    SqlCommand command = new SqlCommand(sqlquery, con);
                    command.ExecuteNonQuery();
                    string CmdString = "SELECT * FROM Tables";
                    SqlDataAdapter sda = new SqlDataAdapter(CmdString, con);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    dataGridView2.DataSource = ds.Tables[0].DefaultView;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
                this.Close();
            }
        }

       

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnTotal_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                sum = sum + int.Parse(dataGridView2.Rows[i].Cells[3].Value.ToString());
            }
            label1.Text = sum.ToString();
        }
    }
}
