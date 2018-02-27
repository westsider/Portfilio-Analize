using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfilio_Analize
{
    class DataConvert
    {
        private TradeResults tradeResults = new TradeResults { };
        private List<TradeResults> allTradeResults = new List<TradeResults>();
        private int fileCount;
        private int filesParsedCount;

        public void createStructFrom(string[] oneFile, bool debug)
        {
            foreach (String rows in oneFile)
            {
                /// Trade Count, Date In, Date Out, Ticker, lastProfitCurrency, cumProfit, exit name, profit factor, winPct Consecutive losers, largest loser, largest winner, profit per month
                var columns = rows.Split(',');
                if (debug)
                {
                    Console.WriteLine(
                     columns[0] + "\t" +    // count
                     columns[1] + "\t" +    // Date In
                     columns[2] + "\t" +    // Date out
                     columns[3] + "\t" +    // Ticker
                     columns[4] + "\t" +    // profit
                     columns[5] + "\t" +    // cumulative
                     columns[6] + "\t" +    // exit name
                     columns[7] + "\t" +    // pf
                     columns[8] + "\t" +    // winPct
                     columns[9] + "\t" +    // consec loser
                     columns[10] + "\t" +   // LL
                     columns[11] + "\t" +   // LW
                     columns[12] + "\t");
                } // monthlyProfit

                tradeResults.tradeNum = Convert.ToInt16(columns[0]);
                tradeResults.dateEntry = columns[1];
                tradeResults.dateExit = columns[2];
                tradeResults.ticker = columns[3];
                tradeResults.profit = Convert.ToDouble(columns[4]);
                tradeResults.cumProfit = Convert.ToDouble(columns[5]);

                tradeResults.exitName = columns[6];
                tradeResults.profitFactor = Convert.ToDouble(columns[7]);
                tradeResults.winPct = Convert.ToDouble(columns[8]);
                tradeResults.consecutiveLosers = Convert.ToInt16(columns[9]);

                tradeResults.largestLoser = Convert.ToDouble(columns[10]);
                tradeResults.largestWinner = Convert.ToDouble(columns[11]);
                tradeResults.profitPerMonth = Convert.ToDouble(columns[12]);

                allTradeResults.Add(tradeResults);

            }

            filesParsedCount += 1;

            ///show struct array when filished
            if (filesParsedCount == fileCount)
            {
                Console.WriteLine("\n" + filesParsedCount + " of " + fileCount + " ticker backtest files parsed\n");
                Console.WriteLine("\nFinished with creating Structs...");
                foreach (TradeResults thing in allTradeResults)
                {
                    if (debug)
                    {
                        Console.WriteLine(thing.tradeNum + " \t\t\t" + thing.dateEntry + "\t\t\t" + thing.dateExit + " \t\t\t" + thing.ticker + "\t\t\t" + thing.profit + "\t\t\t" + thing.cumProfit +
                             " \t\t\t" + thing.exitName + "\t\t\t" + thing.profitFactor + " \t\t\t" + thing.winPct + "\t\t\t" + thing.consecutiveLosers +
                             "\t\t\t" + thing.largestLoser + " \t\t\t" + thing.largestWinner + "\t\t\t" + thing.profitPerMonth
                             );
                    }
                }
            }

        }
    }
}
