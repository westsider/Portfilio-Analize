using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Portfilio_Analize
{
    class Program
    {
        // walk though the basics of SQL https://www.lynda.com/Visual-Studio-tutorials/Visual-Studio-2015-Essentials-13-Data-Tools/499763-2.html
        // walk through SQL read and write https://www.youtube.com/watch?v=Et2khGnrIqc

        //private List<TradeResults> allTradeResults = new List<TradeResults>();

        List<TradeResults> tradeResults = new List<TradeResults>();

        static void Main(string[] args)
        {
            // Get CSV
            CSVhelp csvhelp = new CSVhelp();
            var fileNames = csvhelp.GetFileNames();
            csvhelp.getAllofThe(fileNames: fileNames, debug: true);
            // Save CSV to SQL
            Console.ReadLine();
        }

        public void searchButton()
        {
            DataAccess db = new DataAccess();
            tradeResults = db.GetData("AAPL");
        }

        public void setButton()
        {
            DataAccess db = new DataAccess();
            tradeResults = db.GetData("AAPL");
        }

    }
}
