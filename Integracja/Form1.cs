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
                Files files = new Files(dataGridView);
                files.ImportTextFileToAplication(open.FileName);

            }

        }

        private void save_file_Click(object sender, EventArgs e)
        {



            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Pliki tekstowe (*.txt)|*.txt";
            if (save.ShowDialog() == DialogResult.OK)
            {
                Files files = new Files(dataGridView);
                files.ExportDatatoTextFile(save.FileName);

            }

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
            XmlParsing export = new XmlParsing(dataGridView);
            export.ExportXML();
        }



        private void importXML_Click(object sender, EventArgs e)
        {

            XmlParsing import = new XmlParsing(dataGridView);
            import.ImportXML();

        }
    }
}

