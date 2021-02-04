using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class FileNameGenerator
    {

        public String GenerateFilename(String fileName, int revision)
        {
           
            String finalFileName = fileName;

            finalFileName = String.Format("{0}{1}.pdf", fileName, revision > 0 ? "_" + revision : "");

            return finalFileName;
        }

    }
}
