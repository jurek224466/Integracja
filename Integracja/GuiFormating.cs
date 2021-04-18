using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integracja
{
    public class GuiFormating
    {
        public void setBaseColor(DataGridView data)
        {
           for(int i = 0; i < data.Rows.Count; i++)
            {
                for(int j = 0; j < data.Columns.Count; j++)
                {
                    data.Rows[i].Cells[j].Style.BackColor = Color.Gray;
                }
            }
        }
    }
}
