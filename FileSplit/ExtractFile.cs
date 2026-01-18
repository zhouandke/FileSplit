using System;
using System.ComponentModel;
using System.IO;

namespace FileSplit
{
    class ExtractFile
    {
        public BackgroundWorker bgw;

        const int mBufferSize = 100 * 1024 * 1024;
        byte[] mBuffer = new byte[mBufferSize];

        public void Extract(string sourceFilePath, string targetFolderPath, long offset, long extractSize)
        {
            var fileName = Path.GetFileNameWithoutExtension(sourceFilePath);
            var ext = Path.GetExtension(sourceFilePath);
            var currentFileName = $"{fileName}.subfile{ext}";
            var targetFilePath = Path.Combine(targetFolderPath, currentFileName);

            try
            {
                using (FileStream sourceFs = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read))
                using (FileStream targetFs = new FileStream(targetFilePath, FileMode.Create, FileAccess.Write))
                {
                    sourceFs.Seek(offset, SeekOrigin.Begin);
                    long writtenSize = 0;

                    while (writtenSize < extractSize)
                    {
                        if (bgw.CancellationPending == true)
                        {
                            break;
                        }

                        int bufferFilledSize = sourceFs.Read(mBuffer, 0, mBufferSize);
                        if (bufferFilledSize == 0)
                        {
                            break;
                        }
                        int canWriteSize = (int)Math.Min((long)bufferFilledSize, extractSize - writtenSize);
                        targetFs.Write(mBuffer, 0, canWriteSize);
                        writtenSize += canWriteSize;
                    }
                }
                bgw.ReportProgress(100, $"写入 {currentFileName}");
            }
            catch (Exception ex)
            {
                bgw.ReportProgress(100, $"出现错误 {ex.Message}");
            }

            if (bgw.CancellationPending == true)
            {
                bgw.ReportProgress(0, $"用户取消");
            }
            else
            {
                bgw.ReportProgress(100, $"完成");
            }
        }
    }
}
