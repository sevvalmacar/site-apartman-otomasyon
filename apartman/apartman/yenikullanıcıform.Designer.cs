namespace apartman
{
    partial class yenikullanıcıform
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtrgrv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.kisilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSiteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtrgrv)).BeginInit();
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(257, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 61);
            this.button2.TabIndex = 7;
            this.button2.Text = "Kullanıcı Ekle";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(585, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Geri Dön";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Kişiler";
            // 
            // dtrgrv
            // 
            this.dtrgrv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtrgrv.Location = new System.Drawing.Point(14, 43);
            this.dtrgrv.Name = "dtrgrv";
            this.dtrgrv.RowHeadersWidth = 51;
            this.dtrgrv.RowTemplate.Height = 24;
            this.dtrgrv.Size = new System.Drawing.Size(686, 298);
            this.dtrgrv.TabIndex = 27;
            this.dtrgrv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtrgrv_CellContentClick);
            // 
            // yenikullanıcıform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 446);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtrgrv);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "yenikullanıcıform";
            this.Text = "yenikullanıcıform";
            this.Load += new System.EventHandler(this.yenikullanıcıform_Load);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtrgrv;
    }
}