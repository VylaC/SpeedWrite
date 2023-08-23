using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeWriter
{
    internal class FileReader
    {

        public string ReadAllText(string filePath)
        {
            try
            {
                Console.WriteLine("Reading the file...");
                Thread.Sleep(1000);
                return File.ReadAllText(filePath);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return string.Empty;
        }
    }
}
