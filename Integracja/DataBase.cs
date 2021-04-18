
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integracja
{
    public class DataBase
    {
  
      
        DataGridView gui = new DataGridView();
        string connStr = "server=localhost;user=root;database=integracja_zad4;port=3306;password=";
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
                comm.CommandText = "select * from laptops2";
                gui.Rows.Clear();
                gui.Rows.Add();
                MySqlDataReader rdr = comm.ExecuteReader();
                int row = 0;
                if (rdr.HasRows)
                {

                   
                    while (rdr.Read())
                    {
                        for (int i = 0; i < 15; i++)
                        {
                            gui.Rows[row].Cells[i].Value = rdr[i];
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

        /*    catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }*/


            Console.WriteLine("Done.");

        }
        public void ExportData()
        {
            string data = "";
        
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();

                string sql = "";
                MySqlCommand comm = new MySqlCommand();
                comm.Connection = conn;
                comm.CommandText = "SELECT * from laptops";


                MySqlDataReader rdr = comm.ExecuteReader();

                while (rdr.Read())
                {
                    Console.WriteLine("Próby logowania" + rdr[0]);
                    data = rdr[0].ToString();
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
