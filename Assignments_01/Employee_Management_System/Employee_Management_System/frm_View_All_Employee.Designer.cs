namespace Employee_Management_System
{
    partial class frm_View_All_Employee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_Employee_Detailes = new System.Windows.Forms.Label();
            this.btn_Add_New_Employee = new System.Windows.Forms.Button();
            this.employee_Management_System_03_DBDataSet = new Employee_Management_System.Employee_Management_System_03_DBDataSet();
            this.tblEmployeeInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_Employee_InfoTableAdapter = new Employee_Management_System.Employee_Management_System_03_DBDataSetTableAdapters.Tbl_Employee_InfoTableAdapter();
            this.employee_Management_System_03_DBDataSet1 = new Employee_Management_System.Employee_Management_System_03_DBDataSet1();
            this.tblEmployeeInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_Employee_InfoTableAdapter1 = new Employee_Management_System.Employee_Management_System_03_DBDataSet1TableAdapters.Tbl_Employee_InfoTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employee_Management_System_03_DBDataSet2 = new Employee_Management_System.Employee_Management_System_03_DBDataSet2();
            this.tblEmployeeInfoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_Employee_InfoTableAdapter2 = new Employee_Management_System.Employee_Management_System_03_DBDataSet2TableAdapters.Tbl_Employee_InfoTableAdapter();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sallaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Logout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Management_System_03_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeeInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Management_System_03_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeeInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Management_System_03_DBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeeInfoBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Employee_Detailes
            // 
            this.lbl_Employee_Detailes.AutoSize = true;
            this.lbl_Employee_Detailes.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_Detailes.Location = new System.Drawing.Point(206, 33);
            this.lbl_Employee_Detailes.Name = "lbl_Employee_Detailes";
            this.lbl_Employee_Detailes.Size = new System.Drawing.Size(567, 70);
            this.lbl_Employee_Detailes.TabIndex = 6;
            this.lbl_Employee_Detailes.Text = "Employee Detailes";
            // 
            // btn_Add_New_Employee
            // 
            this.btn_Add_New_Employee.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Employee.Location = new System.Drawing.Point(338, 511);
            this.btn_Add_New_Employee.Name = "btn_Add_New_Employee";
            this.btn_Add_New_Employee.Size = new System.Drawing.Size(348, 53);
            this.btn_Add_New_Employee.TabIndex = 12;
            this.btn_Add_New_Employee.Text = "Add New Employee";
            this.btn_Add_New_Employee.UseVisualStyleBackColor = true;
            this.btn_Add_New_Employee.Click += new System.EventHandler(this.btn_Add_New_Employee_Click);
            // 
            // employee_Management_System_03_DBDataSet
            // 
            this.employee_Management_System_03_DBDataSet.DataSetName = "Employee_Management_System_03_DBDataSet";
            this.employee_Management_System_03_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblEmployeeInfoBindingSource
            // 
            this.tblEmployeeInfoBindingSource.DataMember = "Tbl_Employee_Info";
            this.tblEmployeeInfoBindingSource.DataSource = this.employee_Management_System_03_DBDataSet;
            // 
            // tbl_Employee_InfoTableAdapter
            // 
            this.tbl_Employee_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // employee_Management_System_03_DBDataSet1
            // 
            this.employee_Management_System_03_DBDataSet1.DataSetName = "Employee_Management_System_03_DBDataSet1";
            this.employee_Management_System_03_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblEmployeeInfoBindingSource1
            // 
            this.tblEmployeeInfoBindingSource1.DataMember = "Tbl_Employee_Info";
            this.tblEmployeeInfoBindingSource1.DataSource = this.employee_Management_System_03_DBDataSet1;
            // 
            // tbl_Employee_InfoTableAdapter1
            // 
            this.tbl_Employee_InfoTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.sallaryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblEmployeeInfoBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1006, 329);
            this.dataGridView1.TabIndex = 13;
            // 
            // employee_Management_System_03_DBDataSet2
            // 
            this.employee_Management_System_03_DBDataSet2.DataSetName = "Employee_Management_System_03_DBDataSet2";
            this.employee_Management_System_03_DBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblEmployeeInfoBindingSource2
            // 
            this.tblEmployeeInfoBindingSource2.DataMember = "Tbl_Employee_Info";
            this.tblEmployeeInfoBindingSource2.DataSource = this.employee_Management_System_03_DBDataSet2;
            // 
            // tbl_Employee_InfoTableAdapter2
            // 
            this.tbl_Employee_InfoTableAdapter2.ClearBeforeFill = true;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "Employee_ID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "Employee_ID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sallaryDataGridViewTextBoxColumn
            // 
            this.sallaryDataGridViewTextBoxColumn.DataPropertyName = "Sallary";
            this.sallaryDataGridViewTextBoxColumn.HeaderText = "Sallary";
            this.sallaryDataGridViewTextBoxColumn.Name = "sallaryDataGridViewTextBoxColumn";
            this.sallaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btn_Logout
            // 
            this.btn_Logout.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.Location = new System.Drawing.Point(882, 4);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(145, 53);
            this.btn_Logout.TabIndex = 14;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // frm_View_All_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 598);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Add_New_Employee);
            this.Controls.Add(this.lbl_Employee_Detailes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_View_All_Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_View_All_Employee";
            this.Load += new System.EventHandler(this.frm_View_All_Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employee_Management_System_03_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeeInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Management_System_03_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeeInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Management_System_03_DBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeeInfoBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Employee_Detailes;
        private System.Windows.Forms.Button btn_Add_New_Employee;
        private Employee_Management_System_03_DBDataSet employee_Management_System_03_DBDataSet;
        private System.Windows.Forms.BindingSource tblEmployeeInfoBindingSource;
        private Employee_Management_System_03_DBDataSetTableAdapters.Tbl_Employee_InfoTableAdapter tbl_Employee_InfoTableAdapter;
        private Employee_Management_System_03_DBDataSet1 employee_Management_System_03_DBDataSet1;
        private System.Windows.Forms.BindingSource tblEmployeeInfoBindingSource1;
        private Employee_Management_System_03_DBDataSet1TableAdapters.Tbl_Employee_InfoTableAdapter tbl_Employee_InfoTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Employee_Management_System_03_DBDataSet2 employee_Management_System_03_DBDataSet2;
        private System.Windows.Forms.BindingSource tblEmployeeInfoBindingSource2;
        private Employee_Management_System_03_DBDataSet2TableAdapters.Tbl_Employee_InfoTableAdapter tbl_Employee_InfoTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sallaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_Logout;
    }
}