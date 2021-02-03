using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject;

namespace TestProject
{
    [TestClass]
    public class MainTest
    {
        [TestMethod]
        public void inputOutput()
        {
            var program = new Program();

            bool result = program.inputOutput().GetType() == typeof(String);

            Assert.IsTrue(result, "result is string");
        }
        [TestMethod]
        public void testFileName()
        {

        }

    }
}
