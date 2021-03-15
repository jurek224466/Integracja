using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
     /*   private void saveDataView()
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

        }*/
        private void WriteIntoDataGridView(String filePath)
        {

            dataGridView.ReadOnly = false;
            string[] lines = System.IO.File.ReadAllLines(filePath);
            string[] values = new string[lines.Length];
            
           for(int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine("Licznik lin " + i + " values" + lines[i].ToString());
                values = lines[i].Split(';');
                i= dataGridView.Rows.Add();
                for (int j = 0; j <values.Length-1; j++)
                {
                   dataGridView.Rows[i].Cells[j].Value = values[j].ToString();
                  
                }
               




            }
          

          

        }
        private void ReadFromDataGridView(String filePath)
        {
            var sb = new StringBuilder();

            var headers = dataGridView.Columns.Cast<DataGridViewColumn>();
            sb.AppendLine(string.Join(";", headers.Select(column => "\"" + column.HeaderText + "\"").ToArray()));

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                var cells = row.Cells.Cast<DataGridViewCell>();
                sb.AppendLine(string.Join(";", cells.Select(cell => "\"" + cell.Value + "\"").ToArray()));
            }
            System.IO.File.WriteAllText(filePath, sb.ToString());
        }

        private void dataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            int columnIndex = e.ColumnIndex;
           if(columnIndex==1 || columnIndex==6 || columnIndex==7)
            {
                string value = e.FormattedValue.ToString();
                if (!value.All(char.IsDigit))
                {
                    dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
                    MessageBox.Show(this,"Niepoprawny typ liczbowy","Bład",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
                }
            }
           if(columnIndex==5 || columnIndex==13 || columnIndex==11)
            {
                string value = e.FormattedValue.ToString();
                if (!value.All(char.IsLetterOrDigit))
                {
                    dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
                    MessageBox.Show(this, "Niepoprawny format", "Bład", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
                }
            }
            if (columnIndex == 3 || columnIndex == 4 || columnIndex == 11 && columnIndex==14)
            {
                string value = e.FormattedValue.ToString();
                if (!value.All(char.IsLetter))
                {
                    dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
                    MessageBox.Show(this, "Niepoprawny typ znakowy", "Bład", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
                }
            }

        }
    }
}
