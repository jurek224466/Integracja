using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp
{
   public class DataBaseConnection
    {
        DataGridView dataGridView;
        ComboBox combo1;
        ComboBox combo2;
        public DataBaseConnection(DataGridView dataGrid)
        {
            dataGridView = new DataGridView();
            dataGridView = dataGrid;
        }
        public DataBaseConnection(DataGridView dataGrid, ComboBox combo, ComboBox combo2)
        {
            dataGridView = new DataGridView();
            dataGridView = dataGrid;
            this.combo1 = combo;
            this.combo2 = combo2;
        }

        public void getData()
        {
            string connStr = "server=localhost;user=root;database=integracja_zad4;port=3306;password=;Allow User Variables=true";
            dataGridView.Rows.Add();
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();

                string sql = "";
                MySqlCommand comm = new MySqlCommand();
                comm.Connection = conn;
                comm.CommandText = "select * from laptops";
                dataGridView.Rows.Clear();
                dataGridView.Rows.Add();
                MySqlDataReader rdr = comm.ExecuteReader();
                int row = 0;

                if (rdr.HasRows)
                {


                    while (rdr.Read())
                    {

                        for (int i = 0; i < rdr.FieldCount; i++)
                        {
                            for (int j = 0; j < dataGridView.Rows[row].Cells.Count; j++)
                            {
                                int cells = dataGridView.Rows[row].Cells.Count;
                               
                                dataGridView.Rows[row].Cells[j].Value = rdr[j + 1];


                            }

                        }
                        row++;
                        dataGridView.Rows.Add();
                    }

                }
               /* validation.AddCustomInformation();*/
                conn.Close();

            }
            catch (MySqlException mysql)
            {
                Console.Error.WriteLine(mysql.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


            Console.WriteLine("Done.");


        }
        public void setData()
        {

        }
    }
}
