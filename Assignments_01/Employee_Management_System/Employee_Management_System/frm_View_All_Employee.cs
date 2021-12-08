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
    public partial class frm_View_All_Employee : Form
    {
        public frm_View_All_Employee()
        {
            InitializeComponent();
        }

        private void frm_View_All_Employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employee_Management_System_03_DBDataSet2.Tbl_Employee_Info' table. You can move, or remove it, as needed.
            this.tbl_Employee_InfoTableAdapter2.Fill(this.employee_Management_System_03_DBDataSet2.Tbl_Employee_Info);
            // TODO: This line of code loads data into the 'employee_Management_System_03_DBDataSet1.Tbl_Employee_Info' table. You can move, or remove it, as needed.
            this.tbl_Employee_InfoTableAdapter1.Fill(this.employee_Management_System_03_DBDataSet1.Tbl_Employee_Info);
           

        }

        private void btn_Add_New_Employee_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Add_New_Employee ane = new frm_Add_New_Employee();
            ane.Show();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Login Lg = new frm_Login();
            Lg.Show();
        }
    }
}
