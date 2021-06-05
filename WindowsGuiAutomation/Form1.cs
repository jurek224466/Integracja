using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsGuiAutomation
{
    public partial class Form1 : Form
    {
        public const int BM_CLICK = 0x00F5;
        public Form1()
        {
            InitializeComponent();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {


          
        }
       

        private void PushOKButton(IntPtr ptrWindow)
        {
          /*  [DllImport("user32.dll", SetLastError = true)]
            static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

            public static IntPtr FindWindow(string caption)
            {
                return FindWindow(String.Empty, caption);
            }*/
        }

    }
}

