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
    public partial class frm_Search_Student : Form
    {
        GlobleDB conn = new GlobleDB();
        public frm_Search_Student()
        {
            InitializeComponent();
        }

        private void btn_View_All_Student_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_View_All_Student vas = new frm_View_All_Student();
            vas.Show();
        }

        private void btn_Add_New_Student_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Add_New_Student ans = new frm_Add_New_Student();
            ans.Show();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (tb_StudentID.Text != "")
            {
                conn.con_open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn.con;
                cmd.CommandText = "Select * From Student_Info where StudentId = '" + tb_StudentID.Text + "'";

                var obj = cmd.ExecuteReader();

                if(obj.Read())
                {
                    tb_Name.Text = obj["Name"].ToString();
                    dtp_DOB.Text = obj["DOB"].ToString();
                    tb_Gender.Text = obj["Gender"].ToString();
                    tb_StudentID.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Plese Enter Valid Id","Failuer",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                conn.con_close();
            }
            
        }

        private void frm_Search_Student_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            tb_StudentID.Enabled = true;
            tb_StudentID.Focus();
            tb_StudentID.Clear();
            tb_Name.Clear();
            tb_Gender.Clear();
            dtp_DOB.ResetText();
            
        }

        private void tb_StudentID_TextChanged(object sender, EventArgs e)
        {
            btn_Search.Enabled = true;
        }
    }
}
