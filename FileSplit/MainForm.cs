using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace FileSplit
{
    public partial class MainForm : Form
    {
        BackgroundWorker mWorker;

        public MainForm()
        {
            InitializeComponent();
        }

        private void txtFilePath_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void txtFilePath_DragDrop(object sender, DragEventArgs e)
        {
            lblSourceFileSize.Text = "";
            string[] filePathArray = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (filePathArray.Length <= 0)
            {
                txtSourceFilePath.Text = "";
                return;
            }


            FileInfo fileInfo = new FileInfo(filePathArray[0]);
            if (!fileInfo.Exists)
            {
                txtSourceFilePath.Text = "只能拖放文件";
                return;
            }
            if (fileInfo.Length < 1024)
            {
                lblSourceFileSize.Text = $"{fileInfo.Length} Byte";
            }
            else if (fileInfo.Length < 1024 * 1024)
            {
                lblSourceFileSize.Text = $"{fileInfo.Length / 1024.0:F1} KB";
            }
            else if (fileInfo.Length < 1024 * 1024 * 1024)
            {
                lblSourceFileSize.Text = $"{fileInfo.Length / 1024.0 / 1024:F1} MB";
            }
            else
            {
                lblSourceFileSize.Text = $"{fileInfo.Length / 1024.0 / 1024 / 1024:F1} GB";
            }

            txtSourceFilePath.Text = filePathArray[0];
        }

        private void txtTargetFolderPath_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void txtTargetFolderPath_DragDrop(object sender, DragEventArgs e)
        {
            string[] filePathArray = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (filePathArray.Length <= 0)
            {
                return;
            }

            if (Directory.Exists(filePathArray[0]) == false)
            {
                MessageBox.Show("只能拖放文件夹");
                return;
            }

            txtTargetFolderPath.Text = filePathArray[0];
        }

        private void btnSelectTargetFolderPath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "请选择文件夹";
                folderDialog.RootFolder = Environment.SpecialFolder.Desktop;
                folderDialog.SelectedPath = txtTargetFolderPath.Text;
                folderDialog.ShowNewFolderButton = true; // 允许创建新文件夹

                if (folderDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                txtTargetFolderPath.Text = folderDialog.SelectedPath;
            }
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (mWorker != null)
            {
                e.Cancel = true;
                MessageBox.Show("请等待当前任务结束");
            }
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            if (mWorker != null && btnSplit.Text != "开始")
            {
                mWorker.CancelAsync();
                return;
            }

            if (mWorker != null)
            {
                MessageBox.Show("当前任务还未结束");
                return;
            }


            var checkErrorMsg = CheckSourceAndTarget();
            if (checkErrorMsg != "")
            {
                MessageBox.Show(checkErrorMsg);
                return;
            }

            long unit = getUnit(rdoSplitSizeInKB, rdoSplitSizeInMB, rdoSplitSizeInGB);
            if (unit <= 0)
            {
                MessageBox.Show("切割大小的单位 非法");
                return;
            }
            long splitSize = (long)nudSplitSize.Value * unit;
            long sourceFileSize = new FileInfo(txtSourceFilePath.Text).Length;
            if (sourceFileSize > splitSize * 9999)
            {
                MessageBox.Show("最多分割成 9999 个文件");
                return;
            }

            txtLog.Clear();
            btnSplit.Text = "停止";

            mWorker = new BackgroundWorker() { WorkerReportsProgress = true, WorkerSupportsCancellation = true };
            mWorker.ProgressChanged += showLog;
            mWorker.RunWorkerCompleted += (object backgroundSender, RunWorkerCompletedEventArgs runWorkerCompletedEventArgs) =>
            {
                mWorker = null;
                btnSplit.Text = "开始";
            };
            mWorker.DoWork += (object backgroundSender, DoWorkEventArgs doWorkEventArgs) =>
            {
                Spliter spliter = new Spliter();
                spliter.bgw = mWorker;
                spliter.Split(txtSourceFilePath.Text, txtTargetFolderPath.Text, splitSize);
            };

            mWorker.RunWorkerAsync();
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            if (mWorker != null && btnExtract.Text != "开始")
            {
                mWorker.CancelAsync();
                return;
            }

            if (mWorker != null)
            {
                MessageBox.Show("当前任务还未结束");
                return;
            }

            var checkErrorMsg = CheckSourceAndTarget();
            if (checkErrorMsg != "")
            {
                MessageBox.Show(checkErrorMsg);
                return;
            }

            long extractOffsetUnit = getUnit(rdoExtractOffsetInKB, rdoExtractOffsetInMB, rdoExtractOffsetInGB);
            if (extractOffsetUnit <= 0)
            {
                MessageBox.Show("偏移大小的单位 非法");
                return;
            }

            long extractSizeUnit = getUnit(rdoExtractSizeInKB, rdoExtractSizeInMB, rdoExtractSizeInGB);
            if (extractSizeUnit <= 0)
            {
                MessageBox.Show("提取大小的单位 非法");
                return;
            }

            txtLog.Clear();
            btnExtract.Text = "停止";

            long extractOffset = (long)nudExtractOffset.Value * extractOffsetUnit;
            long extractSize = (long)nudExtractSize.Value * extractSizeUnit;

            mWorker = new BackgroundWorker() { WorkerReportsProgress = true, WorkerSupportsCancellation = true };
            mWorker.ProgressChanged += showLog;
            mWorker.RunWorkerCompleted += (object backgroundSender, RunWorkerCompletedEventArgs runWorkerCompletedEventArgs) =>
            {
                mWorker = null;
                btnExtract.Text = "开始";
            };
            mWorker.DoWork += (object backgroundSender, DoWorkEventArgs doWorkEventArgs) =>
            {
                ExtractFile extractFile = new ExtractFile();
                extractFile.bgw = mWorker;
                extractFile.Extract(txtSourceFilePath.Text, txtTargetFolderPath.Text, extractOffset, extractSize);
            };

            mWorker.RunWorkerAsync();
        }

        private string CheckSourceAndTarget()
        {
            FileInfo fileInfo = new FileInfo(txtSourceFilePath.Text);
            if (!fileInfo.Exists)
            {
                return "源文件不存在";
            }

            if (!Directory.Exists(txtTargetFolderPath.Text))
            {
                return "输出文件夹不存在";
            }

            return "";
        }

        static long getUnit(params RadioButton[] radios)
        {
            foreach (var radio in radios)
            {
                if (!radio.Checked)
                {
                    continue;
                }

                if (radio.Text.Contains("K"))
                {
                    return 1024;
                }
                else if (radio.Text.Contains("M"))
                {
                    return 1024 * 1024;
                }
                else if (radio.Text.Contains("G"))
                {
                    return 1024 * 1024 * 1024;
                }
            }

            return -1;
        }

        private void showLog(object sender, ProgressChangedEventArgs e)
        {
            if (txtLog.Text.Length > 65536)
            {
                txtLog.Clear();
            }
            txtLog.AppendText(e.UserState.ToString());
            txtLog.AppendText(Environment.NewLine);
        }

        private void btnSelectMergeSoureFolderPath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                folderDialog.Description = "请选择文件夹";
                folderDialog.RootFolder = Environment.SpecialFolder.Desktop;
                folderDialog.SelectedPath = txtMergeSoureFolderPath.Text;
                folderDialog.ShowNewFolderButton = true; // 允许创建新文件夹

                if (folderDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                txtMergeSoureFolderPath.Text = folderDialog.SelectedPath;
            }
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            if (mWorker != null && btnMerge.Text != "开始")
            {
                mWorker.CancelAsync();
                return;
            }

            if (mWorker != null)
            {
                MessageBox.Show("当前任务还未结束");
                return;
            }

            if (!Directory.Exists(txtMergeSoureFolderPath.Text))
            {
                MessageBox.Show("合并的源文件夹不存在");
                return;
            }

            if (!Directory.Exists(txtTargetFolderPath.Text))
            {
                MessageBox.Show("输出文件夹不存在");
                return;
            }

            txtLog.Clear();
            btnMerge.Text = "停止";

            mWorker = new BackgroundWorker() { WorkerReportsProgress = true, WorkerSupportsCancellation = true };
            mWorker.ProgressChanged += showLog;
            mWorker.RunWorkerCompleted += (object backgroundSender, RunWorkerCompletedEventArgs runWorkerCompletedEventArgs) =>
            {
                mWorker = null;
                btnMerge.Text = "开始";
            };
            mWorker.DoWork += (object backgroundSender, DoWorkEventArgs doWorkEventArgs) =>
            {
                Merger merger = new Merger();
                merger.bgw = mWorker;
                merger.Merge(txtMergeSoureFolderPath.Text, txtTargetFolderPath.Text);
            };

            mWorker.RunWorkerAsync();
        }


    }
}
