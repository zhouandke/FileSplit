using System;
using System.ComponentModel;
using System.IO;

namespace FileSplit
{
    class Spliter
    {
        public BackgroundWorker bgw;

        const int mBufferSize = 100 * 1024 * 1024;
        byte[] mBuffer = new byte[mBufferSize];

        private string mFileName;
        private string mFileExt;

        FileStream mCurrentTargetFs = null;
        string mCurrentFileName;
        long mCurrentTargetFsWriteSize = 0;
        int mCurrentWriteFileIndex = 0;

        public void Split(string sourceFilePath, string targetFolderPath, long splitSize)
        {
            long sourceFileSize = new FileInfo(sourceFilePath).Length;
            mFileName = Path.GetFileNameWithoutExtension(sourceFilePath);
            mFileExt = Path.GetExtension(sourceFilePath);

            try
            {
                using (FileStream sourceFs = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read))
                {
                    while (true)
                    {
                        if (bgw.CancellationPending == true)
                        {
                            break;
                        }

                        int bufferFilledSize = sourceFs.Read(mBuffer, 0, mBufferSize);
                        int bufferConsumeSize = 0;

                        while (bufferFilledSize > bufferConsumeSize)
                        {
                            if (mCurrentTargetFs == null)
                            {
                                mCurrentTargetFs = CreateCurrentTargetFs(targetFolderPath);
                            }

                            var canWriteSize = Math.Min(splitSize - mCurrentTargetFsWriteSize, (long)bufferFilledSize - bufferConsumeSize);
                            mCurrentTargetFs.Write(mBuffer, bufferConsumeSize, (int)canWriteSize);
                            mCurrentTargetFsWriteSize += canWriteSize;
                            bufferConsumeSize += (int)canWriteSize;
                            if (mCurrentTargetFsWriteSize >= splitSize)
                            {
                                bgw.ReportProgress(0, $"写入 {mCurrentFileName}");
                                mCurrentTargetFs.Dispose();
                                mCurrentTargetFs = null;
                                mCurrentFileName = null;
                            }
                        }

                        if (bufferFilledSize == 0)
                        {
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                bgw.ReportProgress(100, $"出现错误 {ex.Message}");
            }
            finally
            {
                if (mCurrentTargetFs != null)
                {
                    bgw.ReportProgress(100, $"写入 {mCurrentFileName}");
                    mCurrentTargetFs.Dispose();
                    mCurrentTargetFs = null;
                    mCurrentFileName = null;
                }
            }

            if (bgw.CancellationPending == true)
            {
                bgw.ReportProgress(100, $"用户取消");
            }
            else
            {
                bgw.ReportProgress(100, $"完成");
            }
        }

        private FileStream CreateCurrentTargetFs(string targetFolderPath)
        {
            mCurrentFileName = $"{mFileName}.{mCurrentWriteFileIndex:D4}{mFileExt}";
            string currentFileFullPath = Path.Combine(targetFolderPath, mCurrentFileName);
            FileStream targetFs = new FileStream(currentFileFullPath, FileMode.Create, FileAccess.Write);
            mCurrentTargetFsWriteSize = 0;
            mCurrentWriteFileIndex++;
            return targetFs;
        }
    }
}
