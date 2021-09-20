using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Diagnostics;
using SQLDependancyService;
using System.Data.SqlClient;
using WpfClassLibrary.Model;
using System.Threading.Tasks;
using WpfClassLibrary.TmpModel;
using System.Collections.Generic;

namespace WpfClassLibrary
{
    public class WgmateTmpDBUtilClass
    {
        #region // Cpa1Tmp
        public static List<Cpa1TmpCPA1TMainRec> GetCpa1TmpCPA1TMainRec(int CPA1TFileNo, int CPA1TDelPoint, string CPA1TStyle, string CPA1TVarn, ref SQLWriteClass SQLWrite)
        {
            List<Cpa1TmpCPA1TMainRec> listCpa1TmpCPA1TMainRec = null;

            SQLWrite.SQLWriteCommand("[dbo].[GetCpa1TmpCPA1TMainRec]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[4];

            SqlParam[0] = DependancyService.SQLParameter("@CPA1TFileNo",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)CPA1TFileNo);

            SqlParam[1] = DependancyService.SQLParameter("@CPA1TDelPoint",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)CPA1TDelPoint);

            SqlParam[2] = DependancyService.SQLParameter("@CPA1TStyle",
                    "System.String", DependancyService.ParamDirection.Input, (object)CPA1TStyle);

            SqlParam[3] = DependancyService.SQLParameter("@CPA1TVarn",
                    "System.String", DependancyService.ParamDirection.Input, (object)CPA1TVarn);

            DataTable dtCPA1TMainRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtCPA1TMainRec.Rows.Count > 0)
                listCpa1TmpCPA1TMainRec = WpfClassLibrary.Extensions.ToList<Cpa1TmpCPA1TMainRec>(dtCPA1TMainRec);

            return listCpa1TmpCPA1TMainRec;
        }
        public static List<Cpa1TmpCPA1TInstRec> GetCpa1TmpCPA1TInstRec(int CPA1TMainRecID, ref SQLWriteClass SQLWrite)
        {
            List<Cpa1TmpCPA1TInstRec> listCpa1TmpCPA1TInstRec = null;

            SQLWrite.SQLWriteCommand("[dbo].[GetCpa1TmpCPA1TInstRec]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[1];

            SqlParam[0] = DependancyService.SQLParameter("@CPA1TMainRecID",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)CPA1TMainRecID);

            DataTable dtCPA1TInstRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtCPA1TInstRec.Rows.Count > 0)
                listCpa1TmpCPA1TInstRec = WpfClassLibrary.Extensions.ToList<Cpa1TmpCPA1TInstRec>(dtCPA1TInstRec);

            return listCpa1TmpCPA1TInstRec;
        }
        public static List<Cpa1TmpCPA1TMainRec> GetCpa1TmpCPA1TMainRecList(ref SQLWriteClass SQLWrite)
        {
            List<Cpa1TmpCPA1TMainRec> listCpa1TmpCPA1TMainRec = null;

            SQLWrite.SQLWriteCommand("[dbo].[GetCpa1TmpCPA1TMainRecList]", SQLWriteClass.SqlCmdType.PROCEDURE);

            DataTable dtCPA1TMainRec = SQLWrite.ExecuteDataTableQuery(null);

            if (dtCPA1TMainRec.Rows.Count > 0)
                listCpa1TmpCPA1TMainRec = WpfClassLibrary.Extensions.ToList<Cpa1TmpCPA1TMainRec>(dtCPA1TMainRec);

            return listCpa1TmpCPA1TMainRec;
        }
        public static void DeleteCpa1TmpCPA1TMainRec(ref SQLWriteClass SQLWrite)
        {
            SQLWrite.SQLWriteCommand("[dbo].[DeleteCPA1TMainRecAll]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SQLWrite.ExecuteNonQuery(null);
        }
        #endregion
    }
}
