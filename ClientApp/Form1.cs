using ClientApp.ServiceMethod;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class Form1 : Form
    {
        List<String> lista = new List<string>();
        String ScreenChoose = "";
        String brandChoose = "";
        public Form1()
        {
            InitializeComponent();
            ScreenChooseComboBox.Items.Add("16:9");
            ScreenChooseComboBox.Items.Add("16:10");
            ScreenChooseComboBox.Items.Add("4:3");
            

        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            
            /* DataBaseConnection dataBaseConnection = new DataBaseConnection(dataGridView1, ScreenChooseComboBox, brandChooseComboBox);
             dataBaseConnection.getData();*/
            
         /*   for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                if (!lista.Contains(dataGridView1.Rows[i].Cells[0].Value.ToString()))
                {
                    lista.Add(dataGridView1.Rows[i].Cells[0].Value.ToString());
                }
                
                
            }
            for (int j = 0; j < lista.Count; j++)
            {
                comboBox2.Items.Add(lista[j]);
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServiceFilteringClient client = new ServiceFilteringClient();
            DataTable dt = new DataTable("laptops");
            int columnCount = 0;
            List<int> columnNumbers = new List<int>();

            foreach (DataGridViewColumn dataGridViewColumn in dataGridView1.Columns)
            {


                if (dataGridViewColumn.Visible)
                {
                    dt.Columns.Add(dataGridViewColumn.Name);
                    columnNumbers.Add(columnCount);

                }
                columnCount++;
            }

            var cell = new object[columnNumbers.Count];
            foreach (DataGridViewRow dataGridViewRow in dataGridView1.Rows)
            {
                int i = 0;
                foreach (int a in columnNumbers)
                {
                    cell[i] = dataGridViewRow.Cells[a].Value;
                    i++;
                }
                dt.Rows.Add(cell);
            }
            dataGridView1.Rows.Clear();
            DataTable firtredValue=client.filteringBrand(dt,brandChoose);
            dataGridView1.Rows.Add();
            for (int i = 0; i < firtredValue.Rows.Count; i++)
            {
                dataGridView1.Rows.Add();
                for (int j = 0; j < firtredValue.Columns.Count; j++)
                {

                    dataGridView1.Rows[i].Cells[j].Value = firtredValue.Rows[i][j].ToString();
                }

            }
            laptopCount.Text = "Liczba laptopów: " + firtredValue.Rows.Count;

        }

        private void ScreenChooseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            ScreenChoose = ScreenChooseComboBox.SelectedItem.ToString();
            

        }

        private void brandChooseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
            brandChoose = brandChooseComboBox.SelectedItem.ToString();
           
            
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
           
          
        }
        public void LoadDataFromDB()
        {
           
            ServiceFilteringClient client = new ServiceFilteringClient();
            DataTable dt = client.GetDataFromDataBase();
            laptopCount.Text = "Liczba laptopów: " + dt.Rows.Count;
            dataGridView1.Rows.Add();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dataGridView1.Rows.Add();
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    
                    dataGridView1.Rows[i].Cells[j].Value = dt.Rows[i][j].ToString();
                  
                }
                
            }            
        }
        public void AddBrandsToComboBox()
        {
            if (dataGridView1.Rows.Count >= 2)
            {
                if (brandChooseComboBox.Items.Count == 0)
                {
                    List<String> brandList = new List<string>(10);
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        brandList.Add(dataGridView1.Rows[i].Cells[1].Value.ToString());
                    }
                    List<String> distinctBrand = brandList.Distinct().ToList();
                    for (int i = 0; i < distinctBrand.Count; i++)
                    {
                        brandChooseComboBox.Items.Add(distinctBrand[i]);
                    }
                }
                
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadDataFromDB();
            AddBrandsToComboBox();
        }
    }
}
