using BAL.IRepository;
using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Repository
{
    public class ConvertZIP : IConvertZIP
    {
        private readonly string sourceFolder;
        private readonly string targetFolder;

        public ConvertZIP()
        {
            sourceFolder = @"F:\ExampleZIP\sourceFolder"; ;
            targetFolder = @"F:\ExampleZIP\targetFolder\BackUp" + DateTime.Now.Ticks + ".zip";
        }

        public bool FolderInZIP()
        {
            bool isConverted = false;
            ZipFile.CreateFromDirectory(sourceFolder, targetFolder, CompressionLevel.SmallestSize, true);
            return isConverted;
        }
    }
}
