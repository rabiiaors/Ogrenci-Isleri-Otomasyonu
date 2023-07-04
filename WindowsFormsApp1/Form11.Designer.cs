namespace WindowsFormsApp1
{
    partial class Form11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrenciAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciisleriDataSet2 = new WindowsFormsApp1.ogrenciisleriDataSet2();
            this.dersTableAdapter = new WindowsFormsApp1.ogrenciisleriDataSet2TableAdapters.dersTableAdapter();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciisleriDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Brown;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrenciAdiDataGridViewTextBoxColumn,
            this.odevDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(329, 525);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ogrenciAdiDataGridViewTextBoxColumn
            // 
            this.ogrenciAdiDataGridViewTextBoxColumn.DataPropertyName = "ogrenci adi";
            this.ogrenciAdiDataGridViewTextBoxColumn.HeaderText = "ogrenci adi";
            this.ogrenciAdiDataGridViewTextBoxColumn.Name = "ogrenciAdiDataGridViewTextBoxColumn";
            // 
            // odevDataGridViewTextBoxColumn
            // 
            this.odevDataGridViewTextBoxColumn.DataPropertyName = "odev";
            this.odevDataGridViewTextBoxColumn.HeaderText = "odev";
            this.odevDataGridViewTextBoxColumn.Name = "odevDataGridViewTextBoxColumn";
            // 
            // dersBindingSource
            // 
            this.dersBindingSource.DataMember = "ders";
            this.dersBindingSource.DataSource = this.ogrenciisleriDataSet2;
            // 
            // ogrenciisleriDataSet2
            // 
            this.ogrenciisleriDataSet2.DataSetName = "ogrenciisleriDataSet2";
            this.ogrenciisleriDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dersTableAdapter
            // 
            this.dersTableAdapter.ClearBeforeFill = true;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Brown;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(373, 126);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(580, 300);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "               Öğrenci Adı";
            this.columnHeader1.Width = 242;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "                     Ödevi";
            this.columnHeader2.Width = 211;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "             Numara";
            this.columnHeader3.Width = 595;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(574, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 20);
            this.textBox1.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(390, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 16);
            this.label3.TabIndex = 64;
            this.label3.Text = "Aranacak öğrenci adı";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(574, 59);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(126, 23);
            this.button5.TabIndex = 63;
            this.button5.Text = "bul";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(574, 97);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 23);
            this.button4.TabIndex = 62;
            this.button4.Text = "verileri göster";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Transparent;
            this.button11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button11.BackgroundImage")));
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button11.Location = new System.Drawing.Point(872, 21);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(56, 39);
            this.button11.TabIndex = 66;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1013, 524);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form11";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form11";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciisleriDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ogrenciisleriDataSet2 ogrenciisleriDataSet2;
        private System.Windows.Forms.BindingSource dersBindingSource;
        private ogrenciisleriDataSet2TableAdapters.dersTableAdapter dersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odevDataGridViewTextBoxColumn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button button11;
    }
}