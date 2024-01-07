namespace employeesManagement
{
    partial class EmpDashBoard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Insertbutton = new System.Windows.Forms.Button();
            this.Updatebutton = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameLeb = new System.Windows.Forms.Label();
            this.genderLeb = new System.Windows.Forms.Label();
            this.titleLeb = new System.Windows.Forms.Label();
            this.startdateLeb = new System.Windows.Forms.Label();
            this.salaryLeb = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboDepartments = new System.Windows.Forms.ComboBox();
            this.DepartmentLeb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 298);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(767, 178);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // Insertbutton
            // 
            this.Insertbutton.BackColor = System.Drawing.Color.RoyalBlue;
            this.Insertbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Insertbutton.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insertbutton.ForeColor = System.Drawing.Color.White;
            this.Insertbutton.Location = new System.Drawing.Point(236, 267);
            this.Insertbutton.Name = "Insertbutton";
            this.Insertbutton.Size = new System.Drawing.Size(115, 25);
            this.Insertbutton.TabIndex = 1;
            this.Insertbutton.Text = "Insert";
            this.Insertbutton.UseVisualStyleBackColor = false;
            this.Insertbutton.Click += new System.EventHandler(this.Insertbutton_Click);
            // 
            // Updatebutton
            // 
            this.Updatebutton.BackColor = System.Drawing.Color.RoyalBlue;
            this.Updatebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Updatebutton.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebutton.ForeColor = System.Drawing.Color.White;
            this.Updatebutton.Location = new System.Drawing.Point(357, 267);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(115, 25);
            this.Updatebutton.TabIndex = 2;
            this.Updatebutton.Text = "Update";
            this.Updatebutton.UseVisualStyleBackColor = false;
            this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // Exitbutton
            // 
            this.Exitbutton.BackColor = System.Drawing.Color.RoyalBlue;
            this.Exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exitbutton.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbutton.ForeColor = System.Drawing.Color.White;
            this.Exitbutton.Location = new System.Drawing.Point(631, 267);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(163, 25);
            this.Exitbutton.TabIndex = 3;
            this.Exitbutton.Text = "Back To DashBoard";
            this.Exitbutton.UseVisualStyleBackColor = false;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.BackColor = System.Drawing.Color.RoyalBlue;
            this.Deletebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deletebutton.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebutton.ForeColor = System.Drawing.Color.White;
            this.Deletebutton.Location = new System.Drawing.Point(478, 267);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(115, 25);
            this.Deletebutton.TabIndex = 4;
            this.Deletebutton.Text = "Delete";
            this.Deletebutton.UseVisualStyleBackColor = false;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.Gainsboro;
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtname.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(150, 81);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(190, 26);
            this.txtname.TabIndex = 5;
            // 
            // txttitle
            // 
            this.txttitle.BackColor = System.Drawing.Color.Gainsboro;
            this.txttitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttitle.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttitle.Location = new System.Drawing.Point(150, 175);
            this.txttitle.Multiline = true;
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(190, 26);
            this.txttitle.TabIndex = 6;
            // 
            // txtsalary
            // 
            this.txtsalary.BackColor = System.Drawing.Color.Gainsboro;
            this.txtsalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsalary.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalary.Location = new System.Drawing.Point(150, 235);
            this.txtsalary.Multiline = true;
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(190, 26);
            this.txtsalary.TabIndex = 7;
            // 
            // txtsearch
            // 
            this.txtsearch.BackColor = System.Drawing.Color.Gainsboro;
            this.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsearch.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtsearch.Location = new System.Drawing.Point(27, 267);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(203, 25);
            this.txtsearch.TabIndex = 8;
            this.txtsearch.Text = "Search";
            this.txtsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            this.txtsearch.Enter += new System.EventHandler(this.txtsearch_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "Employees DashBoard";
            // 
            // nameLeb
            // 
            this.nameLeb.AutoSize = true;
            this.nameLeb.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLeb.Location = new System.Drawing.Point(42, 86);
            this.nameLeb.Name = "nameLeb";
            this.nameLeb.Size = new System.Drawing.Size(56, 21);
            this.nameLeb.TabIndex = 10;
            this.nameLeb.Text = "Name";
            // 
            // genderLeb
            // 
            this.genderLeb.AutoSize = true;
            this.genderLeb.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLeb.Location = new System.Drawing.Point(42, 111);
            this.genderLeb.Name = "genderLeb";
            this.genderLeb.Size = new System.Drawing.Size(65, 21);
            this.genderLeb.TabIndex = 11;
            this.genderLeb.Text = "Gender";
            // 
            // titleLeb
            // 
            this.titleLeb.AutoSize = true;
            this.titleLeb.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLeb.Location = new System.Drawing.Point(42, 180);
            this.titleLeb.Name = "titleLeb";
            this.titleLeb.Size = new System.Drawing.Size(44, 21);
            this.titleLeb.TabIndex = 12;
            this.titleLeb.Text = "Title";
            // 
            // startdateLeb
            // 
            this.startdateLeb.AutoSize = true;
            this.startdateLeb.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startdateLeb.Location = new System.Drawing.Point(42, 207);
            this.startdateLeb.Name = "startdateLeb";
            this.startdateLeb.Size = new System.Drawing.Size(85, 21);
            this.startdateLeb.TabIndex = 13;
            this.startdateLeb.Text = "Start Date";
            // 
            // salaryLeb
            // 
            this.salaryLeb.AutoSize = true;
            this.salaryLeb.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryLeb.Location = new System.Drawing.Point(42, 240);
            this.salaryLeb.Name = "salaryLeb";
            this.salaryLeb.Size = new System.Drawing.Size(58, 21);
            this.salaryLeb.TabIndex = 14;
            this.salaryLeb.Text = "Salary";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(169, 108);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 24);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(256, 108);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(77, 24);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Female";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.RoyalBlue;
            this.dateTimePicker1.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(150, 207);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(190, 22);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(452, 34);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Gender";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(292, 213);
            this.chart1.TabIndex = 18;
            this.chart1.Text = "chart1";
            // 
            // comboDepartments
            // 
            this.comboDepartments.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDepartments.FormattingEnabled = true;
            this.comboDepartments.Location = new System.Drawing.Point(150, 141);
            this.comboDepartments.Name = "comboDepartments";
            this.comboDepartments.Size = new System.Drawing.Size(190, 28);
            this.comboDepartments.TabIndex = 51;
            // 
            // DepartmentLeb
            // 
            this.DepartmentLeb.AutoSize = true;
            this.DepartmentLeb.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartmentLeb.ForeColor = System.Drawing.Color.RoyalBlue;
            this.DepartmentLeb.Location = new System.Drawing.Point(42, 148);
            this.DepartmentLeb.Name = "DepartmentLeb";
            this.DepartmentLeb.Size = new System.Drawing.Size(102, 21);
            this.DepartmentLeb.TabIndex = 50;
            this.DepartmentLeb.Text = "Department";
            // 
            // EmpDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(843, 500);
            this.Controls.Add(this.comboDepartments);
            this.Controls.Add(this.DepartmentLeb);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.salaryLeb);
            this.Controls.Add(this.startdateLeb);
            this.Controls.Add(this.titleLeb);
            this.Controls.Add(this.genderLeb);
            this.Controls.Add(this.nameLeb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.txtsalary);
            this.Controls.Add(this.txttitle);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.Updatebutton);
            this.Controls.Add(this.Insertbutton);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.RoyalBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "EmpDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dashBoard";
            this.Load += new System.EventHandler(this.dashBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Insertbutton;
        private System.Windows.Forms.Button Updatebutton;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.TextBox txtsalary;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameLeb;
        private System.Windows.Forms.Label genderLeb;
        private System.Windows.Forms.Label titleLeb;
        private System.Windows.Forms.Label startdateLeb;
        private System.Windows.Forms.Label salaryLeb;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox comboDepartments;
        private System.Windows.Forms.Label DepartmentLeb;
    }
}