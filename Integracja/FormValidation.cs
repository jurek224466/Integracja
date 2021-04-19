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
       
        private Form gui;
        public FormValidation(DataGridView item,Form1 main_gui)
        {
            dataGridView = item;
            gui = main_gui;
          
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
            
            if (dataGridView.Rows.Count>=2)
            {
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    dataGridView.Rows[e.RowIndex].Cells[i].Style.BackColor = Color.Green;
                }
            }
           
           
        }
       public void CheckDuplicate()
        {
            bool isDuplicate;
            if (dataGridView.Rows.Count > 1)
            {
                for (int nbRow = 0; nbRow < dataGridView.Rows.Count; nbRow++)
                {
                    for (int nbRowCompare = nbRow; nbRowCompare < dataGridView.Rows.Count; nbRowCompare++)
                    {
                        isDuplicate = true;

                        for (int nbCol = 0; nbCol < dataGridView.Rows[nbRow].Cells.Count; nbCol++)
                        {
                            if (dataGridView[nbCol, nbRow].Value != dataGridView[nbCol, nbRowCompare])
                            {
                                isDuplicate = false;
                                break;     //Exit for each column if they are not duplicate
                            }
                        }

                        if (isDuplicate)
                        {
                            for (int i = 0; i < dataGridView.Columns.Count; i++)
                            {
                                dataGridView.Rows[nbRow].Cells[i].Style.BackColor = Color.Red;
                            }
                        }
                    }
                }
            }
           
        }
        
    }
}
