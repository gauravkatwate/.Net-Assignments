using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Employee_Management_System
{
    public partial class frm_Add_New_Employee : Form
    {
        string Gender;
        public frm_Add_New_Employee()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-D2SMNN1L\SQLEXPRESS;Initial Catalog=Employee_Management_System_03_DB;Integrated Security=True");

        void con_open()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        void con_close()
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        private void btn_View_All_Employee_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_View_All_Employee vae = new frm_View_All_Employee();
            vae.Show();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            con_open();
            if(tb_EmployeeID.Text != "" && tb_Employee_Name.Text != "" && tb_Sallary.Text != "" && Gender != "")
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                
                cmd.CommandText = "Insert Into Tbl_Employee_Info(Employee_ID,Name,Gender,Sallary)values(@EID,@EName,@Gender,@Sal)";

                cmd.Parameters.Add("EID",SqlDbType.Int).Value = tb_EmployeeID.Text;
                cmd.Parameters.Add("EName",SqlDbType.VarChar).Value = tb_Employee_Name.Text;
                cmd.Parameters.Add("Gender",SqlDbType.NChar).Value = Gender;
                cmd.Parameters.Add("Sal",SqlDbType.Money).Value = tb_Sallary.Text;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Information Saved Sucssesfully","Sucsses",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Fill All Information","Fill All",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            con_close();

        }

        private void rb_Male_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void rb_Female_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Login Lg = new frm_Login();
            Lg.Show();
        }
    }
}
