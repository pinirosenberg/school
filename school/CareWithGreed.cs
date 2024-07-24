using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school
{
    public class CareWithGreed
    {
        DBContext db;
        public string Query;
        DataGridView GridView;
        public CareWithGreed(DBContext dBContext, DataGridView gridView) 
        { 
            db = dBContext;
            GridView = gridView;
        }
        public void ChangeQuery(string query) 
        {
            this.Query = query;
        }
        public void LoadCategories(DataTable MyTable)
        {
            GridView.Rows.Clear(); // Clear existing rows
            GridView.Columns.Clear(); // Clear existing columns

            if (MyTable.Columns.Count > 0)
            {
                // Add columns to the DataGridView
                foreach (DataColumn column in MyTable.Columns)
                {
                    GridView.Columns.Add(column.ColumnName, column.ColumnName);
                }

                // Add rows to the DataGridView
                foreach (DataRow row in MyTable.Rows)
                {
                    List<string> values = new List<string>();
                    foreach (DataColumn column in MyTable.Columns)
                    {
                        if (row[column] != DBNull.Value)
                        {
                            values.Add(row[column].ToString());
                        }
                        else
                        {
                            values.Add(string.Empty);
                        }
                    }
                    GridView.Rows.Add(values.ToArray());
                }
            }
            else
            {
                // Handle the case where there are no columns
                MessageBox.Show("No columns available in the DataTable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public async void LoadDataBaseAsync()
        {


            using (SqlConnection connection2 = new SqlConnection(db._connectionString))
            {
                try
                {
                    await connection2.OpenAsync();
                    SqlDataAdapter adapter = new SqlDataAdapter(Query, connection2);
                    DataTable table = new DataTable();
                    await Task.Run(() => adapter.Fill(table));
                    LoadCategories(table);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                }
            }
        }
    }
}
