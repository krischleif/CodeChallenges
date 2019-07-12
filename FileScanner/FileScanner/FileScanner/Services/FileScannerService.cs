using FileScanner.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FileScanner.Services
{
    public class FileScannerService : IFileScannerService
    {
        public int GetNumberOfFiles(string directory)
        {
            return Directory.GetFiles(directory).Count();
        }

        public int GetNumberOfDirectories(string directory)
        {
            return Directory.GetDirectories(directory).Count();
        }

        public long GetFileSizeTotal(string directory)
        {
            var dirInfo = new DirectoryInfo(directory);

            return dirInfo.GetFiles().Select(x => x.Length).Sum();
        }

        public int GetAverageFileSize(string directory)
        {
            return (int)GetFileSizeTotal(directory) / GetNumberOfFiles(directory);
        }
    }
}
