using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integracja
{
    public class FileMethods
    {
     
        public void saveFile(String filePath)
        {

            var sb = new StringBuilder();
            Form1 gui = new Form1();
            var headers = gui.dataGridView.Columns.Cast<DataGridViewColumn>();
            sb.AppendLine(string.Join(",", headers.Select(column => "\"" + column.HeaderText + "\"").ToArray()));

            foreach (DataGridViewRow row in gui.dataGridView.Rows)
            {
                var cells = row.Cells.Cast<DataGridViewCell>();
                sb.AppendLine(string.Join(";", cells.Select(cell => "\"" + cell.Value + "\"").ToArray()));
            }
            System.IO.File.WriteAllText(filePath, sb.ToString());
        }
        public void openFile(String filePath)
        {
            Data data = new Data();
            StreamReader reader = new StreamReader(filePath);
            int i = 0;
            while (reader.ReadLine() != null)
            {
                i++;
                var line = reader.ReadLine();
                
                data.List.Add(line);

            }
            {

            }

        }
    }
}
