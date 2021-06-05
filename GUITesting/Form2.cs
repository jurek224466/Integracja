using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUITesting
{
    public partial class Form2 : Form
    {
        public static WindowsDriver<WindowsElement> driver = null;
        AppiumOptions option = new AppiumOptions();
        WindowsDriver<WindowsElement> windowsDriver;
        List<String> lista = new List<string>();
        public Form2()
        {
            InitializeComponent();
            Process.Start(@"C:\Program Files (x86)\Windows Application Driver\WinAppDriver.exe");
            option.AddAdditionalCapability("app", @"C:\Users\Jurek\OneDrive - pollubstudent\Pulpit\Studia\Politechnika\3 semestr\Integracja systemów\lab\Integracja\Integracja\bin\Debug\Integracja.exe");
            windowsDriver = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), option);
        }


        private void button1_Click(object sender, EventArgs e)
        {

            UpdateValues("one", "one");
            if (checkBoxXML.Checked)
            {

            }
        }






        public void UpdateValues(String collumnName, String cellName)
        {

          
            
            foreach (var checkBox in this.Controls.OfType<CheckBox>().Where(c => c.Checked))
            {
                lista.Add(checkBox.Name);
            }
            ChangeDataGridValues();
            if (checkBoxXML.Checked)
            {

            }
        }
        public void ChangeDataGridValues()
        {
            
            var clickImport = windowsDriver.FindElementByName("Import from DataBase");

            clickImport.Click();
            var datagridview2 = windowsDriver.FindElementByAccessibilityId("dataGridView");
/*
            datagridview2.FindElementByName("Firma Wiersz 4, Nie posortowano.").Click();
            datagridview2.FindElementByName("Firma Wiersz 4, Nie posortowano.").SendKeys("Test");
            datagridview2.FindElementByName("Procesor Wiersz 2, Nie posortowano.").Click();
            datagridview2.FindElementByName("Procesor Wiersz 2, Nie posortowano.").SendKeys("Test2");
            datagridview2.FindElementByName("Firma Wiersz 1, Nie posortowano.").Click();
            datagridview2.FindElementByName("Firma Wiersz 1, Nie posortowano.").SendKeys("One");
            datagridview2.FindElementByName("Napęd optyczny Wiersz 10, Nie posortowano.").Click();
            datagridview2.FindElementByName("Napęd optyczny Wiersz 10, Nie posortowano.").SendKeys("BlueRay");*/
            windowsDriver.FindElementByAccessibilityId("Integracja- Jerzy Antoniuk").SendKeys("{ALT}+{F4}");
           
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

