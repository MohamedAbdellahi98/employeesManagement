using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;

namespace employeesManagement
{
    public partial class EmpDashBoard : Form
    {
        public EmpDashBoard()
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

        private void dashBoard_Load(object sender, EventArgs e)
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

                    txtname.Text = row.Cells["Name"].Value.ToString();
                    comboDepartments.Text = row.Cells["DepName"].Value.ToString();
                    txttitle.Text = row.Cells["Title"].Value.ToString();
                    dateTimePicker1.Text = row.Cells["StartDate"].Value.ToString();
                    txtsalary.Text = row.Cells["Salary"].Value.ToString();
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
                da = new OleDbDataAdapter("SELECT *FROM tbl_employees", con);

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

        private void loadingInfo()
        {
            try
            {
                con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
                dt = new DataTable();
                da = new OleDbDataAdapter("SELECT Gender, COUNT(*) AS GenderCount FROM tbl_employees GROUP BY Gender", con);

                con.Open();
  
                da.Fill(dt); 

                chart1.Series["Gender"].Points.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    string gender = row["Gender"].ToString();
                    int count = Convert.ToInt32(row["GenderCount"]);

                   

                    DataPoint point = new DataPoint();
                    point.AxisLabel = gender;
                    point.YValues = new double[] { count };

                    if (gender == "Male")
                    {
                        point.Color = Color.RoyalBlue;
                    }
                    else if (gender == "Female")
                    {
                        point.Color = Color.Orchid;
                    }

                    chart1.Series["Gender"].Points.Add(point);
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

        private void Insertbutton_Click(object sender, EventArgs e)
        {
            int tempID=0;
            try
            {
                // Add new employee
                if (string.IsNullOrWhiteSpace(txtname.Text) || string.IsNullOrWhiteSpace(txttitle.Text) || string.IsNullOrWhiteSpace(txtsalary.Text))
                {
                    MessageBox.Show("Please fill in all required fields (Name,Title, and Salary) before adding a new employee.");
                    return;
                }

                con.Open();

                string query = "INSERT INTO tbl_employees (Name, Gender, DepName, Title, StartDate, Salary) " +
                               "VALUES (@Name, @Gender, @DepName, @Title, @StartDate, @Salary)";
                cmd = new OleDbCommand(query, con);
                // Add parameters...
                cmd.Parameters.AddWithValue("@Name", txtname.Text);
                cmd.Parameters.AddWithValue("@Gender", radioButton1.Checked ? "Male" : "Female");
                cmd.Parameters.AddWithValue("@DepName", comboDepartments.Text);
                cmd.Parameters.AddWithValue("@Title", txttitle.Text);
                cmd.Parameters.AddWithValue("@StartDate", dateTimePicker1.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@Salary", txtsalary.Text);
                cmd.ExecuteNonQuery();

                query = "SELECT @@IDENTITY";
                cmd = new OleDbCommand(query, con);
                tempID = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.ExecuteNonQuery();

                InitializepersonalInfo(tempID, txtname.Text);
                MessageBox.Show("Employee added successfully!\nYou can update personal information in personal dashboard");
                loadingDatagridView();
            }
            catch (Exception ex)
            {
                HandleError(ex, "Error adding a new employee");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
                
            }
        }

        private void InitializepersonalInfo(int id, string name)
        {
            try
            {
                // con.Open();

                string defaultImagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "icons8-no-image-100.png");

                byte[] defaultImageBytes = File.ReadAllBytes(defaultImagePath);


                string personalQuery = "INSERT INTO tbl_personalInfo (ID, Name, Mall, Telephone, Address, Picture) " +
                "VALUES (@id, @Name, @Mall, @Telephone, @Address, IIF(@Picture IS NULL, @DefaultPicture, @Picture))";

                cmd = new OleDbCommand(personalQuery, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Mall", "no mall yet");
                cmd.Parameters.AddWithValue("@Telephone", "no telephone yet");
                cmd.Parameters.AddWithValue("@Address", "no adress yet");
                cmd.Parameters.AddWithValue("@Picture", DBNull.Value);
                if (defaultImageBytes.Length > 0)
                {
                    cmd.Parameters.AddWithValue("@DefaultPicture", defaultImageBytes);
                }
                else
                {
                    // إذا كانت الصورة الافتراضية فارغة، قم بتعيين قيمة NULL
                    cmd.Parameters.AddWithValue("@DefaultPicture", DBNull.Value);
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                HandleError(ex, "Error adding a new employee to personal table");
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
                if (string.IsNullOrWhiteSpace(txtname.Text) || string.IsNullOrWhiteSpace(txttitle.Text) || string.IsNullOrWhiteSpace(txtsalary.Text))
                {
                    MessageBox.Show("Please fill in all required fields (Name,Title, and Salary) before adding a new employee.");
                    return;
                }

                con.Open();

                string query = "UPDATE tbl_employees " +
                    "SET Name=@Name, Gender=@Gender, DepName=@DepName, Title=@Title, StartDate=@StartDate, Salary=@Salary " +
                    "WHERE ID=@ID";

                Console.WriteLine(query);
                cmd = new OleDbCommand(query, con);

                cmd.Parameters.AddWithValue("@Name", txtname.Text);
                cmd.Parameters.AddWithValue("@Gender", radioButton1.Checked ? "Male" : "Female");
                cmd.Parameters.AddWithValue("@DepName", comboDepartments.Text);
                cmd.Parameters.AddWithValue("@Title", txttitle.Text);
                cmd.Parameters.AddWithValue("@StartDate", dateTimePicker1.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@Salary", txtsalary.Text);
                cmd.Parameters.AddWithValue("@ID", dataGridView1.SelectedCells[0].Value.ToString());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee updated successfully!");
                loadingDatagridView();
            }
            catch (Exception ex)
            {
                HandleError(ex, "Error updating an employee");
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

                string query = "DELETE FROM tbl_employees WHERE ID=@ID";

                cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", dataGridView1.SelectedCells[0].Value.ToString());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee deleted successfully!");
                loadingDatagridView();
            }
            catch (Exception ex)
            {
                HandleError(ex, "Error deleting an employee");
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
                dv.RowFilter = "Name + Title LIKE '%" + txtsearch.Text + "%'";
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

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

                radioButton1.Checked = dataGridView1.CurrentRow.Cells[2].Value.ToString() == "Male";
                radioButton2.Checked = !radioButton1.Checked;
                comboDepartments.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

                txttitle.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txtsalary.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            }
            catch (Exception ex)
            {
                HandleError(ex, "Error handling cell enter");
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
