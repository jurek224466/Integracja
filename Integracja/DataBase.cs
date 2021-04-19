
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integracja
{
    public class DataBase
    {


        DataGridView gui = new DataGridView();
        
        string connStr = "server=localhost;user=root;database=integracja_zad4;port=3306;password=;Allow User Variables=true";
        public DataBase(DataGridView data)
        {
            gui = data;
        }
        public void ImportData()
        {

            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();

                string sql = "";
                MySqlCommand comm = new MySqlCommand();
                comm.Connection = conn;
                comm.CommandText = "select * from laptops";
                gui.Rows.Clear();
                gui.Rows.Add();
                MySqlDataReader rdr = comm.ExecuteReader();
                int row = 0;
               
                 if (rdr.HasRows)
                 {


                     while (rdr.Read())
                     {
                        
                        for (int i = 0; i <rdr.FieldCount; i++)
                         {
                             for (int j = 0; j <gui.Rows[row].Cells.Count; j++)
                             {
                                 int cells = gui.Rows[row].Cells.Count;
                                Console.WriteLine("Index: " + j + " " + rdr[j]);
                                gui.Rows[row].Cells[j].Value = rdr[j+1];


                            }

                         }
                         row++;
                       gui.Rows.Add();
                     }

                 }

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
        public void ExportData()
        {
            string data = "";

            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                MySqlCommand comm = new MySqlCommand();
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                comm.Parameters.AddWithValue("@manufacture", "");
                comm.Parameters.AddWithValue("@screen_size", "");
                comm.Parameters.AddWithValue("@screen_resolution", "");
                comm.Parameters.AddWithValue("@screen_type", "");
                comm.Parameters.AddWithValue("@screen_touch", "");
                comm.Parameters.AddWithValue("@processor_name", "");
                comm.Parameters.AddWithValue("@cpu_speed", "");
                comm.Parameters.AddWithValue("@cpu_thread", "");
                comm.Parameters.AddWithValue("ram_size", "");
                comm.Parameters.AddWithValue("ssd_size", "");
                comm.Parameters.AddWithValue("ssd_type", "");
                comm.Parameters.AddWithValue("gpu_name", "");
                comm.Parameters.AddWithValue("gpu_ram", "");
                comm.Parameters.AddWithValue("os_name", "");
                comm.Parameters.AddWithValue("disc_reader", "");
                comm.CommandText = "INSERT INTO laptops (manufacture,screen_size,screen_resolution,screen_type,screen_touch,processor_name,cpu_speed,cpu_thread,ram_size,ssd_size,ssd_type,gpu_name,gpu_ram,os_name,disc_reader) VALUES (@manufacture,@screen_size,@screen_resolution,@screen_type,@screen_touch,@processor_name,@cpu_speed,@cpu_thread,@ram_size,@ssd_size,@ssd_type,@gpu_name,@gpu_ram,@os_name,@disc_reader)";
                comm.Connection = conn;
                for (int i = 0; i < gui.Rows.Count; i++)
                {

                    comm.Parameters["@manufacture"].Value = gui.Rows[i].Cells[0].Value;
                    comm.Parameters["@screen_size"].Value = gui.Rows[i].Cells[1].Value;
                    comm.Parameters["@screen_resolution"].Value = gui.Rows[i].Cells[2].Value;
                    comm.Parameters["@screen_type"].Value = gui.Rows[i].Cells[3].Value;
                    comm.Parameters["@screen_touch"].Value = gui.Rows[i].Cells[4].Value;
                    comm.Parameters["@processor_name"].Value = gui.Rows[i].Cells[5].Value;
                    comm.Parameters["@cpu_speed"].Value = gui.Rows[i].Cells[6].Value;
                    comm.Parameters["@cpu_thread"].Value = gui.Rows[i].Cells[7].Value;
                    comm.Parameters["@ram_size"].Value = gui.Rows[i].Cells[8].Value;
                    comm.Parameters["@ssd_size"].Value = gui.Rows[i].Cells[9].Value;
                    comm.Parameters["@ssd_type"].Value = gui.Rows[i].Cells[10].Value;
                    comm.Parameters["@gpu_name"].Value = gui.Rows[i].Cells[11].Value;
                    comm.Parameters["@gpu_ram"].Value = gui.Rows[i].Cells[12].Value;
                    comm.Parameters["@os_name"].Value = gui.Rows[i].Cells[13].Value;
                    comm.Parameters["@disc_reader"].Value = gui.Rows[i].Cells[14].Value;
                    comm.ExecuteNonQuery();
                }

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

        public void CheckDuplicate()
        {
          
        }
    }
}
        
    

 

