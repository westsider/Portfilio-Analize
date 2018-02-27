using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace Portfilio_Analize
{
    public class DataAccess
    {
        // get data from sql
        public List<TradeResults> GetData(string ticker)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Portfilio_Analize.Properties.Settings.simplDatabaseConnectionString")))
            {
                var output = connection.Query<TradeResults>($"select * from TradeResults where ticker = '{ ticker }'").ToList();
                //var output = connection.Query<TradeResults>("dbo.traderesults.getbyticker @Ticker", new { Ticker = ticker }).ToList();  // 53min how build stored procedure
                return output;
            }
        }

        // send data to sql
        public void insertData(TradeResults newLine)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Portfilio_Analize.Properties.Settings.simplDatabaseConnectionString")))
            {
                List<TradeResults> tradeResults = new List<TradeResults>();
                tradeResults.Add(newLine);
                connection.Execute("dbo.TradeResults_Insert @treadeNum, @dateEntry, @dateExit, @ticker", tradeResults);
            }

        }
    }
}
