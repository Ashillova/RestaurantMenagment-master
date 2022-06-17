using Microsoft.Data.SqlClient;
using RestaurantMenagment.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RestaurantMenagment
{
    public partial class Form4 : Form
    {
        SqlConnection con;
        public Form4()
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
            string sql = "SELECT * FROM MENU_BILL";
            
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            con.Open();
            dataadapter.Fill(ds, "MENU_BILL");
            con.Close();
            dataGridView2.DataSource = ds;
            dataGridView2.DataMember = "MENU_BILL";
        }
    }
}
