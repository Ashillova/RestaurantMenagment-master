using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantMenagment
{
    public partial class Admin : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        public Admin()
        {
            InitializeComponent();
            string ConString = "Data Source=DESKTOP-P9JRO53;Initial Catalog=restaurant;Integrated Security=True";
            con = new SqlConnection(ConString);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bttClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM MENU_BILL";

            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            con.Open();
            dataadapter.Fill(ds, "MENU_BILL");
            con.Close();
            DgvDaily.DataSource = ds;
            DgvDaily.DataMember = "MENU_BILL";
        }

        private void brnDEL_Click(object sender, EventArgs e)
        {
            if (DgvDaily.SelectedRows.Count > 0)
            {
                int selectedIndex = DgvDaily.SelectedRows[0].Index;
                string sqlquery;
                string ConString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                int rowID = int.Parse(DgvDaily[0, selectedIndex].Value.ToString());
                sqlquery = "DELETE FROM MENU_BILL WHERE Order_Id =" + rowID;

                try
                {
                    SqlCommand command = new SqlCommand(sqlquery, con);
                    command.ExecuteNonQuery();
                    string CmdString = "SELECT * FROM MENU_BILL WHERE Order_Id = Order_Id";
                    SqlDataAdapter sda = new SqlDataAdapter(CmdString, con);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    DgvDaily.DataSource = ds.Tables[0].DefaultView;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btnUsers_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Users";

            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            con.Open();
            dataadapter.Fill(ds, "Users");
            con.Close();
            DgvDaily.DataSource = ds;
            DgvDaily.DataMember = "Users";
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddUsers users = new AddUsers();
            users.ShowDialog();
            users = null;
            this.Show();
        }
    }
}
