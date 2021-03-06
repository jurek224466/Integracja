
namespace Integracja
{
    partial class IntegracjaForm
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
            this.screen_resolution = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.exportDB = new System.Windows.Forms.Button();
            this.importFromDB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.brand,
            this.screen_size,
            this.screen_resolution,
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
            this.dataGridView.Location = new System.Drawing.Point(31, 142);
            this.dataGridView.MaximumSize = new System.Drawing.Size(1600, 1600);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1600, 768);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.VirtualMode = true;
            // 
            // brand
            // 
            this.brand.DataPropertyName = "brand";
            this.brand.HeaderText = "Firma";
            this.brand.Name = "brand";
            // 
            // screen_size
            // 
            this.screen_size.DataPropertyName = "screen_size";
            this.screen_size.HeaderText = "Wielkosc ";
            this.screen_size.Name = "screen_size";
            // 
            // screen_resolution
            // 
            this.screen_resolution.DataPropertyName = "screen_resolution";
            this.screen_resolution.HeaderText = "Rozdzielczosc";
            this.screen_resolution.Name = "screen_resolution";
            // 
            // type_screen
            // 
            this.type_screen.DataPropertyName = "screen_resolution";
            this.type_screen.HeaderText = "Typ ekranu";
            this.type_screen.Name = "type_screen";
            // 
            // touch_screen
            // 
            this.touch_screen.HeaderText = "Czy jest dotykowy ?";
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
            // exportDB
            // 
            this.exportDB.Location = new System.Drawing.Point(703, 30);
            this.exportDB.Name = "exportDB";
            this.exportDB.Size = new System.Drawing.Size(94, 44);
            this.exportDB.TabIndex = 5;
            this.exportDB.Text = "Export to DataBase";
            this.exportDB.UseVisualStyleBackColor = true;
            this.exportDB.Click += new System.EventHandler(this.exportDB_Click);
            // 
            // importFromDB
            // 
            this.importFromDB.Location = new System.Drawing.Point(815, 30);
            this.importFromDB.Name = "importFromDB";
            this.importFromDB.Size = new System.Drawing.Size(105, 44);
            this.importFromDB.TabIndex = 6;
            this.importFromDB.Text = "Import from DataBase";
            this.importFromDB.UseVisualStyleBackColor = true;
            this.importFromDB.Click += new System.EventHandler(this.importFromDB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // IntegracjaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1899, 901);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.importFromDB);
            this.Controls.Add(this.exportDB);
            this.Controls.Add(this.importXML);
            this.Controls.Add(this.xmlExport);
            this.Controls.Add(this.save_file);
            this.Controls.Add(this.read_file);
            this.Controls.Add(this.dataGridView);
            this.Name = "IntegracjaForm";
            this.Text = "Integracja- Jerzy Antoniuk";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button read_file;
        private System.Windows.Forms.Button save_file;
        private System.Windows.Forms.Button xmlExport;
        private System.Windows.Forms.Button importXML;
        public System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button exportDB;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button importFromDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn screen_size;
        private System.Windows.Forms.DataGridViewTextBoxColumn screen_resolution;
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
    }
}

