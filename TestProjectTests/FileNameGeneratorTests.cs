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

            String fileName = fileNameGenerator.generateFilename(expectedFileName);

            bool result = fileName == expectedFileName;

            Console.WriteLine(result.ToString());

            Assert.IsFalse(result, result.ToString());
        }
    }
}