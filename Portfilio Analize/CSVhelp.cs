using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Portfilio_Analize
{
    class CSVhelp
    {
        public static string systemPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

		public  string[] GetFileNames()
        {

            var dateTime = DateTime.Today.ToString("MM_dd_yyyy");
            var filePath = systemPath + @"\Channel" + "_" + dateTime;
            // Put all file names in root directory into array.
            string[] array1 = Directory.GetFiles(filePath);
            //fileCount = array1.Length;
            return array1;
        }
 
		public void getAllofThe(string[] fileNames, bool debug)
        {
            Console.WriteLine("--- Got " + fileNames.Length.ToString() + " CSV Files: ---");
            foreach (string name in fileNames)
            {
                if (debug) { Console.WriteLine(name); }
                readAllLinesFrom(filePath: name, debug: debug);
            }
        }

        public  void readAllLinesFrom(string filePath, bool debug)
        {
            DataAccess db = new DataAccess();
            
            try
            {
                string[] oneFile = System.IO.File.ReadAllLines(filePath);
                Console.WriteLine("Here is the first line of csv file as a string array\n " + oneFile[0] + "\n");

                DataConvert da = new DataConvert();
                // might need a completion handler for this
                da.createStructFrom(oneFile: oneFile, debug: true);
                var allStructs = da.allTradeResults;
                Console.WriteLine("Here is the last struct array \n " + allStructs.Last().dateEntry + "\n");

                // send to SQL
               
            }
            catch (Exception e)
            {
                Console.WriteLine("\nALERT !!! readAllLinesFrom() Exception: " + e.Message);
            }
            finally
            {
                if (debug) { Console.WriteLine("Executing finally block."); }

            }
        }
    }
}
