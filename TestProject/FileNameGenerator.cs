using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class FileNameGenerator
    {
        private static List<FileListModel> fileList = new List<FileListModel>();

        public String generateFilename(String fileName)
        {
            List<FileListModel> results = results = fileList.FindAll(m => m.fileName.Equals(fileName));

            int lastRevisionIndex = 0;

            if (results.Count() < 1)
            {
                FileListModel file = new FileListModel();
                file.fileName = fileName;
                file.fileRevision = 0;

                fileList.Add(file);
            }
            else
            {

                lastRevisionIndex = results.Count() - 1;

                FileListModel file = new FileListModel();
                file.fileName = fileName;
                file.fileRevision = results[lastRevisionIndex].fileRevision + 1;

                fileList.Add(file);

                results = fileList.FindAll(m => m.fileName.Equals(fileName));

                lastRevisionIndex = results.Count() - 1;

            }

            String finalFileName = fileName;

            String[] fileNameSeparatedExtension = fileName.Split('.');

            if (lastRevisionIndex > 0)
            {
                finalFileName = String.Format("{0}_{1}{2}", results[lastRevisionIndex].fileName.Split('.')[0], results[lastRevisionIndex].fileRevision, fileNameSeparatedExtension.Count() > 1 ? "." + fileNameSeparatedExtension[1] : "");
            }

            return finalFileName;
        }

    }
}
