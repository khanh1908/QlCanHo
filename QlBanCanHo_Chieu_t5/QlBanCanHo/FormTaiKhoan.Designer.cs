
namespace QlBanCanHo
{
    partial class FormTaiKhoan
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
            System.Windows.Forms.Label taiKhoanLabel;
            System.Windows.Forms.Label matKhauLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTaiKhoan));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barbttSua = new DevExpress.XtraBars.BarButtonItem();
            this.barbttXoa = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.bttCancel = new System.Windows.Forms.Button();
            this.bttSave = new System.Windows.Forms.Button();
            this.matKhauTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.taiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBanCanHoDataSet = new QlBanCanHo.QLBanCanHoDataSet();
            this.taiKhoanTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.taiKhoanTableAdapter = new QlBanCanHo.QLBanCanHoDataSetTableAdapters.TaiKhoanTableAdapter();
            this.tableAdapterManager = new QlBanCanHo.QLBanCanHoDataSetTableAdapters.TableAdapterManager();
            this.taiKhoanDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            taiKhoanLabel = new System.Windows.Forms.Label();
            matKhauLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matKhauTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanCanHoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // taiKhoanLabel
            // 
            taiKhoanLabel.AutoSize = true;
            taiKhoanLabel.Location = new System.Drawing.Point(113, 22);
            taiKhoanLabel.Name = "taiKhoanLabel";
            taiKhoanLabel.Size = new System.Drawing.Size(73, 17);
            taiKhoanLabel.TabIndex = 0;
            taiKhoanLabel.Text = "Tai Khoan:";
            // 
            // matKhauLabel
            // 
            matKhauLabel.AutoSize = true;
            matKhauLabel.Location = new System.Drawing.Point(406, 24);
            matKhauLabel.Name = "matKhauLabel";
            matKhauLabel.Size = new System.Drawing.Size(70, 17);
            matKhauLabel.TabIndex = 2;
            matKhauLabel.Text = "Mat Khau:";
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
            this.barButtonItem3,
            this.barbttSua,
            this.barButtonItem5,
            this.barbttXoa});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.barbttSua),
            new DevExpress.XtraBars.LinkPersistInfo(this.barbttXoa)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barbttSua
            // 
            this.barbttSua.Caption = "Sửa";
            this.barbttSua.Id = 3;
            this.barbttSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbttSua.ImageOptions.Image")));
            this.barbttSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbttSua.ImageOptions.LargeImage")));
            this.barbttSua.Name = "barbttSua";
            this.barbttSua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barbttSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbttSua_ItemClick);
            // 
            // barbttXoa
            // 
            this.barbttXoa.Caption = "xóa";
            this.barbttXoa.Id = 5;
            this.barbttXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbttXoa.ImageOptions.Image")));
            this.barbttXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbttXoa.ImageOptions.LargeImage")));
            this.barbttXoa.Name = "barbttXoa";
            this.barbttXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barbttXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbttXoa_ItemClick);
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
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(711, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 352);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(711, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 322);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(711, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 322);
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
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Xóa";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Thêm";
            this.barButtonItem5.Id = 4;
            this.barButtonItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.barButtonItem5.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.LargeImage")));
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.bttCancel);
            this.panelControl1.Controls.Add(this.bttSave);
            this.panelControl1.Controls.Add(matKhauLabel);
            this.panelControl1.Controls.Add(this.matKhauTextEdit);
            this.panelControl1.Controls.Add(taiKhoanLabel);
            this.panelControl1.Controls.Add(this.taiKhoanTextEdit);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 30);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(711, 80);
            this.panelControl1.TabIndex = 4;
            // 
            // bttCancel
            // 
            this.bttCancel.Location = new System.Drawing.Point(396, 56);
            this.bttCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttCancel.Name = "bttCancel";
            this.bttCancel.Size = new System.Drawing.Size(67, 18);
            this.bttCancel.TabIndex = 5;
            this.bttCancel.Text = "Cancel";
            this.bttCancel.UseVisualStyleBackColor = true;
            this.bttCancel.Click += new System.EventHandler(this.bttCancel_Click);
            // 
            // bttSave
            // 
            this.bttSave.Location = new System.Drawing.Point(223, 57);
            this.bttSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttSave.Name = "bttSave";
            this.bttSave.Size = new System.Drawing.Size(67, 18);
            this.bttSave.TabIndex = 4;
            this.bttSave.Text = "Save";
            this.bttSave.UseVisualStyleBackColor = true;
            this.bttSave.Click += new System.EventHandler(this.bttSave_Click);
            // 
            // matKhauTextEdit
            // 
            this.matKhauTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.taiKhoanBindingSource, "MatKhau", true));
            this.matKhauTextEdit.Location = new System.Drawing.Point(483, 22);
            this.matKhauTextEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.matKhauTextEdit.MenuManager = this.barManager1;
            this.matKhauTextEdit.Name = "matKhauTextEdit";
            this.matKhauTextEdit.Size = new System.Drawing.Size(133, 22);
            this.matKhauTextEdit.TabIndex = 3;
            // 
            // taiKhoanBindingSource
            // 
            this.taiKhoanBindingSource.DataMember = "TaiKhoan";
            this.taiKhoanBindingSource.DataSource = this.qLBanCanHoDataSet;
            // 
            // qLBanCanHoDataSet
            // 
            this.qLBanCanHoDataSet.DataSetName = "QLBanCanHoDataSet";
            this.qLBanCanHoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taiKhoanTextEdit
            // 
            this.taiKhoanTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.taiKhoanBindingSource, "TaiKhoan", true));
            this.taiKhoanTextEdit.Location = new System.Drawing.Point(195, 19);
            this.taiKhoanTextEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.taiKhoanTextEdit.MenuManager = this.barManager1;
            this.taiKhoanTextEdit.Name = "taiKhoanTextEdit";
            this.taiKhoanTextEdit.Size = new System.Drawing.Size(133, 22);
            this.taiKhoanTextEdit.TabIndex = 1;
            // 
            // taiKhoanTableAdapter
            // 
            this.taiKhoanTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.LoaiCanHoTableAdapter = null;
            this.tableAdapterManager.LoaiGiaoDichTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PhieuXuatCHTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = this.taiKhoanTableAdapter;
            this.tableAdapterManager.UpdateOrder = QlBanCanHo.QLBanCanHoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // taiKhoanDataGridView
            // 
            this.taiKhoanDataGridView.AutoGenerateColumns = false;
            this.taiKhoanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taiKhoanDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.taiKhoanDataGridView.DataSource = this.taiKhoanBindingSource;
            this.taiKhoanDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taiKhoanDataGridView.Location = new System.Drawing.Point(0, 110);
            this.taiKhoanDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.taiKhoanDataGridView.Name = "taiKhoanDataGridView";
            this.taiKhoanDataGridView.RowHeadersWidth = 62;
            this.taiKhoanDataGridView.RowTemplate.Height = 28;
            this.taiKhoanDataGridView.Size = new System.Drawing.Size(711, 242);
            this.taiKhoanDataGridView.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TaiKhoan";
            this.dataGridViewTextBoxColumn1.HeaderText = "TaiKhoan";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MatKhau";
            this.dataGridViewTextBoxColumn2.HeaderText = "MatKhau";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Danh sách tài khoản";
            this.label1.Visible = false;
            // 
            // FormTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 372);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.taiKhoanDataGridView);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormTaiKhoan";
            this.Text = "FormTaiKhoan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matKhauTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanCanHoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barbttSua;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private System.Windows.Forms.BindingSource taiKhoanBindingSource;
        private QLBanCanHoDataSet qLBanCanHoDataSet;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private QLBanCanHoDataSetTableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private QLBanCanHoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView taiKhoanDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DevExpress.XtraEditors.TextEdit matKhauTextEdit;
        private DevExpress.XtraEditors.TextEdit taiKhoanTextEdit;
        private DevExpress.XtraBars.BarButtonItem barbttXoa;
        private System.Windows.Forms.Button bttCancel;
        private System.Windows.Forms.Button bttSave;
    }
}