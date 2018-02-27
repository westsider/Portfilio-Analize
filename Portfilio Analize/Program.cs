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
    
        // walk through SQL https://www.youtube.com/watch?v=Et2khGnrIqc

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


    }
}
