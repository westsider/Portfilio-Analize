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
        public List<TradeResults> GetData(string ticker)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Portfilio_Analize.Properties.Settings.simplDatabaseConnectionString")))
            {
                return connection.Query<TradeResults>($"select * from TradeResults where ticker = '{ ticker }'").ToList();
            }
        }
    }
}
