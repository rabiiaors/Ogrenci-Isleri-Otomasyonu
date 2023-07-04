namespace WindowsFormsApp1
{
    partial class Form12
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.öğrenciAdıDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dönemSonuNotuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciisleriDataSet3 = new WindowsFormsApp1.ogrenciisleriDataSet3();
            this.notTableAdapter = new WindowsFormsApp1.ogrenciisleriDataSet3TableAdapters.notTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciisleriDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Brown;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.öğrenciAdıDataGridViewTextBoxColumn,
            this.dönemSonuNotuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.notBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(324, 467);
            this.dataGridView1.TabIndex = 0;
            // 
            // öğrenciAdıDataGridViewTextBoxColumn
            // 
            this.öğrenciAdıDataGridViewTextBoxColumn.DataPropertyName = "öğrenci adı";
            this.öğrenciAdıDataGridViewTextBoxColumn.HeaderText = "öğrenci adı";
            this.öğrenciAdıDataGridViewTextBoxColumn.Name = "öğrenciAdıDataGridViewTextBoxColumn";
            // 
            // dönemSonuNotuDataGridViewTextBoxColumn
            // 
            this.dönemSonuNotuDataGridViewTextBoxColumn.DataPropertyName = "dönem sonu notu";
            this.dönemSonuNotuDataGridViewTextBoxColumn.HeaderText = "dönem sonu notu";
            this.dönemSonuNotuDataGridViewTextBoxColumn.Name = "dönemSonuNotuDataGridViewTextBoxColumn";
            // 
            // notBindingSource
            // 
            this.notBindingSource.DataMember = "not";
            this.notBindingSource.DataSource = this.ogrenciisleriDataSet3;
            // 
            // ogrenciisleriDataSet3
            // 
            this.ogrenciisleriDataSet3.DataSetName = "ogrenciisleriDataSet3";
            this.ogrenciisleriDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // notTableAdapter
            // 
            this.notTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(584, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(400, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 16);
            this.label3.TabIndex = 69;
            this.label3.Text = "Aranacak personel adı";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlText;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(584, 50);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 23);
            this.button5.TabIndex = 68;
            this.button5.Text = "bul";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlText;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(584, 89);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 23);
            this.button4.TabIndex = 67;
            this.button4.Text = "verileri göster";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Transparent;
            this.button11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button11.BackgroundImage")));
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button11.Location = new System.Drawing.Point(776, 5);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(56, 39);
            this.button11.TabIndex = 71;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Brown;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(351, 157);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(580, 257);
            this.listView1.TabIndex = 72;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "                      Öğrenci Adı";
            this.columnHeader1.Width = 248;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "                     Dönem sonu notu";
            this.columnHeader2.Width = 382;
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(999, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form12";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form12";
            this.Load += new System.EventHandler(this.Form12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciisleriDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ogrenciisleriDataSet3 ogrenciisleriDataSet3;
        private System.Windows.Forms.BindingSource notBindingSource;
        private ogrenciisleriDataSet3TableAdapters.notTableAdapter notTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn öğrenciAdıDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dönemSonuNotuDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}