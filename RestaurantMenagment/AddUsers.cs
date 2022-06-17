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

namespace RestaurantMenagment
{
    public partial class AddUsers : Form
    {
        SqlConnection con;
        public AddUsers()
        {
            InitializeComponent();
            string ConString = "Data Source=DESKTOP-P9JRO53;Initial Catalog=restaurant;Integrated Security=True";
            con = new SqlConnection(ConString);
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "insert into  Users (User_Id ,Fname,Lname,Password) values(@User_Id, @Fname,@Lname,@Password)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@User_Id",textBox1.Text);
            cmd.Parameters.AddWithValue("@Fname", txtFname.Text);
            cmd.Parameters.AddWithValue("@Lname", txtLname.Text);
            cmd.Parameters.AddWithValue("@Password", txtPass.Text);


            int a = cmd.ExecuteNonQuery();
            MessageBox.Show(a.ToString());
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
