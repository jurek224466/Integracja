using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integracja
{
    class FormValidation
    {
        private DataGridView dataGridView = new DataGridView();

        private Form1 gui = new Form1();
        Label label1 = new Label();
        Label label2 = new Label();
        public FormValidation(DataGridView item, Form1 main_gui)
        {
            dataGridView = item;
            gui = main_gui;

        }
        public FormValidation(DataGridView item)
        {
            dataGridView = item;
        }
        public FormValidation(Label label1, Label label2)
        {
            this.label1 = label1;
            this.label2 = label2;

        }
        public void ValidateCelling(object sender, DataGridViewCellValidatingEventArgs e)
        {
            int columnIndex = e.ColumnIndex;
            if (columnIndex == 6 || columnIndex == 7)
            {
                string value = e.FormattedValue.ToString();
                if (!value.All(char.IsDigit))
                {
                    dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
                    MessageBox.Show(gui, "Niepoprawny typ liczbowy", "Bład", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show(gui, "Niepoprawny format. Te pole może się skłądać z liter i liczb", "Bład", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show(gui, "Dane muszą być w formacie np 100GB lub 25GB", "Bład", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show(gui, "Niepoprawny typ znakowy", "Bład", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show(gui, "Dane mogą zawierać 3 duże litery", "Bład", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
                }
            }


        }
        public void ChangeValues(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView.Rows.Count >= 2)
            {
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    dataGridView.Rows[e.RowIndex].Cells[i].Style.BackColor = Color.Green;
                }
            }


        }
        public void CheckDuplicate()
        {
            int duplicateRows = 0;
            for (int currentRow = 0; currentRow <dataGridView.Rows.Count; currentRow++)
            {
                DataGridViewRow rowToCompare = dataGridView.Rows[currentRow];

                for (int otherRow = currentRow + 1; otherRow <dataGridView.Rows.Count; otherRow++)
                {
                    DataGridViewRow row = dataGridView.Rows[otherRow];

                    bool duplicateRow = true;

                    for (int cellIndex = 0; cellIndex <row.Cells.Count; cellIndex++)
                    {
                        if (!rowToCompare.Cells[cellIndex].Value.Equals(row.Cells[cellIndex].Value))
                        {
                            duplicateRow = false;
                            break;
                        }
                    }

                    if (duplicateRow)
                    {
                        duplicateRows++;
                        gui.label2.Text = "Liczba duplikatów: " + duplicateRows;
                        Console.WriteLine("Row duplicated"+otherRow);
                        for(int color = 0; color < dataGridView.Columns.Count; color++)
                        {
                            dataGridView.Rows[otherRow].Cells[color].Style.BackColor = Color.Red;
                        }
                        
                        
                    }
                }
            }
        }
        public void RemoveAddInformation()
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    if (dataGridView.Rows[i].Cells[j].Value == "brak informacji")
                    {
                        dataGridView.Rows[i].Cells[j].Value = "";
                    }
                }
            }
        }
        public void AddCustomInformation()
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    if (dataGridView.Rows[i].Cells[j].Value == "")
                    {
                        dataGridView.Rows[i].Cells[j].Value = "brak informacji";
                    }
                }
            }
        }
    }
}
    

