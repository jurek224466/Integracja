using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integracja
{
    public partial class Form1 : Form
    {
        int k;
        int a = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void read_file_Click(object sender, EventArgs e)
        {
            FileMethods file = new FileMethods();
            String filePath = "";
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Pliki tekstowe (*.txt)|*.txt";
            if (open.ShowDialog()==DialogResult.OK)
            {
                filePath = open.FileName;
                WriteIntoDataGridView(open.FileName);
               
            }
         
           
        }

        private void save_file_Click(object sender, EventArgs e)
        {
            FileMethods file = new FileMethods();
            
            String filepath = "";
            SaveFileDialog save = new SaveFileDialog();
           save.Filter = "Pliki tekstowe (*.txt)|*.txt";
            if (save.ShowDialog() == DialogResult.OK)
            {
                
                ReadFromDataGridView(save.FileName);
               
            }

        }
        private void saveDataView()
        {
            Data data = new Data();
            Console.WriteLine("Licznik k: " + k);
            int b = 4;
            for (int k = a; k <b; k++)
            {
                dataGridView.Rows.Add();
                for (int j = 0; j < 16; j++)
                {
                    dataGridView.Rows[k].Cells[j].Value = "Value";
                    Console.WriteLine("Licznik k: " + k);
                }
               
            }
            a = b;
            b = b + 4;
            
            Console.WriteLine("Licznik k: "+k);

        }
        private void WriteIntoDataGridView(String filePath)
        {
            StreamReader reader = new StreamReader(filePath);
            /* string [] columnName=file*/
            DataTable dt = new DataTable();
            
            while (reader.ReadLine()!=null)
            {
                
                DataRow dr = dt.NewRow();
                
                string[] values = reader.ReadLine().Split(';');
                string[] collumn = new string[16];
                for(int i = 0; i <dataGridView.Columns.Count; i++)
                {
                    collumn[i] = dataGridView.Columns[i].Name;
                }
               for(int i = 0; i < collumn.Length; i++)
                {
                    dt.Columns.Add(collumn[i]);
                }
                    
                
                for (int i = 2; i <values.Length; i++)
                {
                   
                        dr[i] = values[i];
                    
                    
                }
                dt.Rows.Add(dr);
            }
            reader.Close();
            dataGridView.DataSource = dt;
        }
        private void ReadFromDataGridView(String filePath)
        {
            var sb = new StringBuilder();

            var headers = dataGridView.Columns.Cast<DataGridViewColumn>();
            sb.AppendLine(string.Join(",", headers.Select(column => "\"" + column.HeaderText + "\"").ToArray()));

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                var cells = row.Cells.Cast<DataGridViewCell>();
                sb.AppendLine(string.Join(";", cells.Select(cell => "\"" + cell.Value + "\"").ToArray()));
            }
            System.IO.File.WriteAllText(filePath, sb.ToString());
        }
    }
}
