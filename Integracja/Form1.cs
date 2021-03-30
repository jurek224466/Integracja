using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Integracja
{
    public partial class Form1 : Form
    {
        int k;
        int a = 0;
        DataTable table = new DataTable("laptops");
        public Form1()
        {
            InitializeComponent();
        }



        private void read_file_Click(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Pliki tekstowe (*.txt)|*.txt";
            if (open.ShowDialog() == DialogResult.OK)
            {

                WriteTextFileIntoDataGridView(open.FileName);

            }

        }

        private void save_file_Click(object sender, EventArgs e)
        {



            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Pliki tekstowe (*.txt)|*.txt";
            if (save.ShowDialog() == DialogResult.OK)
            {

                ReadTextFileFromDataGridView(save.FileName);

            }

        }

        private void WriteTextFileIntoDataGridView(String filePath)
        {

            dataGridView.ReadOnly = false;
            string[] lines = System.IO.File.ReadAllLines(filePath);
            string[] values = new string[lines.Length];

            /* if (dataGridView.Rows.Count == 1)
             {*/
            for (int i = 0; i < lines.Length; i++)
            {

                values = lines[i].Split(';');
                i = dataGridView.Rows.Add();
                for (int j = 0; j < values.Length - 1; j++)
                {
                    if (values[j] == null || values[j] == "")
                    {
                        dataGridView.Rows[i].Cells[j].Value = "brak";

                    }
                    else
                    {
                        dataGridView.Rows[i].Cells[j].Value = values[j].ToString();
                    }


                }

            }





        }
        private void ReadTextFileFromDataGridView(String filePath)
        {
            var sb = new StringBuilder();

            /*var headers = dataGridView.Columns.Cast<DataGridViewColumn>(); dodawanie nagłówków do plików
            sb.AppendLine(string.Join(";", headers.Select(column => "\"" + column.HeaderText + "\"").ToArray()));*/

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Index < dataGridView.Rows.Count - 1)
                {
                    Console.WriteLine("Row index : " + row.Index);
                    var cells = row.Cells.Cast<DataGridViewCell>();
                    sb.AppendLine(string.Join(";", cells.Select(cell => "\"" + cell.Value + "\"").ToArray()));

                }



            }
            System.IO.File.WriteAllText(filePath, sb.ToString());
        }

        private void dataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            int columnIndex = e.ColumnIndex;
            if (columnIndex == 6 || columnIndex == 7)
            {
                string value = e.FormattedValue.ToString();
                if (!value.All(char.IsDigit))
                {
                    dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
                    MessageBox.Show(this, "Niepoprawny typ liczbowy", "Bład", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
                }
            }
            if (columnIndex == 5 || columnIndex == 13 || columnIndex == 11 || columnIndex == 2)
            {
                string value = e.FormattedValue.ToString();
                if (!value.All(char.IsLetterOrDigit))
                {
                    dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
                    MessageBox.Show(this, "Niepoprawny format. Te pole może się skłądać z liter i liczb", "Bład", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
                }
            }
            if (columnIndex == 8 || columnIndex == 9 || columnIndex == 12)
            {
                string pattern = @"^[0-9]{2}[A-Z]{2}$";

                string value = e.FormattedValue.ToString();
                if (!Regex.IsMatch(value, pattern))
                {
                    dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
                    MessageBox.Show(this, "Dane muszą być w formacie np 100GB lub 25GB", "Bład", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
                }
            }
            if (columnIndex == 0 || columnIndex == 4 || columnIndex == 11 && columnIndex == 14 || columnIndex == 3)
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
            if (columnIndex == 10)
            {
                string pattern = @"^[A-Z]{3}$";

                string value = e.FormattedValue.ToString();
                if (!Regex.IsMatch(value, pattern))
                {
                    dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
                    MessageBox.Show(this, "Dane mogą zawierać 3 duże litery", "Bład", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
                }
            }


        }

        private void xmlExport_Click(object sender, EventArgs e)
        {
            string filePath = "";
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Pliki XML (*.xml)|*.xml";
            if (save.ShowDialog() == DialogResult.OK)
            {
                filePath = save.FileName;
            }
            DateTime date = DateTime.Now;
            XElement root = new XElement("Laptops","");
            root.SetAttributeValue("moddate", date.ToString("yyyy-MM-dd T HH:mm:ss"));
            XDocument document = new XDocument(root);
            XElement size_screen = new XElement("size", "");
            XElement resolution = new XElement("resolution", "");
            XElement screen = new XElement("screen");
            screen.SetAttributeValue("touch", "");
            XElement screen_type = new XElement("type", "");
            screen.Add(resolution);
            screen.Add(size_screen);
            screen.Add(screen_type);
           root.Add(screen);
            XElement procesor = new XElement("processor");
            XElement processor_name = new XElement("name", "");
            XElement physical_cores = new XElement("physical_cores", "");
            XElement clock_speed = new XElement("clock_speed", "");
            procesor.Add(processor_name);
            procesor.Add(physical_cores);
            procesor.Add(clock_speed);
            root.Add(procesor);
            XElement ram = new XElement("ram", "");
            root.Add(ram);
            XElement disc = new XElement("disc");
            disc.SetAttributeValue("type", "");
            XElement storage = new XElement("storage", "");
            disc.Add(storage);
            root.Add(disc);
            XElement graphic_card = new XElement("graphic_card", "");
            XElement name_card = new XElement("name", "");
            graphic_card.Add(name_card);
            XElement gpu_memory = new XElement("memory", "");
            graphic_card.Add(gpu_memory);
            root.Add(graphic_card);
            XElement os = new XElement("os", "Windows 10");
            root.Add(os);
            XElement disc_reader = new XElement("disc_reader", "");
            root.Add(disc_reader);
            disc_reader.Add("Blue-ray");
            document.Save(filePath);
            object[] cellValues = new object[dataGridView.Columns.Count];
            DataSet dataSet = new DataSet();
            DataTable dt = new DataTable();
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    cellValues[i] = row.Cells[i].Value;
                }
                dt.Rows.Add(cellValues);

            }
            dataSet.Tables.Add(dt);

        }



        private void importXML_Click(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Pliki XML (*.xml)|*.xml";
            if (open.ShowDialog() == DialogResult.OK)
            {
                XElement root = XElement.Load(open.FileName);
                XElement os = root.Element("os");
                XElement drive = root.Element("disc_reader");
                string os_string = (string)os;
                string optical_drive = (string)drive;
                Console.WriteLine("Dane " + os_string + " " + optical_drive);

                








            }


        }
    }
}

