namespace apartman
{
    partial class saracoda
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
            this.kisilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSiteDataSet = new apartman.DbSiteDataSet();
            this.kisilerTableAdapter = new apartman.DbSiteDataSetTableAdapters.KisilerTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dtrgrv = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.TextBox();
            this.oturapt = new System.Windows.Forms.TextBox();
            this.telefon = new System.Windows.Forms.TextBox();
            this.adsoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kisilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSiteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtrgrv)).BeginInit();
            this.SuspendLayout();
            // 
            // kisilerBindingSource
            // 
            this.kisilerBindingSource.DataMember = "Kisiler";
            this.kisilerBindingSource.DataSource = this.dbSiteDataSet;
            this.kisilerBindingSource.CurrentChanged += new System.EventHandler(this.kisilerBindingSource_CurrentChanged);
            // 
            // dbSiteDataSet
            // 
            this.dbSiteDataSet.DataSetName = "DbSiteDataSet";
            this.dbSiteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kisilerTableAdapter
            // 
            this.kisilerTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(332, 377);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 61);
            this.button4.TabIndex = 9;
            this.button4.Text = "Kullanıcı Sil";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(175, 377);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 61);
            this.button3.TabIndex = 8;
            this.button3.Text = "Kullanıcı Düzenle";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(24, 378);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 61);
            this.button2.TabIndex = 7;
            this.button2.Text = "Kullanıcı Ekle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(514, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dtrgrv
            // 
            this.dtrgrv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtrgrv.Location = new System.Drawing.Point(11, 47);
            this.dtrgrv.Name = "dtrgrv";
            this.dtrgrv.RowHeadersWidth = 51;
            this.dtrgrv.RowTemplate.Height = 24;
            this.dtrgrv.Size = new System.Drawing.Size(602, 298);
            this.dtrgrv.TabIndex = 10;
            this.dtrgrv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(26, 349);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(100, 22);
            this.ID.TabIndex = 23;
            // 
            // oturapt
            // 
            this.oturapt.Location = new System.Drawing.Point(344, 349);
            this.oturapt.Name = "oturapt";
            this.oturapt.Size = new System.Drawing.Size(100, 22);
            this.oturapt.TabIndex = 22;
            // 
            // telefon
            // 
            this.telefon.Location = new System.Drawing.Point(238, 349);
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(100, 22);
            this.telefon.TabIndex = 21;
            // 
            // adsoyad
            // 
            this.adsoyad.Location = new System.Drawing.Point(132, 349);
            this.adsoyad.Name = "adsoyad";
            this.adsoyad.Size = new System.Drawing.Size(100, 22);
            this.adsoyad.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Kişiler";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // saracoda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 467);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.oturapt);
            this.Controls.Add(this.telefon);
            this.Controls.Add(this.adsoyad);
            this.Controls.Add(this.dtrgrv);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "saracoda";
            this.Text = "saracoda";
            this.Load += new System.EventHandler(this.saracoda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kisilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSiteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtrgrv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource kisilerBindingSource;
        private DbSiteDataSet dbSiteDataSet;
        private DbSiteDataSetTableAdapters.KisilerTableAdapter kisilerTableAdapter;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtrgrv;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox oturapt;
        private System.Windows.Forms.TextBox telefon;
        private System.Windows.Forms.TextBox adsoyad;
        private System.Windows.Forms.Label label1;
    }
}