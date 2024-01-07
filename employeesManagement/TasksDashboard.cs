using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace employeesManagement
{
    public partial class TasksDashboard : Form
    {
        public TasksDashboard()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        //OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_users.accdb");

        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataTable dt = new DataTable();

        private void HandleError(Exception ex, string message)
        {
            MessageBox.Show($"{message}\nError: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void TasksDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                loadingDatagridView();

            }
            catch (Exception ex)
            {
                HandleError(ex, "Error loading data grid view");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    // Update the textboxes with the values from the selected row

                    txtname.Text = row.Cells["TaskName"].Value.ToString();
                    txtassigned.Text = row.Cells["AssignedTo"].Value.ToString();
                    txtduration.Text = row.Cells["TaskDuration"].Value.ToString();
                    comboDepartments.Text = row.Cells["DepName"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                HandleError(ex, "Error handling cell content click");
            }
        }

        private void loadingDatagridView()
        {
            try
            {
                con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
                dt = new DataTable();
                da = new OleDbDataAdapter("SELECT *FROM tbl_tasks", con);

                con.Open();
                LoadDepartmentsComboBox();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                loadingInfo();

            }
            catch (Exception ex)
            {
                HandleError(ex, "Error loading data grid view");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtassigned.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtduration.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                comboDepartments.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

                radioButton1.Checked = dataGridView1.CurrentRow.Cells[5].Value.ToString() == "Done";
                radioButton2.Checked = !radioButton1.Checked;
            }
            catch (Exception ex)
            {
                HandleError(ex, "Error handling cell enter");
            }
        }

        private void Insertbutton_Click(object sender, EventArgs e)
        {
            try
            {
                bool isEmployeeFound = false;

                // Add new Task
                if (string.IsNullOrWhiteSpace(txtname.Text) || string.IsNullOrWhiteSpace(txtassigned.Text) || string.IsNullOrWhiteSpace(txtassigned.Text) || string.IsNullOrWhiteSpace(txtduration.Text) || string.IsNullOrWhiteSpace(comboDepartments.Text))
                {
                    MessageBox.Show("Please fill in all required fields (Task Name, Assigned To, Duration, and Department) before adding a new employee.");
                    return;
                }

                con.Open();

                string query = "SELECT Name FROM tbl_employees";
                cmd = new OleDbCommand(query, con);
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        string employeeName = reader["Name"].ToString();

                        if (employeeName.Equals(txtassigned.Text, StringComparison.OrdinalIgnoreCase))
                        {
                            isEmployeeFound = true;
                            break;
                        }
                    }
                }
                cmd.ExecuteNonQuery();
                if (isEmployeeFound)
                {

                    query = "INSERT INTO tbl_tasks (TaskName, AssignedTo, taskDuration, DepName, TaskStatus) " +
                                   "VALUES (@TaskName, @Assigned, @taskDuration, @DepName, @TaskStatus)";
                    cmd = new OleDbCommand(query, con);
                    // Add parameters...
                    cmd.Parameters.AddWithValue("@TaskName", txtname.Text);
                    cmd.Parameters.AddWithValue("@AssignedTo", txtassigned.Text);
                    cmd.Parameters.AddWithValue("@taskDuration", txtduration.Text);
                    cmd.Parameters.AddWithValue("@DepName", comboDepartments.Text);
                    cmd.Parameters.AddWithValue("@Gender", radioButton1.Checked ? "Done" : "Not finished yet");

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Task added successfully!");
                    loadingDatagridView();
                }
                else
                {
                    MessageBox.Show("There is no employee with this name!");
                    loadingDatagridView();
                }
            }
            catch (Exception ex)
            {
                HandleError(ex, "Error adding a new task");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();

            }
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            bool isEmployeeFound = false;
            try
            {
                // Update Task data
                if (string.IsNullOrWhiteSpace(txtname.Text) || string.IsNullOrWhiteSpace(txtassigned.Text) || string.IsNullOrWhiteSpace(txtassigned.Text) || string.IsNullOrWhiteSpace(txtduration.Text) || string.IsNullOrWhiteSpace(comboDepartments.Text))
                {
                    MessageBox.Show("Please fill in all required fields (Task Name, Assigned To, Duration, and Department) before adding a new employee.");
                    return;
                }

                con.Open();

                string query = "SELECT Name FROM tbl_employees";
                cmd = new OleDbCommand(query, con);
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        string employeeName = reader["Name"].ToString();

                        if (employeeName.Equals(txtassigned.Text, StringComparison.OrdinalIgnoreCase))
                        {
                            isEmployeeFound = true;
                            break;
                        }
                    }
                }
                cmd.ExecuteNonQuery();

                if (isEmployeeFound)
                {
                    query = "UPDATE tbl_tasks " +
                        "SET TaskName=@TaskName, AssignedTo=@AssignedTo, taskDuration=@taskDuration, DepName=@DepName, TaskStatus=@TaskStatus " +
                        "WHERE ID=@ID";

                    Console.WriteLine(query);
                    cmd = new OleDbCommand(query, con);

                    cmd.Parameters.AddWithValue("@TaskName", txtname.Text);
                    cmd.Parameters.AddWithValue("@AssignedTo", txtassigned.Text);
                    cmd.Parameters.AddWithValue("@taskDuration", txtduration.Text);
                    cmd.Parameters.AddWithValue("@DepName", comboDepartments.Text);
                    cmd.Parameters.AddWithValue("@Gender", radioButton1.Checked ? "Done" : "Not finished yet");
                    cmd.Parameters.AddWithValue("@ID", dataGridView1.SelectedCells[0].Value.ToString());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Task updated successfully!");
                    loadingDatagridView();
                }
                else
                {
                    MessageBox.Show("There is no employee with this name!");
                    loadingDatagridView();
                }
            }
            catch (Exception ex)
            {
                HandleError(ex, "Error updating an task");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                // Delete an employee

                con.Open();

                string query = "DELETE FROM tbl_tasks WHERE ID=@ID";
                cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", dataGridView1.SelectedCells[0].Value.ToString());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Task deleted successfully!");
                loadingDatagridView();
            }
            catch (Exception ex)
            {
                HandleError(ex, "Error deleting an task");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        private void Exitbutton_Click(object sender, EventArgs e)
        {
            new dashBoard().Show();
            this.Hide();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = "TaskName + AssignedTo LIKE '%" + txtsearch.Text + "%'";
                dataGridView1.DataSource = dv;
            }
            catch (Exception ex)
            {
                HandleError(ex, "Error handling text changed");
            }
        }

        private void txtsearch_Enter(object sender, EventArgs e)
        {
            txtsearch.Text = "";
        }

        private void loadingInfo()
        {
            try
            {
                con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
                dt = new DataTable();
                da = new OleDbDataAdapter("SELECT TaskStatus, COUNT(*) AS TaskStatusCount FROM tbl_tasks GROUP BY TaskStatus", con);

                con.Open();

                da.Fill(dt); // Populate DataTable with data

                
                chart1.Series["TaskStatus"].Points.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    string TaskStatus = row["TaskStatus"].ToString();
                    int count = Convert.ToInt32(row["TaskStatusCount"]);



                    DataPoint point = new DataPoint();
                    point.AxisLabel = TaskStatus;
                    point.YValues = new double[] { count };

                    if (TaskStatus == "Done")
                    {
                        point.Color = Color.RoyalBlue;
                    }
                    else if (TaskStatus == "Not finished yet")
                    {
                        point.Color = Color.Crimson; 
                    }

                    chart1.Series["TaskStatus"].Points.Add(point);
                }

                // Refresh the chart
                chart1.DataBind();
            }
            catch (Exception ex)
            {
                HandleError(ex, "Error loading information for chart");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void LoadDepartmentsComboBox()
        {
            try
            {
                string query = "SELECT DepName FROM tbl_departments";
                cmd = new OleDbCommand(query, con);

                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    DataTable departmentsTable = new DataTable();
                    departmentsTable.Load(reader);

                    // Set the DataSource and DisplayMember for the ComboBox
                    comboDepartments.DataSource = departmentsTable;
                    comboDepartments.DisplayMember = "DepName";
                }
            }
            catch (Exception ex)
            {
                HandleError(ex, "Error loading departments into ComboBox");
            }
        }
    }
}
