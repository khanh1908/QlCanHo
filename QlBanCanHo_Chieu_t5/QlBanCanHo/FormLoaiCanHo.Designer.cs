
namespace QlBanCanHo
{
    partial class FormLoaiCanHo
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
            System.Windows.Forms.Label tenLoaiLabel;
            System.Windows.Forms.Label maLoaiCHLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoaiCanHo));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barbttThem = new DevExpress.XtraBars.BarButtonItem();
            this.barbttXoa = new DevExpress.XtraBars.BarButtonItem();
            this.barbttSua = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.maLoaiCHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.loaiCanHoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBanCanHoDataSet = new QlBanCanHo.QLBanCanHoDataSet();
            this.tenLoaiTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.loaiCanHoTableAdapter = new QlBanCanHo.QLBanCanHoDataSetTableAdapters.LoaiCanHoTableAdapter();
            this.tableAdapterManager = new QlBanCanHo.QLBanCanHoDataSetTableAdapters.TableAdapterManager();
            this.loaiCanHoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bttSave = new System.Windows.Forms.Button();
            this.bttCancel = new System.Windows.Forms.Button();
            tenLoaiLabel = new System.Windows.Forms.Label();
            maLoaiCHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maLoaiCHTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiCanHoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanCanHoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenLoaiTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiCanHoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tenLoaiLabel
            // 
            tenLoaiLabel.AutoSize = true;
            tenLoaiLabel.Location = new System.Drawing.Point(428, 38);
            tenLoaiLabel.Name = "tenLoaiLabel";
            tenLoaiLabel.Size = new System.Drawing.Size(76, 19);
            tenLoaiLabel.TabIndex = 2;
            tenLoaiLabel.Text = "Ten Loai:";
            // 
            // maLoaiCHLabel
            // 
            maLoaiCHLabel.AutoSize = true;
            maLoaiCHLabel.Location = new System.Drawing.Point(89, 37);
            maLoaiCHLabel.Name = "maLoaiCHLabel";
            maLoaiCHLabel.Size = new System.Drawing.Size(95, 19);
            maLoaiCHLabel.TabIndex = 3;
            maLoaiCHLabel.Text = "Ma Loai CH:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barbttXoa,
            this.barbttSua,
            this.barbttThem});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 5;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(111, 193);
            this.bar2.FloatSize = new System.Drawing.Size(329, 36);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barbttThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.barbttXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.barbttSua)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barbttThem
            // 
            this.barbttThem.Caption = "Thêm";
            this.barbttThem.Id = 4;
            this.barbttThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.barbttThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.LargeImage")));
            this.barbttThem.Name = "barbttThem";
            this.barbttThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barbttThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbttThem_ItemClick);
            // 
            // barbttXoa
            // 
            this.barbttXoa.Caption = "Xóa";
            this.barbttXoa.Id = 2;
            this.barbttXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barbttXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barbttXoa.Name = "barbttXoa";
            this.barbttXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barbttXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbttXoa_ItemClick);
            // 
            // barbttSua
            // 
            this.barbttSua.Caption = "Sửa";
            this.barbttSua.Id = 3;
            this.barbttSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barbttSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barbttSua.Name = "barbttSua";
            this.barbttSua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barbttSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbttSua_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(800, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 450);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(800, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 416);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(800, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 416);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.ActAsDropDown = true;
            this.barButtonItem2.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonItem2.Caption = "Thêm";
            this.barButtonItem2.Enabled = false;
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.bttCancel);
            this.panelControl1.Controls.Add(this.bttSave);
            this.panelControl1.Controls.Add(maLoaiCHLabel);
            this.panelControl1.Controls.Add(this.maLoaiCHTextEdit);
            this.panelControl1.Controls.Add(tenLoaiLabel);
            this.panelControl1.Controls.Add(this.tenLoaiTextEdit);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 34);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(800, 100);
            this.panelControl1.TabIndex = 4;
            // 
            // maLoaiCHTextEdit
            // 
            this.maLoaiCHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.loaiCanHoBindingSource, "MaLoaiCH", true));
            this.maLoaiCHTextEdit.Location = new System.Drawing.Point(190, 34);
            this.maLoaiCHTextEdit.MenuManager = this.barManager1;
            this.maLoaiCHTextEdit.Name = "maLoaiCHTextEdit";
            this.maLoaiCHTextEdit.Size = new System.Drawing.Size(150, 28);
            this.maLoaiCHTextEdit.TabIndex = 4;
            // 
            // loaiCanHoBindingSource
            // 
            this.loaiCanHoBindingSource.DataMember = "LoaiCanHo";
            this.loaiCanHoBindingSource.DataSource = this.qLBanCanHoDataSet;
            // 
            // qLBanCanHoDataSet
            // 
            this.qLBanCanHoDataSet.DataSetName = "QLBanCanHoDataSet";
            this.qLBanCanHoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tenLoaiTextEdit
            // 
            this.tenLoaiTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.loaiCanHoBindingSource, "TenLoai", true));
            this.tenLoaiTextEdit.Location = new System.Drawing.Point(510, 35);
            this.tenLoaiTextEdit.MenuManager = this.barManager1;
            this.tenLoaiTextEdit.Name = "tenLoaiTextEdit";
            this.tenLoaiTextEdit.Size = new System.Drawing.Size(150, 28);
            this.tenLoaiTextEdit.TabIndex = 3;
            // 
            // loaiCanHoTableAdapter
            // 
            this.loaiCanHoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOPHANTableAdapter = null;
            this.tableAdapterManager.CanHoTableAdapter = null;
            this.tableAdapterManager.CanHoTonTableAdapter = null;
            this.tableAdapterManager.ChungTuBanGiaoTableAdapter = null;
            this.tableAdapterManager.CTGiaoDichTableAdapter = null;
            this.tableAdapterManager.CTPhieuXuatTableAdapter = null;
            this.tableAdapterManager.DuAnTableAdapter = null;
            this.tableAdapterManager.GiaoDichTableAdapter = null;
            this.tableAdapterManager.HoaDonDienTuTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.LoaiCanHoTableAdapter = this.loaiCanHoTableAdapter;
            this.tableAdapterManager.LoaiGiaoDichTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PhieuXuatCHTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QlBanCanHo.QLBanCanHoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // loaiCanHoDataGridView
            // 
            this.loaiCanHoDataGridView.AutoGenerateColumns = false;
            this.loaiCanHoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loaiCanHoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.loaiCanHoDataGridView.DataSource = this.loaiCanHoBindingSource;
            this.loaiCanHoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loaiCanHoDataGridView.Location = new System.Drawing.Point(0, 134);
            this.loaiCanHoDataGridView.Name = "loaiCanHoDataGridView";
            this.loaiCanHoDataGridView.RowHeadersWidth = 62;
            this.loaiCanHoDataGridView.RowTemplate.Height = 28;
            this.loaiCanHoDataGridView.Size = new System.Drawing.Size(800, 316);
            this.loaiCanHoDataGridView.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaLoaiCH";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaLoaiCH";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenLoai";
            this.dataGridViewTextBoxColumn2.HeaderText = "TenLoai";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // bttSave
            // 
            this.bttSave.Location = new System.Drawing.Point(713, 54);
            this.bttSave.Name = "bttSave";
            this.bttSave.Size = new System.Drawing.Size(75, 23);
            this.bttSave.TabIndex = 5;
            this.bttSave.Text = "Save";
            this.bttSave.UseVisualStyleBackColor = true;
            this.bttSave.Click += new System.EventHandler(this.bttSave_Click);
            // 
            // bttCancel
            // 
            this.bttCancel.Location = new System.Drawing.Point(555, 70);
            this.bttCancel.Name = "bttCancel";
            this.bttCancel.Size = new System.Drawing.Size(75, 23);
            this.bttCancel.TabIndex = 6;
            this.bttCancel.Text = "Cancel";
            this.bttCancel.UseVisualStyleBackColor = true;
            this.bttCancel.Click += new System.EventHandler(this.bttCancel_Click);
            // 
            // FormLoaiCanHo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.loaiCanHoDataGridView);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormLoaiCanHo";
            this.Text = "FormLoaiCanHo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormLoaiCanHo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maLoaiCHTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiCanHoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanCanHoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenLoaiTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiCanHoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barbttThem;
        private DevExpress.XtraBars.BarButtonItem barbttXoa;
        private DevExpress.XtraBars.BarButtonItem barbttSua;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private System.Windows.Forms.BindingSource loaiCanHoBindingSource;
        private QLBanCanHoDataSet qLBanCanHoDataSet;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private QLBanCanHoDataSetTableAdapters.LoaiCanHoTableAdapter loaiCanHoTableAdapter;
        private QLBanCanHoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView loaiCanHoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DevExpress.XtraEditors.TextEdit maLoaiCHTextEdit;
        private DevExpress.XtraEditors.TextEdit tenLoaiTextEdit;
        private System.Windows.Forms.Button bttCancel;
        private System.Windows.Forms.Button bttSave;
    }
}