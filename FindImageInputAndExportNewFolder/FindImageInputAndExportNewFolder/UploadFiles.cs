
using System.Windows.Forms;

namespace FindImageInputAndExportNewFolder
{
    public partial class UploadFiles : Form
    {
        private List<FileName> jpgFiles;
        private BindingSource bindingSource;
        private BindingSource bindingSourceV2;
        private List<FileName> jpgFiles2 = new List<FileName>();
        // Biến để lưu dòng được chọn
        private DataGridViewRow selectedRow;
        private DataGridViewRow selectedRowV2;
        public UploadFiles()
        {
            InitializeComponent();
        }

        private void btnImportFolder_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại chọn thư mục
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowserDialog.ShowDialog();

                // Nếu người dùng chọn một thư mục và nhấn OK
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    // Set lên txt
                    txtUpload.Text = folderBrowserDialog.SelectedPath;
                    // Lấy danh sách tất cả các tệp trong thư mục
                    string[] files = Directory.GetFiles(folderBrowserDialog.SelectedPath);


                    // Lọc ra các tệp có đuôi mở rộng là .jpg
                    jpgFiles = new List<FileName>();
                    foreach (string file in files)
                    {
                        if (Path.GetExtension(file).Equals(".jpg", StringComparison.OrdinalIgnoreCase))
                        {
                            // Lấy chỉ tên của tệp và thêm vào danh sách jpgFiles
                            string fileName = Path.GetFileName(file);
                            jpgFiles.Add(new FileName
                            {
                                Name = fileName,
                            });
                        }
                    }
                    // Hiển thị tên ảnh trong DataGridView





                    // Hiển thị số lượng tệp .jpg đã được tìm thấy
                    MessageBox.Show($"Tìm thấy {jpgFiles.Count} tệp .jpg trong thư mục đã chọn.");

                    showTable(jpgFiles);
                }
            }
        }
        private void showTable(List<FileName> list)
        {
            dgvImport = updateDataGridView(dgvImport);
            bindingSource = new BindingSource();
            bindingSource.DataSource = list;
            dgvImport.DataSource = null;
            dgvImport.DataSource = bindingSource;
            //foreach (DataGridViewRow row in dgvImport.Rows)
            //{
            //    if (row.Cells[0].Value != null)
            //    {
            //        // Nếu hàng không có giá trị hoặc giá trị là rỗng, bạn có thể thực hiện các hành động tương ứng ở đây
            //        // Ví dụ: Thiết lập giá trị cho cột HeaderCell là số thứ tự hàng, tương tự như bạn đã làm trước đó
            //        row.HeaderCell.Value = (row.Index + 1).ToString();
            //    }
            //}
            dgvImport.ClearSelection();
            dgvExport.ClearSelection();
        }
        private DataGridView updateDataGridView(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgv.BorderStyle = BorderStyle.None;

            dgv.AllowUserToAddRows = false;

            dgv.AllowUserToDeleteRows = false;

            dgv.AllowUserToOrderColumns = false;

            dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;

            dgv.RowHeadersVisible = false;

            dgv.ReadOnly = true;

            return dgv;
        }
        private void showTable2(List<FileName> list)
        {
            dgvExport = updateDataGridView(dgvExport);
            bindingSourceV2 = new BindingSource();
            bindingSourceV2.DataSource = list;
            dgvExport.DataSource = null;
            dgvExport.DataSource = bindingSourceV2;

            foreach (DataGridViewRow row in dgvExport.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    // Nếu hàng không có giá trị hoặc giá trị là rỗng, bạn có thể thực hiện các hành động tương ứng ở đây
                    // Ví dụ: Thiết lập giá trị cho cột HeaderCell là số thứ tự hàng, tương tự như bạn đã làm trước đó
                    row.HeaderCell.Value = (row.Index + 1).ToString();
                }
            }

            dgvImport.ClearSelection();
            dgvExport.ClearSelection();
        }

        private void tblListAdded_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<FileName> list = new List<FileName>();
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên ảnh");
            }
            else
            {
                string search = txtSearch.Text;
                if (jpgFiles.Count > 0)
                {
                    foreach (var file in jpgFiles)
                    {
                        if (file.Name.ToLower().Contains(search.ToLower()))
                        {
                            list.Add(file);
                        }
                    }
                }
                if (list.Count > 0)
                {
                    showTable(list);
                }
            }
        }

        private void btnSearchAll_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            showTable(jpgFiles);
        }

        private void UploadFiles_Load(object sender, EventArgs e)
        {
            dgvImport.KeyPress += DgvImport_KeyPress;

            DataGridViewTextBoxColumn fileNameColumn = new DataGridViewTextBoxColumn();
            // Đặt tên cho cột
            fileNameColumn.DataPropertyName = "Name";
            fileNameColumn.HeaderText = "Name";
            DataGridViewTextBoxColumn fileNameColumnV2 = new DataGridViewTextBoxColumn();
            // Đặt tên cho cột
            fileNameColumnV2.DataPropertyName = "Name";
            fileNameColumnV2.HeaderText = "Name";
            dgvImport.Columns.Add(fileNameColumn);
            dgvExport.Columns.Add(fileNameColumnV2);
        }
        private void DgvImport_KeyPress(object? sender, KeyPressEventArgs e)
        {
            selectedRow = dgvImport.CurrentRow;
            if (selectedRow == null) { return; }
            if (selectedRow != null)
            {
                // Lấy dữ liệu từ dòng đã chọn
                string fileName = selectedRow.Cells[0].Value.ToString();
                if (!string.IsNullOrEmpty(fileName))
                {
                    FileName file = new FileName { Name = fileName };
                    jpgFiles2.Add(file);
                    showTable2(jpgFiles2);
                    dgvImport.Rows.Remove(selectedRow);
                    jpgFiles.RemoveAll(x => x.Name == fileName);
                }
            }
            txtSearch.Text = string.Empty;
        }


        private void DgvExport_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo một hàng hợp lệ đã được chọn
            {
                selectedRowV2 = dgvExport.Rows[e.RowIndex];
            }
        }

        private void DgvImport_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo một hàng hợp lệ đã được chọn
            {
                selectedRow = dgvImport.Rows[e.RowIndex];
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            selectedRowV2 = dgvExport.CurrentRow;
            if (selectedRowV2 == null) { return; }
            if (selectedRowV2 != null)
            {
                string fileName = selectedRowV2.Cells[0].Value.ToString();
                if (!string.IsNullOrEmpty(fileName))
                {
                    jpgFiles.Add(new FileName { Name = fileName });
                    showTable(jpgFiles);
                    dgvExport.Rows.Remove(selectedRowV2);
                    jpgFiles2.RemoveAll(x => x.Name == fileName);
                }
            }
        }

        private void btnExportFolder_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại chọn thư mục
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowserDialog.ShowDialog();

                // Nếu người dùng chọn một thư mục và nhấn OK
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    // Set lên txt
                    txtExport.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem đã chọn thư mục lưu trữ chưa
            if (string.IsNullOrWhiteSpace(txtExport.Text))
            {
                MessageBox.Show("Vui lòng chọn thư mục lưu trữ trước khi lưu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (jpgFiles2.Count > 0)
            {
                // Lưu đường dẫn thư mục đã chọn
                string exportFolderPath = txtExport.Text;

                // Lưu tất cả các file ảnh .jpg từ DataGridView vào thư mục đã chọn
                foreach (DataGridViewRow row in dgvExport.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {

                        string fileName = row.Cells[0].Value.ToString(); // Điều chỉnh tên cột nếu cần

                        // Kiểm tra xem tệp có tồn tại không trước khi sao chép
                        string sourceFilePath = Path.Combine(txtUpload.Text, fileName);
                        if (File.Exists(sourceFilePath))
                        {
                            string destinationFilePath = Path.Combine(exportFolderPath, fileName);
                            File.Copy(sourceFilePath, destinationFilePath);
                        }
                        else
                        {
                            MessageBox.Show($"File '{fileName}' không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                // Thông báo khi hoàn thànhi
                MessageBox.Show("Tất cả các tệp ảnh đã được sao chép vào thư mục được chọn.", "Hoàn thành", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearEXPORTAfterSave();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ảnh để thêm vào folder mới này");
            }



        }

        private void clearEXPORTAfterSave()
        {

            // add all from jpg2 to jpg
            foreach (FileName fileName in jpgFiles2)
            {
                if (fileName != null)
                {
                    jpgFiles.Add(new FileName { Name = fileName.Name });

                    showTable(jpgFiles);
                }
            }

            // delete all jpg2
            jpgFiles2 = new List<FileName>();

            // delete dgv
            dgvExport.Rows.Clear();

            showTable(jpgFiles);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.TextLength > 0)
            {
                btnSearch_Click(sender, e);
            }
            else
            {
                btnSearchAll_Click(sender, e);
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            UploadFiles uploadFiles = new UploadFiles();

            this.Hide();

            uploadFiles.Show();

        }
    }
}
