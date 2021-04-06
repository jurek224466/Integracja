using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Integracja
{
    public class XmlParsing
    {
       DataGridView gui = new DataGridView();
       public XmlParsing(DataGridView f)
        {
            gui = f;
        }
        public void ImportXML()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Pliki XML (*.xml)|*.xml";
           
            if (open.ShowDialog() == DialogResult.OK)
            {

                XmlDocument serverDoc = new XmlDocument();
                serverDoc.Load(open.FileName);
                XmlNodeList xml = serverDoc.SelectNodes("Laptops/laptop");
                gui.Rows.Add();
                foreach (XmlNode node in xml)
                {

                    int values = Int32.Parse(node.Attributes["id"].InnerText);
                    string manufacturer_name = node.SelectSingleNode("manufacturer").InnerText;
                    gui.Rows[values - 1].Cells[0].Value = manufacturer_name;
                    string processor_name = node.SelectSingleNode("processor").SelectSingleNode("name").InnerText;
                    gui.Rows[values - 1].Cells[5].Value = processor_name;
                    string clock_speed = node.SelectSingleNode("processor").SelectSingleNode("clock_speed").InnerText;
                    gui.Rows[values - 1].Cells[6].Value = clock_speed;
                    string physical_cores = node.SelectSingleNode("processor").SelectSingleNode("physical_cores").InnerText;
                    gui.Rows[values - 1].Cells[7].Value = physical_cores;
                    string screen_resolution = node.SelectSingleNode("screen").SelectSingleNode("resolution").InnerText;
                    gui.Rows[values - 1].Cells[2].Value = screen_resolution;
                    string screen_size = node.SelectSingleNode("screen").SelectSingleNode("size").InnerText;
                    gui.Rows[values - 1].Cells[1].Value = screen_size;
                    string screen_type = node.SelectSingleNode("screen").SelectSingleNode("type").InnerText;
                    gui.Rows[values - 1].Cells[3].Value = screen_type;
                    string screen_touch = node.SelectSingleNode("screen").Attributes["touch"].InnerText;
                    gui.Rows[values - 1].Cells[4].Value = screen_touch;
                    string ram = node.SelectSingleNode("ram").InnerText;
                    gui.Rows[values - 1].Cells[8].Value = ram;
                    string gpu_name = node.SelectSingleNode("graphic_card").SelectSingleNode("name").InnerText;
                    gui.Rows[values - 1].Cells[11].Value = gpu_name;
                    string gpu_memory = node.SelectSingleNode("graphic_card").SelectSingleNode("memory").InnerText;
                    gui.Rows[values - 1].Cells[12].Value = gpu_memory;
                    string disc_storage = node.SelectSingleNode("disc").SelectSingleNode("storage").InnerText;
                    gui.Rows[values - 1].Cells[9].Value = disc_storage;
                    string disc_type = node.SelectSingleNode("disc").Attributes["type"].InnerText;
                    gui.Rows[values - 1].Cells[10].Value = disc_type;
                    string os_name = node.SelectSingleNode("os").InnerText;
                    gui.Rows[values - 1].Cells[13].Value = os_name;
                    string disc_reader = node.SelectSingleNode("disc_reader").InnerText;
                    gui.Rows[values - 1].Cells[14].Value = disc_reader;
                    gui.Rows.Add();
                }





            }

        }
        public void ExportXML()
        {
            string filePath = "";
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Pliki XML (*.xml)|*.xml";
            if (save.ShowDialog() == DialogResult.OK)
            {
                filePath = save.FileName;
            }
            DateTime date = DateTime.Now;
            XElement root = new XElement("Laptops", "");
            root.SetAttributeValue("moddate", date.ToString("yyyy-MM-dd T HH:mm:ss"));
            XDocument document = new XDocument(root);
            for (int i = 0; i < 5; i++)
            {

                XElement size_screen = new XElement("size", "");
                XElement resolution = new XElement("resolution", "");
                XElement screen = new XElement("screen");
                screen.SetAttributeValue("touch", "nie");
                XElement screen_type = new XElement("type", "");
                screen.Add(resolution);
                resolution.Add("1920x1200");
                size_screen.Add("14");
                screen_type.Add("matowa");
                screen.Add(size_screen);
                screen.Add(screen_type);
                XElement manufacturer = new XElement("manufacturer", "");
                manufacturer.Add("Asus");
                XElement element = new XElement("laptop", "");
                int licznik = i + 1;
                element.SetAttributeValue("id", licznik);
                root.Add(element);
                element.Add(manufacturer);
                element.Add(screen);
                XElement procesor = new XElement("processor");
                XElement processor_name = new XElement("name", "");
                XElement physical_cores = new XElement("physical_cores", "");
                XElement clock_speed = new XElement("clock_speed", "");
                procesor.Add(processor_name);
                procesor.Add(physical_cores);
                procesor.Add(clock_speed);
                element.Add(procesor);
                physical_cores.Add("5");
                clock_speed.Add("2400");
                XElement ram = new XElement("ram", "8GB");
                element.Add(ram);
                XElement disc = new XElement("disc");
                disc.SetAttributeValue("type", "SSD");
                XElement storage = new XElement("storage", "");
                disc.Add(storage);
                storage.Add("500GB");
                element.Add(disc);
                XElement graphic_card = new XElement("graphic_card", "");
                XElement name_card = new XElement("name", "");
                name_card.Add("Nvidia");
                graphic_card.Add(name_card);
                XElement gpu_memory = new XElement("memory", "");
                graphic_card.Add(gpu_memory);
                element.Add(graphic_card);
                XElement os = new XElement("os", "Windows 10");
                element.Add(os);
                XElement disc_reader = new XElement("disc_reader", "DVD");
                element.Add(disc_reader);



            }
            document.Save(filePath);

        }
    }
}
