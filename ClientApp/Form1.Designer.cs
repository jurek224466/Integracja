
namespace ClientApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.laptopCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ScreenChooseComboBox = new System.Windows.Forms.ComboBox();
            this.brandChooseComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(644, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "wybór matrycy";
            // 
            // laptopCount
            // 
            this.laptopCount.AutoSize = true;
            this.laptopCount.Location = new System.Drawing.Point(388, 61);
            this.laptopCount.Name = "laptopCount";
            this.laptopCount.Size = new System.Drawing.Size(84, 13);
            this.laptopCount.TabIndex = 1;
            this.laptopCount.Text = "Liczba laptopów";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "wybór producenta";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(869, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "lista producentów z matrycą";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(267, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 38);
            this.button2.TabIndex = 4;
            this.button2.Text = "liczba laptopów producenta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ScreenChooseComboBox
            // 
            this.ScreenChooseComboBox.FormattingEnabled = true;
            this.ScreenChooseComboBox.Location = new System.Drawing.Point(742, 58);
            this.ScreenChooseComboBox.Name = "ScreenChooseComboBox";
            this.ScreenChooseComboBox.Size = new System.Drawing.Size(121, 21);
            this.ScreenChooseComboBox.TabIndex = 5;
            this.ScreenChooseComboBox.Text = "One";
            this.ScreenChooseComboBox.SelectedIndexChanged += new System.EventHandler(this.ScreenChooseComboBox_SelectedIndexChanged);
            // 
            // brandChooseComboBox
            // 
            this.brandChooseComboBox.FormattingEnabled = true;
            this.brandChooseComboBox.Location = new System.Drawing.Point(140, 53);
            this.brandChooseComboBox.Name = "brandChooseComboBox";
            this.brandChooseComboBox.Size = new System.Drawing.Size(121, 21);
            this.brandChooseComboBox.TabIndex = 6;
            this.brandChooseComboBox.SelectedIndexChanged += new System.EventHandler(this.brandChooseComboBox_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
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
            this.dataGridView1.Location = new System.Drawing.Point(31, 142);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(1600, 1600);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1600, 768);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // brand
            // 
            this.brand.HeaderText = "Firma";
            this.brand.Name = "brand";
            // 
            // screen_size
            // 
            this.screen_size.HeaderText = "Wielkosc ";
            this.screen_size.Name = "screen_size";
            // 
            // screen_resolution
            // 
            this.screen_resolution.HeaderText = "Rozdzielczosc";
            this.screen_resolution.Name = "screen_resolution";
            // 
            // type_screen
            // 
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(549, 49);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 40);
            this.button3.TabIndex = 7;
            this.button3.Text = "Załaduj dane z serwera";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 664);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.brandChooseComboBox);
            this.Controls.Add(this.ScreenChooseComboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.laptopCount);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Integracja- Aplikacja kliencka";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label laptopCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox ScreenChooseComboBox;
        private System.Windows.Forms.ComboBox brandChooseComboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
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
        private System.Windows.Forms.Button button3;
    }
}

