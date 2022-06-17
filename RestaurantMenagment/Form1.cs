using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantMenagment
{
    public partial class Form1 : Form
    {
       
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var constr = System.Configuration.ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            var con = new SqlConnection(constr);
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from Users where Password= '" + txtPass.Text + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
                f2 = null;
                this.Show();
            }
            if(txtPass.Text == "Admin123")
            {
                this.Hide();
                Admin admin = new Admin();
                admin.ShowDialog();
                admin = null;
                this.Show();
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
