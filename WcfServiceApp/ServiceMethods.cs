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
        public DataTable data = new DataTable("Laptops");
        public List<KeyValuePair<string, string>> AspectRatioList = new List<KeyValuePair<string, string>>();
        public DataTable GetDataFromDataBase()
        {
            string connStr = "server=localhost;user=root;database=integracja_zad4;port=3306;password=;Allow User Variables=true";
            DataTable dataTable = new DataTable("Laptops");
            data = new DataTable("Laptops");
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
                dataTable.Columns.Remove("ID");
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

            data = dataTable;
         
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
            string aspectRatio = "";
            var keyses = AspectRatioList.Where(kvp => kvp.Key ==brand).Select(kvp => kvp.Value);
            
            switch (keyses.Count())
            {
                case 1:
                    aspectRatio = "screen_resolution='" + keyses.ElementAt(0) + "'";
                    break;
                case 2:
                    aspectRatio = "screen_resolution='" + keyses.ElementAt(0) + "' OR screen_resolution='" + keyses.ElementAt(1)+"'";
                    break;
                case 3:
                    aspectRatio = "screen_resolution='" + keyses.ElementAt(0) + "' OR screen_resolution='" + keyses.ElementAt(1) + "'OR screen_resolution='"+keyses.ElementAt(2)+"'";
                    break;
               

            }
        
            try
            {
                
                DataView dv = new DataView(dt,aspectRatio, "screen_resolution desc", DataViewRowState.CurrentRows);
                
                dtf = dv.ToTable();
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Wyjątek " + ex.Message);
            }

          
            return dtf;

            
        }
        public List<String> CalcAspectRadio(DataTable data)
        {
            List<String> aspectRatioTemp = new List<string>();
           
            for(int i = 0; i < data.Rows.Count; i++)
            {
                aspectRatioTemp.Add(data.Rows[i][2].ToString());
                
            }
            aspectRatioTemp.RemoveAll(x => x == "");
            List<string> distinctAspectRatio = aspectRatioTemp.Distinct().ToList();
   
            string[][] test = new string[distinctAspectRatio.Count][];
            List<string> lista = new List<string>();
            for(int i = 0; i < distinctAspectRatio.Count; i++)
            {
                
                    test[i] = distinctAspectRatio[i].Split('x');
                
              
            }
            List<String> aspectRatioLists = new List<string>();
            for(int i = 0; i < test.Length; i++)
            {
                string value = CaluculateAspectRadio(Int32.Parse(test[i][0]), Int32.Parse(test[i][1]));
                aspectRatioLists.Add(CaluculateAspectRadio(Int32.Parse(test[i][0]), Int32.Parse(test[i][1])));
                string resolutionString = test[i][0] + "x" + test[i][1];
                AspectRatioList.Add(new KeyValuePair<string, string>(value,resolutionString));
             
            }
            List<string> aspectRatio = aspectRatioLists.Distinct().ToList();

            
            return aspectRatio;
        }
        public int GCD(int a, int b)
        {

            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a %= b;
                }
                else
                {
                    b %= a;
                }
            }
            if (a == 0)
            {
                return b;
            }
            else
            {
                return a;
            }
        }
        public string CaluculateAspectRadio(int x,int y)
        {
            return string.Format("{0}:{1}", x / GCD(x, y), y / GCD(x, y)); 

        }
        


    }
}