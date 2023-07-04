namespace WindowsFormsApp1
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isimsoyisimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parolaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.knoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciisleriDataSet = new WindowsFormsApp1.ogrenciisleriDataSet();
            this.ogrenciiTableAdapter = new WindowsFormsApp1.ogrenciisleriDataSetTableAdapters.ogrenciiTableAdapter();
            this.button11 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciisleriDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Brown;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tcDataGridViewTextBoxColumn,
            this.isimsoyisimDataGridViewTextBoxColumn,
            this.kullaniciadiDataGridViewTextBoxColumn,
            this.parolaDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.bolumDataGridViewTextBoxColumn,
            this.knoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ogrenciiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(51, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(750, 453);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tcDataGridViewTextBoxColumn
            // 
            this.tcDataGridViewTextBoxColumn.DataPropertyName = "tc";
            this.tcDataGridViewTextBoxColumn.HeaderText = "tc";
            this.tcDataGridViewTextBoxColumn.Name = "tcDataGridViewTextBoxColumn";
            // 
            // isimsoyisimDataGridViewTextBoxColumn
            // 
            this.isimsoyisimDataGridViewTextBoxColumn.DataPropertyName = "isimsoyisim";
            this.isimsoyisimDataGridViewTextBoxColumn.HeaderText = "isimsoyisim";
            this.isimsoyisimDataGridViewTextBoxColumn.Name = "isimsoyisimDataGridViewTextBoxColumn";
            // 
            // kullaniciadiDataGridViewTextBoxColumn
            // 
            this.kullaniciadiDataGridViewTextBoxColumn.DataPropertyName = "kullaniciadi";
            this.kullaniciadiDataGridViewTextBoxColumn.HeaderText = "kullaniciadi";
            this.kullaniciadiDataGridViewTextBoxColumn.Name = "kullaniciadiDataGridViewTextBoxColumn";
            // 
            // parolaDataGridViewTextBoxColumn
            // 
            this.parolaDataGridViewTextBoxColumn.DataPropertyName = "parola";
            this.parolaDataGridViewTextBoxColumn.HeaderText = "parola";
            this.parolaDataGridViewTextBoxColumn.Name = "parolaDataGridViewTextBoxColumn";
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            // 
            // bolumDataGridViewTextBoxColumn
            // 
            this.bolumDataGridViewTextBoxColumn.DataPropertyName = "bolum";
            this.bolumDataGridViewTextBoxColumn.HeaderText = "bolum";
            this.bolumDataGridViewTextBoxColumn.Name = "bolumDataGridViewTextBoxColumn";
            // 
            // knoDataGridViewTextBoxColumn
            // 
            this.knoDataGridViewTextBoxColumn.DataPropertyName = "kno";
            this.knoDataGridViewTextBoxColumn.HeaderText = "kno";
            this.knoDataGridViewTextBoxColumn.Name = "knoDataGridViewTextBoxColumn";
            this.knoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogrenciiBindingSource
            // 
            this.ogrenciiBindingSource.DataMember = "ogrencii";
            this.ogrenciiBindingSource.DataSource = this.ogrenciisleriDataSet;
            // 
            // ogrenciisleriDataSet
            // 
            this.ogrenciisleriDataSet.DataSetName = "ogrenciisleriDataSet";
            this.ogrenciisleriDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciiTableAdapter
            // 
            this.ogrenciiTableAdapter.ClearBeforeFill = true;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Transparent;
            this.button11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button11.BackgroundImage")));
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button11.Location = new System.Drawing.Point(-2, 0);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(56, 39);
            this.button11.TabIndex = 57;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 450);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciisleriDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ogrenciisleriDataSet ogrenciisleriDataSet;
        private System.Windows.Forms.BindingSource ogrenciiBindingSource;
        private ogrenciisleriDataSetTableAdapters.ogrenciiTableAdapter ogrenciiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isimsoyisimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parolaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn knoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button11;
    }
}