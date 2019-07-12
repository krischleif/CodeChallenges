using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileScanner.Services.Interfaces
{
    public interface IFileScannerService
    {
        int GetNumberOfFiles(string directory);

        int GetNumberOfDirectories(string directory);

        long GetFileSizeTotal(string directory);

        int GetAverageFileSize(string directory);
    }
}
