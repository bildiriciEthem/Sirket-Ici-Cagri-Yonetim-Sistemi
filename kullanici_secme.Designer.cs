namespace cagri
{
    partial class kullanici_secme
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cagriDataSet52 = new cagri.cagriDataSet52();
            this.kullanicisekmeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kullanici_sekmeTableAdapter = new cagri.cagriDataSet52TableAdapters.kullanici_sekmeTableAdapter();
            this.coladi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsicil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cagriDataSet52)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicisekmeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.kullanicisekmeBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(194, 374);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coladi,
            this.colsicil});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // cagriDataSet52
            // 
            this.cagriDataSet52.DataSetName = "cagriDataSet52";
            this.cagriDataSet52.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kullanicisekmeBindingSource
            // 
            this.kullanicisekmeBindingSource.DataMember = "kullanici_sekme";
            this.kullanicisekmeBindingSource.DataSource = this.cagriDataSet52;
            // 
            // kullanici_sekmeTableAdapter
            // 
            this.kullanici_sekmeTableAdapter.ClearBeforeFill = true;
            // 
            // coladi
            // 
            this.coladi.FieldName = "adi";
            this.coladi.Name = "coladi";
            this.coladi.Visible = true;
            this.coladi.VisibleIndex = 0;
            // 
            // colsicil
            // 
            this.colsicil.FieldName = "sicil";
            this.colsicil.Name = "colsicil";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // kullanici_secme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 369);
            this.Controls.Add(this.gridControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "kullanici_secme";
            this.Text = "kullanici_secme";
            this.Load += new System.EventHandler(this.kullanici_secme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cagriDataSet52)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicisekmeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private cagriDataSet52 cagriDataSet52;
        private System.Windows.Forms.BindingSource kullanicisekmeBindingSource;
        private cagriDataSet52TableAdapters.kullanici_sekmeTableAdapter kullanici_sekmeTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn coladi;
        private DevExpress.XtraGrid.Columns.GridColumn colsicil;
        private System.Windows.Forms.Timer timer1;
    }
}