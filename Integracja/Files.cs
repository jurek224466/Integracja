using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integracja
{
    class Files
    {
        DataGridView gui = new DataGridView();

        public Files(DataGridView item)
        {
            gui = item;
        }
        public void ImportTextFileToAplication(String filePath)
        {
            gui.Rows.Clear();
            gui.ReadOnly = false;
            string[] lines = System.IO.File.ReadAllLines(filePath);
            string[] values = new string[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {

                values = lines[i].Split(';');
                i = gui.Rows.Add();
                for (int j = 0; j < values.Length - 1; j++)
                {
                    if (values[j] == null || values[j] == "")
                    {
                        gui.Rows[i].Cells[j].Value = "brak informacji";

                    }
                    else
                    {
                        gui.Rows[i].Cells[j].Value = values[j].ToString();
                    }


                }

            }





        }
        public void ExportDatatoTextFile(String filePath)
        {
            var sb = new StringBuilder();

            /*var headers = dataGridView.Columns.Cast<DataGridViewColumn>(); dodawanie nagłówków do plików
            sb.AppendLine(string.Join(";", headers.Select(column => "\"" + column.HeaderText + "\"").ToArray()));*/

            foreach (DataGridViewRow row in gui.Rows)
            {
                if (row.Index < gui.Rows.Count - 1)
                {
                    Console.WriteLine("Row index : " + row.Index);
                    var cells = row.Cells.Cast<DataGridViewCell>();
                    sb.AppendLine(string.Join(";", cells.Select(cell => "\"" + cell.Value + "\"").ToArray()));

                }



            }
            System.IO.File.WriteAllText(filePath, sb.ToString());
        }
    }
}
