using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace ABC_Car_Traders.commonClass
{
    // Enum defining types of database operations (save, update, delete).
    internal enum executeType
    {
        save, update, delete, view
    }
    internal class ABC_DBClass
    {
        // SQL connection to the ABC_Traders database
        internal SqlConnection connect = new SqlConnection(@"Data Source=BMCC-NITHU;Initial Catalog=ABC_Traders;Integrated Security=True");

        // Executes database operations like insert, update, and delete.
        protected bool execute(string sql, executeType type)
        {
            bool funcStatus = false;

            try
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand(sql, connect);
                int affectedRow = cmd.ExecuteNonQuery();
                if (affectedRow > 0) // Check if any rows were affected by the query
                {

                    string message = type == executeType.save ? "Data Inserted Successfully" :
                        type == executeType.update ? "Data Updated Successfully" : "Data Deleted Successfully";
                    MessageBox.Show(message);

                    funcStatus = true;
                }
                else
                {
                    MessageBox.Show("Contact with your IT support");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // Handle any exceptions
            }
            finally
            {
                connect.Close();
            }

            return funcStatus; 
        }

        protected DataTable getDataFromDB(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, connect);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        protected void loadDataInDataGridView(string sql, DataGridView loadTable)
        {
            DataTable dt = getDataFromDB(sql);
            loadTable.DataSource = dt;
        }


        protected void loadFKInComboBox(string sql, ComboBox fkBox, string displayColumnName, string valueColumnName)
        {
            DataTable dt = getDataFromDB(sql);
            fkBox.DataSource = dt;
            fkBox.DisplayMember = displayColumnName;
            fkBox.ValueMember = valueColumnName;
        }

        protected bool showDeleteConfirmationMessage()
        {
            return MessageBox.Show("Do you want to delete ?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;
        }

        protected bool showUpdateConfirmationMessage()
        {
            return MessageBox.Show("Do you want to update ?", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }
    }
}
