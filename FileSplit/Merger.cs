using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FileSplit
{
    class Merger
    {
        public BackgroundWorker bgw;

        const int mBufferSize = 100 * 1024 * 1024;
        byte[] mBuffer = new byte[mBufferSize];
        int mBufferFilledSize = 0;

        List<FileInfo> mSubFileInfos;
        List<FileInfo>.Enumerator mSubFileInfosEnumerator;
        FileStream mCurrentSourceFs;


        public void Merge(string soureFolderPath, string targetFolderPath)
        {
            var directoryInfo = new DirectoryInfo(soureFolderPath);
            var fileInfos = directoryInfo.GetFiles();
            if (fileInfos.Length == 0)
            {
                bgw.ReportProgress(100, $"没有任何文件");
                return;
            }

            mSubFileInfos = fileInfos.OrderBy(o => o.Name).ToList();
            mSubFileInfosEnumerator = mSubFileInfos.GetEnumerator();

            var targetFileName = createTargetFileName(mSubFileInfos[0].Name);
            var targetFilePath = Path.Combine(targetFolderPath, targetFileName);

            try
            {
                using (FileStream targetFs = new FileStream(targetFilePath, FileMode.Create, FileAccess.Write))
                {
                    while (true)
                    {
                        if (bgw.CancellationPending == true)
                        {
                            break;
                        }

                        FillBuffer();

                        if (mBufferFilledSize == 0)
                        {
                            break;
                        }

                        targetFs.Write(mBuffer, 0, mBufferFilledSize);
                        mBufferFilledSize = 0;
                    }
                }



                bgw.ReportProgress(100, $"写入 {targetFilePath}");
            }
            catch (Exception ex)
            {
                bgw.ReportProgress(100, $"出现错误 {ex.Message}");
            }

            if (mCurrentSourceFs!=null)
            {
                mCurrentSourceFs.Dispose();
                mCurrentSourceFs = null;
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

        string createTargetFileName(string fileNameWithExt)
        {
            string pattern = @"^(.+)\.\d{4}\.(.+)$";
            Match match = Regex.Match(fileNameWithExt, pattern);

            if (!match.Success)
            {
                return fileNameWithExt;
            }

            string fileName = match.Groups[1].Value;     
            string extension = match.Groups[2].Value;  
            return $"{fileName}.{extension}";

        }

        void FillBuffer()
        {
            while (mBufferFilledSize < mBufferSize)
            {
                if (bgw.CancellationPending == true)
                {
                    break;
                }

                if (mCurrentSourceFs == null)
                {
                    if (!mSubFileInfosEnumerator.MoveNext())
                    {
                        return;
                    }

                    mCurrentSourceFs = mSubFileInfosEnumerator.Current.Open(FileMode.Open, FileAccess.Read);
                }

                int readSize = mCurrentSourceFs.Read(mBuffer, mBufferFilledSize, mBufferSize - mBufferFilledSize);
                mBufferFilledSize += readSize;

                if (readSize == 0)
                {
                    mCurrentSourceFs.Dispose();
                    mCurrentSourceFs = null;
                }
            }
        }
    }
}
