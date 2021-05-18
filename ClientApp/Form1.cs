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
            
            

        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            
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
            dataGridView1.Rows.Clear();
            laptopCount.Text = "Liczba laptopów: " + dt.Rows.Count;
            dataGridView1.Rows.Add();
            int k = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dataGridView1.Rows.Add();
                for (int j = 1,s=0; j < dt.Columns.Count && s<dt.Columns.Count; j++,s++)
                {
                   
                    dataGridView1.Rows[i].Cells[s].Value = dt.Rows[i][j].ToString();
                  
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
        public void AddAspectRation()
        {
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
            ServiceFilteringClient client = new ServiceFilteringClient();
            string[] list = client.aspectRatioList(dt);
            if (ScreenChooseComboBox.Items.Count == 0)
            {
                for (int i = 0; i < list.Length; i++)
                {
                    ScreenChooseComboBox.Items.Add(list[i]);
                }
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadDataFromDB();
            AddCustomInformation();
            AddBrandsToComboBox();
            AddAspectRation();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
            ServiceFilteringClient client = new ServiceFilteringClient();
            DataTable values = client.FilteringScreenAspectRadio(dt,ScreenChoose);
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add();
            for (int i = 0; i < values.Rows.Count; i++)
            {
                dataGridView1.Rows.Add();
                for (int j = 0; j < values.Columns.Count; j++)
                {

                    dataGridView1.Rows[i].Cells[j].Value = values.Rows[i][j].ToString();
                }

            }
            laptopCount.Text = "Liczba laptopów: " + values.Rows.Count;

        }
        public void AddCustomInformation()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (j != 2)
                    { 
                        if (dataGridView1.Rows[i].Cells[j].Value == "" || dataGridView1.Rows[i].Cells[j].Value == "0")
                        {
                            dataGridView1.Rows[i].Cells[j].Value = "brak informacji";
                        }
                    }
                    
                }
            }
        }
    }
}
