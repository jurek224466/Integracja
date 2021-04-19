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

        private GuiFormating guiFormating = new GuiFormating();
        public Form1()
        {
            InitializeComponent();
            dataGridView.CellValidating += DataGridView_CellValidating;
            dataGridView.CellEndEdit += DataGridView_CellValueChanged;
            dataGridView.RowsAdded += DataGridView_RowsAdded;
          /*  guiFormating.setBaseColor(dataGridView);*/
        }

        private void DataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            FormValidation validation = new FormValidation(dataGridView, this);
            if (e.RowCount > 0)
            {
                
                dataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Gray;
                validation.CheckDuplicate();
            }
           
        }

        private void DataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            FormValidation validation = new FormValidation(dataGridView, this);
        
            validation.ChangeValues(sender, e);
          

        }

        private void DataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
           
                FormValidation validation = new FormValidation(dataGridView, this);
                validation.ValidateCelling(sender, e);
                validation.CheckDuplicate();

        }
       

        private void read_file_Click(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Pliki tekstowe (*.txt)|*.txt";
            if (open.ShowDialog() == DialogResult.OK)
            {
                FilesMethods files = new FilesMethods(dataGridView);
                files.ImportTextFileToAplication(open.FileName);

            }

        }

        private void save_file_Click(object sender, EventArgs e)
        {



            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Pliki tekstowe (*.txt)|*.txt";
            if (save.ShowDialog() == DialogResult.OK)
            {
                FilesMethods files = new FilesMethods(dataGridView);
                files.ExportDatatoTextFile(save.FileName);

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

        private void exportDB_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase(dataGridView);
            dataBase.ExportData();
        }

        private void importFromDB_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase(dataGridView);
            dataBase.ImportData();
        }
    }
}

