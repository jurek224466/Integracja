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
            gui.Rows.Clear();
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
                    string screen_touch = node.SelectSingleNode("screen").Attributes["touch"].Value;
                    gui.Rows[values - 1].Cells[4].Value = screen_touch;
                    string ram = node.SelectSingleNode("ram").InnerText;
                    gui.Rows[values - 1].Cells[8].Value = ram;
                    string gpu_name = node.SelectSingleNode("graphic_card").SelectSingleNode("name").InnerText;
                    gui.Rows[values - 1].Cells[11].Value = gpu_name;
                    string gpu_memory = node.SelectSingleNode("graphic_card").SelectSingleNode("memory").InnerText;
                    gui.Rows[values - 1].Cells[12].Value = gpu_memory;
                    string disc_storage = node.SelectSingleNode("disc").SelectSingleNode("storage").InnerText;
                    gui.Rows[values - 1].Cells[9].Value = disc_storage;
                    string disc_type = node.SelectSingleNode("disc").SelectSingleNode("storage").Attributes["type"].Value;
                    gui.Rows[values - 1].Cells[10].Value = disc_type;
                    string os_name = node.SelectSingleNode("os").InnerText;
                    gui.Rows[values - 1].Cells[13].Value = os_name;
                    string disc_reader = node.SelectSingleNode("disc_reader").InnerText;
                    gui.Rows[values - 1].Cells[14].Value = disc_reader;
                   
                    
                }
               




            }
            
        }
        public void ExportXML()
        {
            string filePath = "";
            RemoveAddInformation();
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Pliki XML (*.xml)|*.xml";
            if (save.ShowDialog() == DialogResult.OK)
            {
                filePath = save.FileName;
            }
            if (filePath != null && filePath != "")
            {

                DateTime date = DateTime.Now;
                XElement root = new XElement("Laptops", "");
                root.SetAttributeValue("moddate", date.ToString("yyyy-MM-dd T HH:mm:ss"));
                XDocument document = new XDocument();
                document.AddFirst(root);
                for (int i = 0; i < gui.Rows.Count - 1; i++)
                {

                    XElement size_screen = new XElement("size");
                    XElement resolution = new XElement("resolution");
                    XElement screen = new XElement("screen");
                    XElement screen_type = new XElement("type");
                    XElement manufacturer = new XElement("manufacturer");
                    XElement element = new XElement("laptop");
                    XElement procesor = new XElement("processor");
                    XElement processor_name = new XElement("name");
                    XElement physical_cores = new XElement("physical_cores");
                    XElement clock_speed = new XElement("clock_speed");
                    XElement ram = new XElement("ram");
                    XElement disc = new XElement("disc");
                    XElement storage = new XElement("storage");
                    XElement graphic_card = new XElement("graphic_card");
                    XElement name_card = new XElement("name");
                    XElement gpu_memory = new XElement("memory");
                    XElement os = new XElement("os");
                    XElement disc_reader = new XElement("disc_reader");

                    screen.Add(resolution);
                    root.Add(element);
                    element.Add(manufacturer);
                    element.Add(screen);

                    procesor.Add(processor_name);
                    graphic_card.Add(name_card);
                    element.Add(ram);
                    procesor.Add(physical_cores);
                    procesor.Add(clock_speed);
                    element.Add(graphic_card);
                    element.Add(procesor);
                    graphic_card.Add(gpu_memory);
                    disc.Add(storage);
                    element.Add(disc);
                    element.Add(os);
                    element.Add(disc_reader);
                    screen.Add(size_screen);
                    screen.Add(screen_type);






                    int licznik = i + 1;
                    element.SetAttributeValue("id", licznik);
                    manufacturer.Add(gui.Rows[i].Cells[0].Value);
                    size_screen.Add(gui.Rows[i].Cells[1].Value);
                    resolution.Add(gui.Rows[i].Cells[2].Value);
                    screen_type.Add(gui.Rows[i].Cells[3].Value);
                    screen.SetAttributeValue("touch", gui.Rows[i].Cells[4].Value);
                    processor_name.Add(gui.Rows[i].Cells[5].Value);
                    clock_speed.Add(gui.Rows[i].Cells[7].Value);
                    physical_cores.Add(gui.Rows[i].Cells[6].Value);
                    ram.Add(gui.Rows[i].Cells[8].Value);
                    storage.Add(gui.Rows[i].Cells[9].Value);
                    disc.SetAttributeValue("type", gui.Rows[i].Cells[10].Value);
                    name_card.Add(gui.Rows[i].Cells[11].Value);
                    gpu_memory.Add(gui.Rows[i].Cells[12].Value);
                    os.Add(gui.Rows[i].Cells[13].Value);
                    disc_reader.Add(gui.Rows[i].Cells[14].Value);

                }
                document.Save(filePath);
             
                AddCustomInformation();


            }
        }
        public void RemoveAddInformation()
        {
            for(int i = 0; i < gui.Rows.Count; i++)
            {
                for(int j = 0; j < gui.Columns.Count;j++)
                {
                    if (gui.Rows[i].Cells[j].Value == "brak informacji")
                    {
                        gui.Rows[i].Cells[j].Value = "";
                    }
                }
            }
        }
        public void AddCustomInformation()
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
