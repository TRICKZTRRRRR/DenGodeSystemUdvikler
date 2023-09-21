using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using DenGodeSystemUdvikler.Model;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenGodeSystemUdvikler.Controller
{
    internal class Controller
    {
        View.View view = new View.View();

        private Lists data = new Lists();

        public void MainController()
        {
            view.Title();
            FileReading();
        }

        public void FileReading()
        {
            try
            {
                string file = @"C:\Users\zbc23jkst\Desktop\TryCatch\txtFile.txt";

                using (StreamReader inputFile = new StreamReader(file))
                {
                    string fileContent = inputFile.ReadToEnd();
                    view.ReadSuccess(fileContent);
                    if (string.IsNullOrWhiteSpace(fileContent))
                    {
                        throw new Exception("Filen er tom eller indeholder ingen data.");
                    }
                    data.logData.AddRange(fileContent.Split('\n'));
                    int errorCount = AnalyzeLogData(fileContent);
                    view.DataAnalyse(errorCount);
                    view.Line();
                    LogData();
                    view.ReadMessage();
                }
            }
            catch (Exception e)
            {
                view.ReadError();
                view.ReadErrorMessage(e.Message);
                view.ReadMessage();
            }
            finally
            {
                view.ReadFinally();
            }
        }

        public int AnalyzeLogData(string fileContent)
        {
            int errorCount = 0;
            foreach (string line in fileContent.Split('\n'))
            {
                if (line.Contains("ERROR"))
                {
                    errorCount++;
                }
            }
            return errorCount;
        }

        private void LogData()
        {
            view.ShowLog();
            foreach (string logEntry in data.logData) 
            {
                view.LogList(logEntry);
            }
        }
    }
}
