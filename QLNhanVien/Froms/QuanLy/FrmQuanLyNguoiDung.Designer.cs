
namespace QLNhanVien.Froms.QuanLy
{
    partial class FrmQuanLyNguoiDung
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grbDanhSachNguoiDung = new System.Windows.Forms.GroupBox();
            this.gridDSNguoiDung = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUserNameSearch = new System.Windows.Forms.TextBox();
            this.plDS = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.grbChiTietNguoiDung = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.plChiTiet = new System.Windows.Forms.Panel();
            this.btnCancer = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbChucVu = new System.Windows.Forms.ComboBox();
            this.maNguoiDungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matKhauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenChucVuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heSoLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguoiDungViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grbDanhSachNguoiDung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDSNguoiDung)).BeginInit();
            this.panel1.SuspendLayout();
            this.plDS.SuspendLayout();
            this.grbChiTietNguoiDung.SuspendLayout();
            this.plChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grbDanhSachNguoiDung);
            this.splitContainer1.Panel1.Controls.Add(this.plDS);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grbChiTietNguoiDung);
            this.splitContainer1.Panel2.Controls.Add(this.plChiTiet);
            this.splitContainer1.Size = new System.Drawing.Size(1166, 382);
            this.splitContainer1.SplitterDistance = 793;
            this.splitContainer1.TabIndex = 0;
            // 
            // grbDanhSachNguoiDung
            // 
            this.grbDanhSachNguoiDung.Controls.Add(this.gridDSNguoiDung);
            this.grbDanhSachNguoiDung.Controls.Add(this.panel1);
            this.grbDanhSachNguoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbDanhSachNguoiDung.Location = new System.Drawing.Point(0, 0);
            this.grbDanhSachNguoiDung.Name = "grbDanhSachNguoiDung";
            this.grbDanhSachNguoiDung.Size = new System.Drawing.Size(793, 341);
            this.grbDanhSachNguoiDung.TabIndex = 0;
            this.grbDanhSachNguoiDung.TabStop = false;
            this.grbDanhSachNguoiDung.Text = "Danh sách người dùng";
            // 
            // gridDSNguoiDung
            // 
            this.gridDSNguoiDung.AutoGenerateColumns = false;
            this.gridDSNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDSNguoiDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNguoiDungDataGridViewTextBoxColumn,
            this.hoTenDataGridViewTextBoxColumn,
            this.matKhauDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn,
            this.tenChucVuDataGridViewTextBoxColumn,
            this.heSoLuongDataGridViewTextBoxColumn});
            this.gridDSNguoiDung.DataSource = this.nguoiDungViewBindingSource;
            this.gridDSNguoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDSNguoiDung.Location = new System.Drawing.Point(3, 49);
            this.gridDSNguoiDung.Name = "gridDSNguoiDung";
            this.gridDSNguoiDung.Size = new System.Drawing.Size(787, 289);
            this.gridDSNguoiDung.TabIndex = 2;
            this.gridDSNguoiDung.SelectionChanged += new System.EventHandler(this.gridDSNguoiDung_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtUserNameSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 27);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.Location = new System.Drawing.Point(451, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nhập Username để lọc";
            // 
            // txtUserNameSearch
            // 
            this.txtUserNameSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtUserNameSearch.Location = new System.Drawing.Point(622, 0);
            this.txtUserNameSearch.Name = "txtUserNameSearch";
            this.txtUserNameSearch.Size = new System.Drawing.Size(165, 26);
            this.txtUserNameSearch.TabIndex = 1;
            this.txtUserNameSearch.TextChanged += new System.EventHandler(this.txtUserNameSearch_TextChanged);
            // 
            // plDS
            // 
            this.plDS.Controls.Add(this.btnAdd);
            this.plDS.Controls.Add(this.btnDelete);
            this.plDS.Controls.Add(this.btnEdit);
            this.plDS.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plDS.Location = new System.Drawing.Point(0, 341);
            this.plDS.Name = "plDS";
            this.plDS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.plDS.Size = new System.Drawing.Size(793, 41);
            this.plDS.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAdd.Location = new System.Drawing.Point(580, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(71, 41);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDelete.Location = new System.Drawing.Point(651, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(71, 41);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEdit.Location = new System.Drawing.Point(722, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(71, 41);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // grbChiTietNguoiDung
            // 
            this.grbChiTietNguoiDung.Controls.Add(this.cbbChucVu);
            this.grbChiTietNguoiDung.Controls.Add(this.label6);
            this.grbChiTietNguoiDung.Controls.Add(this.label4);
            this.grbChiTietNguoiDung.Controls.Add(this.label3);
            this.grbChiTietNguoiDung.Controls.Add(this.label2);
            this.grbChiTietNguoiDung.Controls.Add(this.label1);
            this.grbChiTietNguoiDung.Controls.Add(this.txtPhone);
            this.grbChiTietNguoiDung.Controls.Add(this.txtPass);
            this.grbChiTietNguoiDung.Controls.Add(this.txtFullName);
            this.grbChiTietNguoiDung.Controls.Add(this.txtUserName);
            this.grbChiTietNguoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbChiTietNguoiDung.Location = new System.Drawing.Point(0, 0);
            this.grbChiTietNguoiDung.Name = "grbChiTietNguoiDung";
            this.grbChiTietNguoiDung.Size = new System.Drawing.Size(369, 341);
            this.grbChiTietNguoiDung.TabIndex = 0;
            this.grbChiTietNguoiDung.TabStop = false;
            this.grbChiTietNguoiDung.Text = "Chi tiết người dùng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pass";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "FullName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "UserName";
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone.Location = new System.Drawing.Point(104, 165);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(259, 26);
            this.txtPhone.TabIndex = 3;
            // 
            // txtPass
            // 
            this.txtPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPass.Location = new System.Drawing.Point(104, 124);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(259, 26);
            this.txtPass.TabIndex = 2;
            // 
            // txtFullName
            // 
            this.txtFullName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFullName.Location = new System.Drawing.Point(104, 82);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(259, 26);
            this.txtFullName.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserName.Location = new System.Drawing.Point(104, 41);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(259, 26);
            this.txtUserName.TabIndex = 0;
            // 
            // plChiTiet
            // 
            this.plChiTiet.AutoScroll = true;
            this.plChiTiet.Controls.Add(this.btnCancer);
            this.plChiTiet.Controls.Add(this.btnSave);
            this.plChiTiet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plChiTiet.Location = new System.Drawing.Point(0, 341);
            this.plChiTiet.Name = "plChiTiet";
            this.plChiTiet.Size = new System.Drawing.Size(369, 41);
            this.plChiTiet.TabIndex = 1;
            // 
            // btnCancer
            // 
            this.btnCancer.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCancer.Location = new System.Drawing.Point(0, 0);
            this.btnCancer.Name = "btnCancer";
            this.btnCancer.Size = new System.Drawing.Size(71, 41);
            this.btnCancer.TabIndex = 0;
            this.btnCancer.Text = "Hủy";
            this.btnCancer.UseVisualStyleBackColor = true;
            this.btnCancer.Click += new System.EventHandler(this.btnCancer_Click);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.Location = new System.Drawing.Point(298, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(71, 41);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Chức Vụ";
            // 
            // cbbChucVu
            // 
            this.cbbChucVu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbChucVu.FormattingEnabled = true;
            this.cbbChucVu.Location = new System.Drawing.Point(105, 215);
            this.cbbChucVu.Name = "cbbChucVu";
            this.cbbChucVu.Size = new System.Drawing.Size(258, 28);
            this.cbbChucVu.TabIndex = 5;
            // 
            // maNguoiDungDataGridViewTextBoxColumn
            // 
            this.maNguoiDungDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maNguoiDungDataGridViewTextBoxColumn.DataPropertyName = "MaNguoiDung";
            this.maNguoiDungDataGridViewTextBoxColumn.HeaderText = "Mã Người Dùng";
            this.maNguoiDungDataGridViewTextBoxColumn.Name = "maNguoiDungDataGridViewTextBoxColumn";
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            this.hoTenDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hoTenDataGridViewTextBoxColumn.DataPropertyName = "HoTen";
            this.hoTenDataGridViewTextBoxColumn.HeaderText = "Họ Tên";
            this.hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            // 
            // matKhauDataGridViewTextBoxColumn
            // 
            this.matKhauDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.matKhauDataGridViewTextBoxColumn.DataPropertyName = "MatKhau";
            this.matKhauDataGridViewTextBoxColumn.HeaderText = "Mật Khẩu";
            this.matKhauDataGridViewTextBoxColumn.Name = "matKhauDataGridViewTextBoxColumn";
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "SĐT";
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            // 
            // tenChucVuDataGridViewTextBoxColumn
            // 
            this.tenChucVuDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenChucVuDataGridViewTextBoxColumn.DataPropertyName = "TenChucVu";
            this.tenChucVuDataGridViewTextBoxColumn.HeaderText = "Chức Vụ";
            this.tenChucVuDataGridViewTextBoxColumn.Name = "tenChucVuDataGridViewTextBoxColumn";
            // 
            // heSoLuongDataGridViewTextBoxColumn
            // 
            this.heSoLuongDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.heSoLuongDataGridViewTextBoxColumn.DataPropertyName = "HeSoLuong";
            this.heSoLuongDataGridViewTextBoxColumn.HeaderText = "Hệ Số Lương";
            this.heSoLuongDataGridViewTextBoxColumn.Name = "heSoLuongDataGridViewTextBoxColumn";
            // 
            // nguoiDungViewBindingSource
            // 
            this.nguoiDungViewBindingSource.DataSource = typeof(QLNhanVien.ViewModals.NguoiDungView);
            // 
            // FrmQuanLyNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 382);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmQuanLyNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Quản lý người dùng";
            this.Load += new System.EventHandler(this.FrmQuanLyNguoiDung_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grbDanhSachNguoiDung.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDSNguoiDung)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.plDS.ResumeLayout(false);
            this.grbChiTietNguoiDung.ResumeLayout(false);
            this.grbChiTietNguoiDung.PerformLayout();
            this.plChiTiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grbDanhSachNguoiDung;
        private System.Windows.Forms.Panel plDS;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox grbChiTietNguoiDung;
        private System.Windows.Forms.Panel plChiTiet;
        private System.Windows.Forms.Button btnCancer;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUserNameSearch;
        private System.Windows.Forms.DataGridView gridDSNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn testFieldDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource nguoiDungViewBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNguoiDungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matKhauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenChucVuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heSoLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbbChucVu;
        private System.Windows.Forms.Label label6;
    }
}