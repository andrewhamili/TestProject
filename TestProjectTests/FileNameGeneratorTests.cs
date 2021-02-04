using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Tests
{
    [TestClass()]
    public class FileNameGeneratorTests
    {
        
        [TestMethod()]
        public void generateFilenameTest_newFile()
        {

            FileNameGenerator fileNameGenerator = new FileNameGenerator();

            String expectedFileName = "file.pdf";
            int expectedRevisionId = 0;

            String expectedFullFilename = String.Format("{0}{1}.pdf", expectedFileName, expectedRevisionId > 0 ? "_" + expectedRevisionId : "");

            String fileName = fileNameGenerator.GenerateFilename(expectedFileName, expectedRevisionId);

            bool result = fileName == expectedFullFilename;

            Assert.IsFalse(result, result.ToString());
        }
    }
}