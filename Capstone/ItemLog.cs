using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    public class ItemLog
    {
        public void WriteMessage(string message, decimal amountEntered, decimal newBalance)
        {
            string directory = Directory.GetCurrentDirectory();

            string filename = "Log.txt";
            string fullpath = Path.Combine(directory, filename);
            try
            {
                using (StreamWriter sw = new StreamWriter(fullpath, true))
                {
                    string a = string.Format("{0:C}", amountEntered);
                    string b = string.Format("{0:C}", newBalance);
                    sw.WriteLine($"{DateTime.Now} {message} {a} {b}");
                }
            }
            catch(IOException ex)
            {
                Console.WriteLine("Can't Open File For Writing!");
                Console.WriteLine(ex.Message);
            }

        }

        //public void WriteMessage(string message)
        //{
        //
        //}
    }
}
