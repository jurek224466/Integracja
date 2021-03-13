using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integracja
{
  
    public class Data
    {
        List<string> list = new System.Collections.Generic.List<string>();
        public List<DataGridViewRow> rows = new List<DataGridViewRow>();
      
        public List<string> List { get => list; set => list = value; }
      
    }
}
