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

        /// ////////////////////////////////////////////////////////////////////////////////////////////////
		/// 									Get file names
		/// ////////////////////////////////////////////////////////////////////////////////////////////////
		public  string[] GetFileNames()
        {

            var dateTime = DateTime.Today.ToString("MM_dd_yyyy");
            var filePath = systemPath + @"\Channel" + "_" + dateTime;
            // Put all file names in root directory into array.
            string[] array1 = Directory.GetFiles(filePath);
            //fileCount = array1.Length;
            return array1;
        }
        /// ////////////////////////////////////////////////////////////////////////////////////////////////
		/// 									Read files in folder
		/// ////////////////////////////////////////////////////////////////////////////////////////////////
		public void readAllofThe(string[] fileNames, bool debug)
        {
            Console.WriteLine("--- Got " + fileNames.Length.ToString() + " CSV Files: ---");
            foreach (string name in fileNames)
            {
                if (debug) { Console.WriteLine(name); }
                readAllLinesFrom(filePath: name, debug: debug);
            }
        }

        /// ////////////////////////////////////////////////////////////////////////////////////////////////
        /// 									Read entire CSV 
        /// ////////////////////////////////////////////////////////////////////////////////////////////////
        public  void readAllLinesFrom(string filePath, bool debug)
        {

            try
            {
                string[] oneFile = System.IO.File.ReadAllLines(filePath);

                //createStructFrom(oneFile: oneFile, debug: false);
                Console.WriteLine(oneFile);
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
