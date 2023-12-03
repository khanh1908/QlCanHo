
namespace QlBanCanHo
{
    partial class FormBoPhan
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
            System.Windows.Forms.Label maBPLabel;
            System.Windows.Forms.Label tenBPLabel;
            System.Windows.Forms.Label emailBPLabel;
            System.Windows.Forms.Label soDTBPLabel;
            System.Windows.Forms.Label ngayThanhLapLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBoPhan));
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
            this.qLBanCanHoDataSet = new QlBanCanHo.QLBanCanHoDataSet();
            this.bOPHANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bOPHANTableAdapter = new QlBanCanHo.QLBanCanHoDataSetTableAdapters.BOPHANTableAdapter();
            this.tableAdapterManager = new QlBanCanHo.QLBanCanHoDataSetTableAdapters.TableAdapterManager();
            this.bOPHANDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.bttCancel = new System.Windows.Forms.Button();
            this.bttSave = new System.Windows.Forms.Button();
            this.ngayThanhLapDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.soDTBPTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.emailBPTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tenBPTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.maBPSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            maBPLabel = new System.Windows.Forms.Label();
            tenBPLabel = new System.Windows.Forms.Label();
            emailBPLabel = new System.Windows.Forms.Label();
            soDTBPLabel = new System.Windows.Forms.Label();
            ngayThanhLapLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanCanHoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOPHANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOPHANDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ngayThanhLapDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayThanhLapDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soDTBPTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailBPTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenBPTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maBPSpinEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // maBPLabel
            // 
            maBPLabel.AutoSize = true;
            maBPLabel.Location = new System.Drawing.Point(79, 31);
            maBPLabel.Name = "maBPLabel";
            maBPLabel.Size = new System.Drawing.Size(58, 19);
            maBPLabel.TabIndex = 0;
            maBPLabel.Text = "Ma BP:";
            // 
            // tenBPLabel
            // 
            tenBPLabel.AutoSize = true;
            tenBPLabel.Location = new System.Drawing.Point(332, 39);
            tenBPLabel.Name = "tenBPLabel";
            tenBPLabel.Size = new System.Drawing.Size(65, 19);
            tenBPLabel.TabIndex = 2;
            tenBPLabel.Text = "Ten BP:";
            // 
            // emailBPLabel
            // 
            emailBPLabel.AutoSize = true;
            emailBPLabel.Location = new System.Drawing.Point(624, 35);
            emailBPLabel.Name = "emailBPLabel";
            emailBPLabel.Size = new System.Drawing.Size(77, 19);
            emailBPLabel.TabIndex = 4;
            emailBPLabel.Text = "Email BP:";
            // 
            // soDTBPLabel
            // 
            soDTBPLabel.AutoSize = true;
            soDTBPLabel.Location = new System.Drawing.Point(183, 97);
            soDTBPLabel.Name = "soDTBPLabel";
            soDTBPLabel.Size = new System.Drawing.Size(77, 19);
            soDTBPLabel.TabIndex = 6;
            soDTBPLabel.Text = "So DTBP:";
            // 
            // ngayThanhLapLabel
            // 
            ngayThanhLapLabel.AutoSize = true;
            ngayThanhLapLabel.Location = new System.Drawing.Point(486, 98);
            ngayThanhLapLabel.Name = "ngayThanhLapLabel";
            ngayThanhLapLabel.Size = new System.Drawing.Size(131, 19);
            ngayThanhLapLabel.TabIndex = 8;
            ngayThanhLapLabel.Text = "Ngay Thanh Lap:";
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
            this.barbttThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbttThem.ImageOptions.Image")));
            this.barbttThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbttThem.ImageOptions.LargeImage")));
            this.barbttThem.Name = "barbttThem";
            this.barbttThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barbttThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbttThem_ItemClick);
            // 
            // barbttXoa
            // 
            this.barbttXoa.Caption = "Xóa";
            this.barbttXoa.Id = 2;
            this.barbttXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbttXoa.ImageOptions.Image")));
            this.barbttXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barbttXoa.ImageOptions.LargeImage")));
            this.barbttXoa.Name = "barbttXoa";
            this.barbttXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barbttXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbttXoa_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(877, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 424);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(877, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 390);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(877, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 390);
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
            // qLBanCanHoDataSet
            // 
            this.qLBanCanHoDataSet.DataSetName = "QLBanCanHoDataSet";
            this.qLBanCanHoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bOPHANBindingSource
            // 
            this.bOPHANBindingSource.DataMember = "BOPHAN";
            this.bOPHANBindingSource.DataSource = this.qLBanCanHoDataSet;
            // 
            // bOPHANTableAdapter
            // 
            this.bOPHANTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BOPHANTableAdapter = this.bOPHANTableAdapter;
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
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QlBanCanHo.QLBanCanHoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bOPHANDataGridView
            // 
            this.bOPHANDataGridView.AutoGenerateColumns = false;
            this.bOPHANDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bOPHANDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.bOPHANDataGridView.DataSource = this.bOPHANBindingSource;
            this.bOPHANDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.bOPHANDataGridView.Location = new System.Drawing.Point(0, 34);
            this.bOPHANDataGridView.Name = "bOPHANDataGridView";
            this.bOPHANDataGridView.RowHeadersWidth = 62;
            this.bOPHANDataGridView.RowTemplate.Height = 28;
            this.bOPHANDataGridView.Size = new System.Drawing.Size(877, 220);
            this.bOPHANDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaBP";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaBP";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenBP";
            this.dataGridViewTextBoxColumn2.HeaderText = "TenBP";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "EmailBP";
            this.dataGridViewTextBoxColumn3.HeaderText = "EmailBP";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SoDTBP";
            this.dataGridViewTextBoxColumn4.HeaderText = "SoDTBP";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NgayThanhLap";
            this.dataGridViewTextBoxColumn5.HeaderText = "NgayThanhLap";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.bttCancel);
            this.panelControl1.Controls.Add(this.bttSave);
            this.panelControl1.Controls.Add(ngayThanhLapLabel);
            this.panelControl1.Controls.Add(this.ngayThanhLapDateEdit);
            this.panelControl1.Controls.Add(soDTBPLabel);
            this.panelControl1.Controls.Add(this.soDTBPTextEdit);
            this.panelControl1.Controls.Add(emailBPLabel);
            this.panelControl1.Controls.Add(this.emailBPTextEdit);
            this.panelControl1.Controls.Add(tenBPLabel);
            this.panelControl1.Controls.Add(this.tenBPTextEdit);
            this.panelControl1.Controls.Add(maBPLabel);
            this.panelControl1.Controls.Add(this.maBPSpinEdit);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 254);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(877, 170);
            this.panelControl1.TabIndex = 10;
            // 
            // bttCancel
            // 
            this.bttCancel.Location = new System.Drawing.Point(694, 129);
            this.bttCancel.Name = "bttCancel";
            this.bttCancel.Size = new System.Drawing.Size(79, 36);
            this.bttCancel.TabIndex = 11;
            this.bttCancel.Text = "Cancel";
            this.bttCancel.UseVisualStyleBackColor = true;
            this.bttCancel.Click += new System.EventHandler(this.bttCancel_Click);
            // 
            // bttSave
            // 
            this.bttSave.Location = new System.Drawing.Point(575, 129);
            this.bttSave.Name = "bttSave";
            this.bttSave.Size = new System.Drawing.Size(92, 35);
            this.bttSave.TabIndex = 10;
            this.bttSave.Text = "Save";
            this.bttSave.UseVisualStyleBackColor = true;
            this.bttSave.Click += new System.EventHandler(this.bttSave_Click);
            // 
            // ngayThanhLapDateEdit
            // 
            this.ngayThanhLapDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bOPHANBindingSource, "NgayThanhLap", true));
            this.ngayThanhLapDateEdit.EditValue = null;
            this.ngayThanhLapDateEdit.Location = new System.Drawing.Point(623, 95);
            this.ngayThanhLapDateEdit.MenuManager = this.barManager1;
            this.ngayThanhLapDateEdit.Name = "ngayThanhLapDateEdit";
            this.ngayThanhLapDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayThanhLapDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayThanhLapDateEdit.Size = new System.Drawing.Size(150, 28);
            this.ngayThanhLapDateEdit.TabIndex = 9;
            // 
            // soDTBPTextEdit
            // 
            this.soDTBPTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bOPHANBindingSource, "SoDTBP", true));
            this.soDTBPTextEdit.Location = new System.Drawing.Point(266, 94);
            this.soDTBPTextEdit.MenuManager = this.barManager1;
            this.soDTBPTextEdit.Name = "soDTBPTextEdit";
            this.soDTBPTextEdit.Size = new System.Drawing.Size(150, 28);
            this.soDTBPTextEdit.TabIndex = 7;
            // 
            // emailBPTextEdit
            // 
            this.emailBPTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bOPHANBindingSource, "EmailBP", true));
            this.emailBPTextEdit.Location = new System.Drawing.Point(707, 32);
            this.emailBPTextEdit.MenuManager = this.barManager1;
            this.emailBPTextEdit.Name = "emailBPTextEdit";
            this.emailBPTextEdit.Size = new System.Drawing.Size(150, 28);
            this.emailBPTextEdit.TabIndex = 5;
            // 
            // tenBPTextEdit
            // 
            this.tenBPTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bOPHANBindingSource, "TenBP", true));
            this.tenBPTextEdit.Location = new System.Drawing.Point(403, 36);
            this.tenBPTextEdit.MenuManager = this.barManager1;
            this.tenBPTextEdit.Name = "tenBPTextEdit";
            this.tenBPTextEdit.Size = new System.Drawing.Size(150, 28);
            this.tenBPTextEdit.TabIndex = 3;
            // 
            // maBPSpinEdit
            // 
            this.maBPSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bOPHANBindingSource, "MaBP", true));
            this.maBPSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.maBPSpinEdit.Location = new System.Drawing.Point(143, 28);
            this.maBPSpinEdit.MenuManager = this.barManager1;
            this.maBPSpinEdit.Name = "maBPSpinEdit";
            this.maBPSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.maBPSpinEdit.Size = new System.Drawing.Size(150, 28);
            this.maBPSpinEdit.TabIndex = 1;
            // 
            // FormBoPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 444);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.bOPHANDataGridView);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormBoPhan";
            this.Text = "FormBoPhan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormBoPhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBanCanHoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOPHANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOPHANDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ngayThanhLapDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayThanhLapDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soDTBPTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailBPTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenBPTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maBPSpinEdit.Properties)).EndInit();
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
        private System.Windows.Forms.BindingSource bOPHANBindingSource;
        private QLBanCanHoDataSet qLBanCanHoDataSet;
        private QLBanCanHoDataSetTableAdapters.BOPHANTableAdapter bOPHANTableAdapter;
        private QLBanCanHoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView bOPHANDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.DateEdit ngayThanhLapDateEdit;
        private DevExpress.XtraEditors.TextEdit soDTBPTextEdit;
        private DevExpress.XtraEditors.TextEdit emailBPTextEdit;
        private DevExpress.XtraEditors.TextEdit tenBPTextEdit;
        private DevExpress.XtraEditors.SpinEdit maBPSpinEdit;
        private System.Windows.Forms.Button bttCancel;
        private System.Windows.Forms.Button bttSave;
    }
}