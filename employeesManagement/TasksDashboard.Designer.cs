namespace employeesManagement
{
    partial class TasksDashboard
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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.nameLeb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.Updatebutton = new System.Windows.Forms.Button();
            this.Insertbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.assignedLeb = new System.Windows.Forms.Label();
            this.txtassigned = new System.Windows.Forms.TextBox();
            this.durationLeb = new System.Windows.Forms.Label();
            this.txtduration = new System.Windows.Forms.TextBox();
            this.DepartmentLeb = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.status = new System.Windows.Forms.Label();
            this.comboDepartments = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "TaskStatus";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(303, 235);
            this.chart1.TabIndex = 18;
            this.chart1.Text = "chart1";
            // 
            // nameLeb
            // 
            this.nameLeb.AutoSize = true;
            this.nameLeb.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLeb.ForeColor = System.Drawing.Color.RoyalBlue;
            this.nameLeb.Location = new System.Drawing.Point(39, 83);
            this.nameLeb.Name = "nameLeb";
            this.nameLeb.Size = new System.Drawing.Size(92, 21);
            this.nameLeb.TabIndex = 30;
            this.nameLeb.Text = "Task Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(34, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 37);
            this.label1.TabIndex = 29;
            this.label1.Text = "Tasks DashBoard";
            // 
            // txtsearch
            // 
            this.txtsearch.BackColor = System.Drawing.Color.Gainsboro;
            this.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsearch.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtsearch.Location = new System.Drawing.Point(41, 275);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(203, 25);
            this.txtsearch.TabIndex = 28;
            this.txtsearch.Text = "Search";
            this.txtsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            this.txtsearch.Enter += new System.EventHandler(this.txtsearch_Enter);
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.Gainsboro;
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtname.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(159, 78);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(190, 26);
            this.txtname.TabIndex = 25;
            // 
            // Deletebutton
            // 
            this.Deletebutton.BackColor = System.Drawing.Color.RoyalBlue;
            this.Deletebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deletebutton.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebutton.ForeColor = System.Drawing.Color.White;
            this.Deletebutton.Location = new System.Drawing.Point(501, 275);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(115, 25);
            this.Deletebutton.TabIndex = 24;
            this.Deletebutton.Text = "Delete";
            this.Deletebutton.UseVisualStyleBackColor = false;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // Exitbutton
            // 
            this.Exitbutton.BackColor = System.Drawing.Color.RoyalBlue;
            this.Exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exitbutton.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbutton.ForeColor = System.Drawing.Color.White;
            this.Exitbutton.Location = new System.Drawing.Point(622, 275);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(166, 25);
            this.Exitbutton.TabIndex = 23;
            this.Exitbutton.Text = "Back To DashBoard";
            this.Exitbutton.UseVisualStyleBackColor = false;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // Updatebutton
            // 
            this.Updatebutton.BackColor = System.Drawing.Color.RoyalBlue;
            this.Updatebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Updatebutton.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebutton.ForeColor = System.Drawing.Color.White;
            this.Updatebutton.Location = new System.Drawing.Point(371, 275);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(115, 25);
            this.Updatebutton.TabIndex = 22;
            this.Updatebutton.Text = "Update";
            this.Updatebutton.UseVisualStyleBackColor = false;
            this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // Insertbutton
            // 
            this.Insertbutton.BackColor = System.Drawing.Color.RoyalBlue;
            this.Insertbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Insertbutton.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insertbutton.ForeColor = System.Drawing.Color.White;
            this.Insertbutton.Location = new System.Drawing.Point(250, 275);
            this.Insertbutton.Name = "Insertbutton";
            this.Insertbutton.Size = new System.Drawing.Size(115, 25);
            this.Insertbutton.TabIndex = 21;
            this.Insertbutton.Text = "Insert";
            this.Insertbutton.UseVisualStyleBackColor = false;
            this.Insertbutton.Click += new System.EventHandler(this.Insertbutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 306);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(767, 178);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // assignedLeb
            // 
            this.assignedLeb.AutoSize = true;
            this.assignedLeb.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignedLeb.ForeColor = System.Drawing.Color.RoyalBlue;
            this.assignedLeb.Location = new System.Drawing.Point(39, 120);
            this.assignedLeb.Name = "assignedLeb";
            this.assignedLeb.Size = new System.Drawing.Size(99, 21);
            this.assignedLeb.TabIndex = 41;
            this.assignedLeb.Text = "Assigned to";
            // 
            // txtassigned
            // 
            this.txtassigned.BackColor = System.Drawing.Color.Gainsboro;
            this.txtassigned.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtassigned.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtassigned.Location = new System.Drawing.Point(159, 115);
            this.txtassigned.Multiline = true;
            this.txtassigned.Name = "txtassigned";
            this.txtassigned.Size = new System.Drawing.Size(190, 26);
            this.txtassigned.TabIndex = 40;
            // 
            // durationLeb
            // 
            this.durationLeb.AutoSize = true;
            this.durationLeb.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationLeb.ForeColor = System.Drawing.Color.RoyalBlue;
            this.durationLeb.Location = new System.Drawing.Point(38, 162);
            this.durationLeb.Name = "durationLeb";
            this.durationLeb.Size = new System.Drawing.Size(114, 21);
            this.durationLeb.TabIndex = 43;
            this.durationLeb.Text = "Task Duration";
            // 
            // txtduration
            // 
            this.txtduration.BackColor = System.Drawing.Color.Gainsboro;
            this.txtduration.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtduration.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtduration.Location = new System.Drawing.Point(159, 157);
            this.txtduration.Multiline = true;
            this.txtduration.Name = "txtduration";
            this.txtduration.Size = new System.Drawing.Size(190, 26);
            this.txtduration.TabIndex = 42;
            // 
            // DepartmentLeb
            // 
            this.DepartmentLeb.AutoSize = true;
            this.DepartmentLeb.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartmentLeb.ForeColor = System.Drawing.Color.RoyalBlue;
            this.DepartmentLeb.Location = new System.Drawing.Point(39, 204);
            this.DepartmentLeb.Name = "DepartmentLeb";
            this.DepartmentLeb.Size = new System.Drawing.Size(102, 21);
            this.DepartmentLeb.TabIndex = 45;
            this.DepartmentLeb.Text = "Department";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.radioButton2.Location = new System.Drawing.Point(225, 245);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(126, 21);
            this.radioButton2.TabIndex = 47;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Not finished yet";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.radioButton1.Location = new System.Drawing.Point(160, 245);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 21);
            this.radioButton1.TabIndex = 46;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Done";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.RoyalBlue;
            this.status.Location = new System.Drawing.Point(37, 244);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(91, 21);
            this.status.TabIndex = 48;
            this.status.Text = "Task status";
            // 
            // comboDepartments
            // 
            this.comboDepartments.FormattingEnabled = true;
            this.comboDepartments.Location = new System.Drawing.Point(159, 204);
            this.comboDepartments.Name = "comboDepartments";
            this.comboDepartments.Size = new System.Drawing.Size(191, 21);
            this.comboDepartments.TabIndex = 49;
            // 
            // TasksDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(843, 500);
            this.Controls.Add(this.comboDepartments);
            this.Controls.Add(this.status);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.DepartmentLeb);
            this.Controls.Add(this.durationLeb);
            this.Controls.Add(this.txtduration);
            this.Controls.Add(this.assignedLeb);
            this.Controls.Add(this.txtassigned);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.nameLeb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.Updatebutton);
            this.Controls.Add(this.Insertbutton);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "TasksDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TasksDashboard";
            this.Load += new System.EventHandler(this.TasksDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label nameLeb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Button Updatebutton;
        private System.Windows.Forms.Button Insertbutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label assignedLeb;
        private System.Windows.Forms.TextBox txtassigned;
        private System.Windows.Forms.Label durationLeb;
        private System.Windows.Forms.TextBox txtduration;
        private System.Windows.Forms.Label DepartmentLeb;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.ComboBox comboDepartments;
    }
}