using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DenGodeSystemUdvikler.Controller
{
    internal class Controller
    {
        View.View view = new View.View();

        public void MainController()
        {
            FileReading();
        }

        public void FileReading()
        {
            try
            {
                string file = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "txtFile.txt");

                using (StreamReader inputFile = new StreamReader(file))
                {
                    view.ReadSuccess(inputFile.ReadToEnd());
                    view.ReadMessage();
                }
            }
            catch (Exception e)
            {
                view.ReadError();
                view.ReadErrorMessage(e.Message);
                view.ReadMessage();
            }
        }
    }
}
