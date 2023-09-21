using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenGodeSystemUdvikler.View
{
    internal class View
    {

        public void ReadSuccess(string inputFile)
        {
            Console.WriteLine($"Text: \n\n" +
                $"{inputFile}");
        }
        public void ReadError()
        {
            Console.WriteLine("Kunne ikke indlæse filen");
        }
        
        public void ReadErrorMessage(string e)
        {
            Console.Write(e);
        }

        public void ReadMessage()
        {
            Console.ReadLine();
        }
    }
}
