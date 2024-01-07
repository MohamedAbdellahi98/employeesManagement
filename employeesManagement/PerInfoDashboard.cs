using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace employeesManagement
{
    public partial class PerInfoDashboard : Form
    {
        public PerInfoDashboard()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        //OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_users.accdb");

        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataTable dt = new DataTable();

        private byte[] pictureData;
        private void HandleError(Exception ex, string message)
        {
            MessageBox.Show($"{message}\nError: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void PerInfoDashboard_Load(object sender, EventArgs e)
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
                    txtbadge.Text = row.Cells["Badge"].Value.ToString();
                    txtmall.Text= row.Cells["Mall"].Value.ToString();
                    txttelephone.Text = row.Cells["Telephone"].Value.ToString();
                    txtaddress.Text = row.Cells["Address"].Value.ToString();
                    byte[] pictureData = (byte[])row.Cells["picture"].Value;
                    if (pictureData != null && pictureData.Length > 0)
                    {
                        MemoryStream ms = new MemoryStream(pictureData);
                        pictureBox.Image = Image.FromStream(ms);
                    }
                    else
                    {
                        pictureBox.Image = null; // Clear the image if no data is specified
                    }
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
                da = new OleDbDataAdapter("SELECT *FROM tbl_personalInfo", con);

                con.Open();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                //loadingInfo();

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

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                // Update Info
                if (string.IsNullOrWhiteSpace(txtmall.Text) || string.IsNullOrWhiteSpace(txttelephone.Text) || string.IsNullOrWhiteSpace(txtaddress.Text))
                {
                    MessageBox.Show("Please fill in all required fields (mall, phone, and address) before updating employee information.");
                    return;
                }

                con.Open();

                int employeeID = Convert.ToInt32(txtbadge.Text);

                string updatequery = "UPDATE tbl_personalInfo SET " +
                     "Mall=@Mall, Telephone=@Telephone, Address=@Address" +
                     (pictureData != null ? ", Picture=@Picture" : "") +
                     " WHERE ID=@ID";

                cmd = new OleDbCommand(updatequery, con);

                cmd.Parameters.AddWithValue("@Mall", txtmall.Text);
                cmd.Parameters.AddWithValue("@Telephone", txttelephone.Text);
                cmd.Parameters.AddWithValue("@Address", txtaddress.Text);
                if (pictureData != null)
                {
                    cmd.Parameters.AddWithValue("@Picture", pictureData);
                }

                cmd.Parameters.AddWithValue("@ID", employeeID);

                cmd.ExecuteNonQuery();
                MessageBox.Show("personal informations updated successfully!");
                loadingDatagridView();
            }
            catch (Exception ex)
            {
                HandleError(ex, "Error updating personal informations");
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
                txtbadge.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtmall.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txttelephone.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtaddress.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

                object pictureCellValue = dataGridView1.CurrentRow.Cells["picture"].Value;

                if (pictureCellValue != DBNull.Value)
                {
                    byte[] pictureData = (byte[])pictureCellValue;
                    if (pictureData != null && pictureData.Length > 0)
                    {
                        MemoryStream ms = new MemoryStream(pictureData);
                        pictureBox.Image = Image.FromStream(ms);
                    }
                    else
                    {
                        pictureBox.Image = null; // Clear the image if no data is specified
                    }
                }
                else
                {
                    pictureBox.Image = null; // Handle DBNull value for picture column
                }
            }
            catch (Exception ex)
            {
                HandleError(ex, "Error handling cell enter");
            }

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = "Name LIKE '%" + txtsearch.Text + "%'";
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

        private void picButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png", ValidateNames = true, Multiselect = false })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        pictureBox.Image = new Bitmap(ofd.FileName);

                        // Convert the Image to byte array
                        MemoryStream ms = new MemoryStream();
                        pictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        pictureData = ms.ToArray(); // Update the global variable pictureData
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string query = "DELETE FROM tbl_personalInfo WHERE ID=@ID";

                cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", dataGridView1.SelectedCells[0].Value.ToString());

                cmd.ExecuteNonQuery();
                MessageBox.Show("personal informations deleted successfully!");
                loadingDatagridView();
            }
            catch (Exception ex)
            {
                HandleError(ex, "Error deleting an personal informations");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
    }
    
}
