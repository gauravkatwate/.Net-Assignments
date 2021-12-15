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
    public partial class frm_Add_New_Student : Form
    {
        string Gender;


        GlobleDB conn = new GlobleDB();

        public frm_Add_New_Student()
        {
            fillcombobox();
            InitializeComponent();
        }

        private void btn_Search_Student_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Search_Student ss = new frm_Search_Student();
            ss.Show();
        }

        private void frm_Add_New_Student_Load(object sender, EventArgs e)
        {
          //  tb_StudentID.Text = Convert.ToString(AutoIncrement());
            //tb_StudentID.Enabled = false;
        }

         int AutoIncrement()
        {
            int cnt = 0;

            conn.con_open();

            SqlCommand cmd = new SqlCommand("Select Count(StudentID) From Student_Info",conn.con);

            cnt = Convert.ToInt32(cmd.ExecuteScalar());

            cnt = 101 + cnt;

            conn.con_close();

            return cnt;
            
        }

        private void btn_View_All_Student_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_View_All_Student vas = new frm_View_All_Student();
            vas.Show();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            conn.con_open();
            if( tb_Name.Text != "" && dtp_DOB.Text != "" && Gender != "")
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn.con;

                cmd.CommandText = "insert into Student_Info(StudentID,Name,DOB,Gender)values(@SID,@Name,@DOB,@Gender)";

              //  cmd.Parameters.Add("SID",SqlDbType.Int).Value = tb_StudentID.Text;
                cmd.Parameters.Add("Name",SqlDbType.VarChar).Value = tb_Name.Text;
                cmd.Parameters.Add("DOB",SqlDbType.Date).Value = dtp_DOB.Text;
                cmd.Parameters.Add("Gender",SqlDbType.Char).Value = Gender;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Information Saved Sucssesfully","Sucsses",MessageBoxButtons.OK,MessageBoxIcon.Information);

                tb_Name.Clear();
         //       tb_StudentID.Text = Convert.ToString(AutoIncrement());
            }
            else
            {
                MessageBox.Show("Plese Enter All Information","Failuer",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            conn.con_close();
        }

        private void rb_Male_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void rb_Female_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            tb_Name.Clear();
        }

         void fillcombobox()
        {
            SqlCommand cmd = new SqlCommand("Select * from Student_Info",conn.con);
            SqlDataReader dr;

            try
            {
                conn.con_open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string sname = dr.GetString(1);
                    comboBox1.Items.Add(sname);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
    }

    }
}
