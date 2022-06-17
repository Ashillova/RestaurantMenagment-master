using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantMenagment.Menu
{
    public partial class Amount : Form
    {
        SqlConnection con;
        public Amount()
        {
            InitializeComponent();
            string ConString = "Data Source=DESKTOP-P9JRO53;Initial Catalog=restaurant;Integrated Security=True";
            con = new SqlConnection(ConString);
            con.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bttAdd_Click(object sender, EventArgs e)
        {
            string sql = "insert into  MENU_BILL (Order_Id,Name ,Quantity,Price ) values(@Order_Id,@Name, @Quantity,@Price)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Quantity", textBox1.Text);
            cmd.Parameters.AddWithValue("@Order_Id", textBox3.Text);
            cmd.Parameters.AddWithValue("@Price", textBox2.Text);
            cmd.Parameters.AddWithValue("@Name", textBox4.Text);
            int a = cmd.ExecuteNonQuery();
            string sql1 = "insert into  Tables (Oreder_Id,Name ,Quantity,Price ) values(@Oreder_Id,@Name, @Quantity,@Price)";
            SqlCommand cmd1 = new SqlCommand(sql1, con);
            cmd1.Parameters.AddWithValue("@Quantity", textBox1.Text);
            cmd1.Parameters.AddWithValue("@Oreder_Id", textBox3.Text);
            cmd1.Parameters.AddWithValue("@Price", textBox2.Text);
            cmd1.Parameters.AddWithValue("@Name", textBox4.Text);

            int b = cmd1.ExecuteNonQuery();
            MessageBox.Show(b.ToString());
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}