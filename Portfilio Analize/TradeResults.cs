using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfilio_Analize
{
    public class TradeResults
    {
        /// Trade Count, Date In, Date Out, Ticker, profit, cumProfit,
        public int tradeNum { get; set; }
        public string dateEntry { get; set; }
        public string dateExit { get; set; }
        public string ticker { get; set; }
        public double profit { get; set; }
        public double cumProfit { get; set; }

        /// exit name, profit factor, winPct, Consecutive losers, 
        public string exitName { get; set; }
        public double profitFactor { get; set; }
        public double winPct { get; set; }
        public int consecutiveLosers { get; set; }

        /// largest loser, largest winner, profit per month
        public double largestLoser { get; set; }
        public double largestWinner { get; set; }
        public double profitPerMonth { get; set; }
    }
}
