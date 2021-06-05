using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace TestingGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            [DllImport("FindCaptureDevice.dll")]
            public static extern StringBuilder GetDeviceName(int index);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Drugi przycisk");
          
        }
    }
}
