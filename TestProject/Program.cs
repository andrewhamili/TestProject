using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class Program
    {

        private static FileNameGenerator fileNameGenerator = new FileNameGenerator();

        static void Main(string[] args)
        {

            String fileName = "";

            while (fileName != "end")
            {
                Console.Write("Input filename: ");
                fileName = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine(fileNameGenerator.generateFilename(fileName));
            }

        }
        public int inputOutput()
        {
            return 0;
        }
        
    }
}
