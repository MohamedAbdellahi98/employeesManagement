using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace employeesManagement
{
    public partial class DepDashboard : Form
    {
        public DepDashboard()
        {
            InitializeComponent();
        }

        SQLiteConnection con = new SQLiteConnection("Data Source=db_users.db;Version=3;");

        SQLiteCommand cmd = new SQLiteCommand();
        SQLiteDataAdapter da = new SQLiteDataAdapter();
        DataTable dt = new DataTable();

        private void HandleError(Exception ex, string message)
        {
            MessageBox.Show($"{message}\nError: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void DepDashboard_Load(object sender, EventArgs e)
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

                    txtname.Text = row.Cells["DepName"].Value.ToString();
                    txtdes.Text = row.Cells["Description"].Value.ToString();
                    txtlocation.Text = row.Cells["Location"].Value.ToString();
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
                con = new SQLiteConnection("Data Source=db_users.db;Version=3;");
                dt = new DataTable();
                da = new SQLiteDataAdapter("SELECT *FROM tbl_departments", con);

                con.Open();

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

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            new dashBoard().Show();
            this.Hide();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtdes.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtlocation.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

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
                // Add new department
                if (string.IsNullOrWhiteSpace(txtname.Text) || string.IsNullOrWhiteSpace(txtdes.Text) || string.IsNullOrWhiteSpace(txtlocation.Text))
                {
                    MessageBox.Show("Please fill in all required fields (Name,Title, and Salary) before adding a new employee.");
                    return;
                }

                con.Open();

                string query = "INSERT INTO tbl_departments (DepName, Description, Location) " +
                               "VALUES (@Name, @description, @location)";
                cmd = new SQLiteCommand(query, con);
                // Add parameters...
                cmd.Parameters.AddWithValue("@Name", txtname.Text);
                cmd.Parameters.AddWithValue("@description", txtdes.Text);
                cmd.Parameters.AddWithValue("@location",txtlocation.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Department added successfully!");

                
                loadingDatagridView();
            }
            catch (Exception ex)
            {
                HandleError(ex, "Error adding a new department");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();

            }
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                // Update employee data
                if (string.IsNullOrWhiteSpace(txtname.Text) || string.IsNullOrWhiteSpace(txtdes.Text) || string.IsNullOrWhiteSpace(txtlocation.Text))
                {
                    MessageBox.Show("Please fill in all required fields (Name,description, and location) before adding a new employee.");
                    return;
                }

                con.Open();

                string query = "UPDATE tbl_departments " +
                    "SET DepName=@Name, Description=@description, Location=@location " +
                    "WHERE ID=@ID";

                Console.WriteLine(query);
                cmd = new SQLiteCommand(query, con);

                cmd.Parameters.AddWithValue("@Name", txtname.Text);
                cmd.Parameters.AddWithValue("@description", txtdes.Text);
                cmd.Parameters.AddWithValue("@location", txtlocation);
                cmd.Parameters.AddWithValue("@ID", dataGridView1.SelectedCells[0].Value.ToString());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Department updated successfully!");
                loadingDatagridView();
            }
            catch (Exception ex)
            {
                HandleError(ex, "Error updating an department");
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
                // Delete an department
                con.Open();

                string query = "DELETE FROM tbl_departments WHERE ID=@ID";


                cmd = new SQLiteCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", dataGridView1.SelectedCells[0].Value.ToString());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Department deleted successfully!");
                loadingDatagridView();
            }
            catch (Exception ex)
            {
                HandleError(ex, "Error deleting an department");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void loadingInfo()
        {
            try
            {
                con = new SQLiteConnection("Data Source=db_users.db;Version=3;");
                dt = new DataTable();
                da = new SQLiteDataAdapter("SELECT DepName, COUNT(*) AS empAmount FROM tbl_employees GROUP BY DepName", con);

                con.Open();

                da.Fill(dt); 
                
                chart1.ChartAreas[0].AxisY.Interval = 1;
                chart1.Series["Number of Employees"].Points.Clear();
                chart1.Series["Number of Employees"].Color = Color.White;
               
                Random random = new Random();
                
                foreach (DataRow row in dt.Rows)
                {
                    string depName = row["DepName"].ToString();
                    int count = Convert.ToInt32(row["empAmount"]);

                    DataPoint point = new DataPoint();
                    point.AxisLabel = depName;
                    point.YValues = new double[] { count };
                    

                    Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                    point.Color = randomColor;

                    chart1.Series["Number of Employees"].Points.Add(point);
                    
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
    }
}
