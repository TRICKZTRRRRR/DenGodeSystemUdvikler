using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenGodeSystemUdvikler.View
{
    internal class View
    {
        #region View
        public void ReadSuccess(string inputFile)
        {
            Console.WriteLine("Text: ");
            Line();
            Console.WriteLine(inputFile);
        }
        public void ReadError()
        {
            Console.WriteLine("Kunne ikke indlæse filen");
        }
        
        public void ReadErrorMessage(string e)
        {
            Console.Write(e);
        }

        public void ReadFinally()
        {
            Console.WriteLine("Alt data er håndteret rigtigt");
        }
        #endregion

        #region Analyse
        public void DataAnalyse(int errorCount)
        {
            Line();
            Console.WriteLine($"Der står 'ERROR': {errorCount} gange");
        }

        public void LogList(string logEntry)
        {
            Console.WriteLine($"{logEntry}");
        }

        public void ShowLog()
        {
            Console.WriteLine("Listen indeholder: ");
        }

        public void ReadMessage()
        {
            Console.ReadLine();
        }

        public void Clear()
        {
            Console.Clear();
        }

        public void Line()
        {
            Console.WriteLine("--------------------------------------------------");
        }

        #endregion
    }
}
