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
            int revisionId = 0;

            while (fileName != "end")
            {
                try
                {
                    Console.Write("Input filename: ");
                    fileName = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("Input revision ID: ");
                    revisionId = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine(fileNameGenerator.GenerateFilename(fileName, revisionId));
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }

        }
        public int inputOutput()
        {
            return 0;
        }
        
    }
}
