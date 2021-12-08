using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Employee_Management_System
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if(tb_Username.Text == "A" && tb_Password.Text == "A")
            {
                MessageBox.Show("Login Sucssesfull","Sucsses",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Hide();
                frm_Add_New_Employee anp = new frm_Add_New_Employee();
                anp.Show();
            }
            else
            {
                MessageBox.Show("Login Failed","Failuer",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
