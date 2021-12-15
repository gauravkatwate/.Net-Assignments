using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Student_Management_System_03
{
    public partial class frm_View_All_Student : Form
    {
        public frm_View_All_Student()
        {
            InitializeComponent();
        }

        private void btn_Add_New_Student_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Add_New_Student ans = new frm_Add_New_Student();
            ans.Show();
        }

        private void frm_View_All_Student_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student_Management_System_03_DBDataSet.Student_Info' table. You can move, or remove it, as needed.
            this.student_InfoTableAdapter.Fill(this.student_Management_System_03_DBDataSet.Student_Info);

        }
    }
}
