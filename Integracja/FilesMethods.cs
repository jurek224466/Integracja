using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integracja
{
    class FilesMethods
    {
        DataGridView gui = new DataGridView();

        public FilesMethods(DataGridView item)
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
                    gui.Rows[i].Cells[j].Value = values[j].ToString();

                }

            }
            AddCustomInformation();
        }
        public void ExportDatatoTextFile(String filePath)
        {
            TextWriter writer = new StreamWriter(filePath);

            var headers = gui.Columns.Cast<DataGridViewColumn>(); //dodawanie nagłówków do plików
            writer.WriteLine(string.Join(";", headers.Select(column => "\"" + column.HeaderText + "\"").ToArray()));
            RemoveAddInformation();
            for(int i = 0; i < gui.Rows.Count-1; i++)
            {
                for(int j = 0; j < gui.Columns.Count; j++)
                {
                    writer.Write(gui.Rows[i].Cells[j].Value + ";");
                }
                writer.WriteLine("");
            }
            writer.Close();
            AddCustomInformation();
           
        }
        private void RemoveAddInformation()
        {
            for (int i = 0; i < gui.Rows.Count; i++)
            {
                for (int j = 0; j < gui.Columns.Count; j++)
                {
                    if (gui.Rows[i].Cells[j].Value == "brak informacji")
                    {
                        gui.Rows[i].Cells[j].Value = "";
                    }
                }
            }
        }
        private void AddCustomInformation()
        {
            for (int i = 0; i < gui.Rows.Count; i++)
            {
                for (int j = 0; j < gui.Columns.Count; j++)
                {
                    if (gui.Rows[i].Cells[j].Value == "")
                    {
                        gui.Rows[i].Cells[j].Value = "brak informacji";
                    }
                }
            }
        }
    }
}
