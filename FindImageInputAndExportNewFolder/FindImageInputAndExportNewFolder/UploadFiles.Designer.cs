namespace FindImageInputAndExportNewFolder
{
    partial class UploadFiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadFiles));
            btnExportFolder = new Button();
            btnSearch = new Button();
            txtUpload = new TextBox();
            btnImportFolder = new Button();
            dgvImport = new DataGridView();
            txtSearch = new TextBox();
            txtExport = new TextBox();
            dgvExport = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            btnSearchAll = new Button();
            btnSaveAll = new Button();
            btnRestart = new Button();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvImport).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvExport).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnExportFolder
            // 
            btnExportFolder.Location = new Point(461, 64);
            btnExportFolder.Name = "btnExportFolder";
            btnExportFolder.Size = new Size(105, 38);
            btnExportFolder.TabIndex = 9;
            btnExportFolder.Text = "Export";
            btnExportFolder.UseVisualStyleBackColor = true;
            btnExportFolder.Click += btnExportFolder_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(688, 68);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(76, 31);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Visible = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtUpload
            // 
            txtUpload.BorderStyle = BorderStyle.None;
            txtUpload.Location = new Point(7, 108);
            txtUpload.Multiline = true;
            txtUpload.Name = "txtUpload";
            txtUpload.Size = new Size(448, 29);
            txtUpload.TabIndex = 2;
            // 
            // btnImportFolder
            // 
            btnImportFolder.BackColor = SystemColors.Control;
            btnImportFolder.FlatAppearance.BorderColor = SystemColors.Control;
            btnImportFolder.FlatAppearance.BorderSize = 0;
            btnImportFolder.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btnImportFolder.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            btnImportFolder.ForeColor = SystemColors.ActiveCaptionText;
            btnImportFolder.Location = new Point(7, 64);
            btnImportFolder.Name = "btnImportFolder";
            btnImportFolder.Size = new Size(146, 38);
            btnImportFolder.TabIndex = 3;
            btnImportFolder.Text = "Import";
            btnImportFolder.UseVisualStyleBackColor = false;
            btnImportFolder.Click += btnImportFolder_Click;
            // 
            // dgvImport
            // 
            dgvImport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvImport.Location = new Point(7, 197);
            dgvImport.Name = "dgvImport";
            dgvImport.RowHeadersWidth = 56;
            dgvImport.Size = new Size(448, 684);
            dgvImport.TabIndex = 4;
            dgvImport.CellContentClick += tblListAdded_CellContentClick;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Location = new Point(7, 143);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(258, 48);
            txtSearch.TabIndex = 4;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // txtExport
            // 
            txtExport.BorderStyle = BorderStyle.None;
            txtExport.Location = new Point(461, 108);
            txtExport.Multiline = true;
            txtExport.Name = "txtExport";
            txtExport.Size = new Size(453, 29);
            txtExport.TabIndex = 8;
            // 
            // dgvExport
            // 
            dgvExport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExport.Location = new Point(461, 197);
            dgvExport.Name = "dgvExport";
            dgvExport.RowHeadersWidth = 56;
            dgvExport.Size = new Size(453, 480);
            dgvExport.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(808, 53);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(76, 31);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Visible = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(461, 143);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(272, 48);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearchAll
            // 
            btnSearchAll.Location = new Point(358, 143);
            btnSearchAll.Name = "btnSearchAll";
            btnSearchAll.Size = new Size(97, 50);
            btnSearchAll.TabIndex = 6;
            btnSearchAll.Text = "Search all";
            btnSearchAll.UseVisualStyleBackColor = true;
            btnSearchAll.Click += btnSearchAll_Click;
            // 
            // btnSaveAll
            // 
            btnSaveAll.Location = new Point(461, 683);
            btnSaveAll.Name = "btnSaveAll";
            btnSaveAll.Size = new Size(453, 37);
            btnSaveAll.TabIndex = 11;
            btnSaveAll.Text = "Save all";
            btnSaveAll.UseVisualStyleBackColor = true;
            btnSaveAll.Click += btnSaveAll_Click;
            // 
            // btnRestart
            // 
            btnRestart.Location = new Point(826, 143);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(88, 50);
            btnRestart.TabIndex = 12;
            btnRestart.Text = "Restart";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += btnRestart_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-2, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1248, 49);
            panel1.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 12);
            label1.Name = "label1";
            label1.Size = new Size(274, 21);
            label1.TabIndex = 15;
            label1.Text = "Dịch vụ lọc ảnh nhanh - NhuMyStudio";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._367414274_803314774825615_8341341525306293701_n;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // UploadFiles
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            ClientSize = new Size(932, 988);
            Controls.Add(btnExportFolder);
            Controls.Add(panel1);
            Controls.Add(btnRestart);
            Controls.Add(btnSaveAll);
            Controls.Add(btnSearchAll);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dgvExport);
            Controls.Add(txtExport);
            Controls.Add(txtSearch);
            Controls.Add(dgvImport);
            Controls.Add(btnImportFolder);
            Controls.Add(txtUpload);
            Controls.Add(btnSearch);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UploadFiles";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "  ";
            Load += UploadFiles_Load;
            ((System.ComponentModel.ISupportInitialize)dgvImport).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvExport).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExportFolder;
        private Button btnSearch;
        private TextBox txtUpload;
        private Button btnImportFolder;
        private DataGridView dgvImport;
        private TextBox txtSearch;
        private TextBox txtExport;
        private DataGridView dgvExport;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnSearchAll;
        private Button btnSaveAll;
        private Button btnRestart;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
    }
}