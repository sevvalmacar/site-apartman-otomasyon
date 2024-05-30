namespace apartman
{
    partial class macarGercekKisiler
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dtgrview = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.TextBox();
            this.oturapt = new System.Windows.Forms.TextBox();
            this.telefon = new System.Windows.Forms.TextBox();
            this.adsoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewapt = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.kisilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSiteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewapt)).BeginInit();
            this.SuspendLayout();
            // 
            // kisilerBindingSource
            // 
            this.kisilerBindingSource.DataMember = "Kisiler";
            this.kisilerBindingSource.DataSource = this.dbSiteDataSet;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(705, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(144, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 61);
            this.button2.TabIndex = 2;
            this.button2.Text = "Kullanıcı Ekle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(295, 376);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 61);
            this.button3.TabIndex = 3;
            this.button3.Text = "Kullanıcı Düzenle";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(452, 376);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 61);
            this.button4.TabIndex = 4;
            this.button4.Text = "Kullanıcı Sil";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // dtgrview
            // 
            this.dtgrview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrview.Location = new System.Drawing.Point(12, 36);
            this.dtgrview.Name = "dtgrview";
            this.dtgrview.RowHeadersWidth = 51;
            this.dtgrview.RowTemplate.Height = 24;
            this.dtgrview.Size = new System.Drawing.Size(602, 298);
            this.dtgrview.TabIndex = 5;
            this.dtgrview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(144, 349);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(100, 22);
            this.ID.TabIndex = 19;
            // 
            // oturapt
            // 
            this.oturapt.Location = new System.Drawing.Point(462, 349);
            this.oturapt.Name = "oturapt";
            this.oturapt.Size = new System.Drawing.Size(100, 22);
            this.oturapt.TabIndex = 18;
            // 
            // telefon
            // 
            this.telefon.Location = new System.Drawing.Point(356, 349);
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(100, 22);
            this.telefon.TabIndex = 17;
            // 
            // adsoyad
            // 
            this.adsoyad.Location = new System.Drawing.Point(250, 349);
            this.adsoyad.Name = "adsoyad";
            this.adsoyad.Size = new System.Drawing.Size(100, 22);
            this.adsoyad.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(616, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Apartmanlar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Kişiler";
            // 
            // dataGridViewapt
            // 
            this.dataGridViewapt.AllowUserToAddRows = false;
            this.dataGridViewapt.AllowUserToDeleteRows = false;
            this.dataGridViewapt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewapt.Location = new System.Drawing.Point(620, 36);
            this.dataGridViewapt.Name = "dataGridViewapt";
            this.dataGridViewapt.RowHeadersWidth = 51;
            this.dataGridViewapt.RowTemplate.Height = 24;
            this.dataGridViewapt.Size = new System.Drawing.Size(922, 298);
            this.dataGridViewapt.TabIndex = 20;
            // 
            // macarGercekKisiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1558, 658);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewapt);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.oturapt);
            this.Controls.Add(this.telefon);
            this.Controls.Add(this.adsoyad);
            this.Controls.Add(this.dtgrview);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "macarGercekKisiler";
            this.Text = "macarGercekoda";
            this.Load += new System.EventHandler(this.macarGercekKisiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kisilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSiteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewapt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DbSiteDataSet dbSiteDataSet;
        private System.Windows.Forms.BindingSource kisilerBindingSource;
        private DbSiteDataSetTableAdapters.KisilerTableAdapter kisilerTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dtgrview;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox oturapt;
        private System.Windows.Forms.TextBox telefon;
        private System.Windows.Forms.TextBox adsoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewapt;
    }
}