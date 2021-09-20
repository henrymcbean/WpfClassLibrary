using System;
using System.Data;
using System.Linq;
using System.Text;
using SQLDependancyService;
using WpfClassLibrary.Model;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace WpfClassLibrary
{
    public class CostdbExtensions
    {
        static public CostdbCostMRec GetCostsdbCostMRec(string ConnectionString, string Style, string Varn)
        {
            CostdbCostMRec CostMRec = null;
            SQLWriteClass SQLWrite = new SQLWriteClass(SQLConnection.SubscriberConnectionString); 

            SQLWrite.SQLWriteCommand("dbo.GetCostdbStyleVarn", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[2];

            // PaymentPlan ID - int
            SqlParam[0] = DependancyService.SQLParameter("@Style",
                        "System.String", DependancyService.ParamDirection.Input, (object)Style.Trim());

            // Modified - DateTime   SubscriberConnectionString
            SqlParam[1] = DependancyService.SQLParameter("@CTVarn",
                        "System.String", DependancyService.ParamDirection.Input, (object)Varn.Trim());

            DataTable dtCostMRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtCostMRec.Rows.Count > 0)
            {
                List<CostdbCostMRec> listcostMRec = WpfClassLibrary.Extensions.ToList<CostdbCostMRec>(dtCostMRec);
                CostMRec = listcostMRec[0];
            }

            return CostMRec;
        }
    }
}
