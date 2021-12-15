using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Management_System_03
{
    public partial class frm_Login : Form
    {
        GlobleDB conn = new GlobleDB();

        public frm_Login()
        {
            InitializeComponent();
        }

        private void tb_Username_TextChanged(object sender, EventArgs e)
        {
            tb_Password.Enabled = true;
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Login.Enabled = true;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if(tb_Username.Text != "" && tb_Password.Text != "")
            {
                conn.con_open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from Tbl_Login where Username = '"+tb_Username.Text+"' and Password = '"+tb_Password.Text+"'",conn.con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if(dt.Rows.Count > 0)
                {
                    MessageBox.Show("Login Sucssesfull","Sucsses",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Hide();
                    frm_Add_New_Student ans = new frm_Add_New_Student();
                    ans.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed","Failuer",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                
            }
            else
            {
                MessageBox.Show("Please Enter Username Or Password","Failuer",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
 