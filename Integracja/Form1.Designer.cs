
namespace Integracja
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.screen_size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sceen_resolution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_screen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.touch_screen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpu_speed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thread_cpu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ram_size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storage_size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_storage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpu_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpu_ram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.os = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optical_drive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.read_file = new System.Windows.Forms.Button();
            this.save_file = new System.Windows.Forms.Button();
            this.xmlExport = new System.Windows.Forms.Button();
            this.importXML = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.brand,
            this.screen_size,
            this.sceen_resolution,
            this.type_screen,
            this.touch_screen,
            this.cpu,
            this.cpu_speed,
            this.thread_cpu,
            this.ram_size,
            this.storage_size,
            this.type_storage,
            this.gpu_name,
            this.gpu_ram,
            this.os,
            this.optical_drive});
            this.dataGridView.Location = new System.Drawing.Point(31, 96);
            this.dataGridView.MaximumSize = new System.Drawing.Size(1600, 1600);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1600, 814);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView_CellValidating);
            // 
            // brand
            // 
            this.brand.HeaderText = "Firma";
            this.brand.Name = "brand";
            // 
            // screen_size
            // 
            this.screen_size.HeaderText = "Wielkość ekranu";
            this.screen_size.Name = "screen_size";
            // 
            // sceen_resolution
            // 
            this.sceen_resolution.HeaderText = "Rozdzielczość ekranu";
            this.sceen_resolution.Name = "sceen_resolution";
            // 
            // type_screen
            // 
            this.type_screen.HeaderText = "Typ ekranu";
            this.type_screen.Name = "type_screen";
            // 
            // touch_screen
            // 
            this.touch_screen.HeaderText = "Czz jest dotykowy ?";
            this.touch_screen.Name = "touch_screen";
            // 
            // cpu
            // 
            this.cpu.HeaderText = "Procesor";
            this.cpu.Name = "cpu";
            // 
            // cpu_speed
            // 
            this.cpu_speed.HeaderText = "Taktowanie procesora";
            this.cpu_speed.Name = "cpu_speed";
            // 
            // thread_cpu
            // 
            this.thread_cpu.HeaderText = "Rdzenie procesora";
            this.thread_cpu.Name = "thread_cpu";
            // 
            // ram_size
            // 
            this.ram_size.HeaderText = "Wielkość pamięci RAM";
            this.ram_size.Name = "ram_size";
            // 
            // storage_size
            // 
            this.storage_size.HeaderText = "Wielkość pamięci masowej";
            this.storage_size.Name = "storage_size";
            // 
            // type_storage
            // 
            this.type_storage.HeaderText = "Typ pamięci";
            this.type_storage.Name = "type_storage";
            // 
            // gpu_name
            // 
            this.gpu_name.HeaderText = "Nazwa karty graficznej";
            this.gpu_name.Name = "gpu_name";
            // 
            // gpu_ram
            // 
            this.gpu_ram.HeaderText = "Pamieć RAM karty graficznej";
            this.gpu_ram.Name = "gpu_ram";
            // 
            // os
            // 
            this.os.HeaderText = "System operacyjny";
            this.os.Name = "os";
            // 
            // optical_drive
            // 
            this.optical_drive.HeaderText = "Napęd optyczny";
            this.optical_drive.Name = "optical_drive";
            // 
            // read_file
            // 
            this.read_file.Location = new System.Drawing.Point(77, 29);
            this.read_file.Name = "read_file";
            this.read_file.Size = new System.Drawing.Size(128, 46);
            this.read_file.TabIndex = 1;
            this.read_file.Text = "Wczytaj z pliku";
            this.read_file.UseVisualStyleBackColor = true;
            this.read_file.Click += new System.EventHandler(this.read_file_Click);
            // 
            // save_file
            // 
            this.save_file.Location = new System.Drawing.Point(221, 27);
            this.save_file.Name = "save_file";
            this.save_file.Size = new System.Drawing.Size(179, 47);
            this.save_file.TabIndex = 2;
            this.save_file.Text = "Zapisz do pliku";
            this.save_file.UseVisualStyleBackColor = true;
            this.save_file.Click += new System.EventHandler(this.save_file_Click);
            // 
            // xmlExport
            // 
            this.xmlExport.Location = new System.Drawing.Point(406, 30);
            this.xmlExport.Name = "xmlExport";
            this.xmlExport.Size = new System.Drawing.Size(124, 44);
            this.xmlExport.TabIndex = 3;
            this.xmlExport.Text = "Exportuj do XML";
            this.xmlExport.UseVisualStyleBackColor = true;
            this.xmlExport.Click += new System.EventHandler(this.xmlExport_Click);
            // 
            // importXML
            // 
            this.importXML.Location = new System.Drawing.Point(548, 30);
            this.importXML.Name = "importXML";
            this.importXML.Size = new System.Drawing.Size(140, 47);
            this.importXML.TabIndex = 4;
            this.importXML.Text = "Importuj do XML";
            this.importXML.UseVisualStyleBackColor = true;
            this.importXML.Click += new System.EventHandler(this.importXML_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1899, 901);
            this.Controls.Add(this.importXML);
            this.Controls.Add(this.xmlExport);
            this.Controls.Add(this.save_file);
            this.Controls.Add(this.read_file);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "Integracja- Jerzy Antoniuk";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button read_file;
        private System.Windows.Forms.Button save_file;
        public System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn screen_size;
        private System.Windows.Forms.DataGridViewTextBoxColumn sceen_resolution;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_screen;
        private System.Windows.Forms.DataGridViewTextBoxColumn touch_screen;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpu_speed;
        private System.Windows.Forms.DataGridViewTextBoxColumn thread_cpu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ram_size;
        private System.Windows.Forms.DataGridViewTextBoxColumn storage_size;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_storage;
        private System.Windows.Forms.DataGridViewTextBoxColumn gpu_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn gpu_ram;
        private System.Windows.Forms.DataGridViewTextBoxColumn os;
        private System.Windows.Forms.DataGridViewTextBoxColumn optical_drive;
        private System.Windows.Forms.Button xmlExport;
        private System.Windows.Forms.Button importXML;
    }
}

