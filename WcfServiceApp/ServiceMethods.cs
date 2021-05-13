using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Windows.Forms;
using MySqlConnector;

namespace WcfServiceApp
{
    public class ServiceMethods
    {
        public DataTable data = new DataTable("laptops");
        public DataTable GetDataFromDataBase()
        {
            string connStr = "server=localhost;user=root;database=integracja_zad4;port=3306;password=;Allow User Variables=true";
            DataTable dataTable = new DataTable("Laptops");
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();

                string sql = "";
                MySqlCommand comm = new MySqlCommand();
                comm.Connection = conn;
                comm.CommandText = "select * from laptops";
                MySqlDataReader rdr = comm.ExecuteReader();
                dataTable.Load(rdr);
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

            aspectRadio(dataTable);
           return dataTable;


        }
       
       
        public DataTable filteringBrand(DataTable dt,String brand)
        {
            DataTable dtf = new DataTable("Laptops");
            string brandFilter = "brand='" + brand + "'";
            try
            {
             Console.WriteLine("Filtrowanie brandów");
             DataView dv = new DataView(dt,brandFilter, "brand desc", DataViewRowState.CurrentRows);
             dtf = dv.ToTable();
            }catch(Exception ex)
            {
                Console.Error.WriteLine("Wyjątek " + ex.Message);
            }
            return dtf;
        

        }
        public DataTable  FilteringScreenAspectRadio(DataTable dt,String brand)
        {
            Console.WriteLine("Filtrowanie Rozdzielczości");
            DataTable dtf = new DataTable("Laptops");
            string aspectRadio = "brand='" + brand + "'";
            
            try
            {
                Console.WriteLine("Filtrowanie brandów");
                DataView dv = new DataView(dt,aspectRadio, "brand desc", DataViewRowState.CurrentRows);
                dtf = dv.ToTable();
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Wyjątek " + ex.Message);
            }

          
            return dtf;

            
        }
        public List<String> aspectRadio(DataTable dataTable)
        {
            List<String> aspectRadio = new List<string>();
            for(int i = 0; i < dataTable.Rows.Count; i++)
            {
                aspectRadio.Add(dataTable.Rows[i][3].ToString());
            }
            List<string> distinctAspectRadio = aspectRadio.Distinct().ToList();

            return distinctAspectRadio;
        }
    }
}