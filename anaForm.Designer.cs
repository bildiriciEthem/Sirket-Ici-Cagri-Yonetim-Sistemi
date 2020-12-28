namespace cagri
{
    partial class anaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anaForm));
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.colForm = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.menulerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cagriDataSet32 = new cagri.cagriDataSet32();
            this.menulerTableAdapter2 = new cagri.cagriDataSet32TableAdapters.MenulerTableAdapter();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.form1userkontrol1 = new cagri.form1userkontrol();
            this.adminkontrol1 = new cagri.adminkontrol();
            this.kaydolkontrol1 = new cagri.kaydolkontrol();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.kullanicibilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cagriDataSet35 = new cagri.cagriDataSet35();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colkullanici_sicil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colozel_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.kullanici_bilgiTableAdapter = new cagri.cagriDataSet35TableAdapters.kullanici_bilgiTableAdapter();
            this.xtraUserControl1 = new DevExpress.XtraEditors.XtraUserControl();
            this.bilgiİşlemKontrol1 = new cagri.bilgiİşlemKontrol();
            this.satinAlma1 = new cagri.satinAlma();
            this.ik1 = new cagri.ik();
            this.kapak1 = new cagri.kapak();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menulerBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cagriDataSet32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicibilgiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cagriDataSet35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            resources.ApplyResources(this.treeList1, "treeList1");
            this.treeList1.Appearance.Row.Font = ((System.Drawing.Font)(resources.GetObject("treeList1.Appearance.Row.Font")));
            this.treeList1.Appearance.Row.FontSizeDelta = ((int)(resources.GetObject("treeList1.Appearance.Row.FontSizeDelta")));
            this.treeList1.Appearance.Row.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("treeList1.Appearance.Row.FontStyleDelta")));
            this.treeList1.Appearance.Row.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("treeList1.Appearance.Row.GradientMode")));
            this.treeList1.Appearance.Row.Image = ((System.Drawing.Image)(resources.GetObject("treeList1.Appearance.Row.Image")));
            this.treeList1.Appearance.Row.Options.UseFont = true;
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colForm});
            this.treeList1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treeList1.DataSource = this.menulerBindingSource2;
            this.treeList1.HierarchyColumn = this.colForm;
            this.treeList1.LookAndFeel.SkinName = "The Bezier";
            this.treeList1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsBehavior.Editable = false;
            this.treeList1.OptionsBehavior.ReadOnly = true;
            this.treeList1.OptionsBehavior.ResizeNodes = false;
            this.treeList1.OptionsCustomization.AllowBandMoving = false;
            this.treeList1.OptionsView.ShowIndentAsRowStyle = true;
            this.treeList1.CustomRowFilter += new DevExpress.XtraTreeList.CustomRowFilterEventHandler(this.treeList1_CustomRowFilter);
            this.treeList1.Click += new System.EventHandler(this.treeList1_Click);
            // 
            // colForm
            // 
            resources.ApplyResources(this.colForm, "colForm");
            this.colForm.FieldName = "Form";
            this.colForm.ImageOptions.Alignment = ((System.Drawing.StringAlignment)(resources.GetObject("colForm.ImageOptions.Alignment")));
            this.colForm.ImageOptions.ImageIndex = ((int)(resources.GetObject("colForm.ImageOptions.ImageIndex")));
            this.colForm.Name = "colForm";
            // 
            // menulerBindingSource2
            // 
            this.menulerBindingSource2.DataMember = "Menuler";
            this.menulerBindingSource2.DataSource = this.cagriDataSet32;
            // 
            // cagriDataSet32
            // 
            this.cagriDataSet32.DataSetName = "cagriDataSet32";
            this.cagriDataSet32.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menulerTableAdapter2
            // 
            this.menulerTableAdapter2.ClearBeforeFill = true;
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // form1userkontrol1
            // 
            resources.ApplyResources(this.form1userkontrol1, "form1userkontrol1");
            this.form1userkontrol1.Name = "form1userkontrol1";
            // 
            // adminkontrol1
            // 
            resources.ApplyResources(this.adminkontrol1, "adminkontrol1");
            this.adminkontrol1.Name = "adminkontrol1";
            // 
            // kaydolkontrol1
            // 
            resources.ApplyResources(this.kaydolkontrol1, "kaydolkontrol1");
            this.kaydolkontrol1.Name = "kaydolkontrol1";
            // 
            // gridControl1
            // 
            resources.ApplyResources(this.gridControl1, "gridControl1");
            this.gridControl1.DataSource = this.kullanicibilgiBindingSource;
            this.gridControl1.EmbeddedNavigator.AccessibleDescription = resources.GetString("gridControl1.EmbeddedNavigator.AccessibleDescription");
            this.gridControl1.EmbeddedNavigator.AccessibleName = resources.GetString("gridControl1.EmbeddedNavigator.AccessibleName");
            this.gridControl1.EmbeddedNavigator.AllowHtmlTextInToolTip = ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("gridControl1.EmbeddedNavigator.AllowHtmlTextInToolTip")));
            this.gridControl1.EmbeddedNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("gridControl1.EmbeddedNavigator.Anchor")));
            this.gridControl1.EmbeddedNavigator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gridControl1.EmbeddedNavigator.BackgroundImage")));
            this.gridControl1.EmbeddedNavigator.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("gridControl1.EmbeddedNavigator.BackgroundImageLayout")));
            this.gridControl1.EmbeddedNavigator.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("gridControl1.EmbeddedNavigator.ImeMode")));
            this.gridControl1.EmbeddedNavigator.MaximumSize = ((System.Drawing.Size)(resources.GetObject("gridControl1.EmbeddedNavigator.MaximumSize")));
            this.gridControl1.EmbeddedNavigator.TextLocation = ((DevExpress.XtraEditors.NavigatorButtonsTextLocation)(resources.GetObject("gridControl1.EmbeddedNavigator.TextLocation")));
            this.gridControl1.EmbeddedNavigator.ToolTip = resources.GetString("gridControl1.EmbeddedNavigator.ToolTip");
            this.gridControl1.EmbeddedNavigator.ToolTipIconType = ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("gridControl1.EmbeddedNavigator.ToolTipIconType")));
            this.gridControl1.EmbeddedNavigator.ToolTipTitle = resources.GetString("gridControl1.EmbeddedNavigator.ToolTipTitle");
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // kullanicibilgiBindingSource
            // 
            this.kullanicibilgiBindingSource.DataMember = "kullanici_bilgi";
            this.kullanicibilgiBindingSource.DataSource = this.cagriDataSet35;
            // 
            // cagriDataSet35
            // 
            this.cagriDataSet35.DataSetName = "cagriDataSet35";
            this.cagriDataSet35.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            resources.ApplyResources(this.gridView1, "gridView1");
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colkullanici_sicil,
            this.colozel_id});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colkullanici_sicil
            // 
            resources.ApplyResources(this.colkullanici_sicil, "colkullanici_sicil");
            this.colkullanici_sicil.FieldName = "kullanici_sicil";
            this.colkullanici_sicil.ImageOptions.Alignment = ((System.Drawing.StringAlignment)(resources.GetObject("colkullanici_sicil.ImageOptions.Alignment")));
            this.colkullanici_sicil.ImageOptions.ImageIndex = ((int)(resources.GetObject("colkullanici_sicil.ImageOptions.ImageIndex")));
            this.colkullanici_sicil.Name = "colkullanici_sicil";
            // 
            // colozel_id
            // 
            resources.ApplyResources(this.colozel_id, "colozel_id");
            this.colozel_id.FieldName = "ozel_id";
            this.colozel_id.ImageOptions.Alignment = ((System.Drawing.StringAlignment)(resources.GetObject("colozel_id.ImageOptions.Alignment")));
            this.colozel_id.ImageOptions.ImageIndex = ((int)(resources.GetObject("colozel_id.ImageOptions.ImageIndex")));
            this.colozel_id.Name = "colozel_id";
            // 
            // kullanici_bilgiTableAdapter
            // 
            this.kullanici_bilgiTableAdapter.ClearBeforeFill = true;
            // 
            // xtraUserControl1
            // 
            resources.ApplyResources(this.xtraUserControl1, "xtraUserControl1");
            this.xtraUserControl1.Name = "xtraUserControl1";
            this.xtraUserControl1.Load += new System.EventHandler(this.xtraUserControl1_Load);
            // 
            // bilgiİşlemKontrol1
            // 
            resources.ApplyResources(this.bilgiİşlemKontrol1, "bilgiİşlemKontrol1");
            this.bilgiİşlemKontrol1.Name = "bilgiİşlemKontrol1";
            // 
            // satinAlma1
            // 
            resources.ApplyResources(this.satinAlma1, "satinAlma1");
            this.satinAlma1.Name = "satinAlma1";
            this.satinAlma1.Load += new System.EventHandler(this.satinAlma1_Load);
            // 
            // ik1
            // 
            resources.ApplyResources(this.ik1, "ik1");
            this.ik1.Name = "ik1";
            // 
            // kapak1
            // 
            resources.ApplyResources(this.kapak1, "kapak1");
            this.kapak1.Name = "kapak1";
            // 
            // anaForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kapak1);
            this.Controls.Add(this.ik1);
            this.Controls.Add(this.satinAlma1);
            this.Controls.Add(this.bilgiİşlemKontrol1);
            this.Controls.Add(this.xtraUserControl1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.kaydolkontrol1);
            this.Controls.Add(this.adminkontrol1);
            this.Controls.Add(this.form1userkontrol1);
            this.Controls.Add(this.treeList1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.LookAndFeel.SkinName = "The Bezier";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "anaForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.anaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menulerBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cagriDataSet32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicibilgiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cagriDataSet35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTreeList.TreeList treeList1;
        private cagriDataSet32 cagriDataSet32;
        private System.Windows.Forms.BindingSource menulerBindingSource2;
        private cagriDataSet32TableAdapters.MenulerTableAdapter menulerTableAdapter2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colForm;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private form1userkontrol form1userkontrol1;
        private adminkontrol adminkontrol1;
        private kaydolkontrol kaydolkontrol1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private cagriDataSet35 cagriDataSet35;
        private System.Windows.Forms.BindingSource kullanicibilgiBindingSource;
        private cagriDataSet35TableAdapters.kullanici_bilgiTableAdapter kullanici_bilgiTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colkullanici_sicil;
        private DevExpress.XtraGrid.Columns.GridColumn colozel_id;
        private DevExpress.XtraEditors.XtraUserControl xtraUserControl1;
        private bilgiİşlemKontrol bilgiİşlemKontrol1;
        private satinAlma satinAlma1;
        private ik ik1;
        private kapak kapak1;
    }
}