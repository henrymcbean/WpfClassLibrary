using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Diagnostics;
using SQLDependancyService;
using System.Data.SqlClient;
using WpfClassLibrary.Model;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WpfClassLibrary
{
    public class WgmateDBUtilClass
    {
        #region // Careins
        public static CareinsCINST_MainRec GetCareinsCINST_MainRec(short Type, string Code, short Color, ref SQLWriteClass SQLWrite)
        {
            CareinsCINST_MainRec CINST_MainRec = null;

            SQLWrite.SQLWriteCommand("[dbo].[GetCareinsCINST_MainRec]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[3];

            SqlParam[0] = DependancyService.SQLParameter("@Type",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)Type);

            SqlParam[1] = DependancyService.SQLParameter("@Code",
                    "System.String", DependancyService.ParamDirection.Input, (object)Code);

            SqlParam[2] = DependancyService.SQLParameter("@Color",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)Color);

            DataTable dtCINST_MainRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtCINST_MainRec.Rows.Count > 0)
            {
                List<CareinsCINST_MainRec>  listCareinsCINST_MainRec = WpfClassLibrary.Extensions.ToList<CareinsCINST_MainRec>(dtCINST_MainRec);
                CINST_MainRec = listCareinsCINST_MainRec[0];
            }

            return CINST_MainRec;
        }
        public static CareinsCINST_MainRec GetCareinsCINST_MainRecByCode(short Type, string Code, ref SQLWriteClass SQLWrite)
        {
            CareinsCINST_MainRec CINST_MainRec = null;

            SQLWrite.SQLWriteCommand("[dbo].[GetCareinsCINST_MainRec]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[2];

            SqlParam[0] = DependancyService.SQLParameter("@Type",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)Type);

            SqlParam[1] = DependancyService.SQLParameter("@Code",
                    "System.String", DependancyService.ParamDirection.Input, (object)Code);

            DataTable dtCINST_MainRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtCINST_MainRec.Rows.Count > 0)
            {
                List<CareinsCINST_MainRec>  listCareinsCINST_MainRec = WpfClassLibrary.Extensions.ToList<CareinsCINST_MainRec>(dtCINST_MainRec);
                CINST_MainRec = listCareinsCINST_MainRec[0];
            }

            return CINST_MainRec;
        }
        #endregion

        #region // Colrcomb
        public static ColrcombColrCombSibl GetColrcombColrCombSibl(string Style, string Varn, short Part, short Type, short Colr, ref SQLWriteClass SQLWrite)
        {
            DataTable dtColrCombMain;
            DataTable dtColrCombSibl;
            List<ColrcombColrCombSibl> listColrCombSibl = null;

            SQLWrite.SQLWriteCommand("[dbo].[GetColrcombColrCombMain]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[5];

            SqlParam[0] = DependancyService.SQLParameter("@Style",
                    "System.String", DependancyService.ParamDirection.Input, (object)Style);

            SqlParam[1] = DependancyService.SQLParameter("@Varn",
                    "System.String", DependancyService.ParamDirection.Input, (object)Varn);

            SqlParam[2] = DependancyService.SQLParameter("@MatPart",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)Part);

            SqlParam[3] = DependancyService.SQLParameter("@MatType",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)Type);

            SqlParam[4] = DependancyService.SQLParameter("@ColrNo",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)Colr);

            dtColrCombMain = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtColrCombMain.Rows.Count > 0)
            {
                List<ColrcombColrCombMain> listColrCombMain = WpfClassLibrary.Extensions.ToList<ColrcombColrCombMain>(dtColrCombMain);

                SQLWrite.SQLWriteCommand("GetColrcombColrCombSibl", SQLWriteClass.SqlCmdType.PROCEDURE);
                SqlParam = new SqlParameter[1];

                SqlParam[0] = DependancyService.SQLParameter("@CombMainID",
                        "System.String", DependancyService.ParamDirection.Input, (object)listColrCombMain[0].ID);

                dtColrCombSibl = SQLWrite.ExecuteDataTableQuery(SqlParam);

                if (dtColrCombSibl.Rows.Count > 0)
                    listColrCombSibl = WpfClassLibrary.Extensions.ToList<ColrcombColrCombSibl>(dtColrCombSibl);
            }

            return listColrCombSibl != null ? listColrCombSibl[0] : null;
        }
        public static List<ColrcombColrCombSibl> GetColrcombColrCombSibl(ref CostdbCostMRec CostMRec, ref CostdbCTMatsRec CTMatsRec, ref SQLWriteClass SQLWrite, ref List<ColrcombColrCombMain> listColrCombMain)
        {
            DataTable dtColrCombMain;
            DataTable dtColrCombSibl;
            List<ColrcombColrCombSibl> listColrCombSibl = null;

            SQLWrite.SQLWriteCommand("[dbo].[GetColrcombColrCombMainByCstextraCSTEColoursRec]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[4];

            SqlParam[0] = DependancyService.SQLParameter("@Style",
                    "System.String", DependancyService.ParamDirection.Input, (object)CostMRec.CTStyle);

            SqlParam[1] = DependancyService.SQLParameter("@Varn",
                    "System.String", DependancyService.ParamDirection.Input, (object)CostMRec.CTVarn);

            SqlParam[2] = DependancyService.SQLParameter("@MatPart",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)CTMatsRec.CTMatPart);

            SqlParam[3] = DependancyService.SQLParameter("@MatType",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)CTMatsRec.CTMatType);

            dtColrCombMain = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtColrCombMain.Rows.Count > 0)
            {
                listColrCombMain = WpfClassLibrary.Extensions.ToList<ColrcombColrCombMain>(dtColrCombMain);

                SQLWrite.SQLWriteCommand("GetColrcombColrCombSibl", SQLWriteClass.SqlCmdType.PROCEDURE);
                SqlParam = new SqlParameter[1];

                SqlParam[0] = DependancyService.SQLParameter("@CombMainID",
                        "System.String", DependancyService.ParamDirection.Input, (object)listColrCombMain[0].ID);

                dtColrCombSibl = SQLWrite.ExecuteDataTableQuery(SqlParam);

                if (dtColrCombSibl.Rows.Count > 0)
                    listColrCombSibl = WpfClassLibrary.Extensions.ToList<ColrcombColrCombSibl>(dtColrCombSibl);
            }

            return listColrCombSibl;
        }
        public static List<ColrcombColrCombSibl> GetColrcombColrCombSiblByStyle(string CLCMStyle, string CLCMVarn, ref DataTable dtColrCombMain, ref SQLWriteClass SQLWrite)
        {
            DataTable dtColrCombSibl;
            List<ColrcombColrCombSibl> listColrCombSibl = null;

            SQLWrite.SQLWriteCommand("[dbo].[GetColrcombColrCombMainByStyle]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[2];

            SqlParam[0] = DependancyService.SQLParameter("@Style",
                    "System.String", DependancyService.ParamDirection.Input, (object)CLCMStyle.Trim());

            SqlParam[1] = DependancyService.SQLParameter("@Varn",
                    "System.String", DependancyService.ParamDirection.Input, (object)CLCMVarn.Trim());

            dtColrCombMain = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtColrCombMain.Rows.Count > 0)
            {
                SQLWrite.SQLWriteCommand("GetColrcombColrCombSibl", SQLWriteClass.SqlCmdType.PROCEDURE);
                SqlParam = new SqlParameter[1];

                SqlParam[0] = DependancyService.SQLParameter("@CombMainID",
                        "System.Int32", DependancyService.ParamDirection.Input, (object)dtColrCombMain.Rows[0]["ID"]);

                dtColrCombSibl = SQLWrite.ExecuteDataTableQuery(SqlParam);

                if (dtColrCombSibl.Rows.Count > 0)
                    listColrCombSibl = WpfClassLibrary.Extensions.ToList<ColrcombColrCombSibl>(dtColrCombSibl);
            }

            return listColrCombSibl;
        }
        public static List<ColrcombColrCombSibl> GetColrcombColrCombSiblByStyle(string CLCMStyle, string CLCMVarn, ref SQLWriteClass SQLWrite)
        {
            DataTable dtColrCombMain;
            DataTable dtColrCombSibl;
            List<ColrcombColrCombSibl> listColrCombSibl = null;

            SQLWrite.SQLWriteCommand("[dbo].[GetColrcombColrCombMainByStyle]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[2];

            SqlParam[0] = DependancyService.SQLParameter("@Style",
                    "System.String", DependancyService.ParamDirection.Input, (object)CLCMStyle.Trim());

            SqlParam[1] = DependancyService.SQLParameter("@Varn",
                    "System.String", DependancyService.ParamDirection.Input, (object)CLCMVarn.Trim());

            dtColrCombMain = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtColrCombMain.Rows.Count > 0)
            {
                SQLWrite.SQLWriteCommand("GetColrcombColrCombSibl", SQLWriteClass.SqlCmdType.PROCEDURE);
                SqlParam = new SqlParameter[1];

                SqlParam[0] = DependancyService.SQLParameter("@CombMainID",
                        "System.Int32", DependancyService.ParamDirection.Input, (object)dtColrCombMain.Rows[0]["ID"]);

                dtColrCombSibl = SQLWrite.ExecuteDataTableQuery(SqlParam);

                if (dtColrCombSibl.Rows.Count > 0)
                    listColrCombSibl = WpfClassLibrary.Extensions.ToList<ColrcombColrCombSibl>(dtColrCombSibl);
            }

            return listColrCombSibl;
        }
        public static short GetColrcombColrCombMainFirstCLCMColrNo(string CLCMStyle, string CLCMVarn, ref SQLWriteClass SQLWrite)
        {
            short CLCMColrNo;

            SQLWrite.SQLWriteCommand("[dbo].[GetColrcombColrCombMainFirstCLCMColrNo]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[2];

            SqlParam[0] = DependancyService.SQLParameter("@CLCMStyle",
                    "System.String", DependancyService.ParamDirection.Input, (object)CLCMStyle);

            SqlParam[1] = DependancyService.SQLParameter("@CLCMVarn",
                    "System.String", DependancyService.ParamDirection.Input, (object)CLCMVarn);

            CLCMColrNo = (short)SQLWrite.ExecuteQueryFunction(SqlParam);

            return CLCMColrNo;
        }
        public static bool IsAnyColourCombinations(string CLCMStyle, string CLCMVarn, short CLCMPartNo, short CLCMMatrNo, ref SQLWriteClass SQLWrite)
        {
            bool bColrComb;

            SQLWrite.SQLWriteCommand("[dbo].[IsAnyColourCombinations]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[4];

            SqlParam[0] = DependancyService.SQLParameter("@CLCMStyle",
                    "System.String", DependancyService.ParamDirection.Input, (object)CLCMStyle);

            SqlParam[1] = DependancyService.SQLParameter("@CLCMVarn",
                    "System.String", DependancyService.ParamDirection.Input, (object)CLCMVarn);

            SqlParam[2] = DependancyService.SQLParameter("@CLCMPartNo",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)CLCMPartNo);

            SqlParam[3] = DependancyService.SQLParameter("@CLCMMatrNo",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)CLCMMatrNo);

            bColrComb = (bool)SQLWrite.ExecuteQueryFunction(SqlParam);

            return bColrComb;
        }
        #endregion

        #region // Cusprefs
        public static CusprefsCusPrefsMRec GetCusprefsCusPrefsMRec(string Style, string Varn, short Part, short Type, string Code, short Colr, short Colr1,
                                                                short Supl, short Whse, short Locn, ref SQLWriteClass SQLWrite)
        {
            CusprefsCusPrefsMRec CusPrefsMRec = null;
            SqlParameter[] SqlParam = new SqlParameter[10];
            SQLWrite.SQLWriteCommand("[dbo].[GetCusprefsCusPrefsMRec]", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@Style",
                      "System.String", DependancyService.ParamDirection.Input, (object)Style);

            SqlParam[1] = DependancyService.SQLParameter("@Varn",
                      "System.String", DependancyService.ParamDirection.Input, (object)Varn);

            SqlParam[2] = DependancyService.SQLParameter("@Part",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)Part);

            SqlParam[3] = DependancyService.SQLParameter("@Type",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)Type);

            SqlParam[4] = DependancyService.SQLParameter("@Code",
                      "System.String", DependancyService.ParamDirection.Input, (object)Code);

            SqlParam[5] = DependancyService.SQLParameter("@Colr",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)Colr);

            SqlParam[6] = DependancyService.SQLParameter("@Colr1",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)Colr1);

            SqlParam[7] = DependancyService.SQLParameter("@Supl",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)Supl);

            SqlParam[8] = DependancyService.SQLParameter("@Whse",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)Whse);

            SqlParam[9] = DependancyService.SQLParameter("@Locn",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)Locn);

            DataTable dtCusPrefsMRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtCusPrefsMRec.Rows.Count > 0)
            {
                List<CusprefsCusPrefsMRec> listCusprefsCusPrefsMRec = WpfClassLibrary.Extensions.ToList<CusprefsCusPrefsMRec>(dtCusPrefsMRec);
                CusPrefsMRec = listCusprefsCusPrefsMRec[0];
            }

            return CusPrefsMRec;
        }
        public static CusprefsCusPrefsMRec GetCusprefsCusPrefsMRecByMaterial(short Part, short Type, string Code, short Colr, short Colr1,
                                                                                short Supl, short Whse, short Locn, ref SQLWriteClass SQLWrite)
        {
            CusprefsCusPrefsMRec CusPrefsMRec = null;
            SqlParameter[] SqlParam = new SqlParameter[8];
            SQLWrite.SQLWriteCommand("[dbo].[GetCusprefsCusPrefsMRecByMaterial]", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@Part",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)Part);

            SqlParam[1] = DependancyService.SQLParameter("@Type",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)Type);

            SqlParam[2] = DependancyService.SQLParameter("@Code",
                      "System.String", DependancyService.ParamDirection.Input, (object)Code);

            SqlParam[3] = DependancyService.SQLParameter("@Colr",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)Colr);

            SqlParam[4] = DependancyService.SQLParameter("@Colr1",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)Colr1);

            SqlParam[5] = DependancyService.SQLParameter("@Supl",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)Supl);

            SqlParam[6] = DependancyService.SQLParameter("@Whse",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)Whse);

            SqlParam[7] = DependancyService.SQLParameter("@Locn",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)Locn);

            DataTable dtCusPrefsMRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtCusPrefsMRec.Rows.Count > 0)
            {
                List<CusprefsCusPrefsMRec> listCusprefsCusPrefsMRec = WpfClassLibrary.Extensions.ToList<CusprefsCusPrefsMRec>(dtCusPrefsMRec);
                CusPrefsMRec = listCusprefsCusPrefsMRec[0];
            }

            return CusPrefsMRec;
        }
        public static List<CusprefsCusPrefsSiblRec> GetCusprefsCusPrefsSiblRec(int CusPrefsMRecID, ref SQLWriteClass SQLWrite)
        {
            SqlParameter[] SqlParam = new SqlParameter[1];
            List<CusprefsCusPrefsSiblRec> listCusPrefsSiblRec = null;
            SQLWrite.SQLWriteCommand("[dbo].[GetCusprefsCusPrefsSiblRec]", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@CusPrefsMRecID",
                      "System.Int32", DependancyService.ParamDirection.Input, (object)CusPrefsMRecID);

            DataTable dtCusPrefsSiblRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtCusPrefsSiblRec.Rows.Count > 0)
                listCusPrefsSiblRec = WpfClassLibrary.Extensions.ToList<CusprefsCusPrefsSiblRec>(dtCusPrefsSiblRec);

            return listCusPrefsSiblRec;
        }
        public static List<CusprefsCusPrefsSiblRec> GetCusprefsCusPrefsSiblRecEx(int CusPrefsMRecID, int CustNumber, int CustDelAddrs, ref SQLWriteClass SQLWrite)
        {
            SqlParameter[] SqlParam = new SqlParameter[3];
            List<CusprefsCusPrefsSiblRec> listCusPrefsSiblRec = null;
            SQLWrite.SQLWriteCommand("[dbo].[GetCusprefsCusPrefsSiblRecEx]", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@CusPrefsMRecID",
                      "System.Int32", DependancyService.ParamDirection.Input, (object)CusPrefsMRecID);

            SqlParam[1] = DependancyService.SQLParameter("@CSPRFSELCustNumber",
                      "System.Int32", DependancyService.ParamDirection.Input, (object)CustNumber);

            SqlParam[2] = DependancyService.SQLParameter("@CSPRFSELCustDelAddrs",
                      "System.Int32", DependancyService.ParamDirection.Input, (object)CustDelAddrs);

            DataTable dtCusPrefsSiblRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtCusPrefsSiblRec.Rows.Count > 0)
                listCusPrefsSiblRec = WpfClassLibrary.Extensions.ToList<CusprefsCusPrefsSiblRec>(dtCusPrefsSiblRec);

            return listCusPrefsSiblRec;
        }
        #endregion

        #region // Costsdb
        public static double GetCostsdbCostMRecCTSelPrice1(string Style, string Varn, ref SQLWriteClass SQLWrite)
        {
            double CTSelPrice1 = 0.0;

            SQLWrite.SQLWriteCommand("[dbo].[GetCostsdbCostMRecCTSelPrice1]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[2];

            SqlParam[0] = DependancyService.SQLParameter("@CTSTyle",
                    "System.String", DependancyService.ParamDirection.Input, (object)Style);

            SqlParam[1] = DependancyService.SQLParameter("@CTVarn",
                    "System.String", DependancyService.ParamDirection.Input, (object)Varn);

            CTSelPrice1 = (double)SQLWrite.ExecuteQueryFunction(SqlParam);

            return CTSelPrice1;
        }
        public static CostdbCostMRec GetCostsdbCostMRec(string Style, string Varn, ref SQLWriteClass SQLWrite)
        {
            List<CostdbCostMRec> listcostdbCostMRec = null;

            SQLWrite.SQLWriteCommand("[dbo].[GetCostdbStyleVarn]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[2];

            SqlParam[0] = DependancyService.SQLParameter("@CTSTyle",
                    "System.String", DependancyService.ParamDirection.Input, (object)Style);

            SqlParam[1] = DependancyService.SQLParameter("@CTVarn",
                    "System.String", DependancyService.ParamDirection.Input, (object)Varn);

            DataTable dtCostsdbCostMRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtCostsdbCostMRec.Rows.Count > 0)
                listcostdbCostMRec = WpfClassLibrary.Extensions.ToList<CostdbCostMRec>(dtCostsdbCostMRec);

            return (listcostdbCostMRec != null && listcostdbCostMRec.Count > 0) ? listcostdbCostMRec[0] : null;
        }
        public static List<CostdbCTNotsRec> GetGetCostdbCTNotsRec(int CostdbID, ref SQLWriteClass SQLWrite)
        {
            List<CostdbCTNotsRec> listcostdbCTNotsRec = null;

            SQLWrite.SQLWriteCommand("[dbo].[GetCostdbCTNotsRec]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[1];

            SqlParam[0] = DependancyService.SQLParameter("@CostdbID",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)CostdbID);

            DataTable dtCostdbCTNotsRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtCostdbCTNotsRec.Rows.Count > 0)
                listcostdbCTNotsRec = WpfClassLibrary.Extensions.ToList<CostdbCTNotsRec>(dtCostdbCTNotsRec);

            return (listcostdbCTNotsRec != null && listcostdbCTNotsRec.Count > 0) ? listcostdbCTNotsRec : null;
        }
        public static List<CostdbCTNotsRec> GetCostdbCTNotsRecByCTStyleCTVarn(string CTStyle, string CTVarn, ref SQLWriteClass SQLWrite)
        {
            List<CostdbCTNotsRec> listcostdbCTNotsRec = null;

            SQLWrite.SQLWriteCommand("[dbo].[GetCostsdbCTNotsRecByStyleVarn]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[2];

            SqlParam[0] = DependancyService.SQLParameter("@CTStyle",
                    "System.String", DependancyService.ParamDirection.Input, (object)CTStyle);

            SqlParam[1] = DependancyService.SQLParameter("@CTVarn",
                    "System.String", DependancyService.ParamDirection.Input, (object)CTVarn);

            DataTable dtCostdbCTNotsRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtCostdbCTNotsRec.Rows.Count > 0)
                listcostdbCTNotsRec = WpfClassLibrary.Extensions.ToList<CostdbCTNotsRec>(dtCostdbCTNotsRec);

            return (listcostdbCTNotsRec != null && listcostdbCTNotsRec.Count > 0) ? listcostdbCTNotsRec : null;
        }
        public static string GetCostsdbCostMRecCTUkSzKey(string Style, string Varn, ref SQLWriteClass SQLWrite)
        {
            string CTUkSzKey = "";

            SQLWrite.SQLWriteCommand("[dbo].[GetCostsdbCostMRecCTUkSzKey]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[2];

            SqlParam[0] = DependancyService.SQLParameter("@CTSTyle",
                    "System.String", DependancyService.ParamDirection.Input, (object)Style);

            SqlParam[1] = DependancyService.SQLParameter("@CTVarn",
                    "System.String", DependancyService.ParamDirection.Input, (object)Varn);

            CTUkSzKey = (string)SQLWrite.ExecuteQueryFunction(SqlParam);

            return CTUkSzKey;
        }
        public static string GetCostsdbCostMRecCTStyleDescr(string Style, string Varn, ref SQLWriteClass SQLWrite)
        {
            string sStyleDescr = "";

            SQLWrite.SQLWriteCommand("[dbo].[GetCostsdbCostMRecCTStyleDescr]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[2];

            SqlParam[0] = DependancyService.SQLParameter("@CTSTyle",
                    "System.String", DependancyService.ParamDirection.Input, (object)Style);

            SqlParam[1] = DependancyService.SQLParameter("@CTVarn",
                    "System.String", DependancyService.ParamDirection.Input, (object)Varn);

            sStyleDescr = (string)SQLWrite.ExecuteQueryFunction(SqlParam);

            return sStyleDescr;
        }
        public static double GetCostsdbCostMRecCTCostMaking(string Style, string Varn, ref SQLWriteClass SQLWrite)
        {
            double CostMaking = 0.0;

            SQLWrite.SQLWriteCommand("[dbo].[GetCostsdbCostMRecCTCostMaking]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[2];

            SqlParam[0] = DependancyService.SQLParameter("@CTSTyle",
                    "System.String", DependancyService.ParamDirection.Input, (object)Style);

            SqlParam[1] = DependancyService.SQLParameter("@CTVarn",
                    "System.String", DependancyService.ParamDirection.Input, (object)Varn);

            CostMaking = (double)SQLWrite.ExecuteQueryFunction(SqlParam);

            return CostMaking;
        }
        public static double GetCostsdbCostMRecCTTimeToMake(string Style, string Varn, ref SQLWriteClass SQLWrite)
        {
            double TimeToMake = 0.0;

            SQLWrite.SQLWriteCommand("[dbo].[GetCostsdbCostMRecCTTimeToMake]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[2];

            SqlParam[0] = DependancyService.SQLParameter("@CTSTyle",
                    "System.String", DependancyService.ParamDirection.Input, (object)Style);

            SqlParam[1] = DependancyService.SQLParameter("@CTVarn",
                    "System.String", DependancyService.ParamDirection.Input, (object)Varn);

            TimeToMake = (double)SQLWrite.ExecuteQueryFunction(SqlParam);

            return TimeToMake;
        }
        public static string GetCostsdbCostMRecCTMainFabric(string Style, string Varn, ref SQLWriteClass SQLWrite)
        {
            string CTMainFabric = "";

            SQLWrite.SQLWriteCommand("[dbo].[GetCostsdbCostMRecCTMainFabric]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[2];

            SqlParam[0] = DependancyService.SQLParameter("@CTSTyle",
                    "System.String", DependancyService.ParamDirection.Input, (object)Style);

            SqlParam[1] = DependancyService.SQLParameter("@CTVarn",
                    "System.String", DependancyService.ParamDirection.Input, (object)Varn);

            CTMainFabric = (string)SQLWrite.ExecuteQueryFunction(SqlParam);

            return CTMainFabric;
        }
        public static CostdbCTMatsRec GetGetCostsdbCTMatsRecFirstRecord(string Style, string Varn, ref SQLWriteClass SQLWrite)
        {
            List<CostdbCTMatsRec> listcostdbCTMatsRec = null;

            SQLWrite.SQLWriteCommand("[dbo].[GetCostsdbCTMatsRecFirstRecord]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[2];

            SqlParam[0] = DependancyService.SQLParameter("@CTSTyle",
                    "System.String", DependancyService.ParamDirection.Input, (object)Style);

            SqlParam[1] = DependancyService.SQLParameter("@CTVarn",
                    "System.String", DependancyService.ParamDirection.Input, (object)Varn);

            DataTable dtCostdbCTMatsRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtCostdbCTMatsRec.Rows.Count > 0)
                listcostdbCTMatsRec = WpfClassLibrary.Extensions.ToList<CostdbCTMatsRec>(dtCostdbCTMatsRec);

            return (listcostdbCTMatsRec != null && listcostdbCTMatsRec.Count > 0) ? listcostdbCTMatsRec[0] : null;
        }
        public static double GetCostsdbCostMRecCTGrading(string Style, string Varn, ref SQLWriteClass SQLWrite)
        {
            double CTGrading = 0.0;

            SQLWrite.SQLWriteCommand("[dbo].[GetCostsdbCostMRecCTGrading]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[2];

            SqlParam[0] = DependancyService.SQLParameter("@CTSTyle",
                    "System.String", DependancyService.ParamDirection.Input, (object)Style);

            SqlParam[1] = DependancyService.SQLParameter("@CTVarn",
                    "System.String", DependancyService.ParamDirection.Input, (object)Varn);

            CTGrading = (double)SQLWrite.ExecuteQueryFunction(SqlParam);

            return CTGrading;
        }
        public static List<CostdbCTMatsRec> GetCostdbCTMatsRec(int CostdbID, ref SQLWriteClass SQLWrite)
        {
            List<CostdbCTMatsRec> listcostdbCTMatsRec = null;

            SQLWrite.SQLWriteCommand("[dbo].[GetCostdbCTMatsRec]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[1];

            SqlParam[0] = DependancyService.SQLParameter("@CostdbID",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)CostdbID);

            DataTable dtCostdbCTMatsRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtCostdbCTMatsRec.Rows.Count > 0)
                listcostdbCTMatsRec = WpfClassLibrary.Extensions.ToList<CostdbCTMatsRec>(dtCostdbCTMatsRec);

            return (listcostdbCTMatsRec != null && listcostdbCTMatsRec.Count > 0) ? listcostdbCTMatsRec : null;
        }
        public static List<CostdbCTMatsRec> GetCostdbCTMatsRecByCTStyleCTVarn(string Style, string Varn, ref SQLWriteClass SQLWrite)
        {
            List<CostdbCTMatsRec> listcostdbCTMatsRec = null;

            SQLWrite.SQLWriteCommand("[dbo].[GetCostdbCTMatsRecByCTStyleCTVarn]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[2];

            SqlParam[0] = DependancyService.SQLParameter("@CTSTyle",
                    "System.String", DependancyService.ParamDirection.Input, (object)Style);

            SqlParam[1] = DependancyService.SQLParameter("@CTVarn",
                    "System.String", DependancyService.ParamDirection.Input, (object)Varn);

            DataTable dtCostdbCTMatsRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtCostdbCTMatsRec.Rows.Count > 0)
                listcostdbCTMatsRec = WpfClassLibrary.Extensions.ToList<CostdbCTMatsRec>(dtCostdbCTMatsRec);

            return (listcostdbCTMatsRec != null && listcostdbCTMatsRec.Count > 0) ? listcostdbCTMatsRec : null;
        }
        public static bool GetCostsdbCostMRecAndSibbling(string Style, string Varn, ref List<CostdbCostMRec> listCostdbCostMRec, ref List<CostdbCTMatsRec> listCostdbCTMatsRec, ref SQLWriteClass SQLWrite)
        {
            bool bFound = false;

            SQLWrite.SQLWriteCommand("[dbo].[GetCostdbStyleVarn]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[2];

            SqlParam[0] = DependancyService.SQLParameter("@CTSTyle",
                    "System.String", DependancyService.ParamDirection.Input, (object)Style);

            SqlParam[1] = DependancyService.SQLParameter("@CTVarn",
                    "System.String", DependancyService.ParamDirection.Input, (object)Varn);

            DataTable dtCostMRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtCostMRec.Rows.Count > 0)
            {
                bFound = true;
                listCostdbCostMRec = Extensions.ToList<CostdbCostMRec>(dtCostMRec);

                SQLWrite.SQLWriteCommand("[dbo].[GetCostdbCTMatsRec]", SQLWriteClass.SqlCmdType.PROCEDURE);
                SqlParam = new SqlParameter[1];

                SqlParam[0] = DependancyService.SQLParameter("@CostdbID",
                        "System.Int32", DependancyService.ParamDirection.Input, (object)listCostdbCostMRec[0].CostdbID);

                DataTable dtCTMatsRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

                if (dtCTMatsRec.Rows.Count > 0)
                    listCostdbCTMatsRec = Extensions.ToList<CostdbCTMatsRec>(dtCTMatsRec);
            }

            return bFound;
        }
        public static double GetOrdersOrdCostsOrdCostingView(int FileNoIssd, string OrdStyle, string OrdVarn, short OrdColrNo, short OrdMatType,
                                                                string OrdMatCode, short OrdMatSupl, short OrdMatWhse, short OrdMatLocn, ref SQLWriteClass SQLWrite)
        {
            double OrdCosting = 0.0;

            SQLWrite.SQLWriteCommand("[dbo].[GetOrdersOrdCostsOrdCostingView]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[9];

            SqlParam[0] = DependancyService.SQLParameter("@OrdFlNoIssued",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)FileNoIssd);

            SqlParam[1] = DependancyService.SQLParameter("@CTStyle",
                    "System.String", DependancyService.ParamDirection.Input, (object)OrdStyle);

            SqlParam[2] = DependancyService.SQLParameter("@CTVarn",
                    "System.String", DependancyService.ParamDirection.Input, (object)OrdVarn);

            SqlParam[3] = DependancyService.SQLParameter("@CTMatColr",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)OrdColrNo);

            SqlParam[4] = DependancyService.SQLParameter("@CTMatType",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)OrdMatType);

            SqlParam[5] = DependancyService.SQLParameter("@CTMatCode",
                    "System.String", DependancyService.ParamDirection.Input, (object)OrdMatCode);

            SqlParam[6] = DependancyService.SQLParameter("@CTMatSupl",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)OrdMatSupl);

            SqlParam[7] = DependancyService.SQLParameter("@CTMatWhse",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)OrdMatWhse);

            SqlParam[8] = DependancyService.SQLParameter("@CTMatLocn",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)OrdMatLocn);

            OrdCosting = (double)SQLWrite.ExecuteQueryFunction(SqlParam);

            return OrdCosting;
        }
        public static bool IsCostsdbCTMatsRecCTMatTypeValid(string Style, string Varn, short CTMatType, ref SQLWriteClass SQLWrite)
        {
            bool bValid = false;

            SQLWrite.SQLWriteCommand("[dbo].[IsCostsdbCTMatsRecCTMatTypeValid]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[3];

            SqlParam[0] = DependancyService.SQLParameter("@CTSTyle",
                    "System.String", DependancyService.ParamDirection.Input, (object)Style);

            SqlParam[1] = DependancyService.SQLParameter("@CTVarn",
                    "System.String", DependancyService.ParamDirection.Input, (object)Varn);

            SqlParam[2] = DependancyService.SQLParameter("@CTMatType",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)CTMatType);

            bValid = (bool)SQLWrite.ExecuteQueryFunction(SqlParam);

            return bValid;
        }
        #endregion

        #region // Consumpt
        public static string GetConsumptMRecConSConsumption(string Style, string Varn, string SizeKey,
                                                                        short Part, short Type, string Code, short Colr,
                                                                            short Colr1, short Supl, short Whse, short Locn,
                                                                                                    ref SQLWriteClass SQLWrite)
        {
            string ConSConsumption = "";

            SQLWrite.SQLWriteCommand("[dbo].[GetConsumptConsumptMRecConSConsumption]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[11];

            SqlParam[0] = DependancyService.SQLParameter("@Style",
                    "System.String", DependancyService.ParamDirection.Input, (object)Style);

            SqlParam[1] = DependancyService.SQLParameter("@Varn",
                    "System.String", DependancyService.ParamDirection.Input, (object)Varn);

            SqlParam[2] = DependancyService.SQLParameter("@SizeKey",
                    "System.String", DependancyService.ParamDirection.Input, (object)SizeKey);

            SqlParam[3] = DependancyService.SQLParameter("@Part",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)Part);

            SqlParam[4] = DependancyService.SQLParameter("@Type",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)Type);

            SqlParam[5] = DependancyService.SQLParameter("@Code",
                    "System.String", DependancyService.ParamDirection.Input, (object)Code);

            SqlParam[6] = DependancyService.SQLParameter("@Colr",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)Colr);

            SqlParam[7] = DependancyService.SQLParameter("@Colr1",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)Colr1);

            SqlParam[8] = DependancyService.SQLParameter("@Supl",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)Supl);

            SqlParam[9] = DependancyService.SQLParameter("@Whse",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)Whse);

            SqlParam[10] = DependancyService.SQLParameter("@Locn",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)Locn);

            ConSConsumption = (string)SQLWrite.ExecuteQueryFunction(SqlParam);

            return ConSConsumption;
        }
        #endregion

        #region // Cospinst
        public static List<CospinstCOIInstsRec> GetCospinstCOIInstsRec(string Style, string Varn, ref SQLWriteClass SQLWrite)
        {
            List<CospinstCOIInstsRec> listcospinstCOIInstsRec = null;

            SQLWrite.SQLWriteCommand("[dbo].[GetCospinstCOIInstsRec]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[2];

            SqlParam[0] = DependancyService.SQLParameter("@Style",
                    "System.String", DependancyService.ParamDirection.Input, (object)Style);

            SqlParam[1] = DependancyService.SQLParameter("@Varn",
                    "System.String", DependancyService.ParamDirection.Input, (object)Varn);

            DataTable dtCOIInstsRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtCOIInstsRec.Rows.Count > 0)
                listcospinstCOIInstsRec = WpfClassLibrary.Extensions.ToList<CospinstCOIInstsRec>(dtCOIInstsRec);

            return (listcospinstCOIInstsRec != null && listcospinstCOIInstsRec.Count > 0) ? listcospinstCOIInstsRec : null;
        }
        #endregion

        #region // Cpcusts
        public static short GetCpcustsCPCSTMainRecCPCSTNoOfDays(int CPCSTCustNo, short CPCSTOperNo, short CPCSTCpaNo, ref SQLWriteClass SQLWrite)
        {
            SqlParameter[] SqlParam = new SqlParameter[3];
            SQLWrite.SQLWriteCommand("dbo.GetCpcustsCPCSTMainRecCPCSTNoOfDays", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@CPCSTCustNo", "System.Int32", DependancyService.ParamDirection.Input, (object)CPCSTCustNo);
            SqlParam[1] = DependancyService.SQLParameter("@CPCSTOperNo", "System.Int16", DependancyService.ParamDirection.Input, (object)CPCSTOperNo);
            SqlParam[2] = DependancyService.SQLParameter("@CPCSTCpaNo", "System.Int16", DependancyService.ParamDirection.Input, (object)CPCSTCpaNo);

            short GMOCPAFactNo = (short)SQLWrite.ExecuteQueryFunction(SqlParam);

            return GMOCPAFactNo;
        }
        #endregion

        #region // Cstextra
        public static int GetCstextraCSTExtraRecCSTEFactory(string CSTEStyle, string CSTEVarn, ref SQLWriteClass SQLWrite)
        {
            int CSTEFactory = 0;
            SQLWrite.SQLWriteCommand("[dbo].[GetCstextraCSTExtraRecCSTEFactory]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[2];

            SqlParam[0] = DependancyService.SQLParameter("@CSTEStyle",
                    "System.String", DependancyService.ParamDirection.Input, (object)CSTEStyle);

            SqlParam[1] = DependancyService.SQLParameter("@CSTEVarn",
                    "System.String", DependancyService.ParamDirection.Input, (object)CSTEVarn);

            CSTEFactory = (int)SQLWrite.ExecuteQueryFunction(SqlParam);

            return CSTEFactory;
        }
        public static CstextraCSTExtraRec GetCstextraCSTExtraRec(string Style, string Varn, ref SQLWriteClass SQLWrite)
        {
            List<CstextraCSTExtraRec> listcstextraCSTExtraRec = null;

            SQLWrite.SQLWriteCommand("[dbo].[GetCstextraCSTExtraRec]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[2];

            SqlParam[0] = DependancyService.SQLParameter("@Style",
                    "System.String", DependancyService.ParamDirection.Input, (object)Style);

            SqlParam[1] = DependancyService.SQLParameter("@Varn",
                    "System.String", DependancyService.ParamDirection.Input, (object)Varn);

            DataTable dtCstextraCSTExtraRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtCstextraCSTExtraRec.Rows.Count > 0)
                listcstextraCSTExtraRec = WpfClassLibrary.Extensions.ToList<CstextraCSTExtraRec>(dtCstextraCSTExtraRec);

            return (listcstextraCSTExtraRec != null && listcstextraCSTExtraRec.Count > 0) ? listcstextraCSTExtraRec[0] : null;
        }
        public static List<CstextraCSTEColoursRec> GetCstextraCSTEColoursRec(string Style, string Varn, ref SQLWriteClass SQLWrite)
        {
            List<CstextraCSTEColoursRec> listcstextraCSTExtraRec = null;

            SQLWrite.SQLWriteCommand("[dbo].[GetCstextraCSTEColoursRec]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[2];

            SqlParam[0] = DependancyService.SQLParameter("@Style",
                    "System.String", DependancyService.ParamDirection.Input, (object)Style);

            SqlParam[1] = DependancyService.SQLParameter("@Varn",
                    "System.String", DependancyService.ParamDirection.Input, (object)Varn);

            DataTable dtCstextraCSTEColoursRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtCstextraCSTEColoursRec.Rows.Count > 0)
                listcstextraCSTExtraRec = WpfClassLibrary.Extensions.ToList<CstextraCSTEColoursRec>(dtCstextraCSTEColoursRec);

            return listcstextraCSTExtraRec;
        }
        #endregion

        #region // DaysOff
        public static List<DaysoffHHeaderInfo> GetDaysoffHHeaderInfo(short HClientType, int HClientNumber, int HYear, ref SQLWriteClass SQLWrite)
        {
            SqlParameter[] SqlParam = new SqlParameter[3];
            List<DaysoffHHeaderInfo> listDaysoffHHeaderInfo = null;
            SQLWrite.SQLWriteCommand("[dbo].[GetDaysoffHHeaderInfo]", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@HClientType",
                        "System.Int16", DependancyService.ParamDirection.InputOutput, (object)HClientType);

            SqlParam[1] = DependancyService.SQLParameter("@HClientNumber",
                        "System.Int32", DependancyService.ParamDirection.Input, (object)HClientNumber);

            SqlParam[2] = DependancyService.SQLParameter("@HYear",
                        "System.Int16", DependancyService.ParamDirection.Input, (object)HYear);

            DataTable dtHHeaderInfo = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtHHeaderInfo.Rows.Count > 0)
                listDaysoffHHeaderInfo = WpfClassLibrary.Extensions.ToList<DaysoffHHeaderInfo>(dtHHeaderInfo);

            return listDaysoffHHeaderInfo;
        }
        public static List<DaysoffHHolidaysInfo> GetDaysoffHHolidaysInfo(int HHeaderInfoID, ref SQLWriteClass SQLWrite)
        {
            SqlParameter[] SqlParam = new SqlParameter[1];
            List<DaysoffHHolidaysInfo> listDaysoffHHolidaysInfo = null;
            SQLWrite.SQLWriteCommand("[dbo].[GetDaysoffHHolidaysInfo]", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@HHeaderInfoID",
                        "System.Int32", DependancyService.ParamDirection.InputOutput, (object)@HHeaderInfoID);

            DataTable dtHHolidaysInfo = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtHHolidaysInfo.Rows.Count > 0)
                listDaysoffHHolidaysInfo = WpfClassLibrary.Extensions.ToList<DaysoffHHolidaysInfo>(dtHHolidaysInfo);

            return listDaysoffHHolidaysInfo;
        }
        public static List<DaysoffHVariableDaysInfo> GetDaysoffHVariableDaysInfo(int HHeaderInfoID, ref SQLWriteClass SQLWrite)
        {
            SqlParameter[] SqlParam = new SqlParameter[1];
            List<DaysoffHVariableDaysInfo> listDaysoffHVariableDaysInfo = null;
            SQLWrite.SQLWriteCommand("[dbo].[GetDaysoffHVariableDaysInfo]", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@HHeaderInfoID",
                        "System.Int32", DependancyService.ParamDirection.InputOutput, (object)@HHeaderInfoID);

            DataTable dtHVariableDaysInfo = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtHVariableDaysInfo.Rows.Count > 0)
                listDaysoffHVariableDaysInfo = WpfClassLibrary.Extensions.ToList<DaysoffHVariableDaysInfo>(dtHVariableDaysInfo);

            return listDaysoffHVariableDaysInfo;
        }
        #endregion

        #region // dockets
        public static bool CompleteDocket(int DocketNoIssued, ref SQLWriteClass SQLWrite)
        {
            bool bRtn = false;
            bool? CompleteFlag = false;
            SqlParameter[] SqlParam = new SqlParameter[2];
            SQLWrite.SQLWriteCommand("dbo.DcksnCompleteDocket", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@Complete",
                        "System.Boolean", DependancyService.ParamDirection.InputOutput, (object)CompleteFlag);

            SqlParam[1] = DependancyService.SQLParameter("@DocketNoIssued",
                        "System.Int32", DependancyService.ParamDirection.Input, (object)DocketNoIssued);

            bRtn = SQLWrite.ExecuteNonQuery(SqlParam);

            return bRtn;
        }
        public static DocketMainData GetDocketMainData(int DocketNoIssued, ref SQLWriteClass SQLWrite)
        {
            DocketMainData MainData = null;
            SqlParameter[] SqlParam = new SqlParameter[1];
            SQLWrite.SQLWriteCommand("dbo.GetDocketMainData", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@DocketNoIssued",
                        "System.Int32", DependancyService.ParamDirection.Input, (object)DocketNoIssued);

            DataTable dtDocketMainData = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtDocketMainData.Rows.Count > 0)
            {
                List<DocketMainData> listDocketMainData = WpfClassLibrary.Extensions.ToList<DocketMainData>(dtDocketMainData);
                MainData = listDocketMainData[0];
            }

            return MainData;
        }
        public static DocketMainData GetDocketMainDataByCustOrderNoIssued(int CustOrderNoIssued, ref SQLWriteClass SQLWrite)
        {
            DocketMainData MainData = null;
            SqlParameter[] SqlParam = new SqlParameter[1];
            SQLWrite.SQLWriteCommand("dbo.GetDocketMainDataByCustOrderNoIssued", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@CustOrderNoIssued",
                        "System.Int32", DependancyService.ParamDirection.Input, (object)CustOrderNoIssued);

            DataTable dtDocketMainData = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtDocketMainData.Rows.Count > 0)
            {
                List<DocketMainData> listDocketMainData = WpfClassLibrary.Extensions.ToList<DocketMainData>(dtDocketMainData);
                MainData = listDocketMainData[0];
            }

            return MainData;
        }
        public static List<DocketStyles> GetDocketDockStyles(int DocketID, ref SQLWriteClass SQLWrite)
        {
            List<DocketStyles> listDocketStyles = null;
            SqlParameter[] SqlParam = new SqlParameter[1];
            SQLWrite.SQLWriteCommand("dbo.GetDocketMainData", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@DocketID",
                        "System.Int32", DependancyService.ParamDirection.Input, (object)DocketID);

            DataTable dtDocketStyles = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtDocketStyles.Rows.Count > 0)
                listDocketStyles = WpfClassLibrary.Extensions.ToList<DocketStyles>(dtDocketStyles);

            return listDocketStyles;
        }
        public static string GetDocketStylesMainMatCodeIssued(int DocketID, ref SQLWriteClass SQLWrite)
        {
            string MainMatCodeIssued = "";

            SqlParameter[] SqlParam = new SqlParameter[1];
            SQLWrite.SQLWriteCommand("dbo.GetDocketStylesMainMatCodeIssued", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@DocketID",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)DocketID);

            MainMatCodeIssued = (string)SQLWrite.ExecuteQueryFunction(SqlParam);

            return MainMatCodeIssued;
        }
        public static List<DocketColrsQtys> GetDocketDockColrsQtys(int StyleID, ref SQLWriteClass SQLWrite)
        {
            List<DocketColrsQtys> listDocketColrsQtys = null;
            SqlParameter[] SqlParam = new SqlParameter[1];
            SQLWrite.SQLWriteCommand("dbo.GetDocketDockColrsQtys", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@StyleID",
                        "System.Int32", DependancyService.ParamDirection.Input, (object)StyleID);

            DataTable dtDockColrsQtys = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtDockColrsQtys.Rows.Count > 0)
                listDocketColrsQtys = WpfClassLibrary.Extensions.ToList<DocketColrsQtys>(dtDockColrsQtys);

            return listDocketColrsQtys;
        }
        public static List<DocketOrgCostings> GetDocketOrgCostings(int ColrsQtysID, ref SQLWriteClass SQLWrite)
        {
            SqlParameter[] SqlParam = new SqlParameter[1];
            List<DocketOrgCostings> listDocketOrgCostings = null;

            SQLWrite.SQLWriteCommand("dbo.GetDocketDockOrgCostings", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@ColrID",
                        "System.Int32", DependancyService.ParamDirection.Input, (object)ColrsQtysID);

            DataTable dtDocketOrgCostings = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtDocketOrgCostings.Rows.Count > 0)
                listDocketOrgCostings = WpfClassLibrary.Extensions.ToList<DocketOrgCostings>(dtDocketOrgCostings);

            return listDocketOrgCostings;
        }
        public static bool CompleteDocketMaterials(int DocketNoIssued, short DeletionFlag, ref SQLWriteClass SQLWrite)
        {
            bool bRtn = false;
            bool? CompleteFlag = false;
            SqlParameter[] SqlParam = new SqlParameter[3];
            SQLWrite.SQLWriteCommand("dbo.DcksnCompleteMaterails", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@Complete",
                        "System.Boolean", DependancyService.ParamDirection.InputOutput, (object)CompleteFlag);

            SqlParam[1] = DependancyService.SQLParameter("@DocketNoIssued",
                        "System.Int16", DependancyService.ParamDirection.Input, (object)DocketNoIssued);

            SqlParam[2] = DependancyService.SQLParameter("@DeletionFlag",
                        "System.Int32", DependancyService.ParamDirection.Input, (object)DeletionFlag);

            bRtn = SQLWrite.ExecuteNonQuery(SqlParam);

            return bRtn;
        }
        public static bool GetDocketMainDataDocketNoIssuedByCustomerNoIssue(int DocketNoIssued, ref SQLWriteClass SQLWrite)
        {
            bool bRtn = false;
            bool? CompleteFlag = false;
            SqlParameter[] SqlParam = new SqlParameter[2];
            SQLWrite.SQLWriteCommand("dbo.GetDocketMainDataDocketNoIssuedByCustomerNoIssue", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@Complete",
                        "System.Boolean", DependancyService.ParamDirection.InputOutput, (object)CompleteFlag);

            SqlParam[1] = DependancyService.SQLParameter("@DocketNoIssued",
                        "System.Int32", DependancyService.ParamDirection.Input, (object)DocketNoIssued);

            bRtn = SQLWrite.ExecuteNonQuery(SqlParam);

            return bRtn;
        }
        public static int GetDocketMainDataDocketNoIssuedByCustomerNoIssued(short CustomerNoIssued, ref SQLWriteClass SQLWrite)
        {
            int DocketNoIssued = 0;
            SqlParameter[] SqlParam = new SqlParameter[1];
            SQLWrite.SQLWriteCommand("dbo.GetDocketMainDataDocketNoIssuedByCustomerNoIssued", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@CustomerNoIssued", "System.Int16", DependancyService.ParamDirection.Input, (object)CustomerNoIssued);
            DocketNoIssued = (int)SQLWrite.ExecuteQueryFunction(SqlParam);

            return DocketNoIssued;
        }
        public static short GetDocketMainDataOutWorkerIssuedByCustOrderNoIssued(int CustOrderNoIssued, ref SQLWriteClass SQLWrite)
        {
            short OutWorkerIssued = 0;
            SqlParameter[] SqlParam = new SqlParameter[1];
            SQLWrite.SQLWriteCommand("dbo.GetDocketMainDataOutWorkerIssuedByCustOrderNoIssued", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@CustOrderNoIssued", "System.Int32", DependancyService.ParamDirection.Input, (object)CustOrderNoIssued);
            OutWorkerIssued = (short)SQLWrite.ExecuteQueryFunction(SqlParam);

            return OutWorkerIssued;
        }
        public static short GetDocketMainDataCustomerNoIssuedByCustOrderNoIssued(int CustOrderNoIssued, ref SQLWriteClass SQLWrite)
        {
            short CustomerNoIssued = 0;
            SqlParameter[] SqlParam = new SqlParameter[1];
            SQLWrite.SQLWriteCommand("dbo.GetDocketMainDataCustomerNoIssuedByCustOrderNoIssued", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@CustOrderNoIssued", "System.Int32", DependancyService.ParamDirection.Input, (object)CustOrderNoIssued);
            CustomerNoIssued = (short)SQLWrite.ExecuteQueryFunction(SqlParam);

            return CustomerNoIssued;
        }
        public static string GetDocketStylesFirstRecMainMatCodeIssuedByDocketMainDataCustOrderNoIssued(int CustOrderNoIssued, ref SQLWriteClass SQLWrite)
        {
            string MainMatCodeIssued = "";

            SqlParameter[] SqlParam = new SqlParameter[1];
            SQLWrite.SQLWriteCommand("dbo.GetDocketStylesFirstRecMainMatCodeIssuedByDocketMainDataCustOrderNoIssued", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@CustOrderNoIssued",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)CustOrderNoIssued);

            MainMatCodeIssued = (string)SQLWrite.ExecuteQueryFunction(SqlParam);

            return MainMatCodeIssued;
        }
        public static DataTable GetDocketColrsQtysProductionScheduleView(string Style, string Varn, short ColrNo, string DateCheck, ref SQLWriteClass SQLWrite)
        {
            SQLWrite.SQLWriteCommand("[dbo].[GetDocketColrsQtysProductionScheduleView]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[4];

            SqlParam[0] = DependancyService.SQLParameter("@OrdStyle",
                    "System.String", DependancyService.ParamDirection.Input, (object)Style);

            SqlParam[1] = DependancyService.SQLParameter("@OrdVarn",
                    "System.String", DependancyService.ParamDirection.Input, (object)Varn);

            SqlParam[2] = DependancyService.SQLParameter("@OrdColrNo",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)ColrNo);

            SqlParam[3] = DependancyService.SQLParameter("@DateCheck",
                    "System.String", DependancyService.ParamDirection.Input, (object)DateCheck);

            DataTable dtOrdColrsQty = SQLWrite.ExecuteDataTableQuery(SqlParam);


            return dtOrdColrsQty;
        }
        public static double GetDocketMatIssuedSupplied(int DocketNoIssued, short MatType, string MatCode, short MatColr, short MatSupl, short MatWhse, short MatLocn, ref SQLWriteClass SQLWrite)
        {
            double ndSupplied = 0.0;

            SqlParameter[] SqlParam = new SqlParameter[7];
            SQLWrite.SQLWriteCommand("dbo.GetDocketMatIssuedSupplied", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@DocketNoIssued",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)DocketNoIssued);

            SqlParam[1] = DependancyService.SQLParameter("@MatType",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)MatType);

            SqlParam[2] = DependancyService.SQLParameter("@MatCode",
                    "System.String", DependancyService.ParamDirection.Input, (object)MatCode);

            SqlParam[3] = DependancyService.SQLParameter("@MatColr",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)MatColr);

            SqlParam[4] = DependancyService.SQLParameter("@MatSupl",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)MatSupl);

            SqlParam[5] = DependancyService.SQLParameter("@MatWhse",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)MatWhse);

            SqlParam[6] = DependancyService.SQLParameter("@MatLocn",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)MatLocn);

            ndSupplied = (double)SQLWrite.ExecuteQueryFunction(SqlParam);

            return ndSupplied;
        }
        public static double GetDocketMatIssuedSuppliedByOrdersOrdMainDataOrdCsNoIssued(int CustOrderNoIssued, short MatType, string MatCode, short MatColr, short MatSupl, short MatWhse, short MatLocn, ref SQLWriteClass SQLWrite)
        {
            double ndSupplied = 0.0;

            SqlParameter[] SqlParam = new SqlParameter[7];
            SQLWrite.SQLWriteCommand("dbo.GetDocketMatIssuedSuppliedByOrdersOrdMainDataOrdCsNoIssued", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@CustOrderNoIssued",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)CustOrderNoIssued);

            SqlParam[1] = DependancyService.SQLParameter("@MatType",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)MatType);

            SqlParam[2] = DependancyService.SQLParameter("@MatCode",
                    "System.String", DependancyService.ParamDirection.Input, (object)MatCode);

            SqlParam[3] = DependancyService.SQLParameter("@MatColr",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)MatColr);

            SqlParam[4] = DependancyService.SQLParameter("@MatSupl",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)MatSupl);

            SqlParam[5] = DependancyService.SQLParameter("@MatWhse",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)MatWhse);

            SqlParam[6] = DependancyService.SQLParameter("@MatLocn",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)MatLocn);

            ndSupplied = (double)SQLWrite.ExecuteQueryFunction(SqlParam);

            return ndSupplied;
        }
        #endregion

        #region // Docktbox
        public static DocktboxDBC_MainRec GetDocktboxDBC_MainRec(int DBC_TransNumber, ref SQLWriteClass SQLWrite)
        {
            DocktboxDBC_MainRec DBC_MainRec = null;

            SQLWrite.SQLWriteCommand("[dbo].[GetDocktboxDBC_MainRec]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[1];

            SqlParam[0] = DependancyService.SQLParameter("@DBC_TransNumber",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)DBC_TransNumber);

            DataTable dtDBC_MainRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtDBC_MainRec.Rows.Count > 0)
            {
                List<DocktboxDBC_MainRec> listDocktboxDBC_MainRec = WpfClassLibrary.Extensions.ToList<DocktboxDBC_MainRec>(dtDBC_MainRec);
                DBC_MainRec = listDocktboxDBC_MainRec[0];
            }

            return DBC_MainRec;
        }
        public static List<DocktboxDBC_BoxGroupRec> GetDocktboxDBC_BoxGroupRec(int MainRecID, ref SQLWriteClass SQLWrite)
        {
            List<DocktboxDBC_BoxGroupRec> listDBC_BoxGroupRec = null;

            SQLWrite.SQLWriteCommand("[dbo].[GetDocktboxDBC_BoxGroupRec]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[1];

            SqlParam[0] = DependancyService.SQLParameter("@MainRecID",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)MainRecID);

            DataTable dtDBC_BoxGroupRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtDBC_BoxGroupRec.Rows.Count > 0)
                listDBC_BoxGroupRec = WpfClassLibrary.Extensions.ToList<DocktboxDBC_BoxGroupRec>(dtDBC_BoxGroupRec);

            return listDBC_BoxGroupRec;
        }
        public static List<DocktboxDBC_DocketNumbers> GetDocktboxDBC_DocketNumbers(int MainRecID, ref SQLWriteClass SQLWrite)
        {
            List<DocktboxDBC_DocketNumbers> listDBC_DocketNumbers = null;

            SQLWrite.SQLWriteCommand("[dbo].[GetDocktboxDBC_DocketNumbers]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[1];

            SqlParam[0] = DependancyService.SQLParameter("@MainRecID",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)MainRecID);

            DataTable dtDBC_DocketNumbers = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtDBC_DocketNumbers.Rows.Count > 0)
                listDBC_DocketNumbers = WpfClassLibrary.Extensions.ToList<DocktboxDBC_DocketNumbers>(dtDBC_DocketNumbers);

            return listDBC_DocketNumbers;
        }
        public static List<DocktboxDBC_ItemsRec> GetDocktboxDBC_ItemsRec(int BoxGroupRecID, ref SQLWriteClass SQLWrite)
        {
            List<DocktboxDBC_ItemsRec> listDBC_ItemsRec = null;

            SQLWrite.SQLWriteCommand("[dbo].[GetDocktboxDBC_ItemsRec]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[1];

            SqlParam[0] = DependancyService.SQLParameter("@BoxGroupRecID",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)BoxGroupRecID);

            DataTable dtDBC_ItemsRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtDBC_ItemsRec.Rows.Count > 0)
                listDBC_ItemsRec = WpfClassLibrary.Extensions.ToList<DocktboxDBC_ItemsRec>(dtDBC_ItemsRec);

            return listDBC_ItemsRec;
        }
        #endregion

        #region // Gmcpa1
        public static int GetFirstGmcpa1CPA1MainRecCPA1FileNo(ref SQLWriteClass SQLWrite)
        {
            int CPA1FileNo = 0;
            SQLWrite.SQLWriteCommand("[dbo].[GetFirstGmcpa1CPA1MainRecCPA1FileNo]", SQLWriteClass.SqlCmdType.PROCEDURE);

            CPA1FileNo = (int)SQLWrite.ExecuteQueryFunction(null);

            return CPA1FileNo;
        }
        public static Gmcpa1CPA1MainRec GetGmcpa1CPA1MainRec(int CPA1FileNo, short CPA1DelPoint, string CPA1Style, string CPA1Varn, ref SQLWriteClass SQLWrite)
        {
            Gmcpa1CPA1MainRec CPA1MainRec = null;
            SqlParameter[] SqlParam = new SqlParameter[4];
            SQLWrite.SQLWriteCommand("dbo.GetGmcpa1CPA1MainRec", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@CPA1FileNo",
                        "System.Int32", DependancyService.ParamDirection.Input, (object)CPA1FileNo);

            SqlParam[1] = DependancyService.SQLParameter("@CPA1DelPoint",
                        "System.Int16", DependancyService.ParamDirection.Input, (object)CPA1DelPoint);

            SqlParam[2] = DependancyService.SQLParameter("@CPA1Style",
                        "System.String", DependancyService.ParamDirection.Input, (object)CPA1Style);

            SqlParam[3] = DependancyService.SQLParameter("@CPA1Varn",
                        "System.String", DependancyService.ParamDirection.Input, (object)CPA1Varn);

            DataTable dtGmcpa1CPA1MainRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtGmcpa1CPA1MainRec.Rows.Count > 0)
            {
                List<Gmcpa1CPA1MainRec> listGmcpa1CPA1MainRec = WpfClassLibrary.Extensions.ToList<Gmcpa1CPA1MainRec>(dtGmcpa1CPA1MainRec);
                CPA1MainRec = listGmcpa1CPA1MainRec[0];
            }

            return CPA1MainRec;
        }
        public static List<Gmcpa1CPA1InstRec> GetGmcpa1CPA1InstRec(int CPA1MainRecID, ref SQLWriteClass SQLWrite)
        {
            SqlParameter[] SqlParam = new SqlParameter[1];
            List<Gmcpa1CPA1InstRec> listGmcpa1CPA1InstRec = null;
            SQLWrite.SQLWriteCommand("dbo.GetGmcpa1CPA1InstRec", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@CPA1MainRecID",
                        "System.Int32", DependancyService.ParamDirection.Input, (object)CPA1MainRecID);

            DataTable dtGmcpa1CPA1InstRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtGmcpa1CPA1InstRec.Rows.Count > 0)
                listGmcpa1CPA1InstRec = WpfClassLibrary.Extensions.ToList<Gmcpa1CPA1InstRec>(dtGmcpa1CPA1InstRec);

            return listGmcpa1CPA1InstRec;
        }
        public static List<Gmcpa1CPA1InstNotsRec> GetGmcpa1CPA1InstNotsRec(int CPA1MainRecID, ref SQLWriteClass SQLWrite)
        {
            SqlParameter[] SqlParam = new SqlParameter[1];
            List<Gmcpa1CPA1InstNotsRec> listdtGmcpa1CPA1InstNotsRec = null;
            SQLWrite.SQLWriteCommand("dbo.GetGmcpa1CPA1InstNotsRec", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@CPA1MainRecID",
                        "System.Int32", DependancyService.ParamDirection.Input, (object)CPA1MainRecID);

            DataTable dtGmcpa1CPA1InstNotsRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtGmcpa1CPA1InstNotsRec.Rows.Count > 0)
                listdtGmcpa1CPA1InstNotsRec = WpfClassLibrary.Extensions.ToList<Gmcpa1CPA1InstNotsRec>(dtGmcpa1CPA1InstNotsRec);

            return listdtGmcpa1CPA1InstNotsRec;
        }
        public static List<Gmcpa1CPA1MatsRec> GetGmcpa1CPA1MatsRec(int CPA1MainRecID, ref SQLWriteClass SQLWrite)
        {
            SqlParameter[] SqlParam = new SqlParameter[1];
            List<Gmcpa1CPA1MatsRec> listGmcpa1CPA1MatsRec = null;
            SQLWrite.SQLWriteCommand("dbo.GetGmcpa1CPA1MatsRec", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@CPA1MainRecID",
                        "System.Int32", DependancyService.ParamDirection.Input, (object)CPA1MainRecID);

            DataTable dtGmcpa1CPA1MatsRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtGmcpa1CPA1MatsRec.Rows.Count > 0)
                listGmcpa1CPA1MatsRec = WpfClassLibrary.Extensions.ToList<Gmcpa1CPA1MatsRec>(dtGmcpa1CPA1MatsRec);

            return listGmcpa1CPA1MatsRec;
        }
        public static List<Gmcpa1CPA1MatsNotsRec> GetGmcpa1CPA1MatsNotsRec(int CPA1MainRecID, ref SQLWriteClass SQLWrite)
        {
            SqlParameter[] SqlParam = new SqlParameter[1];
            List<Gmcpa1CPA1MatsNotsRec> listGmcpa1CPA1MatsNotsRec = null;
            SQLWrite.SQLWriteCommand("dbo.GetGmcpa1CPA1MatsNotsRec", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@CPA1MainRecID",
                        "System.Int32", DependancyService.ParamDirection.Input, (object)CPA1MainRecID);

            DataTable dtGmcpa1CPA1MatsNotsRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtGmcpa1CPA1MatsNotsRec.Rows.Count > 0)
                listGmcpa1CPA1MatsNotsRec = WpfClassLibrary.Extensions.ToList<Gmcpa1CPA1MatsNotsRec>(dtGmcpa1CPA1MatsNotsRec);

            return listGmcpa1CPA1MatsNotsRec;
        }
        #endregion

        #region // Gmcpas
        public static short GetGmcpasCPASMainRecCPASNoOfDays(short CPASOperNo, short CPASCpaNo, ref SQLWriteClass SQLWrite)
        {
            short CPASNoOfDays = 0;
            SqlParameter[] SqlParam = new SqlParameter[2];
            SQLWrite.SQLWriteCommand("dbo.GetGmcpasCPASMainRecCPASNoOfDays", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@CPASOperNo",
                        "System.Int16", DependancyService.ParamDirection.Input, (object)CPASOperNo);

            SqlParam[1] = DependancyService.SQLParameter("@CPASCpaNo",
                        "System.Int16", DependancyService.ParamDirection.Input, (object)CPASOperNo);

            CPASNoOfDays = (short)SQLWrite.ExecuteQueryFunction(SqlParam);

            return CPASNoOfDays;
        }
        public static List<GmcpasCPASOperDescRec> GetGmcpasCPASOperDescRecList(ref SQLWriteClass SQLWrite)
        {
            List<GmcpasCPASOperDescRec> listgmcpasCPASOperDescRec = null;
            SQLWrite.SQLWriteCommand("dbo.GetGmcpasCPASOperDescRecList", SQLWriteClass.SqlCmdType.PROCEDURE);

            DataTable dtCPASOperDescRec = SQLWrite.ExecuteDataTableQuery(null);

            if (dtCPASOperDescRec.Rows.Count > 0)
                listgmcpasCPASOperDescRec = WpfClassLibrary.Extensions.ToList<GmcpasCPASOperDescRec>(dtCPASOperDescRec);
            else listgmcpasCPASOperDescRec = null;

            return listgmcpasCPASOperDescRec;
        }
        public static DataTable GetGmcpasCPASOperDescRecTable(short CPASDOperNo, ref SQLWriteClass SQLWrite)
        {
            DataTable dtCPASOperDescRecTable = null;
            SqlParameter[] SqlParam = new SqlParameter[1];
            SQLWrite.SQLWriteCommand("dbo.GetGmcpasCPASOperDescRecTable", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@CPASDOperNo",
                        "System.Int16", DependancyService.ParamDirection.Input, (object)CPASDOperNo);

            dtCPASOperDescRecTable = SQLWrite.ExecuteQueryTableFunction(SqlParam);

            return dtCPASOperDescRecTable;
        }
        public static List<GmcpasCPASMainRec> GetGmcpasCPASMainRec(short CPASOperNo, short CPASNoOfDays, ref SQLWriteClass SQLWrite)
        {
            SqlParameter[] SqlParam = new SqlParameter[2];
            List<GmcpasCPASMainRec> listgmcpasCPASMainRec = null;
            SQLWrite.SQLWriteCommand("dbo.GetGmcpasCPASMainRec", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@CPASOperNo",
                        "System.Int16", DependancyService.ParamDirection.Input, (object)CPASOperNo);

            SqlParam[1] = DependancyService.SQLParameter("@CPASNoOfDays",
                        "System.Int16", DependancyService.ParamDirection.Input, (object)CPASNoOfDays);

            DataTable dtGmcpasCPASMainRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtGmcpasCPASMainRec.Rows.Count > 0)
                listgmcpasCPASMainRec = WpfClassLibrary.Extensions.ToList<GmcpasCPASMainRec>(dtGmcpasCPASMainRec);
            else listgmcpasCPASMainRec = null;

            return listgmcpasCPASMainRec;
        }
        public static List<GmcpasCPASOperDescRec> GetOpersForCompletion(short ActionNumber, short iMatType, ref SQLWriteClass SQLWrite)
        {
            SqlParameter[] SqlParam = new SqlParameter[2];
            List<GmcpasCPASOperDescRec> listgmcpasCPASOperDescRec = null;
            SQLWrite.SQLWriteCommand("dbo.GetGmcpasCPASOperDescRec", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@CPASDActionNumber",
                        "System.Int16", DependancyService.ParamDirection.Input, (object)ActionNumber);

            SqlParam[1] = DependancyService.SQLParameter("@CPASDMatType",
                        "System.Int32", DependancyService.ParamDirection.Input, (object)iMatType);

            DataTable dtCPASOperDescRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtCPASOperDescRec.Rows.Count > 0)
                listgmcpasCPASOperDescRec = WpfClassLibrary.Extensions.ToList<GmcpasCPASOperDescRec>(dtCPASOperDescRec);
            else listgmcpasCPASOperDescRec = null;

            return listgmcpasCPASOperDescRec;
        }
        public static GmcpasCPASOperDescRec GetGmcpasCPASOperDescRec(short ActionNumber, short iMatType, ref SQLWriteClass SQLWrite)
        {
            GmcpasCPASOperDescRec CPASOperDescRec = null;
            SqlParameter[] SqlParam = new SqlParameter[2];
            SQLWrite.SQLWriteCommand("dbo.GetGmcpasCPASOperDescRec", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@CPASDActionNumber",
                        "System.Int16", DependancyService.ParamDirection.Input, (object)ActionNumber);

            SqlParam[1] = DependancyService.SQLParameter("@CPASDMatType",
                        "System.Int32", DependancyService.ParamDirection.Input, (object)iMatType);

            DataTable dtCPASOperDescRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtCPASOperDescRec.Rows.Count > 0)
            {
                List<GmcpasCPASOperDescRec> listgmcpasCPASOperDescRec = WpfClassLibrary.Extensions.ToList<GmcpasCPASOperDescRec>(dtCPASOperDescRec);
                CPASOperDescRec = listgmcpasCPASOperDescRec[0];
            }

            return CPASOperDescRec;
        }
        public static DataTable GetReportGmcpasCPASMainRecView(short CPASCpaNo, short OperFrom, short OperTo, ref SQLWriteClass SQLWrite)
        {
            DataTable dtCPASMainRec = null;
            SqlParameter[] SqlParam = new SqlParameter[3];
            SQLWrite.SQLWriteCommand("dbo.GetReportGmcpasCPASMainRecView", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@CPASCpaNo",
                        "System.Int16", DependancyService.ParamDirection.Input, (object)CPASCpaNo);

            SqlParam[1] = DependancyService.SQLParameter("@OperatorFrom",
                        "System.Int16", DependancyService.ParamDirection.Input, (object)OperFrom);

            SqlParam[2] = DependancyService.SQLParameter("@OperatorTo",
                        "System.Int16", DependancyService.ParamDirection.Input, (object)OperTo);

            dtCPASMainRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            return dtCPASMainRec;
        }
        public static List<GmcpasCPASMainRec> GetGmcpasCPASMainRecByCPASOperNoCPASCpaNo(short CPASOperNo, short CPASCpaNo, ref SQLWriteClass SQLWrite)
        {
            SqlParameter[] SqlParam = new SqlParameter[2];
            List<GmcpasCPASMainRec> listgmcpasCPASMainRec = null;
            SQLWrite.SQLWriteCommand("dbo.GetGmcpasCPASMainRecByCPASOperNoCPASCpaNo", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@CPASOperNo",
                        "System.Int16", DependancyService.ParamDirection.Input, (object)CPASOperNo);

            SqlParam[1] = DependancyService.SQLParameter("@CPASCpaNo",
                        "System.Int16", DependancyService.ParamDirection.Input, (object)CPASCpaNo);

            DataTable dtGmcpasCPASMainRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtGmcpasCPASMainRec.Rows.Count > 0)
                listgmcpasCPASMainRec = WpfClassLibrary.Extensions.ToList<GmcpasCPASMainRec>(dtGmcpasCPASMainRec);
            else listgmcpasCPASMainRec = null;

            return listgmcpasCPASMainRec;
        }
        #endregion

        #region // Gmcurrs
        public static DataRow GetGmcurrsDataRow(short CurrcyKey, ref DataTable dtCURCurrenciesRec)
        {
            List<DataRow> sQuery = (from DataRow dt in dtCURCurrenciesRec.AsEnumerable()
                                    where dt.Field<Int32>("CURCurrencyKey") == CurrcyKey
                                    select dt).ToList();


            return sQuery.Count > 0 ? (DataRow)sQuery[0] : null;
        }
        public static GmcurrsCURCurrenciesRec GetGmcurrsRecord(short CurrcyKey, ref List<GmcurrsCURCurrenciesRec> listCURCurrenciesRec)
        {
            List<GmcurrsCURCurrenciesRec> Curr = (from GmcurrsCURCurrenciesRec in listCURCurrenciesRec
                                    where GmcurrsCURCurrenciesRec.CURCurrencyKey == CurrcyKey
                                    select GmcurrsCURCurrenciesRec).ToList();


            return Curr.Count > 0 ? (GmcurrsCURCurrenciesRec)Curr[0] : null;
        }
        public static GmcurrsCURCurrenciesRec GetGmcurrsRecord(short CurrcyKey, ref DataTable dtCURCurrenciesRec)
        {
            List<GmcurrsCURCurrenciesRec> listCURCurrenciesRec = WpfClassLibrary.Extensions.ToList<GmcurrsCURCurrenciesRec>(dtCURCurrenciesRec);

            List<GmcurrsCURCurrenciesRec> Curr = (from GmcurrsCURCurrenciesRec in listCURCurrenciesRec
                                                  where GmcurrsCURCurrenciesRec.CURCurrencyKey == CurrcyKey
                                                  select GmcurrsCURCurrenciesRec).ToList();


            return Curr.Count > 0 ? (GmcurrsCURCurrenciesRec)Curr[0] : null;
        }
        public static string GetGmcurrsName(short CurrcyKey, ref DataTable dtCURCurrenciesRec)
        {
            string sCurrency = "";

            var sQuery = from DataRow dt in dtCURCurrenciesRec.AsEnumerable()
                        where dt.Field<Int32>("CURCurrencyKey") == CurrcyKey
                         select dt.Field<string>("CURCurrency");

            if (sQuery.Count() > 0)
                sCurrency = sQuery.ElementAt(0);

            return sCurrency;
        }
        #endregion

        #region // GmoCpa
        public static short GetGmoCpaGMOCPASiblRecFirstRecGMOCPAFactNoByGMOCPAMainRecGMOCPAFileNo(int GMOCPAFileNo, ref SQLWriteClass SQLWrite)
        {
            SqlParameter[] SqlParam = new SqlParameter[1];
            SQLWrite.SQLWriteCommand("dbo.GetGmoCpaGMOCPASiblRecFirstRecGMOCPAFactNoByGMOCPAMainRecGMOCPAFileNo", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@GMOCPAFileNo", "System.Int32", DependancyService.ParamDirection.Input, (object)GMOCPAFileNo);
            short GMOCPAFactNo = (short)SQLWrite.ExecuteQueryFunction(SqlParam);

            return GMOCPAFactNo;
        }
        public static short GetGmoCpaGMOCPASiblRecFirstRecGMOCPACpaNoByGMOCPAMainRecGMOCPAFileNo(int GMOCPAFileNo, ref SQLWriteClass SQLWrite)
        {
            SqlParameter[] SqlParam = new SqlParameter[1];
            SQLWrite.SQLWriteCommand("dbo.GetGmoCpaGMOCPASiblRecFirstRecGMOCPACpaNoByGMOCPAMainRecGMOCPAFileNo", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@GMOCPAFileNo", "System.Int32", DependancyService.ParamDirection.Input, (object)GMOCPAFileNo);
            short GMOCPACpaNo = (short)SQLWrite.ExecuteQueryFunction(SqlParam);

            return GMOCPACpaNo;
        }
        public static short GetGmoCpaGMOCPASiblRecGMOCPACpaNo(int GMOCPAFileNo, ref SQLWriteClass SQLWrite)
        {
            SqlParameter[] SqlParam = new SqlParameter[1];
            SQLWrite.SQLWriteCommand("dbo.GetGmoCpaGMOCPASiblRecGMOCPACpaNo", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@GMOCPAFileNo", "System.Int32", DependancyService.ParamDirection.Input, (object)GMOCPAFileNo);
            short GMOCPACpaNo = (short)SQLWrite.ExecuteQueryFunction(SqlParam);

            return GMOCPACpaNo;
        }
        public static short GetGmoCpaGMOCPASiblRecGMOCPACpaNoNonZero(int GMOCPAFileNo, ref SQLWriteClass SQLWrite)
        {
            SqlParameter[] SqlParam = new SqlParameter[1];
            SQLWrite.SQLWriteCommand("dbo.GetGmoCpaGMOCPASiblRecGMOCPACpaNoNonZero", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@GMOCPAFileNo", "System.Int32", DependancyService.ParamDirection.Input, (object)GMOCPAFileNo);
            short GMOCPACpaNo = (short)SQLWrite.ExecuteQueryFunction(SqlParam);

            return GMOCPACpaNo;
        }
        public static int GetGmoCpaGMOCPAMainRecGMOCPASeqNo(int GMOCPAFileNo, ref SQLWriteClass SQLWrite)
        {
            SqlParameter[] SqlParam = new SqlParameter[1];
            SQLWrite.SQLWriteCommand("dbo.GetGmoCpaGMOCPAMainRecGMOCPASeqNo", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@GMOCPAFileNo", "System.Int32", DependancyService.ParamDirection.Input, (object)GMOCPAFileNo);
            int GMOCPASeqNo = (int)SQLWrite.ExecuteQueryFunction(SqlParam);

            return GMOCPASeqNo;
        }
        #endregion

        #region // GmParams
        public static string GetGmParamsDescr(short DescKey, short ParamKey, ref DataTable dtParametersRec)
        {
            string sDesc = "";

            List<string> sQuery = (from DataRow dt in dtParametersRec.AsEnumerable()
                                   where dt.Field<Int16>("PARParDescripKey") == DescKey
                                   where dt.Field<Int16>("PARParParamsKey") == ParamKey
                                   select dt.Field<string>("PARParDescr")).ToList();

            if (sQuery.Count > 0)
                sDesc = sQuery[0].Trim();

            return sDesc;
        }
        public static string GetGmcurrsCURCurrenciesDescr(short CurrcyKey, ref DataTable dtCURCurrenciesRec)
        {
            string sDesc = "";

            List<string> sQuery = (from DataRow dt in dtCURCurrenciesRec.AsEnumerable()
                                   where dt.Field<Int32>("CURCurrencyKey") == CurrcyKey
                                   select dt.Field<string>("CURCurrency")).ToList();


            if (sQuery.Count > 0)
                sDesc = sQuery[0].Trim();

            return sDesc;
        }
        #endregion

        #region // Gmsizes
        public static DataRow GetGmSizeDataRow(string Size, ref DataTable dtGMSizesRec)
        {
            DataRow dr = null;
            List<DataRow> listGmSizes = null;

            if (Size.Trim().Length > 0)
            {
                Size = Size.Trim();
                int Len = 5 - Size.Length;

                if (Size.Trim().Length < 5)
                    for (short i = 0; i < Len; i++)
                        Size += " ";

                if (dtGMSizesRec.Columns[0].ColumnName == "Size Key")
                {
                    listGmSizes = (from DataRow drItem in dtGMSizesRec.AsEnumerable()
                                                 where drItem.Field<string>("Size Key") == Size
                                                 select drItem).ToList();
                }
                else
                { 
                    listGmSizes = (from DataRow drItem in dtGMSizesRec.AsEnumerable()
                                                 where drItem.Field<string>("GMSizeKey") == Size 
                                                 select drItem).ToList();
                }

                if (listGmSizes.Count > 0)
                    dr = listGmSizes[0];
            }

            return dr;
        }
        public static GmsizesGMSizesRec GetGmSizeRecord(string Size, ref DataTable dtGMSizesRec)
        {
            GmsizesGMSizesRec GMSizesRec;
            List<GmsizesGMSizesRec> listGMSizesRec = WpfClassLibrary.Extensions.ToList<GmsizesGMSizesRec>(dtGMSizesRec);

            var sQuery = (from GmsizesGMSizesRec in listGMSizesRec
                          where GmsizesGMSizesRec.GMSizeKey.Trim() == Size.Trim()
                          select GmsizesGMSizesRec).ToList();

            if (sQuery.Count > 0)
                GMSizesRec = sQuery[0];
            else
                GMSizesRec = null;

            return GMSizesRec;
        }
        public static bool IsGmSizeKeyValid(string Size, ref DataTable dtGMSizesRec)
        {
            bool bValid = false;
            if (Size.Trim().Length != 0)
            {
                Size.Trim();

                // Pad with Correct amount of spaces
                for (int i = Size.Length; i < 5; i++)
                    Size += ' ';

                List<DataRow> listGmSizes = (from DataRow drItem in dtGMSizesRec.AsEnumerable()
                                             where drItem.Field<string>("GMSizeKey") == Size
                                             select drItem).ToList();

                if (listGmSizes.Count > 0)
                    bValid = true;
            }

            return bValid;
        }
        public static bool IsGmSizeValid(string SizeKey, string Size, ref DataTable dtGMSizesRec)
        {
            bool bValid = false;

            if (Size.Trim().Length != 0)
            { 
                string[] sGmSizes = new string[128];
                DataRow dr = GetGmSizeDataRow(SizeKey, ref dtGMSizesRec);
                WpfClassLibrary.SQLArrayConvert.StringToStringArray(dr["GMSizes"].ToString(), ref sGmSizes);

                List<string> sQuery = (from string sSize in sGmSizes
                              where sSize.Trim() == Size.Trim()
                              select sSize).ToList();

                if (sQuery.Count > 0)
                    bValid = true;
            }

            return bValid;
        }
        public static int GetGmSizeIndex(string Size, ref DataRow drSize)
        {
            int Index = -1;

            if (Size.Trim().Length > 0)
            { 
                string[] sGmSizes = new string[128];
                WpfClassLibrary.SQLArrayConvert.StringToStringArray(drSize["GMSizes"].ToString(), ref sGmSizes);

                Index = Array.IndexOf(sGmSizes, Size.Trim());
            }

            return Index;
        }
        public static bool IsIsGmSizeGreater(string SizeKey, string Size1, string Size2, ref DataTable dtGMSizesRec)
        {
            DataRow dr = GetGmSizeDataRow(SizeKey, ref dtGMSizesRec);
            int Index1 = GetGmSizeIndex(Size1, ref dr);
            int Index2 = GetGmSizeIndex(Size2, ref dr);

            return Index1 > Index2;
        }
        #endregion

        #region // Gstkdb
        public static string GetGstkdbGarsMRecGTQtys(int GTFileNo, string GTStyle, string GTVarn, short OrdColrNo, short OrdColrNo1, short GTWhse, short @GTLocn, ref SQLWriteClass SQLWrite)
        {
            string GTQtys = "";

            SQLWrite.SQLWriteCommand("[dbo].[GetGstkdbGarsMRecGTQtys]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[7];

            SqlParam[0] = DependancyService.SQLParameter("@GTFileNo",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)GTFileNo);

            SqlParam[1] = DependancyService.SQLParameter("@GTStyle",
                    "System.String", DependancyService.ParamDirection.Input, (object)GTStyle);

            SqlParam[2] = DependancyService.SQLParameter("@GTVarn",
                    "System.String", DependancyService.ParamDirection.Input, (object)GTVarn);

            SqlParam[3] = DependancyService.SQLParameter("@OrdColrNo",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)OrdColrNo);

            SqlParam[4] = DependancyService.SQLParameter("@OrdColrNo1",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)OrdColrNo1);

            SqlParam[5] = DependancyService.SQLParameter("@GTWhse",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)GTWhse);

            SqlParam[6] = DependancyService.SQLParameter("@GTLocn",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)GTLocn);

            GTQtys = (string)SQLWrite.ExecuteQueryFunction(SqlParam);

            return GTQtys;
        }
        public static double GetGstkdbGarsMRecGTPrice(string GTStyle, string GTVarn, ref SQLWriteClass SQLWrite)
        {
            double GTPrice = 0.0;

            SQLWrite.SQLWriteCommand("[dbo].[GetGstkdbGarsMRecGTPrice]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[2];

            SqlParam[0] = DependancyService.SQLParameter("@GTStyle",
                    "System.String", DependancyService.ParamDirection.Input, (object)GTStyle);

            SqlParam[1] = DependancyService.SQLParameter("@GTVarn",
                    "System.String", DependancyService.ParamDirection.Input, (object)GTVarn);

            GTPrice = (double)SQLWrite.ExecuteQueryFunction(SqlParam);

            return GTPrice;
        }
        public static double GetGstkdbGarsMRecGTRSPrice(string GTStyle, string GTVarn, ref SQLWriteClass SQLWrite)
        {
            double GTRSPrice = 0.0;

            SQLWrite.SQLWriteCommand("[dbo].[GetGstkdbGarsMRecGTRSPrice]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[2];

            SqlParam[0] = DependancyService.SQLParameter("@GTStyle",
                    "System.String", DependancyService.ParamDirection.Input, (object)GTStyle);

            SqlParam[1] = DependancyService.SQLParameter("@GTVarn",
                    "System.String", DependancyService.ParamDirection.Input, (object)GTVarn);

            GTRSPrice = (double)SQLWrite.ExecuteQueryFunction(SqlParam);

            return GTRSPrice;
        }
        public static double GetGstkdbGarsMRecGTQtysByGTColrNoTotal(string GTStyle, string GTVarn, short GTColrNo, ref SQLWriteClass SQLWrite)
        {
            double GTQtysTotal = 0.0;

            SQLWrite.SQLWriteCommand("[dbo].[GetGstkdbGarsMRecGTQtysByGTColrNoTotal]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[3];

            SqlParam[0] = DependancyService.SQLParameter("@GTStyle",
                    "System.String", DependancyService.ParamDirection.Input, (object)GTStyle);

            SqlParam[1] = DependancyService.SQLParameter("@GTVarn",
                    "System.String", DependancyService.ParamDirection.Input, (object)GTVarn);

            SqlParam[2] = DependancyService.SQLParameter("@GTColrNo",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)GTColrNo);

            GTQtysTotal = (double)SQLWrite.ExecuteQueryFunction(SqlParam);

            return GTQtysTotal;
        }
        public static double GetGstkdbGarsMRecGTQtysByGTFileNoGTColrNoTotal(string GTStyle, string GTVarn, int GTFileNo, short GTColrNo, ref SQLWriteClass SQLWrite)
        {
            double GTQtysTotal = 0.0;

            SQLWrite.SQLWriteCommand("[dbo].[GetGstkdbGarsMRecGTQtysByGTFileNoGTColrNoTotal]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[4];

            SqlParam[0] = DependancyService.SQLParameter("@GTStyle",
                    "System.String", DependancyService.ParamDirection.Input, (object)GTStyle);

            SqlParam[1] = DependancyService.SQLParameter("@GTVarn",
                    "System.String", DependancyService.ParamDirection.Input, (object)GTVarn);

            SqlParam[2] = DependancyService.SQLParameter("@GTFileNo",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)GTFileNo);

            SqlParam[3] = DependancyService.SQLParameter("@GTColrNo",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)GTColrNo);

            GTQtysTotal = (double)SQLWrite.ExecuteQueryFunction(SqlParam);

            return GTQtysTotal;
        }
        public static List<GstkdbGarsMRec> GetGstkdbGarsMRecList(string GTStyle, string GTVarn, ref SQLWriteClass SQLWrite)
        {
            List<GstkdbGarsMRec> listGarsMRec = null;

            SQLWrite.SQLWriteCommand("[dbo].[GetGstkdbGarsMRec]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[2];

            SqlParam[0] = DependancyService.SQLParameter("@GTStyle",
                    "System.String", DependancyService.ParamDirection.Input, (object)GTStyle);

            SqlParam[1] = DependancyService.SQLParameter("@GTVarn",
                    "System.String", DependancyService.ParamDirection.Input, (object)GTVarn);

            DataTable dtGarsMRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtGarsMRec.Rows.Count > 0)
                listGarsMRec = WpfClassLibrary.Extensions.ToList<GstkdbGarsMRec>(dtGarsMRec);

                return listGarsMRec;
        }
        public static GstkdbGarsMRec GetGstkdbGarsMRec(string GTStyle, string GTVarn, ref SQLWriteClass SQLWrite)
        {
            GstkdbGarsMRec GarsMRec = null;
            List<GstkdbGarsMRec> listGarsMRec = null;

            SQLWrite.SQLWriteCommand("[dbo].[GetGstkdbGarsMRec]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[2];

            SqlParam[0] = DependancyService.SQLParameter("@GTStyle",
                    "System.String", DependancyService.ParamDirection.Input, (object)GTStyle);

            SqlParam[1] = DependancyService.SQLParameter("@GTVarn",
                    "System.String", DependancyService.ParamDirection.Input, (object)GTVarn);

            DataTable dtGarsMRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtGarsMRec.Rows.Count > 0)
            {
                listGarsMRec = WpfClassLibrary.Extensions.ToList<GstkdbGarsMRec>(dtGarsMRec);
                GarsMRec = listGarsMRec[0];
            }

            return GarsMRec;
        }
        #endregion

        #region // Gmdfnots
        public static GmdfnotsGMDFNotesMainRec GetGmdfnotsGMDFNotesMainRec(short GMDFNModNo, short GMDFNModSubNo, ref SQLWriteClass SQLWrite)
        {
            GmdfnotsGMDFNotesMainRec FNotesMainRe = null;

            SQLWrite.SQLWriteCommand("[dbo].[GetGmdfnotsGMDFNotesMainRec]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[2];

            SqlParam[0] = DependancyService.SQLParameter("@GMDFNModNo",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)GMDFNModNo);

            SqlParam[1] = DependancyService.SQLParameter("@GMDFNModSubNo",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)GMDFNModSubNo);

            DataTable dtGMDFNotesMainRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtGMDFNotesMainRec.Rows.Count > 0)
            {
                List<GmdfnotsGMDFNotesMainRec> listGmdfnotsGMDFNotesMainRec = WpfClassLibrary.Extensions.ToList<GmdfnotsGMDFNotesMainRec>(dtGMDFNotesMainRec);
                FNotesMainRe = listGmdfnotsGMDFNotesMainRec[0];
            }

            return FNotesMainRe;
        }
        public static List<GmdfnotsGMDFNotesRec> GetGmdfnotsGMDFNotesRec(int MainRecID, ref SQLWriteClass SQLWrite)
        {
            List<GmdfnotsGMDFNotesRec> listGmdfnotsGMDFNotesRec = null;

            SQLWrite.SQLWriteCommand("[dbo].[GetGmdfnotsGMDFNotesRec]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[1];

            SqlParam[0] = DependancyService.SQLParameter("@MainRecID",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)MainRecID);

            DataTable dtGMDFNotesRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtGMDFNotesRec.Rows.Count > 0)
                listGmdfnotsGMDFNotesRec = WpfClassLibrary.Extensions.ToList<GmdfnotsGMDFNotesRec>(dtGMDFNotesRec);

            return listGmdfnotsGMDFNotesRec;
        }
        #endregion

        #region // Gopacks
        public static GopacksGOPKSMainRec GetGopacksGOPKSMainRec(int GOPKSFileNo, short GOPKSDelPoint, short GOPKSDelIndex, 
                                                    short GOPKSColrNo, short GOPKSColourIndex, string GOPKSStyle, 
                                                                            string GOPKSVarn, ref SQLWriteClass SQLWrite)
        {
            GopacksGOPKSMainRec GOPKSMainRec = null;

            SQLWrite.SQLWriteCommand("[dbo].[GetGopacksGOPKSMainRec]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[7];

            SqlParam[0] = DependancyService.SQLParameter("@GOPKSFileNo",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)GOPKSFileNo);

            SqlParam[1] = DependancyService.SQLParameter("@GOPKSDelPoint",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)GOPKSDelPoint);

            SqlParam[2] = DependancyService.SQLParameter("@GOPKSDelIndex",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)GOPKSDelIndex);

            SqlParam[3] = DependancyService.SQLParameter("@GOPKSStyle",
                    "System.String", DependancyService.ParamDirection.Input, (object)GOPKSStyle);

            SqlParam[4] = DependancyService.SQLParameter("@GOPKSVarn",
                    "System.String", DependancyService.ParamDirection.Input, (object)GOPKSVarn);

            SqlParam[5] = DependancyService.SQLParameter("@GOPKSColrNo",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)GOPKSColrNo);

            SqlParam[6] = DependancyService.SQLParameter("@GOPKSColourIndex",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)GOPKSColourIndex);

            DataTable dtGOPKSMainRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtGOPKSMainRec.Rows.Count > 0)
            {
                List<GopacksGOPKSMainRec> listGopacksGOPKSMainRec = WpfClassLibrary.Extensions.ToList<GopacksGOPKSMainRec>(dtGOPKSMainRec);
                GOPKSMainRec = listGopacksGOPKSMainRec[0];
            }

            return GOPKSMainRec;
        }
        public static List<GopacksGOPKSSiblRec> GetGopacksGOPKSSiblRec(int @GOPKSMainRecID, ref SQLWriteClass SQLWrite)
        {
            List<GopacksGOPKSSiblRec> listGopacksGOPKSSiblRec = null;

            SQLWrite.SQLWriteCommand("[dbo].[GetGopacksGOPKSSiblRec]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[1];

            SqlParam[0] = DependancyService.SQLParameter("@GOPKSMainRecID",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)@GOPKSMainRecID);

            DataTable dtGOPKSSiblRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtGOPKSSiblRec.Rows.Count > 0)
                listGopacksGOPKSSiblRec = WpfClassLibrary.Extensions.ToList<GopacksGOPKSSiblRec>(dtGOPKSSiblRec);

            return listGopacksGOPKSSiblRec;
        }
        public static List<GopacksGOPKSSiblRec> GetGopacksGOPKSSiblRecByFileStyleDelPointIndex(int GOPKSFileNo, short GOPKSDelPoint, short GOPKSDelIndex,
                                                                            short GOPKSColrNo, string GOPKSStyle, string GOPKSVarn, ref SQLWriteClass SQLWrite)
        {
            List<GopacksGOPKSSiblRec> listGopacksGOPKSSiblRec = null;

            SQLWrite.SQLWriteCommand("[dbo].[GetGopacksGOPKSSiblRecByFileStyleDelPointIndex]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[6];

            SqlParam[0] = DependancyService.SQLParameter("@GOPKSFileNo",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)GOPKSFileNo);

            SqlParam[1] = DependancyService.SQLParameter("@GOPKSDelPoint",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)GOPKSDelPoint);

            SqlParam[2] = DependancyService.SQLParameter("@GOPKSDelIndex",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)GOPKSDelIndex);

            SqlParam[3] = DependancyService.SQLParameter("@GOPKSStyle",
                    "System.String", DependancyService.ParamDirection.Input, (object)GOPKSStyle);

            SqlParam[4] = DependancyService.SQLParameter("@GOPKSVarn",
                    "System.String", DependancyService.ParamDirection.Input, (object)GOPKSVarn);

            SqlParam[5] = DependancyService.SQLParameter("@GOPKSColrNo",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)GOPKSColrNo);

            DataTable dtGOPKSSiblRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtGOPKSSiblRec.Rows.Count > 0)
                listGopacksGOPKSSiblRec = WpfClassLibrary.Extensions.ToList<GopacksGOPKSSiblRec>(dtGOPKSSiblRec);

            return listGopacksGOPKSSiblRec;
        }
        #endregion

        #region // Gmpacks
        public static GmpacksPKSMainRec GetGmpacksPKSMainRec(string PKSPackKey, ref SQLWriteClass SQLWrite)
        {
            SQLWrite.SQLWriteCommand("[dbo].[GetGmpacksPKSMainRec]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[1];
            GmpacksPKSMainRec PKSMainRec = null;

            SqlParam[0] = DependancyService.SQLParameter("@PKSPackKey",
                    "System.String", DependancyService.ParamDirection.Input, (object)PKSPackKey);

            DataTable dtPKSMainRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtPKSMainRec.Rows.Count > 0)
            {
                List<GmpacksPKSMainRec> listGmpacksPKSMainRec = WpfClassLibrary.Extensions.ToList<GmpacksPKSMainRec>(dtPKSMainRec);
                PKSMainRec = listGmpacksPKSMainRec[0];
            }

            return PKSMainRec;
        }
        #endregion

        #region // Glformat.GLFTModulesRec
        public static void GetGlformatGLFTModulesRec(short ModuleNo, short FunctionNo, short FrmtTypeNo, ref short FrmtDigits, ref short FrmtPoints, ref SQLWriteClass SQLWrite)
        {
            DataTable dtGLFTModulesRec;
            SqlParameter[] SqlParam = new SqlParameter[3];
            List<GlformatGLFTModulesRec> listGLFTModulesRec = null;
            SQLWrite.SQLWriteCommand("dbo.GetGlformatGLFTModulesRec", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@GLFTModuleNo", "System.Int16", DependancyService.ParamDirection.Input, (object)ModuleNo);
            SqlParam[1] = DependancyService.SQLParameter("@GLFTGlFrmtFunctionNo", "System.Int16", DependancyService.ParamDirection.Input, (object)FunctionNo);
            SqlParam[2] = DependancyService.SQLParameter("@GLFTGlFrmtTypeNo", "System.Int16", DependancyService.ParamDirection.Input, (object)FrmtTypeNo);

            dtGLFTModulesRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtGLFTModulesRec.Rows.Count > 0)
            {
                listGLFTModulesRec = WpfClassLibrary.Extensions.ToList<GlformatGLFTModulesRec>(dtGLFTModulesRec);
                FrmtDigits = (short)listGLFTModulesRec[0].GLFTGlFrmtDigits;
                FrmtPoints = (short)listGLFTModulesRec[0].GLFTGlFrmtPoints;
            }
            else
            {
                FrmtDigits = 0;
                FrmtPoints = 0;
            }
        }
        #endregion

        #region // Gmlineno
        public static string GetGmlinenoGMLNMainRecGMLNLineNo(int GMLNFileNo, short GMLNDelAddr, string GMLNStyle, string GMLNVarn,
                                                        short GMLNColrNo, short GMLNColrNo1, ref SQLWriteClass SQLWrite)
        {
            string GMLNLineNo = "";

            SQLWrite.SQLWriteCommand("[dbo].[GetGmlinenoGMLNMainRecGMLNLineNo]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[7];

            SqlParam[0] = DependancyService.SQLParameter("@GMLNFileNo",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)GMLNFileNo);

            SqlParam[1] = DependancyService.SQLParameter("@GMLNDelAddr",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)GMLNDelAddr);

            SqlParam[2] = DependancyService.SQLParameter("@GMLNStyle",
                    "System.String", DependancyService.ParamDirection.Input, (object)GMLNStyle);

            SqlParam[3] = DependancyService.SQLParameter("@GMLNVarn",
                    "System.String", DependancyService.ParamDirection.Input, (object)GMLNVarn);

            SqlParam[4] = DependancyService.SQLParameter("@GMLNColrNo",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)GMLNColrNo);

            SqlParam[5] = DependancyService.SQLParameter("@GMLNColrNo1",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)GMLNColrNo1);

            SqlParam[6] = DependancyService.SQLParameter("@GMLNLineIndex",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)0);

            GMLNLineNo = (string)SQLWrite.ExecuteQueryFunction(SqlParam);

            return GMLNLineNo == null ? "" :GMLNLineNo.Trim();
        }
        public static string GetGmlinenoGMLNMainRecGMLNLineNo(int GMLNFileNo, short GMLNDelAddr, string GMLNStyle, string GMLNVarn,
                                                        short GMLNColrNo, short GMLNColrNo1, short GMLNLineIndex, ref SQLWriteClass SQLWrite)
        {
            string GMLNLineNo = "";

            SQLWrite.SQLWriteCommand("[dbo].[GetGmlinenoGMLNMainRecGMLNLineNo]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[7];

            SqlParam[0] = DependancyService.SQLParameter("@GMLNFileNo",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)GMLNFileNo);

            SqlParam[1] = DependancyService.SQLParameter("@GMLNDelAddr",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)GMLNDelAddr);

            SqlParam[2] = DependancyService.SQLParameter("@GMLNStyle",
                    "System.String", DependancyService.ParamDirection.Input, (object)GMLNStyle);

            SqlParam[3] = DependancyService.SQLParameter("@GMLNVarn",
                    "System.String", DependancyService.ParamDirection.Input, (object)GMLNVarn);

            SqlParam[4] = DependancyService.SQLParameter("@GMLNColrNo",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)GMLNColrNo);

            SqlParam[5] = DependancyService.SQLParameter("@GMLNColrNo1",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)GMLNColrNo1);

            SqlParam[6] = DependancyService.SQLParameter("@GMLNLineIndex",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)GMLNLineIndex);

            GMLNLineNo = (string)SQLWrite.ExecuteQueryFunction(SqlParam);

            return GMLNLineNo == null ? "" : GMLNLineNo.Trim();
        }
        public static GmlinenoGMLNMainRec GetGmlinenoGMLNMainRec(int GMLNFileNo, short GMLNDelAddr, string GMLNStyle, string GMLNVarn,
                                                        short GMLNColrNo, short GMLNColrNo1, short GMLNLineIndex, ref SQLWriteClass SQLWrite)
        {
            List<GmlinenoGMLNMainRec> listGMLNMainRec = null;

            SQLWrite.SQLWriteCommand("[dbo].[GetGlinenoGMLNMainRec]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[7];

            SqlParam[0] = DependancyService.SQLParameter("@GMLNFileNo",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)GMLNFileNo);

            SqlParam[1] = DependancyService.SQLParameter("@GMLNDelAddr",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)GMLNDelAddr);

            SqlParam[2] = DependancyService.SQLParameter("@GMLNStyle",
                    "System.String", DependancyService.ParamDirection.Input, (object)GMLNStyle);

            SqlParam[3] = DependancyService.SQLParameter("@GMLNVarn",
                    "System.String", DependancyService.ParamDirection.Input, (object)GMLNVarn);

            SqlParam[4] = DependancyService.SQLParameter("@GMLNColrNo",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)GMLNColrNo);

            SqlParam[5] = DependancyService.SQLParameter("@GMLNColrNo1",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)GMLNColrNo1);

            SqlParam[6] = DependancyService.SQLParameter("@GMLNLineIndex",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)GMLNLineIndex);

            DataTable dtGMLNMainRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtGMLNMainRec.Rows.Count > 0)
                listGMLNMainRec = WpfClassLibrary.Extensions.ToList<GmlinenoGMLNMainRec>(dtGMLNMainRec);

            return listGMLNMainRec == null ? null : listGMLNMainRec[0];
        }
        #endregion

        #region // Headft
        public static HeadftHDFTModulesRec GetHeadftHDFTModulesRec(short HDFTModuleNo, short HDFTSubModuleNo, short HDFTTypeNo, ref SQLWriteClass SQLWrite)
        {
            HeadftHDFTModulesRec HDFTModulesRec = null;
            SqlParameter[] SqlParam = new SqlParameter[3];
            SQLWrite.SQLWriteCommand("[dbo].[GetHeadftHDFTModulesRec]", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@HDFTModuleNo",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)HDFTModuleNo);

            SqlParam[1] = DependancyService.SQLParameter("@HDFTSubModuleNo",
                      "System.String", DependancyService.ParamDirection.Input, (object)HDFTSubModuleNo);

            SqlParam[2] = DependancyService.SQLParameter("@HDFTTypeNo",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)HDFTTypeNo);

            DataTable dtHDFTModulesRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtHDFTModulesRec.Rows.Count > 0)
            {
                List<HeadftHDFTModulesRec> listHeadftHDFTModulesRec = WpfClassLibrary.Extensions.ToList<HeadftHDFTModulesRec>(dtHDFTModulesRec);
                HDFTModulesRec = listHeadftHDFTModulesRec[0];
            }

            return HDFTModulesRec;
        }
        public static List<HeadftHDFTHeaderTextRec> GetHeadftHDFTHeaderTextRec(int ModulesRecID, ref SQLWriteClass SQLWrite)
        {
            SqlParameter[] SqlParam = new SqlParameter[1];
            List<HeadftHDFTHeaderTextRec> listHDFTHeaderTextRec = null;
            SQLWrite.SQLWriteCommand("[dbo].[GetHeadftHDFTHeaderTextRec]", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@ModulesRecID",
                      "System.Int32", DependancyService.ParamDirection.Input, (object)ModulesRecID);

            DataTable dtHDFTHeaderTextRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtHDFTHeaderTextRec.Rows.Count > 0)
                listHDFTHeaderTextRec = WpfClassLibrary.Extensions.ToList<HeadftHDFTHeaderTextRec>(dtHDFTHeaderTextRec);

            return listHDFTHeaderTextRec;
        }
        public static List<HeadftHDFTFooterTextRec> GetHeadftHDFTFooterTextRec(int ModulesRecID, ref SQLWriteClass SQLWrite)
        {
            SqlParameter[] SqlParam = new SqlParameter[1];
            List<HeadftHDFTFooterTextRec> listHDFTFooterTextRec = null;
            SQLWrite.SQLWriteCommand("[dbo].[GetHeadftHDFTFooterTextRec]", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@ModulesRecID",
                      "System.Int32", DependancyService.ParamDirection.Input, (object)ModulesRecID);

            DataTable dtHDFTFooterTextRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtHDFTFooterTextRec.Rows.Count > 0)
                listHDFTFooterTextRec = WpfClassLibrary.Extensions.ToList<HeadftHDFTFooterTextRec>(dtHDFTFooterTextRec);

            return listHDFTFooterTextRec;
        }
        #endregion

        #region // Matalcn
        public static MatalcnMAMainRec GetMatalcnMAMainRec(int MAFileNo, short MAMatType, string MAMatCode, short MAMatColr, short MAMatColr1,
                                                                short MAMatSupl, short MAMatWhse, short MAMatLocn, ref SQLWriteClass SQLWrite)
        {
            MatalcnMAMainRec MAMainRec = null;

            SQLWrite.SQLWriteCommand("[dbo].[GetMatalcnMAMainRec]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[8];

            SqlParam[0] = DependancyService.SQLParameter("@MAFileNo",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)MAFileNo);

            SqlParam[1] = DependancyService.SQLParameter("@MAMatType",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)MAMatType);

            SqlParam[2] = DependancyService.SQLParameter("@MAMatCode",
                    "System.String", DependancyService.ParamDirection.Input, (object)MAMatCode);

            SqlParam[3] = DependancyService.SQLParameter("@MAMatColr",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)MAMatColr);

            SqlParam[4] = DependancyService.SQLParameter("@MAMatColr1",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)MAMatColr1);

            SqlParam[5] = DependancyService.SQLParameter("@MAMatSupl",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)MAMatSupl);

            SqlParam[6] = DependancyService.SQLParameter("@MAMatWhse",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)MAMatWhse);

            SqlParam[7] = DependancyService.SQLParameter("@MAMatLocn",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)MAMatLocn);

            DataTable dtMAMainRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtMAMainRec.Rows.Count > 0)
            {
                List<MatalcnMAMainRec> listMatalcnMAMainRec = WpfClassLibrary.Extensions.ToList<MatalcnMAMainRec>(dtMAMainRec);
                MAMainRec = listMatalcnMAMainRec[0];
            }

            return MAMainRec;
        }
        #endregion

        #region // Matsbin
        public static MatsbinMatBinMainRec GetMatsbinMatBinMainRec(short MatType, string MatCode, short MatColr, short MatColr1,
                                                                short MatSupl, short MatWhse, short MatLocn, ref SQLWriteClass SQLWrite)
        {
            MatsbinMatBinMainRec MatBinMainRec = null;
            SqlParameter[] SqlParam = new SqlParameter[7];
            SQLWrite.SQLWriteCommand("[dbo].[GetMatsbinMatBinMainRec]", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@BMatType",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatType);

            SqlParam[1] = DependancyService.SQLParameter("@BMatCode",
                      "System.String", DependancyService.ParamDirection.Input, (object)MatCode);

            SqlParam[2] = DependancyService.SQLParameter("@BMatColr",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatColr);

            SqlParam[3] = DependancyService.SQLParameter("@BMatColr1",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatColr1);

            SqlParam[4] = DependancyService.SQLParameter("@BMatSupl",
                      "System.String", DependancyService.ParamDirection.Input, (object)MatSupl);

            SqlParam[5] = DependancyService.SQLParameter("@BMatWhse",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatWhse);

            SqlParam[6] = DependancyService.SQLParameter("@BMatLocn",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatLocn);

            DataTable dtMatBinMainRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtMatBinMainRec.Rows.Count > 0)
            {
                List<MatsbinMatBinMainRec> listMatBinMainRec = WpfClassLibrary.Extensions.ToList<MatsbinMatBinMainRec>(dtMatBinMainRec);
                MatBinMainRec = listMatBinMainRec[0];
            }

            return MatBinMainRec;
        }
        #endregion

        #region // Mords
        public static int GetMordsItemsPurchOrdNoIssdByMaterial(int FileNoIssd, short MatType, string MatCodeIssd, short MatColr, short MatColr1,
                                                                short MatSuplIssd, short MatWhse, short MatLocn, ref SQLWriteClass SQLWrite)
        {
            int PurchOrdNoIssd = 0;
            SqlParameter[] SqlParam = new SqlParameter[8];
            SQLWrite.SQLWriteCommand("[dbo].[GetMordsItemsPurchOrdNoIssdByMaterial]", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@FileNoIssd",
                      "System.Int32", DependancyService.ParamDirection.Input, (object)FileNoIssd);

            SqlParam[1] = DependancyService.SQLParameter("@MatType",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatType);

            SqlParam[2] = DependancyService.SQLParameter("@MatCodeIssd",
                      "System.String", DependancyService.ParamDirection.Input, (object)MatCodeIssd);

            SqlParam[3] = DependancyService.SQLParameter("@MatColr",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatColr);

            SqlParam[4] = DependancyService.SQLParameter("@MatColr1",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatColr1);

            SqlParam[5] = DependancyService.SQLParameter("@MatSuplIssd",
                      "System.Int32", DependancyService.ParamDirection.Input, (object)MatSuplIssd);

            SqlParam[6] = DependancyService.SQLParameter("@MatWhse",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatWhse);

            SqlParam[7] = DependancyService.SQLParameter("@MatLocn",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatLocn);

            PurchOrdNoIssd = (int)SQLWrite.ExecuteQueryFunction(SqlParam);

            return PurchOrdNoIssd;
        }
        public static int GetMordsOrderNoPurchOrdNoIssdByFileNoIssd(int FileNoIssd, short MatType, string MatCodeIssd, ref SQLWriteClass SQLWrite)
        {
            int PurchOrdNoIssd = 0;
            SqlParameter[] SqlParam = new SqlParameter[3];
            SQLWrite.SQLWriteCommand("[dbo].[GetMordsOrderNoPurchOrdNoIssdByFileNoIssd]", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@FileNoIssd",
                      "System.Int32", DependancyService.ParamDirection.Input, (object)FileNoIssd);

            SqlParam[1] = DependancyService.SQLParameter("@MatType",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatType);

            SqlParam[2] = DependancyService.SQLParameter("@MatCodeIssd",
                      "System.String", DependancyService.ParamDirection.Input, (object)MatCodeIssd);

            PurchOrdNoIssd = (int)SQLWrite.ExecuteQueryFunction(SqlParam);

            return PurchOrdNoIssd;
        }
        public static DateTime? GetMordsItemsDelivDateFromIssdByFileNoIssd(int FileNoIssd, short MatType, string MatCodeIssd, ref SQLWriteClass SQLWrite)
        {
            DateTime? DelivDateFromIssd = null;
            SqlParameter[] SqlParam = new SqlParameter[3];
            SQLWrite.SQLWriteCommand("[dbo].[GetMordsItemsDelivDateFromIssdByFileNoIssd]", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@FileNoIssd",
                      "System.Int32", DependancyService.ParamDirection.Input, (object)FileNoIssd);

            SqlParam[1] = DependancyService.SQLParameter("@MatType",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatType);

            SqlParam[2] = DependancyService.SQLParameter("@MatCodeIssd",
                      "System.String", DependancyService.ParamDirection.Input, (object)MatCodeIssd);

            DelivDateFromIssd = (DateTime?)SQLWrite.ExecuteQueryFunction(SqlParam);

            return DelivDateFromIssd;
        }
        #endregion

        #region // Mstkcost
        public static MstkcostMSCSTMainRec GetMstkcostMSCSTMainRecEx(short MatType, string MatCode, short MatColr, short MatColr1,
                                                                short MatSupl, short MatWhse, short MatLocn, ref SQLWriteClass SQLWrite)
        {
            MstkcostMSCSTMainRec MSCSTMainRec = null;
            SqlParameter[] SqlParam = new SqlParameter[7];
            SQLWrite.SQLWriteCommand("[dbo].[GetMstkcostMSCSTMainRecEx]", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@MatType",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatType);

            SqlParam[1] = DependancyService.SQLParameter("@MatCode",
                      "System.String", DependancyService.ParamDirection.Input, (object)MatCode);

            SqlParam[2] = DependancyService.SQLParameter("@Colr",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatColr);

            SqlParam[3] = DependancyService.SQLParameter("@Colr1",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatColr1);

            SqlParam[4] = DependancyService.SQLParameter("@MatSupl",
                      "System.String", DependancyService.ParamDirection.Input, (object)MatSupl);

            SqlParam[5] = DependancyService.SQLParameter("@MatWhse",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatWhse);

            SqlParam[6] = DependancyService.SQLParameter("@MatLocn",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatLocn);

            DataTable dtMSCSTMainRecc = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtMSCSTMainRecc.Rows.Count > 0)
            {
                List<MstkcostMSCSTMainRec> listMstkcostMSCSTMainRec = WpfClassLibrary.Extensions.ToList<MstkcostMSCSTMainRec>(dtMSCSTMainRecc);
                MSCSTMainRec = listMstkcostMSCSTMainRec[0];
            }

            return MSCSTMainRec;
        }
        #endregion

        #region // Mstknots
        public static List<MstknotsMSTKNotesRec> GetMstkcostMSCSTNotsRecEx(short MatType, string MatCode, short MatColr, short MatColr1,
                                                                                            short MatSupl, short MatWhse, short MatLocn, ref SQLWriteClass SQLWrite)
        {
            SqlParameter[] SqlParam = new SqlParameter[7];
            List<MstknotsMSTKNotesRec> listMstknotsMSTKNotesRec = null;
            SQLWrite.SQLWriteCommand("[dbo].[GetMstkcostMSCSTNotsRecEx]", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@MatType",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatType);

            SqlParam[1] = DependancyService.SQLParameter("@MatCode",
                      "System.String", DependancyService.ParamDirection.Input, (object)MatCode);

            SqlParam[2] = DependancyService.SQLParameter("@MatColr",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatColr);

            SqlParam[3] = DependancyService.SQLParameter("@MatColr1",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatColr1);

            SqlParam[4] = DependancyService.SQLParameter("@MatSup",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatSupl);

            SqlParam[5] = DependancyService.SQLParameter("@MatWhse",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatWhse);

            SqlParam[6] = DependancyService.SQLParameter("@MatLocn",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatLocn);

            DataTable dtMSCSTNotsRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtMSCSTNotsRec.Rows.Count > 0)
                listMstknotsMSTKNotesRec = WpfClassLibrary.Extensions.ToList<MstknotsMSTKNotesRec>(dtMSCSTNotsRec);

            return listMstknotsMSTKNotesRec;
        }
        #endregion

        #region // Opers
        public static double GetOpersGLOpersRecRatePerHour(short OperNo, ref SQLWriteClass SQLWrite)
        {
            double RatePerHour = 0.0;
            SqlParameter[] SqlParam = new SqlParameter[1];
            SQLWrite.SQLWriteCommand("dbo.GetOpersGLOpersRecGLRatePerHour", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@CGLOperNo", "System.Int16", DependancyService.ParamDirection.Input, (object)OperNo);
            RatePerHour = (double)SQLWrite.ExecuteQueryFunction(SqlParam);

            return RatePerHour;
        }
        #endregion

        #region // Orders
        public static int GetNextOrdersOrdMainDataOrdFlNoIssued(ref SQLWriteClass SQLWrite)
        {
            int OrdFlNoIssued = 0;
            SQLWrite.SQLWriteCommand("[dbo].[GetNextOrdersOrdMainDataOrdFlNoIssued]", SQLWriteClass.SqlCmdType.PROCEDURE);

            OrdFlNoIssued = (int)SQLWrite.ExecuteQueryFunction(null);

            return OrdFlNoIssued;
        }
        public static short GetOrdersOrdMainDataOrdComDockFlag(int OrdCsNoIssued, short DeliveryIndex, ref SQLWriteClass SQLWrite)
        {
            short OrdComDockFlag = 0;

            SQLWrite.SQLWriteCommand("[dbo].[GetOrdersOrdMainDataOrdComDockFlag]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[1];

            SqlParam[0] = DependancyService.SQLParameter("@OrdCsNoIssued",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)OrdCsNoIssued);

            object obj = SQLWrite.ExecuteQueryFunction(SqlParam);

            if (obj == null)
                OrdComDockFlag = 0;
            else
                OrdComDockFlag = (short)obj;

            return OrdComDockFlag;
        }
        public static short GetOrdersOrdMainDataOrdComDockFlagByOrdFlNoIssued(int OrdFlNoIssued, ref SQLWriteClass SQLWrite)
        {
            short OrdComDockFlag = 0;

            SQLWrite.SQLWriteCommand("[dbo].[GetOrdersOrdMainDataOrdComDockFlagByOrdFlNoIssued]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[1];

            SqlParam[0] = DependancyService.SQLParameter("@OrdFlNoIssued",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)OrdFlNoIssued);

            object obj = SQLWrite.ExecuteQueryFunction(SqlParam);

            if (obj == null)
                OrdComDockFlag = 0;
            else
                OrdComDockFlag = (short)obj;

            return OrdComDockFlag;
        }
        public static string GetOrdersOrdOrderReference(int OrdFlNoIssued, short DeliveryIndex, ref SQLWriteClass SQLWrite)
        {
            string OrdOrderReference = "";

            SQLWrite.SQLWriteCommand("[dbo].[GetOrdersOrdDelivAddrOrdOrderReference]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[2];

            SqlParam[0] = DependancyService.SQLParameter("@OrdFlNoIssued",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)OrdFlNoIssued);

            SqlParam[1] = DependancyService.SQLParameter("@Index",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)DeliveryIndex);

            object obj = SQLWrite.ExecuteQueryFunction(SqlParam);

            if (obj == null)
                OrdOrderReference = "";
            else
                OrdOrderReference = (string)obj;

            return OrdOrderReference;
        }
        public static double GetOrdersOrdColrsQtysOrdMatCost(int OrdFlNoIssued, short DelAddress, string Style, string Varn, short ColrNo, short ColrNo1, ref SQLWriteClass SQLWrite)
        {
            double OrdMatCost = 0.0;

            SQLWrite.SQLWriteCommand("[dbo].[GetOrdersOrdColrsQtysOrdMatCost]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[6];

            SqlParam[0] = DependancyService.SQLParameter("@OrdFlNoIssued",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)OrdFlNoIssued);

            SqlParam[1] = DependancyService.SQLParameter("@DelAddress",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)DelAddress);

            SqlParam[2] = DependancyService.SQLParameter("@OrdStyles",
                    "System.String", DependancyService.ParamDirection.Input, (object)Style);

            SqlParam[3] = DependancyService.SQLParameter("@OrdVarn",
                    "System.String", DependancyService.ParamDirection.Input, (object)Varn);

            SqlParam[4] = DependancyService.SQLParameter("@OrdColrNo",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)ColrNo);

            SqlParam[5] = DependancyService.SQLParameter("@OrdColrNo1",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)ColrNo1);

            OrdMatCost = (double)SQLWrite.ExecuteQueryFunction(SqlParam);

            return OrdMatCost;
        }
        public static DataTable GetOrdersOrdColrsQtysProductionScheduleView(string Style, string Varn, short ColrNo, string DateCheck, ref SQLWriteClass SQLWrite)
        {
            SQLWrite.SQLWriteCommand("[dbo].[GetOrdersOrdColrsQtysProductionScheduleView]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[4];

            SqlParam[0] = DependancyService.SQLParameter("@OrdStyle",
                    "System.String", DependancyService.ParamDirection.Input, (object)Style);

            SqlParam[1] = DependancyService.SQLParameter("@OrdVarn",
                    "System.String", DependancyService.ParamDirection.Input, (object)Varn);

            SqlParam[2] = DependancyService.SQLParameter("@OrdColrNo",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)ColrNo);

            SqlParam[3] = DependancyService.SQLParameter("@DateCheck",
                    "System.String", DependancyService.ParamDirection.Input, (object)DateCheck);

            DataTable dtOrdColrsQty = SQLWrite.ExecuteDataTableQuery(SqlParam);


            return dtOrdColrsQty;
        }
        public static OrdersOrdMainData GetOrdersOrdMainData(int OrdFlNoIssued, ref SQLWriteClass SQLWrite)
        {
            OrdersOrdMainData OrdMainData = null;
            SqlParameter[] SqlParam = new SqlParameter[1];
            SQLWrite.SQLWriteCommand("[dbo].[GetOrdersOrdMainData]", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@OrdFlNoIssued", "System.Int32", DependancyService.ParamDirection.Input, (object)OrdFlNoIssued);

            DataTable dtOrdersOrdMainData = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtOrdersOrdMainData.Rows.Count > 0)
            {
                List<OrdersOrdMainData> listdtOrdersOrdMainData = WpfClassLibrary.Extensions.ToList<OrdersOrdMainData>(dtOrdersOrdMainData);
                OrdMainData = listdtOrdersOrdMainData[0];
            }

            return OrdMainData;
        }
        public static List<OrdersOrdDelivAddr> GetOrdersOrdDelivAddr(int OrderID, ref SQLWriteClass SQLWrite)
        {
            SqlParameter[] SqlParam = new SqlParameter[1];
            List<OrdersOrdDelivAddr> listdtOrdersOrdDelivAddr = null;
            SQLWrite.SQLWriteCommand("[dbo].[GetOrdersOrdDelivAddr]", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@OrderID", "System.Int32", DependancyService.ParamDirection.Input, (object)OrderID);

            DataTable dtOrdersOrdDelivAddra = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtOrdersOrdDelivAddra.Rows.Count > 0)
                listdtOrdersOrdDelivAddr = WpfClassLibrary.Extensions.ToList<OrdersOrdDelivAddr>(dtOrdersOrdDelivAddra);

            return listdtOrdersOrdDelivAddr;
        }
        public static List<OrdersOrdStyles> GetOrdersOrdStyles(int OrdDelivAddrID, ref SQLWriteClass SQLWrite)
        {
            SqlParameter[] SqlParam = new SqlParameter[1];
            List<OrdersOrdStyles> listdtOrdersOrdStyles = null;
            SQLWrite.SQLWriteCommand("[dbo].[GetOrdersOrdStyles]", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@OrdDelivAddrID", "System.Int32", DependancyService.ParamDirection.Input, (object)OrdDelivAddrID);

            DataTable dtOrdersOrdStyles = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtOrdersOrdStyles.Rows.Count > 0)
                listdtOrdersOrdStyles = WpfClassLibrary.Extensions.ToList<OrdersOrdStyles>(dtOrdersOrdStyles);

            return listdtOrdersOrdStyles;
        }
        public static List<OrdersOrdColrsQtys> GetOrdersOrdColrsQtys(int OrdStylesID, ref SQLWriteClass SQLWrite)
        {
            SqlParameter[] SqlParam = new SqlParameter[1];
            List<OrdersOrdColrsQtys> listdtOrdersOrdColrsQtys = null;
            SQLWrite.SQLWriteCommand("[dbo].[GetOrdersOrdStyles]", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@OrdStylesID", "System.Int32", DependancyService.ParamDirection.Input, (object)OrdStylesID);

            DataTable dtOrdersOrdColrsQtys = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtOrdersOrdColrsQtys.Rows.Count > 0)
                listdtOrdersOrdColrsQtys = WpfClassLibrary.Extensions.ToList<OrdersOrdColrsQtys>(dtOrdersOrdColrsQtys);

            return listdtOrdersOrdColrsQtys;
        }
        public static List<OrdersOrdCosts> GetOrdersOrdCosts(int OrdColrsQtysID, ref SQLWriteClass SQLWrite)
        {
            SqlParameter[] SqlParam = new SqlParameter[1];
            List<OrdersOrdCosts> listdtOrdersOrdCosts = null;
            SQLWrite.SQLWriteCommand("[dbo].[GetOrdersOrdCosts]", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@OrdColrsQtysID", "System.Int32", DependancyService.ParamDirection.Input, (object)OrdColrsQtysID);

            DataTable dtOrdersOrdersOrdCosts = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtOrdersOrdersOrdCosts.Rows.Count > 0)
                listdtOrdersOrdCosts = WpfClassLibrary.Extensions.ToList<OrdersOrdCosts>(dtOrdersOrdersOrdCosts);

            return listdtOrdersOrdCosts;
        }
        public static double GetOrdersOrdCostsOrdCostingView(string OrdStyle, string OrdVarn, short OrdColrNo, short OrdMatType, 
                                                                string OrdMatCode, short OrdMatSupl, short OrdMatWhse, short OrdMatLocn, ref SQLWriteClass SQLWrite)
        {
            double OrdMatCost = 0.0;

            SQLWrite.SQLWriteCommand("[dbo].[GetOrdersOrdCostsOrdCostingView]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[8];

            SqlParam[0] = DependancyService.SQLParameter("@OrdStyle",
                    "System.String", DependancyService.ParamDirection.Input, (object)OrdStyle);

            SqlParam[1] = DependancyService.SQLParameter("@OrdVarn",
                    "System.String", DependancyService.ParamDirection.Input, (object)OrdVarn);

            SqlParam[2] = DependancyService.SQLParameter("@OrdColrNo",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)OrdColrNo);

            SqlParam[3] = DependancyService.SQLParameter("@OrdMatType",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)OrdMatType);

            SqlParam[4] = DependancyService.SQLParameter("@OrdMatCode",
                    "System.String", DependancyService.ParamDirection.Input, (object)OrdMatCode);

            SqlParam[5] = DependancyService.SQLParameter("@OrdMatSupl",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)OrdMatSupl);

            SqlParam[6] = DependancyService.SQLParameter("@OrdMatWhse",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)OrdMatWhse);

            SqlParam[7] = DependancyService.SQLParameter("@OrdMatLocn",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)OrdMatLocn);

            OrdMatCost = (double)SQLWrite.ExecuteQueryFunction(SqlParam);

            return OrdMatCost;
        }
        #endregion

        #region // Ordersex
        public static short GetOrdersexORDEXAdditions2RecORDEXA2CanFlag(int ORDEXA2FileNumber, short ORDEXA2DeliveryIndex, ref SQLWriteClass SQLWrite)
        {
            short ORDEXA2CanFlag = 0;

            SQLWrite.SQLWriteCommand("[dbo].[GetOrdersexORDEXAdditions2RecORDEXA2CanFlag]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[2];

            SqlParam[0] = DependancyService.SQLParameter("@ORDEXA2FileNumber",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)ORDEXA2FileNumber);

            SqlParam[1] = DependancyService.SQLParameter("@ORDEXA2DeliveryIndex",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)ORDEXA2DeliveryIndex);

            ORDEXA2CanFlag = (short)SQLWrite.ExecuteQueryFunction(SqlParam);

            return ORDEXA2CanFlag;
        }
        public static OrdersexORDEXMainRec GetOrdersexORDEXMainRec(int ORDEXFileNumber, short ORDEXDeliveryIndex, ref SQLWriteClass SQLWrite)   
        {
            OrdersexORDEXMainRec ORDEXMainRec = null;
            SqlParameter[] SqlParam = new SqlParameter[2];
            SQLWrite.SQLWriteCommand("[dbo].[GetOrdersexORDEXMainRec]", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@ORDEXFileNumber",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)ORDEXFileNumber);

            SqlParam[1] = DependancyService.SQLParameter("@ORDEXDeliveryIndex",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)ORDEXDeliveryIndex);

            DataTable dtORDEXMainRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtORDEXMainRec.Rows.Count > 0)
            {
                List<OrdersexORDEXMainRec> listOrdersexORDEXMainRec = WpfClassLibrary.Extensions.ToList<OrdersexORDEXMainRec>(dtORDEXMainRec);
                ORDEXMainRec = listOrdersexORDEXMainRec[0];
            }

            return ORDEXMainRec;
        }
        public static string GetOrdersexORDEXFileRecORDEXFGBSPuma(int ORDEXFileNumber, ref SQLWriteClass SQLWrite)
        {
            string sORDEXFileNumber = "";

            SQLWrite.SQLWriteCommand("[dbo].[GetOrdersexORDEXFileRecORDEXFGBSPuma]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[1];

            SqlParam[0] = DependancyService.SQLParameter("@ORDEXFileNumber",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)ORDEXFileNumber);

            sORDEXFileNumber = (string)SQLWrite.ExecuteQueryFunction(SqlParam);

            return sORDEXFileNumber == null ? "" : sORDEXFileNumber.Trim();
        }
        public static OrdersexORDEXDelStlClrRec GetOrdersexORDEXDelStlClrRec(int ORDEXFileNumber, int ORDEXSDeliveryIndex, 
                                                            string ORDEXSStyle, string ORDEXSVarn, ref SQLWriteClass SQLWrite)
        {
            SqlParameter[] SqlParam = new SqlParameter[4];
            OrdersexORDEXDelStlClrRec ORDEXDelStlClrRec = null;
            SQLWrite.SQLWriteCommand("[dbo].[GetOrdersexORDEXDelStlClrRec]", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@ORDEXFileNumber",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)ORDEXFileNumber);

            SqlParam[1] = DependancyService.SQLParameter("@ORDEXSDeliveryIndex",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)ORDEXSDeliveryIndex);

            SqlParam[2] = DependancyService.SQLParameter("@ORDEXSStyle",
                    "System.String", DependancyService.ParamDirection.Input, (object)ORDEXSStyle);

            SqlParam[3] = DependancyService.SQLParameter("@ORDEXSVarn",
                    "System.String", DependancyService.ParamDirection.Input, (object)ORDEXSVarn);

            DataTable dtsORDEXDelStlClrRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtsORDEXDelStlClrRec.Rows.Count > 0)
            {
                List<OrdersexORDEXDelStlClrRec> listOrdersexORDEXDelStlClrRec = WpfClassLibrary.Extensions.ToList<OrdersexORDEXDelStlClrRec>(dtsORDEXDelStlClrRec);
                ORDEXDelStlClrRec = listOrdersexORDEXDelStlClrRec[0];
            }

            return ORDEXDelStlClrRec;
        }
        #endregion

        #region // Ordnotes
        public static List<OrdnotesOrdNotsRec> GetOrdnotesOrdNotsRecByOrdNFlNo(int OrdNFlNo, ref SQLWriteClass SQLWrite)
        {
            SqlParameter[] SqlParam = new SqlParameter[1];
            List<OrdnotesOrdNotsRec> listOrdnotesOrdNotsRec = null;
            SQLWrite.SQLWriteCommand("[dbo].[GetOrdnotesOrdNotsRecByOrdNFlNo]", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@OrdNFlNo", "System.Int32", DependancyService.ParamDirection.Input, (object)OrdNFlNo);

            DataTable dtOrdNotsRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtOrdNotsRec.Rows.Count > 0)
                listOrdnotesOrdNotsRec = WpfClassLibrary.Extensions.ToList<OrdnotesOrdNotsRec>(dtOrdNotsRec);

            return listOrdnotesOrdNotsRec;
        }
        #endregion

        #region // Pricelst - May be depreicated
        public static double GetPricelstXPLMainRecXPLSelPrice1(string XPLStyle, string XPLVarn, short XPLCurrencyNo, ref SQLWriteClass SQLWrite)
        {
            double SelPrice1 = 0.0;
            SqlParameter[] SqlParam = new SqlParameter[3];
            SQLWrite.SQLWriteCommand("[dbo].[GetPricelstXPLMainRecXPLSelPrice1]", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@XPLStyle",
                      "System.String", DependancyService.ParamDirection.Input, (object)XPLStyle);

            SqlParam[1] = DependancyService.SQLParameter("@XPLVarn",
                      "System.String", DependancyService.ParamDirection.Input, (object)XPLVarn);

            SqlParam[2] = DependancyService.SQLParameter("@XPLCurrencyNo",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)XPLCurrencyNo);

            SelPrice1 = (double)SQLWrite.ExecuteQueryFunction(SqlParam);

            return SelPrice1;
        }
        #endregion

        #region // Rollsdb
        public static string GetRollsdbRollsMRecCodeDesc(ref SqlParameter[] SqlParam, ref SQLWriteClass SQLWrite)
        {
            SQLWrite.SQLWriteCommand("[dbo].[GetRollsdbRollsMRecByCodeDesc]", SQLWriteClass.SqlCmdType.PROCEDURE);

            object Obj = SQLWrite.ExecuteQueryFunction(SqlParam);

            return Obj == null ? "" : (string)Obj;
        }
        public static RollsdbRollsMRec GetRollsdbRollsMRecByLocation(ref SqlParameter[] SqlParam, ref SQLWriteClass SQLWrite)
        {
            RollsdbRollsMRec RollsMRec = null;
            SQLWrite.SQLWriteCommand("[dbo].[GetRollsdbRollsMRecByLocation]", SQLWriteClass.SqlCmdType.PROCEDURE);

            DataTable dtRollsMRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtRollsMRec.Rows.Count > 0)
            {
                List<RollsdbRollsMRec> listRollsdbRollsMRec = WpfClassLibrary.Extensions.ToList<RollsdbRollsMRec>(dtRollsMRec);
                RollsMRec = listRollsdbRollsMRec[0];
            }

            return RollsMRec;
        }
        public static RollsdbRollsMRec GetRollsdbRollsMRecByCode(ref SqlParameter[] SqlParam, ref SQLWriteClass SQLWrite)
        {
            RollsdbRollsMRec RollsMRec = null;
            SQLWrite.SQLWriteCommand("[dbo].[GetRollsdbRollsMRecByCode]", SQLWriteClass.SqlCmdType.PROCEDURE);
            DataTable dtRollsMRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtRollsMRec.Rows.Count > 0)
            {
                List<RollsdbRollsMRec> listRollsdbRollsMRec = WpfClassLibrary.Extensions.ToList<RollsdbRollsMRec>(dtRollsMRec);
                RollsMRec = listRollsdbRollsMRec[0];
            }

            return RollsMRec;
        }
        public static RollsdbRollsMRec GetRollsdbRollsMRecByCode(short MatType, string MatCode, ref SQLWriteClass SQLWrite)
        {
            RollsdbRollsMRec RollsMRec = null;
            SqlParameter[] SqlParam = new SqlParameter[2];
            SQLWrite.SQLWriteCommand("[dbo].[GetRollsdbRollsMRecByCode]", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@RMatType",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatType);

            SqlParam[1] = DependancyService.SQLParameter("@RMatCode",
                      "System.String", DependancyService.ParamDirection.Input, (object)MatCode);

            DataTable dtRollsMRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtRollsMRec.Rows.Count > 0)
            {
                List<RollsdbRollsMRec> listRollsdbRollsMRec = WpfClassLibrary.Extensions.ToList<RollsdbRollsMRec>(dtRollsMRec);
                RollsMRec = listRollsdbRollsMRec[0];
            }

            return RollsMRec;
        }
        public static string GetRollsdbMaterialDescByColour(short MatType, string MatCode, short MatColr, ref SQLWriteClass SQLWrite)
        {
            string RMatDescr = "";
            RollsdbRollsMRec RollsMRec = null;
            SqlParameter[] SqlParam = new SqlParameter[3];
            SQLWrite.SQLWriteCommand("[dbo].[GetRollsdbMaterialDescByColour]", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@RMatType",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatType);

            SqlParam[1] = DependancyService.SQLParameter("@RMatCode",
                      "System.String", DependancyService.ParamDirection.Input, (object)MatCode);

            SqlParam[2] = DependancyService.SQLParameter("@RMatColr",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatColr);

            DataTable dtRollsMRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtRollsMRec.Rows.Count > 0)
            {
                List<RollsdbRollsMRec> listRollsdbRollsMRec = WpfClassLibrary.Extensions.ToList<RollsdbRollsMRec>(dtRollsMRec);
                RollsMRec = listRollsdbRollsMRec[0];
                RMatDescr = RollsMRec.RMatDescr.Trim();
            }

            return RMatDescr;
        }
        public static RollsdbRollsMRec GetRollsdbRollsMRecByColour(ref SqlParameter[] SqlParam, ref SQLWriteClass SQLWrite)
        {
            RollsdbRollsMRec RollsMRec = null;
            SQLWrite.SQLWriteCommand("[dbo].[GetRollsdbRollsMRecByColour]", SQLWriteClass.SqlCmdType.PROCEDURE);
            DataTable dtRollsMRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtRollsMRec.Rows.Count > 0)
            {
                List<RollsdbRollsMRec> listRollsdbRollsMRec = WpfClassLibrary.Extensions.ToList<RollsdbRollsMRec>(dtRollsMRec);
                RollsMRec = listRollsdbRollsMRec[0];
            }

            return RollsMRec;
        }
        public static RollsdbRollsMRec GetRollsdbRollsMRecByColour(short MatType, string MatCode, short MatColr, ref SQLWriteClass SQLWrite)
        {
            RollsdbRollsMRec RollsMRec = null;
            SqlParameter[] SqlParam = new SqlParameter[3];
            SQLWrite.SQLWriteCommand("[dbo].[GetRollsdbRollsMRecByColour]", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@RMatType",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatType);

            SqlParam[1] = DependancyService.SQLParameter("@RMatCode",
                      "System.String", DependancyService.ParamDirection.Input, (object)MatCode);

            SqlParam[2] = DependancyService.SQLParameter("@RMatColr",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatColr);

            DataTable dtRollsMRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtRollsMRec.Rows.Count > 0)
            {
                List<RollsdbRollsMRec> listRollsdbRollsMRec = WpfClassLibrary.Extensions.ToList<RollsdbRollsMRec>(dtRollsMRec);
                RollsMRec = listRollsdbRollsMRec[0];
            }

            return RollsMRec;
        }
        public static RollsdbRollsMRec GetRollsdbRollsMRecByLocation(short MatType, string MatCode, short MatColr, short MatColr1,
                                                                short MatSupl, short MatWhse, short MatLocn, ref SQLWriteClass SQLWrite)
        {
            RollsdbRollsMRec RollsMRec = null;
            SqlParameter[] SqlParam = new SqlParameter[7];
            SQLWrite.SQLWriteCommand("[dbo].[GetRollsdbRollsMRecByLocation]", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@RMatType",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatType);

            SqlParam[1] = DependancyService.SQLParameter("@RMatCode",
                      "System.String", DependancyService.ParamDirection.Input, (object)MatCode);

            SqlParam[2] = DependancyService.SQLParameter("@RMatColr",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatColr);

            SqlParam[3] = DependancyService.SQLParameter("@RMatColr1",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatColr1);

            SqlParam[4] = DependancyService.SQLParameter("@RMatSupl",
                      "System.String", DependancyService.ParamDirection.Input, (object)MatSupl);

            SqlParam[5] = DependancyService.SQLParameter("@RMatWhse",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatWhse);

            SqlParam[6] = DependancyService.SQLParameter("@RMatLocn",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatLocn);

            DataTable dtRollsMRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtRollsMRec.Rows.Count > 0)
            {
                List<RollsdbRollsMRec> listRollsdbRollsMRec = WpfClassLibrary.Extensions.ToList<RollsdbRollsMRec>(dtRollsMRec);
                RollsMRec = listRollsdbRollsMRec[0];
            }

            return RollsMRec;
        }
        public static RollsdbRollsMRec GetRollsdbRollsMRecBySupplier(ref SqlParameter[] SqlParam, ref SQLWriteClass SQLWrite)
        {
            RollsdbRollsMRec RollsMRec = null;
            SQLWrite.SQLWriteCommand("[dbo].[GetRollsdbRollsMRecBySupplier]", SQLWriteClass.SqlCmdType.PROCEDURE);
            DataTable dtRollsMRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtRollsMRec.Rows.Count > 0)
            {
                List<RollsdbRollsMRec> listRollsdbRollsMRec = WpfClassLibrary.Extensions.ToList<RollsdbRollsMRec>(dtRollsMRec);
                RollsMRec = listRollsdbRollsMRec[0];
            }

            return RollsMRec;
        }
        public static RollsdbRMatSizes GetRollsdbRMatSizes(ref DataTable dtRollsdbRMatSizes, int Index = 0)
        {
            RollsdbRMatSizes RMatSizes = null;
            List<RollsdbRMatSizes> listRollsdbRMatSizes = WpfClassLibrary.Extensions.ToList < RollsdbRMatSizes>(dtRollsdbRMatSizes);

            if (Index < listRollsdbRMatSizes.Count)
                RMatSizes = listRollsdbRMatSizes[Index];

            return RMatSizes;
        }
        public static RollsdbRMatSizesE GetRollsdbRMatSizesE(ref DataTable dtRollsdbRMatSizes, int Index = 0)
        {
            RollsdbRMatSizesE RMatSizesE = null;
            List<RollsdbRMatSizesE> listRollsdbRMatSizesE = WpfClassLibrary.Extensions.ToList<RollsdbRMatSizesE>(dtRollsdbRMatSizes);

            if (Index < listRollsdbRMatSizesE.Count)
                RMatSizesE = listRollsdbRMatSizesE[Index];

            return RMatSizesE;
        }
        public static RollsdbRMatSizes GetRollsdbRMatSizes(int ID, ref SQLWriteClass SQLWrite)
        {
            RollsdbRMatSizes RMatSizes = null;
            SqlParameter[] SqlParam = new SqlParameter[1];
            SQLWrite.SQLWriteCommand("[dbo].[GetRollsdbRMatSizes]", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@RollsID",
                      "System.Int32", DependancyService.ParamDirection.Input, (object)ID);

            DataTable dtRMatSizes = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtRMatSizes.Rows.Count > 0)
            {
                List<RollsdbRMatSizes> listRollsdbRMatSizess = WpfClassLibrary.Extensions.ToList<RollsdbRMatSizes>(dtRMatSizes);
                RMatSizes = listRollsdbRMatSizess[0];
            }

            return RMatSizes;
        }
        public static RollsdbRMatSizesE GetRollsdbRMatSizesE(int ID, ref SQLWriteClass SQLWrite)
        {
            RollsdbRMatSizesE RMatSizesE = null;
            SqlParameter[] SqlParam = new SqlParameter[1];
            SQLWrite.SQLWriteCommand("[dbo].[GetRollsdbRMatSizesE]", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@RollsID",
                      "System.Int32", DependancyService.ParamDirection.Input, (object)ID);

            DataTable dtRMatSizesE = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtRMatSizesE.Rows.Count > 0)
            {
                List<RollsdbRMatSizesE> listRollsdbRMatSizess = WpfClassLibrary.Extensions.ToList<RollsdbRMatSizesE>(dtRMatSizesE);
                RMatSizesE = listRollsdbRMatSizess[0];
            }

            return RMatSizesE;
        }
        public static RollsdbProperties GetRollsdbPropertiesByID(int ID, ref SQLWriteClass SQLWrite)
        {
            DataTable dtProperties;
            RollsdbProperties Properties = null;
            SqlParameter[] SqlParam = new SqlParameter[1];
            SQLWrite.SQLWriteCommand("[dbo].[GetRollsdbPropertiesByRollsID]", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@RollsID",
                      "System.Int32", DependancyService.ParamDirection.Input, (object)ID);

            dtProperties = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtProperties.Rows.Count > 0)
            {
                List<RollsdbProperties> listRollsdbProperties = WpfClassLibrary.Extensions.ToList<RollsdbProperties>(dtProperties);
                Properties = listRollsdbProperties[0];
            }
            else
                Properties = null;
           
            return Properties;
        }
        public static RollsdbProperties GetRollsdbPropertiesEx(short MatType, string MatCode, short MatColr, short MatColr1,
                                                                short MatSupl, short MatWhse, short MatLocn, ref SQLWriteClass SQLWrite)
        {
            RollsdbProperties Properties = null;
            SqlParameter[] SqlParam = new SqlParameter[7];
            SQLWrite.SQLWriteCommand("[dbo].[GetRollsdbPropertiesEx]", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@RMatType",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatType);

            SqlParam[1] = DependancyService.SQLParameter("@RMatCode",
                      "System.String", DependancyService.ParamDirection.Input, (object)MatCode);

            SqlParam[2] = DependancyService.SQLParameter("@RMatColr",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatColr);

            SqlParam[3] = DependancyService.SQLParameter("@RMatColr1",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatColr1);

            SqlParam[4] = DependancyService.SQLParameter("@RMatSupl",
                      "System.String", DependancyService.ParamDirection.Input, (object)MatSupl);

            SqlParam[5] = DependancyService.SQLParameter("@RMatWhse",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatWhse);

            SqlParam[6] = DependancyService.SQLParameter("@RMatLocn",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatLocn);

            DataTable dtProperties = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtProperties.Rows.Count > 0)
            {
                List<RollsdbProperties> listRollsdbProperties = WpfClassLibrary.Extensions.ToList<RollsdbProperties>(dtProperties);
                Properties = listRollsdbProperties[0];
            }

            return Properties;
        }
        public static double GetRollsdbPropertiesMinOrderQty(short MatType, string MatCode, short MatColr, short MatColr1,
                                                                short MatSupl, short MatWhse, short MatLocn, ref SQLWriteClass SQLWrite)
        {
            double MinOrderQty = 0.0;
            SqlParameter[] SqlParam = new SqlParameter[7];
            SQLWrite.SQLWriteCommand("[dbo].[GetRollsdbPropertiesMinOrderQty]", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@RMatType",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatType);

            SqlParam[1] = DependancyService.SQLParameter("@RMatCode",
                      "System.String", DependancyService.ParamDirection.Input, (object)MatCode);

            SqlParam[2] = DependancyService.SQLParameter("@RMatColr",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatColr);

            SqlParam[3] = DependancyService.SQLParameter("@RMatColr1",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatColr1);

            SqlParam[4] = DependancyService.SQLParameter("@RMatSupl",
                      "System.String", DependancyService.ParamDirection.Input, (object)MatSupl);

            SqlParam[5] = DependancyService.SQLParameter("@RMatWhse",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatWhse);

            SqlParam[6] = DependancyService.SQLParameter("@RMatLocn",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatLocn);

            MinOrderQty = (double)SQLWrite.ExecuteQueryFunction(SqlParam);

            return MinOrderQty;
        }
        public static RollsdbProperties GetRollsdbProperties(short MatType, string MatCode, ref SQLWriteClass SQLWrite)
        {
            RollsdbProperties Properties = null;
            SqlParameter[] SqlParam = new SqlParameter[2];
            SQLWrite.SQLWriteCommand("[dbo].[GetRollsdbProperties]", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@RMatType",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatType);

            SqlParam[1] = DependancyService.SQLParameter("@RMatCode",
                      "System.String", DependancyService.ParamDirection.Input, (object)MatCode);

            DataTable dtProperties = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtProperties.Rows.Count > 0)
            {
                List<RollsdbProperties> listRollsdbProperties = WpfClassLibrary.Extensions.ToList<RollsdbProperties>(dtProperties);
                Properties = listRollsdbProperties[0];
            }

            return Properties;
        }
        public static string GetRollsdbRollsMRecRMatSizeKeyEx(short MatType, string MatCode, short MatColr, short MatColr1, 
                                                                short MatSupl, short MatWhse, short MatLocn, ref SQLWriteClass SQLWrite)
        {
            string SizeKey = "";
            SqlParameter[] SqlParam = new SqlParameter[7];
            SQLWrite.SQLWriteCommand("[dbo].[GetRollsdbRollsMRecRMatSizeKeyEx]", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@RMatType",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatType);

            SqlParam[1] = DependancyService.SQLParameter("@RMatCode",
                      "System.String", DependancyService.ParamDirection.Input, (object)MatCode);

            SqlParam[2] = DependancyService.SQLParameter("@RMatColr",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatColr);

            SqlParam[3] = DependancyService.SQLParameter("@RMatColr1",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatColr1);

            SqlParam[4] = DependancyService.SQLParameter("@RMatSupl",
                      "System.String", DependancyService.ParamDirection.Input, (object)MatSupl);

            SqlParam[5] = DependancyService.SQLParameter("@RMatWhse",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatWhse);

            SqlParam[6] = DependancyService.SQLParameter("@RMatLocn",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatLocn);

            SizeKey = (string)SQLWrite.ExecuteQueryFunction(SqlParam);

            return SizeKey;
        }
        public static string GetRollsdbRollsMRecRMatSizeKey(short MatType, string MatCode, short MatSupl, ref SQLWriteClass SQLWrite)
        {
            string SizeKey = "";
            SqlParameter[] SqlParam = new SqlParameter[3];
            SQLWrite.SQLWriteCommand("[dbo].[GetRollsdbRollsMRecRMatSizeKeyEx]", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@RMatType",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatType);

            SqlParam[1] = DependancyService.SQLParameter("@RMatCode",
                      "System.String", DependancyService.ParamDirection.Input, (object)MatCode);

            SqlParam[2] = DependancyService.SQLParameter("@RMatSupl",
                      "System.String", DependancyService.ParamDirection.Input, (object)MatSupl);

            SizeKey = (string)SQLWrite.ExecuteQueryFunction(SqlParam);

            return SizeKey;
        }
        public static string GetRollsdbRollsMRecRMatSizeKey(short MatType, string MatCode, short MatColr, short MatColr1,
                                                                short MatSupl, short MatWhse, short MatLocn, ref SQLWriteClass SQLWrite)
        {
            string RMatSizeKey = "";
            SqlParameter[] SqlParam = new SqlParameter[7];
            SQLWrite.SQLWriteCommand("[dbo].[GetRollsdbRollsMRecRMatSizeKeyEx]", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@RMatType",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatType);

            SqlParam[1] = DependancyService.SQLParameter("@RMatCode",
                      "System.String", DependancyService.ParamDirection.Input, (object)MatCode);

            SqlParam[2] = DependancyService.SQLParameter("@RMatColr",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatColr);

            SqlParam[3] = DependancyService.SQLParameter("@RMatColr1",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatColr1);

            SqlParam[4] = DependancyService.SQLParameter("@RMatSupl",
                      "System.String", DependancyService.ParamDirection.Input, (object)MatSupl);

            SqlParam[5] = DependancyService.SQLParameter("@RMatWhse",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatWhse);

            SqlParam[6] = DependancyService.SQLParameter("@RMatLocn",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatLocn);

            RMatSizeKey = (string)SQLWrite.ExecuteQueryFunction(SqlParam);

            return RMatSizeKey;
        }
        public static double GetRollsdbRollsMRecRMatCost(short MatType, string MatCode, short MatColr, short MatColr1,
                                                                short MatSupl, short MatWhse, short MatLocn, ref SQLWriteClass SQLWrite)
        {
            double RMatCost = 0.0;
            SqlParameter[] SqlParam = new SqlParameter[7];
            SQLWrite.SQLWriteCommand("[dbo].[GetRollsdbRollsMRecRMatCost]", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@RMatType",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatType);

            SqlParam[1] = DependancyService.SQLParameter("@RMatCode",
                      "System.String", DependancyService.ParamDirection.Input, (object)MatCode);

            SqlParam[2] = DependancyService.SQLParameter("@RMatColr",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatColr);

            SqlParam[3] = DependancyService.SQLParameter("@RMatColr1",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatColr1);

            SqlParam[4] = DependancyService.SQLParameter("@RMatSupl",
                      "System.String", DependancyService.ParamDirection.Input, (object)MatSupl);

            SqlParam[5] = DependancyService.SQLParameter("@RMatWhse",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatWhse);

            SqlParam[6] = DependancyService.SQLParameter("@RMatLocn",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatLocn);

            RMatCost = (double)SQLWrite.ExecuteQueryFunction(SqlParam);

            return RMatCost;
        }
        public static double GetRollsdbRollsMRecOrderUnit(short MatType, string MatCode, short MatColr, short MatColr1,
                                                                short MatSupl, short MatWhse, short MatLocn, ref SQLWriteClass SQLWrite)
        {
            double OrderUnit = 0.0;
            SqlParameter[] SqlParam = new SqlParameter[7];
            SQLWrite.SQLWriteCommand("[dbo].[GetRollsdbPropertiesOrderUnit]", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@RMatType",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatType);

            SqlParam[1] = DependancyService.SQLParameter("@RMatCode",
                      "System.String", DependancyService.ParamDirection.Input, (object)MatCode);

            SqlParam[2] = DependancyService.SQLParameter("@RMatColr",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatColr);

            SqlParam[3] = DependancyService.SQLParameter("@RMatColr1",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatColr1);

            SqlParam[4] = DependancyService.SQLParameter("@RMatSupl",
                      "System.String", DependancyService.ParamDirection.Input, (object)MatSupl);

            SqlParam[5] = DependancyService.SQLParameter("@RMatWhse",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatWhse);

            SqlParam[6] = DependancyService.SQLParameter("@RMatLocn",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatLocn);

            OrderUnit = (double)SQLWrite.ExecuteQueryFunction(SqlParam);

            return OrderUnit;
        }
        public static string GetRollsdbRollsMRecRMatUnit(short MatType, string MatCode, short MatColr, ref SQLWriteClass SQLWrite)
        {
            string SizeKey = "";
            SqlParameter[] SqlParam = new SqlParameter[3];
            SQLWrite.SQLWriteCommand("[dbo].[GetRollsdbRollsMRecRMatUnit]", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@RMatType",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatType);

            SqlParam[1] = DependancyService.SQLParameter("@RMatCode",
                      "System.String", DependancyService.ParamDirection.Input, (object)MatCode);

            SqlParam[2] = DependancyService.SQLParameter("@RMatColr",
                      "System.String", DependancyService.ParamDirection.Input, (object)MatColr);

            SizeKey = (string)SQLWrite.ExecuteQueryFunction(SqlParam);

            return SizeKey;
        }
        public static string GetRollsdbRollsMRecRMatUnitEx(short MatType, string MatCode, short MatColr, short MatColr1, short MatSupl, short MatWhse, short MatLocn, ref SQLWriteClass SQLWrite)
        {
            SqlParameter[] SqlParam = new SqlParameter[7];
            SQLWrite.SQLWriteCommand("[dbo].[GetRollsdbRollsMRecRMatUnitEx]", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@MatType",
                    "System.Int16", DependancyService.ParamDirection.InputOutput, (object)MatType);

            SqlParam[1] = DependancyService.SQLParameter("@MatCode",
                    "System.String", DependancyService.ParamDirection.Input, (object)MatCode.Trim());

            SqlParam[2] = DependancyService.SQLParameter("@MatColr",
                    "System.Int16", DependancyService.ParamDirection.InputOutput, (object)MatColr);

            SqlParam[3] = DependancyService.SQLParameter("@MatColr1",
                    "System.Int16", DependancyService.ParamDirection.InputOutput, (object)MatColr1);

            SqlParam[4] = DependancyService.SQLParameter("@MatSupl",
                    "System.Int16", DependancyService.ParamDirection.InputOutput, (object)MatSupl);

            SqlParam[5] = DependancyService.SQLParameter("@MatWhse",
                    "System.Int16", DependancyService.ParamDirection.InputOutput, (object)MatWhse);

            SqlParam[6] = DependancyService.SQLParameter("@MatLocn",
                    "System.Int16", DependancyService.ParamDirection.InputOutput, (object)MatLocn);

            object Obj = SQLWrite.ExecuteQueryFunction(SqlParam);

            return Obj == null ? "" : (string)Obj;
        }
        public static string GetRollsdbRollsMRecCodeDesc(short MatType, string MatCode, short MatColr, short MatColr1, short MatSupl, short MatWhse, short MatLocn, ref SQLWriteClass SQLWrite)
        {
            SqlParameter[] SqlParam = new SqlParameter[7];
            SQLWrite.SQLWriteCommand("[dbo].[GetRollsdbRollsMRecMatDescription]", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@MatType",
                    "System.Int16", DependancyService.ParamDirection.InputOutput, (object)MatType);

            SqlParam[1] = DependancyService.SQLParameter("@MatCode",
                    "System.String", DependancyService.ParamDirection.Input, (object)MatCode.Trim());

            SqlParam[2] = DependancyService.SQLParameter("@MatColr",
                    "System.Int16", DependancyService.ParamDirection.InputOutput, (object)MatColr);

            SqlParam[3] = DependancyService.SQLParameter("@MatColr1",
                    "System.Int16", DependancyService.ParamDirection.InputOutput, (object)MatColr1);

            SqlParam[4] = DependancyService.SQLParameter("@MatSupl",
                    "System.Int16", DependancyService.ParamDirection.InputOutput, (object)MatSupl);

            SqlParam[5] = DependancyService.SQLParameter("@MatWhse",
                    "System.Int16", DependancyService.ParamDirection.InputOutput, (object)MatWhse);

            SqlParam[6] = DependancyService.SQLParameter("@MatLocn",
                    "System.Int16", DependancyService.ParamDirection.InputOutput, (object)MatLocn);

            object Obj = SQLWrite.ExecuteQueryFunction(SqlParam);

            return Obj == null ? "" : (string)Obj;
        }
        public static string GetRollsdbRollsMRecCodeDesc(short MatType, string MatCode, ref SQLWriteClass SQLWrite)
        {
            SqlParameter[] SqlParam = new SqlParameter[2];
            SQLWrite.SQLWriteCommand("[dbo].[GetRollsdbRollsMRecByCodeDesc]", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@MatType",
                    "System.Int16", DependancyService.ParamDirection.InputOutput, (object)MatType);

            SqlParam[1] = DependancyService.SQLParameter("@MatCode",
                    "System.String", DependancyService.ParamDirection.Input, (object)MatCode.Trim());

            object Obj = SQLWrite.ExecuteQueryFunction(SqlParam);

            return Obj == null ? "" : (string)Obj;
        }
        #endregion

        #region // Szgrid
        public static SzgridGMSZGMainRec GetSzgridGMSZGMainRecByStyleVarnType(string GMSZGStyle, string GMSZGVarn, short GMSZGType, ref SQLWriteClass SQLWrite)
        {
            List<SzgridGMSZGMainRec> listszgridGMSZGMainRec = null;

            SQLWrite.SQLWriteCommand("[dbo].[GetSzgridGMSZGMainRecByStyleVarnType]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[3];

            SqlParam[0] = DependancyService.SQLParameter("@GMSZGStyle",
                    "System.String", DependancyService.ParamDirection.Input, (object)GMSZGStyle);

            SqlParam[1] = DependancyService.SQLParameter("@GMSZGVarn",
                    "System.String", DependancyService.ParamDirection.Input, (object)GMSZGVarn);

            SqlParam[2] = DependancyService.SQLParameter("@GMSZGType",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)GMSZGType);

            DataTable dtGMSZGMainRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtGMSZGMainRec.Rows.Count > 0)
                listszgridGMSZGMainRec = WpfClassLibrary.Extensions.ToList<SzgridGMSZGMainRec>(dtGMSZGMainRec);

            return (listszgridGMSZGMainRec != null && listszgridGMSZGMainRec.Count > 0) ? listszgridGMSZGMainRec[0] : null;
        }
        public static List<SzgridGMSZGSiblRec> GetSzgridGMSZGSiblRec(int MainRecID, ref SQLWriteClass SQLWrite)
        {
            List<SzgridGMSZGSiblRec> listszgridGMSZGSiblRec = null;

            SQLWrite.SQLWriteCommand("[dbo].[GetSzgridGMSZGSiblRec]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[1];

            SqlParam[0] = DependancyService.SQLParameter("@MainRecID",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)MainRecID);

            DataTable dtGMSZGSiblRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtGMSZGSiblRec.Rows.Count > 0)
                listszgridGMSZGSiblRec = WpfClassLibrary.Extensions.ToList<SzgridGMSZGSiblRec>(dtGMSZGSiblRec);

            return (listszgridGMSZGSiblRec != null && listszgridGMSZGSiblRec.Count > 0) ? listszgridGMSZGSiblRec : null;
        }
        public static DataTable GetSzgridGMSZGSiblRecProductionScheduleView(string Style, string Varn, ref SQLWriteClass SQLWrite)
        {
            SQLWrite.SQLWriteCommand("[dbo].[GetSzgridGMSZGSiblRecProductionScheduleView]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[2];

            SqlParam[0] = DependancyService.SQLParameter("@OrdStyle",
                    "System.String", DependancyService.ParamDirection.Input, (object)Style);

            SqlParam[1] = DependancyService.SQLParameter("@OrdVarn",
                    "System.String", DependancyService.ParamDirection.Input, (object)Varn);

            DataTable dtGMSZGSiblRec = SQLWrite.ExecuteDataTableQuery(SqlParam);


            return dtGMSZGSiblRec;
        }
        #endregion

        #region // Szmappng
        public static SzmappngSzMappingRec GetSzmappngSzMappingRec(ref CostdbCostMRec CostMRec, ref CostdbCTMatsRec CTMatsRec, ref SQLWriteClass SQLWrite)
        {
            DataTable dtSzMappingRec;
            SzmappngSzMappingRec SzMappingRec = null;
            List<SzmappngSzMappingRec> listSzMappingRec;
            SqlParameter[] SqlParam = new SqlParameter[10];
            SQLWrite.SQLWriteCommand("[dbo].[GetSzmappngSzMappingRec]", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@Style",
                      "System.String", DependancyService.ParamDirection.Input, (object)CostMRec.CTStyle);

            SqlParam[1] = DependancyService.SQLParameter("@Varn",
                      "System.String", DependancyService.ParamDirection.Input, (object)CostMRec.CTVarn);

            SqlParam[2] = DependancyService.SQLParameter("@Part",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)CTMatsRec.CTMatPart);

            SqlParam[3] = DependancyService.SQLParameter("@Type",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)CTMatsRec.CTMatType);

            SqlParam[4] = DependancyService.SQLParameter("@Code",
                      "System.String", DependancyService.ParamDirection.Input, (object)CTMatsRec.CTMatCode);

            SqlParam[5] = DependancyService.SQLParameter("@Colr",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)CTMatsRec.CTMatColr);

            SqlParam[6] = DependancyService.SQLParameter("@Colr",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)CTMatsRec.CTMatColr);

            SqlParam[7] = DependancyService.SQLParameter("@Supl",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)CTMatsRec.CTMatSupl);

            SqlParam[8] = DependancyService.SQLParameter("@Whse",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)CTMatsRec.CTMatWhse);

            SqlParam[9] = DependancyService.SQLParameter("@Locn",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)CTMatsRec.CTMatLocn);

            dtSzMappingRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtSzMappingRec.Rows.Count > 0)
            {
                listSzMappingRec = WpfClassLibrary.Extensions.ToList<SzmappngSzMappingRec>(dtSzMappingRec);
                SzMappingRec = listSzMappingRec[0];
            }
            else
                SzMappingRec = null;

            return SzMappingRec;
        }
        public static SzmappngSzMappingRec GetSzmappngSzMappingRecWithSize(string Style, string Varn, short MatPart, short MatType, string MatCode, 
                                                                            short MatColr, short MatColr1, short MatSupl, short MatWhse, short MatLocn, 
                                                                                                                string Size,  ref SQLWriteClass SQLWrite)
        {
            DataTable dtSzMappingRec;
            SzmappngSzMappingRec SzMappingRec = null;
            List<SzmappngSzMappingRec> listSzMappingRec;
            SqlParameter[] SqlParam = new SqlParameter[11];
            SQLWrite.SQLWriteCommand("[dbo].[GetSzmappngSzMappingRecWithSize]", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@Style",
                      "System.String", DependancyService.ParamDirection.Input, (object)Style);

            SqlParam[1] = DependancyService.SQLParameter("@Varn",
                      "System.String", DependancyService.ParamDirection.Input, (object)Varn);

            SqlParam[2] = DependancyService.SQLParameter("@Part",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatPart);

            SqlParam[3] = DependancyService.SQLParameter("@Type",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatType);

            SqlParam[4] = DependancyService.SQLParameter("@Code",
                      "System.String", DependancyService.ParamDirection.Input, (object)MatCode);

            SqlParam[5] = DependancyService.SQLParameter("@Colr",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatColr);

            SqlParam[6] = DependancyService.SQLParameter("@Colr1",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatColr1);

            SqlParam[7] = DependancyService.SQLParameter("@Supl",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatSupl);

            SqlParam[8] = DependancyService.SQLParameter("@Whse",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatWhse);

            SqlParam[9] = DependancyService.SQLParameter("@Locn",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatLocn);

            SqlParam[9] = DependancyService.SQLParameter("@Size",
                      "System.String", DependancyService.ParamDirection.Input, (object)Size);

            dtSzMappingRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtSzMappingRec.Rows.Count > 0)
            {
                listSzMappingRec = WpfClassLibrary.Extensions.ToList<SzmappngSzMappingRec>(dtSzMappingRec);
                SzMappingRec = listSzMappingRec[0];
            }
            else
                SzMappingRec = null;

            return SzMappingRec;
        }
        public static string GetSzmappngSzMappingRecRecMSZSSizes(string Style, string Varn, short MatPart, short MatType, string MatCode,
                                                                            short MatColr, short MatColr1, short MatSupl, short MatWhse, short MatLocn,
                                                                                                                string Size, ref SQLWriteClass SQLWrite)
        {
            string MSZSSizes = "";
            SqlParameter[] SqlParam = new SqlParameter[11];
            SQLWrite.SQLWriteCommand("[dbo].[GetSzmappngSzMappingRecMSZSSizes]", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@Style",
                      "System.String", DependancyService.ParamDirection.Input, (object)Style);

            SqlParam[1] = DependancyService.SQLParameter("@Varn",
                      "System.String", DependancyService.ParamDirection.Input, (object)Varn);

            SqlParam[2] = DependancyService.SQLParameter("@Part",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatPart);

            SqlParam[3] = DependancyService.SQLParameter("@Type",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatType);

            SqlParam[4] = DependancyService.SQLParameter("@Code",
                      "System.String", DependancyService.ParamDirection.Input, (object)MatCode.Trim());

            SqlParam[5] = DependancyService.SQLParameter("@Colr",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatColr);

            SqlParam[6] = DependancyService.SQLParameter("@Colr1",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatColr1);

            SqlParam[7] = DependancyService.SQLParameter("@Supl",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatSupl);

            SqlParam[8] = DependancyService.SQLParameter("@Whse",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatWhse);

            SqlParam[9] = DependancyService.SQLParameter("@Locn",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatLocn);

            SqlParam[10] = DependancyService.SQLParameter("@Size",
                      "System.String", DependancyService.ParamDirection.Input, (object)Size);

            MSZSSizes = (string)SQLWrite.ExecuteQueryFunction(SqlParam);

            return MSZSSizes == null ? "" : MSZSSizes;
        }
        public static string GetSzmappngSzMappingRecByMSZSCodeMSZSSizes(string Style, string Varn, short MatPart, short MatType, string MatCode,
                                                                                                                string Size, ref SQLWriteClass SQLWrite)
        {
            string MSZSSizes = "";
            SqlParameter[] SqlParam = new SqlParameter[6];
            SQLWrite.SQLWriteCommand("[dbo].[GetSzmappngSzMappingRecMSZSSizes]", SQLWriteClass.SqlCmdType.PROCEDURE);

            SqlParam[0] = DependancyService.SQLParameter("@Style",
                      "System.String", DependancyService.ParamDirection.Input, (object)Style);

            SqlParam[1] = DependancyService.SQLParameter("@Varn",
                      "System.String", DependancyService.ParamDirection.Input, (object)Varn);

            SqlParam[2] = DependancyService.SQLParameter("@Part",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatPart);

            SqlParam[3] = DependancyService.SQLParameter("@Type",
                      "System.Int16", DependancyService.ParamDirection.Input, (object)MatType);

            SqlParam[4] = DependancyService.SQLParameter("@Code",
                      "System.String", DependancyService.ParamDirection.Input, (object)MatCode.Trim());

            SqlParam[5] = DependancyService.SQLParameter("@Size",
                      "System.String", DependancyService.ParamDirection.Input, (object)Size);

            MSZSSizes = (string)SQLWrite.ExecuteQueryFunction(SqlParam);

            return MSZSSizes == null ? "" : MSZSSizes;
        }
        #endregion

        #region // Stock Contol Functions - Matalcn.MAMainRec & Rollsdb.RollsMRe
        public static void CollateCostings(List<DocketStyles> listdocketStyles, List<List<DocketColrsQtys>> listdocketColrsQtys, List<List<DocketOrgCostings>> listdocketOrgCostings,
                                                List<List<MatRequiremts>> listMatRequiremts, List<ColoursInfo> listColoursInfo, DataTable dtGMSizesRec, short CustomerNo, SQLWriteClass SQLWrite)
        {
            string MatSizeKey;
            bool bFrist = true;
            int IndexStyle = -1;
            int MatReqIndex = 0;
            int IndexColrsQty = -1;
            SqlParameter[] SqlParam;
            MatRequiremts MatRequiremt = null;
            List<CostdbCostMRec> listCostdbCostMRec = null;
            List<CostdbCTMatsRec> listCostdbCTMatsRec = null;
            List<RollsdbRollsMRec> listRollsdbRollsMRec = null;

            bFrist = true;
            listColoursInfo.Clear();
            listMatRequiremts[0].Clear();
            listColoursInfo.AddRange(Enumerable.Range(0, listdocketStyles.Count).Select(x => new ColoursInfo()));

            try
            {
                var sQuery = (from DocketStyles in listdocketStyles
                    select DocketStyles).Count(x =>
                    {
                        ReadOrigCostingForAllColours(ref listCostdbCostMRec, listdocketStyles, listdocketColrsQtys, listdocketOrgCostings, listCostdbCTMatsRec, SQLWrite, CustomerNo, (short)listdocketStyles.IndexOf(x));

                        
                        SQLWrite.SQLWriteCommand("dbo.GetCostdbStyleVarn", SQLWriteClass.SqlCmdType.PROCEDURE);
                        SqlParam = new SqlParameter[2];

                        SqlParam[0] = DependancyService.SQLParameter("@CTStyle",
                                    "System.String", DependancyService.ParamDirection.Input, (object)x.StyleCode.Trim());

                        SqlParam[1] = DependancyService.SQLParameter("@CTVarn",
                                    "System.String", DependancyService.ParamDirection.Input, (object)x.VarnCode.Trim());
                        
                        if (listCostdbCostMRec == null)
                        { 
                            // CostMRec
                            DataTable dtCostsdbCostMRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

                            if (dtCostsdbCostMRec.Rows.Count > 0)
                                listCostdbCostMRec = Extensions.ToList<CostdbCostMRec>(dtCostsdbCostMRec);
                        }

                        // CSTExtraRec
                        SQLWrite.SQLWriteCommand("dbo.GetCstextraCSTExtraRec", SQLWriteClass.SqlCmdType.PROCEDURE);
                        DataTable dtCstextraCSTExtraRec = SQLWrite.ExecuteDataTableQuery(SqlParam);
                        IndexStyle = listdocketStyles.IndexOf(x);

                        #region // Docket ColrsQtys
                        var sQueryColrsQtys = (from DocketColrsQtys in listdocketColrsQtys[IndexStyle]
                            where DocketColrsQtys.StyleID == x.ID
                            select DocketColrsQtys).Count(y =>
                            {
                                int[] IssdQtys = null;
                                IndexColrsQty = listdocketColrsQtys[IndexStyle].IndexOf(y);
                                WpfClassLibrary.SQLArrayConvert.StringToIntArray(y.IssdQtys, ref IssdQtys);

                                // Issued Totals
                                listColoursInfo[IndexStyle].ColourTotals[IndexColrsQty] = (from Issd in IssdQtys
                                                                                            select Issd).Sum();

                                #region // Docket OrgCostings
                                var sQueryRolls = (from OrgCost in listdocketOrgCostings[IndexStyle]
                                                   where OrgCost.ColrID == y.ID
                                select OrgCost).Count(z =>
                                {
                                    #region // Rollsdb - RollsMRec & Properties
                                    
                                    SQLWrite.SQLWriteCommand("dbo.GetRollsdbRollsMRecByLocation", SQLWriteClass.SqlCmdType.PROCEDURE);
                                    SqlParam = new SqlParameter[7];

                                    SqlParam[0] = DependancyService.SQLParameter("@RMatType",
                                                "System.Int32", DependancyService.ParamDirection.Input, (object)z.OrgMatType);

                                    SqlParam[1] = DependancyService.SQLParameter("@RMatCode",
                                                "System.String", DependancyService.ParamDirection.Input, (object)z.OrgMatCode.Trim());

                                    SqlParam[2] = DependancyService.SQLParameter("@RMatColr",
                                                "System.Int32", DependancyService.ParamDirection.Input, (object)z.OrgMatColr);

                                    SqlParam[3] = DependancyService.SQLParameter("@RMatColr1",
                                                "System.Int32", DependancyService.ParamDirection.Input, (object)z.OrgMatColr1);

                                    SqlParam[4] = DependancyService.SQLParameter("@RMatSupl",
                                                "System.Int32", DependancyService.ParamDirection.Input, (object)z.OrgMatSupl);

                                    SqlParam[5] = DependancyService.SQLParameter("@RMatWhse",
                                                "System.Int32", DependancyService.ParamDirection.Input, (object)z.OrgMatWhse);

                                    SqlParam[6] = DependancyService.SQLParameter("@RMatLocn",
                                                "System.Int32", DependancyService.ParamDirection.Input, (object)z.OrgMatLocn);

                                    // Rollsdb
                                    DataTable dtRollsMRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

                                    if (dtRollsMRec.Rows.Count > 0)
                                    {
                                        listRollsdbRollsMRec = Extensions.ToList<RollsdbRollsMRec>(dtRollsMRec);
                                        z.OrgMatPrice = listRollsdbRollsMRec[0].RMatCost;

                                        SqlParam = new SqlParameter[1];

                                        SqlParam[0] = DependancyService.SQLParameter("@RollsiD",
                                                    "System.Int32", DependancyService.ParamDirection.Input, (object)listRollsdbRollsMRec[0].RollsID);

                                        if (listRollsdbRollsMRec[0].RMatSizeKey.Trim().Length > 0)
                                        {
                                            SQLWrite.SQLWriteCommand("dbo.GetRollsdbRMatSizes", SQLWriteClass.SqlCmdType.PROCEDURE);

                                            // RMatSizes
                                            DataTable dtRollsdbRMatSizes = SQLWrite.ExecuteDataTableQuery(SqlParam);
                                        }

                                        SQLWrite.SQLWriteCommand("dbo.GetRollsdbPropertiesByRollsID", SQLWriteClass.SqlCmdType.PROCEDURE);

                                        // Properties
                                        DataTable dtRollsdbProperties = SQLWrite.ExecuteDataTableQuery(SqlParam);
                                    }
                                    
                                    #endregion

                                    if (bFrist)
                                    {
                                        bFrist = false;
                                        
                                        // Create MatRequiremts into listMatRequiremts
                                        MatRequiremt = new MatRequiremts();
                                        listMatRequiremts[0].Add(MatRequiremt);

                                        #region // Create first MatRequiremts
                                        MatRequiremt.SpareFlag1 = (short)z.OrgSpareFlag1;
                                        MatRequiremt.MatPart = (short)z.OrgMatPart;
                                        MatRequiremt.MatPartDesc = "";
                                        MatRequiremt.MatType = (short)z.OrgMatType;
                                        MatRequiremt.MatTypeDesc = "";
                                        MatRequiremt.MatCode = z.OrgMatCode.Trim();
                                        MatRequiremt.MatColr = (short)z.OrgMatColr;
                                        MatRequiremt.MatColr1 = (short)z.OrgMatColr1;
                                        MatRequiremt.MatColrDesc = "";
                                        MatRequiremt.MatSupl = (short)z.OrgMatSupl;
                                        MatRequiremt.MatWhse = (short)z.OrgMatWhse;
                                        MatRequiremt.MatLocn = (short)z.OrgMatLocn;
                                        MatRequiremt.MatCosting = (double)z.OrgCosting;
                                        MatRequiremt.MatPrice = (double)z.OrgMatPrice;
                                        
                                        string sConsumption = WgmateDBUtilClass.GetConsumptMRecConSConsumption(x.StyleCode,
                                            x.VarnCode, listRollsdbRollsMRec[0].RMatSizeKey, (short)z.OrgMatPart,
                                                                (short)z.OrgMatType, z.OrgMatCode, (short)z.OrgMatColr,
                                                                (short)z.OrgMatColr1, (short)z.OrgMatSupl, (short)z.OrgMatWhse,
                                                                (short)z.OrgMatLocn, ref SQLWrite);

                                        if (sConsumption.Trim().Length > 0)
                                        {
                                            double Reqd = 0.0;
                                            double[] Consumption = null;
                                            WpfClassLibrary.SQLArrayConvert.StringToDoubleArray(sConsumption, ref Consumption);

                                            for (int i = 0; i < IssdQtys.Count(); i++)
                                                Reqd += IssdQtys[i] * Consumption[i];

                                            MatRequiremt.Required = Reqd;
                                        }
                                        else
                                        {
                                            if (listMatRequiremts[0][MatReqIndex].MatType == 1 || listMatRequiremts[0][MatReqIndex].MatType == 2)
                                            {
                                                double Reqd = 0.0;

                                                for (int i = 0; i < IssdQtys.Count(); i++)
                                                    Reqd += IssdQtys[i] * ((double)z.OrgCosting + (((double)listCostdbCostMRec[0].CTGrading / 100.0) * (i - 1)));

                                                MatRequiremt.Required = Reqd;
                                            }
                                            else
                                                MatRequiremt.Required += (listColoursInfo[IndexStyle].ColourTotals[IndexColrsQty] * (double)z.OrgCosting);
                                        }

                                        // [Rollsdb.RollsMRec] - [RMatSizeKey]
                                        MatSizeKey = WgmateDBUtilClass.GetRollsdbRollsMRecRMatSizeKeyEx((short)z.OrgMatType, z.OrgMatCode,
                                                                                                                        (short)z.OrgMatColr, (short)z.OrgMatColr1,
                                                                                                                        (short)z.OrgMatSupl, (short)z.OrgMatWhse,
                                                                                                                        (short)z.OrgMatLocn, ref SQLWrite);

                                        if (MatSizeKey != null && MatSizeKey.Trim().Length > 0)
                                        {
                                            string[] MSZSSizes = null;
                                            string sMSZSSizes = "";
                                            string[] GmSizes = null;

                                            // Gmsizes
                                            DataRow drSizes = WgmateDBUtilClass.GetGmSizeDataRow(MatSizeKey, ref dtGMSizesRec);
                                            WpfClassLibrary.SQLArrayConvert.StringToStringArray(drSizes["GMSizes"].ToString(), ref GmSizes);

                                            // Szmappng.SzMappingRec - [MSZSSizes]
                                            sMSZSSizes = WgmateDBUtilClass.GetSzmappngSzMappingRecRecMSZSSizes(x.StyleCode, x.VarnCode, (short)z.OrgMatPart,
                                                                                                                        (short)z.OrgMatType, z.OrgMatCode,
                                                                                                                        (short)z.OrgMatColr, (short)z.OrgMatColr1,
                                                                                                                        (short)z.OrgMatSupl, (short)z.OrgMatWhse,
                                                                                                                        (short)z.OrgMatLocn, MatSizeKey, ref SQLWrite);

                                            if (sMSZSSizes != null && sMSZSSizes.Trim().Length > 0)
                                            {
                                                WpfClassLibrary.SQLArrayConvert.StringToStringArray(sMSZSSizes, ref MSZSSizes);

                                                for (int i = 0; i < 32; i++)
                                                {   // Find MSZSSizes Index in GmSizes
                                                    int Index = Array.FindIndex(GmSizes, row => row.Trim().Contains(MSZSSizes[i].Trim()));

                                                    if (Index != -1)
                                                        MatRequiremt.RequiredSizes[Index] += (y.IssdQtys[Index] * (double)z.OrgCosting);
                                                }

                                                MatRequiremt.Required = 0.0;
                                                //-----------------------------------------------------------------
                                                for (int i = 0; i < 128; i++)
                                                    MatRequiremt.Required += MatRequiremt.RequiredSizes[i];
                                                //-----------------------------------------------------------------
                                            }
                                            else
                                            {
                                                for (int i = 0; i < 32; i++)
                                                    MatRequiremt.RequiredSizes[i] = (y.IssdQtys[i] * (double)z.OrgCosting);

                                                MatRequiremt.Required = 0.0;
                                                //-----------------------------------------------------------------
                                                for (int i = 0; i < 128; i++)
                                                    MatRequiremt.Required += MatRequiremt.RequiredSizes[i];
                                                //-----------------------------------------------------------------
                                            } // end if - else
                                        } // end if
                                        //=====================================================================
                                        #endregion

                                        MatReqIndex += 1;
                                    }
                                    else
                                    {
                                        bool bFound = false;
                                        #region // Add to Existing Requiremts
                                        var sQueryRequiremts = (from MatRequiremts in listMatRequiremts[0]
                                            select MatRequiremts).Count(w =>
                                            {
                                                if (w.MatType == (short)z.OrgMatType &&
                                                    w.MatCode.Trim() == z.OrgMatCode.Trim() &&
                                                    w.MatColr == (short)z.OrgMatColr)
                                                {
                                                    bFound = true;
                                                    double RequiredHold = w.Required;
                                                    
                                                    string sConsumption = WgmateDBUtilClass.GetConsumptMRecConSConsumption(x.StyleCode,
                                                        x.VarnCode, listRollsdbRollsMRec[0].RMatSizeKey, (short)z.OrgMatPart,
                                                                            (short)z.OrgMatType, z.OrgMatCode, (short)z.OrgMatColr,
                                                                            (short)z.OrgMatColr1, (short)z.OrgMatSupl, (short)z.OrgMatWhse,
                                                                            (short)z.OrgMatLocn, ref SQLWrite);
                                                    
                                                    if (sConsumption != null &&  sConsumption.Trim().Length > 0)
                                                    {
                                                        double Reqd = 0.0;

                                                        double[] Consumption = null;
                                                        WpfClassLibrary.SQLArrayConvert.StringToDoubleArray(sConsumption, ref Consumption);

                                                        for (int i = 0; i < IssdQtys.Count(); i++)
                                                            Reqd += IssdQtys[i] * Consumption[i];

                                                        w.Required += Reqd;
                                                    }
                                                    else
                                                    {
                                                        if (w.MatType == 1 || w.MatType == 2)
                                                        {
                                                            double Reqd = 0.0;

                                                            for (int i = 0; i < IssdQtys.Count(); i++)
                                                                Reqd += IssdQtys[i] * ((double)z.OrgCosting + (((double)listCostdbCostMRec[0].CTGrading / 100.0) * (i - 1)));

                                                            w.Required += Reqd;
                                                        }
                                                        else
                                                            w.Required += (listColoursInfo[IndexStyle].ColourTotals[IndexColrsQty] * (double)z.OrgCosting);
                                                    }

                                                    // [Rollsdb.RollsMRec] - [RMatSizeKey]
                                                    MatSizeKey = WgmateDBUtilClass.GetRollsdbRollsMRecRMatSizeKeyEx((short)z.OrgMatType, z.OrgMatCode,
                                                                                                                                    (short)z.OrgMatColr, (short)z.OrgMatColr1,
                                                                                                                                    (short)z.OrgMatSupl, (short)z.OrgMatWhse,
                                                                                                                                    (short)z.OrgMatLocn, ref SQLWrite);

                                                    if (MatSizeKey != null && MatSizeKey.Trim().Length > 0)
                                                    {
                                                        string[] MSZSSizes = null;
                                                        string sMSZSSizes = "";
                                                        string[] GmSizes = null;

                                                        // Gmsizes
                                                        DataRow drSizes = WgmateDBUtilClass.GetGmSizeDataRow(MatSizeKey, ref dtGMSizesRec);
                                                        WpfClassLibrary.SQLArrayConvert.StringToStringArray(drSizes["GMSizes"].ToString(), ref GmSizes);

                                                        // Szmappng.SzMappingRec - [MSZSSizes]
                                                        sMSZSSizes = WgmateDBUtilClass.GetSzmappngSzMappingRecRecMSZSSizes(x.StyleCode, x.VarnCode, (short)z.OrgMatPart,
                                                                                                                                    (short)z.OrgMatType, z.OrgMatCode,
                                                                                                                                    (short)z.OrgMatColr, (short)z.OrgMatColr1,
                                                                                                                                    (short)z.OrgMatSupl, (short)z.OrgMatWhse,
                                                                                                                                    (short)z.OrgMatLocn, MatSizeKey, ref SQLWrite);

                                                        if (sMSZSSizes != null && sMSZSSizes.Trim().Length > 0)
                                                        {
                                                            WpfClassLibrary.SQLArrayConvert.StringToStringArray(sMSZSSizes, ref MSZSSizes);

                                                            for (int i = 0; i < 32; i++)
                                                            {   // Find MSZSSizes Index in GmSizes
                                                                int Index = Array.FindIndex(GmSizes, row => row.Trim().Contains(MSZSSizes[i].Trim()));

                                                                if (Index != -1)
                                                                    w.RequiredSizes[Index] += (IssdQtys[i] * (double)z.OrgCosting);
                                                            }

                                                            w.Required = 0.0;
                                                            //-----------------------------------------------------------------
                                                            for (int i = 0; i < 128; i++)
                                                                w.Required += w.RequiredSizes[i];
                                                            //-----------------------------------------------------------------
                                                        }
                                                        else
                                                        {
                                                            for (int i = 0; i < 32; i++)
                                                                w.RequiredSizes[i] += (IssdQtys[i] * (double)z.OrgCosting);

                                                            w.Required = 0.0;
                                                            //-----------------------------------------------------------------
                                                            for (int i = 0; i < 128; i++)
                                                                w.Required += w.RequiredSizes[i];
                                                            //-----------------------------------------------------------------
                                                        } // end if - else
                                                    } // end if
                                                    //=====================================================================
                                                }
                                                return true;
                                            });
                                        #endregion
                                        
                                        if (!bFound)
                                        {
                                            // Create MatRequiremts into listMatRequiremts
                                            MatRequiremt = new MatRequiremts();
                                            listMatRequiremts[0].Add(MatRequiremt);
                                            
                                            #region // Create New MatRequiremts
                                            MatRequiremt.SpareFlag1 = (short)z.OrgSpareFlag1;
                                            MatRequiremt.MatPart = (short)z.OrgMatPart;
                                            MatRequiremt.MatPartDesc = "";
                                            MatRequiremt.MatType = (short)z.OrgMatType;
                                            MatRequiremt.MatTypeDesc = "";
                                            MatRequiremt.MatCode = z.OrgMatCode.Trim();
                                            MatRequiremt.MatColr = (short)z.OrgMatColr;
                                            MatRequiremt.MatColr1 = (short)z.OrgMatColr1;
                                            MatRequiremt.MatColrDesc = "";
                                            MatRequiremt.MatSupl = (short)z.OrgMatSupl;
                                            MatRequiremt.MatWhse = (short)z.OrgMatWhse;
                                            MatRequiremt.MatLocn = (short)z.OrgMatLocn;
                                            MatRequiremt.MatCosting = (double)z.OrgCosting;
                                            MatRequiremt.MatPrice = (double)z.OrgMatPrice;

                                             string sConsumption = WgmateDBUtilClass.GetConsumptMRecConSConsumption(x.StyleCode,
                                                                     x.VarnCode, listRollsdbRollsMRec[0].RMatSizeKey, (short)z.OrgMatPart,
                                                                     (short)z.OrgMatType, z.OrgMatCode, (short)z.OrgMatColr,
                                                                     (short)z.OrgMatColr1, (short)z.OrgMatSupl, (short)z.OrgMatWhse,
                                                                     (short)z.OrgMatLocn, ref SQLWrite);
                                           
                                           if (sConsumption != null && sConsumption.Trim().Length > 0)
                                           {
                                               double Reqd = 0.0;
                                               double[] Consumption = null;
                                               WpfClassLibrary.SQLArrayConvert.StringToDoubleArray(sConsumption, ref Consumption);


                                               for (int i = 0; i < IssdQtys.Count(); i++)
                                                   Reqd += IssdQtys[i] * Consumption[i];

                                               MatRequiremt.Required += Reqd;
                                           }
                                           else
                                           {
                                               if (MatRequiremt.MatType == 1 || MatRequiremt.MatType == 2)
                                               {
                                                   double Reqd = 0.0;

                                                   for (int i = 0; i < IssdQtys.Count(); i++)
                                                       Reqd += IssdQtys[i] * ((double)z.OrgCosting + (((double)listCostdbCostMRec[0].CTGrading / 100.0) * (i - 1)));

                                                   MatRequiremt.Required += Reqd;
                                               }
                                               else
                                                   MatRequiremt.Required += (listColoursInfo[IndexStyle].ColourTotals[IndexColrsQty] * (double)z.OrgCosting);
                                           }
                                            
                                           // [Rollsdb.RollsMRec] - [RMatSizeKey]
                                           MatSizeKey = WgmateDBUtilClass.GetRollsdbRollsMRecRMatSizeKeyEx((short)z.OrgMatType, z.OrgMatCode,
                                                                                                                           (short)z.OrgMatColr, (short)z.OrgMatColr1,
                                                                                                                           (short)z.OrgMatSupl, (short)z.OrgMatWhse,
                                                                                                                           (short)z.OrgMatLocn, ref SQLWrite);
                                            
                                           if (MatSizeKey != null && MatSizeKey.Trim().Length > 0)
                                           {
                                               string[] MSZSSizes = null;
                                               string sMSZSSizes = "";
                                               string[] GmSizes = null;

                                               // Gmsizes
                                               DataRow drSizes = WgmateDBUtilClass.GetGmSizeDataRow(MatSizeKey, ref dtGMSizesRec);
                                               WpfClassLibrary.SQLArrayConvert.StringToStringArray(drSizes["GMSizes"].ToString(), ref GmSizes);

                                               // Szmappng.SzMappingRec - [MSZSSizes]
                                               sMSZSSizes = WgmateDBUtilClass.GetSzmappngSzMappingRecRecMSZSSizes(x.StyleCode, x.VarnCode, (short)z.OrgMatPart,
                                                                                                                           (short)z.OrgMatType, z.OrgMatCode,
                                                                                                                           (short)z.OrgMatColr, (short)z.OrgMatColr1,
                                                                                                                           (short)z.OrgMatSupl, (short)z.OrgMatWhse,
                                                                                                                           (short)z.OrgMatLocn, MatSizeKey, ref SQLWrite);
                                               
                                               if (sMSZSSizes != null && sMSZSSizes.Trim().Length > 0)
                                               {
                                                   WpfClassLibrary.SQLArrayConvert.StringToStringArray(sMSZSSizes, ref MSZSSizes);

                                                   for (int i = 0; i < 32; i++)
                                                   {   // Find MSZSSizes Index in GmSizes
                                                       int Index = Array.FindIndex(GmSizes, row => row.Trim().Contains(MSZSSizes[i].Trim()));

                                                       if (Index != -1)
                                                           MatRequiremt.RequiredSizes[Index] += (IssdQtys[i] * (double)z.OrgCosting);
                                                   }

                                                   MatRequiremt.Required = 0.0;
                                                   //-----------------------------------------------------------------
                                                   for (int i = 0; i < 128; i++)
                                                       MatRequiremt.Required += MatRequiremt.RequiredSizes[i];
                                                   //-----------------------------------------------------------------
                                               }
                                               else
                                               {
                                                   for (int i = 0; i < 32; i++)
                                                       MatRequiremt.RequiredSizes[i] = (IssdQtys[i] * (double)z.OrgCosting);

                                                   MatRequiremt.Required = 0.0;
                                                   //-----------------------------------------------------------------
                                                   for (int i = 0; i < 128; i++)
                                                       MatRequiremt.Required += MatRequiremt.RequiredSizes[i];
                                                   //-----------------------------------------------------------------
                                               } // end if - else
                                           } // end if
                                             //=====================================================================
                                            #endregion
                                        }
                                        MatReqIndex += 1;
                                    }

                                    return true;
                                });
                                #endregion
                                
                                return true;
                            });
                    #endregion

                    return true;
                    });
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }

            // Apply OrderUnit
            var sOrdunit = (from MatRequiremts in listMatRequiremts[0]
                          select MatRequiremts).Count(x =>
                         {
                             double Ordunit = GetRollsdbRollsMRecOrderUnit(x.MatType, x.MatCode.Trim(), x.MatColr, x.MatColr1, x.MatSupl, x.MatWhse, x.MatLocn, ref SQLWrite);

                             if (Ordunit > 0.001)
                                 x.Required = x.Required / Ordunit;

                             return true;
                         });


            // Sort by Material Type
            listMatRequiremts[0] = (from MatRequiremts in listMatRequiremts[0]
                                      orderby MatRequiremts.MatType
                                      select MatRequiremts).ToList();
        }
        public static void ReadOrigCosting(List<DocketStyles> listdocketStyles, List<List<DocketColrsQtys>> listdocketColrsQtys, ref List<List<DocketOrgCostings>> listdocketOrgCostings,
                                                        ref List<CostdbCostMRec> listCostdbCostMRec, ref List<CostdbCTMatsRec> listCostdbCTMatsRec, DocketColrsQtys ColrsQtys, short CustomerNo,  
                                                                                                                                                        short DelivIndex, SQLWriteClass SQLWrite)
        {
            SqlParameter[] SqlParam = null;
            DocketOrgCostings DocketOrgCosting = null;
            List<CostdbCostMRec> listCostdbCostMRec_l = null;
            List<CostdbCTMatsRec> listCostdbCTMatsRec_l = null;
            List<CusprefsCusPrefsSiblRec> listCusprefsCusPrefsSiblRec = null;
            List<DocketOrgCostings> listDocketOrgCosting = listdocketOrgCostings[DelivIndex];

            #region // ReadOrigCosting
            SQLWrite.SQLWriteCommand("[dbo].[GetCostdbStyleVarn]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParam = new SqlParameter[2];

            SqlParam[0] = DependancyService.SQLParameter("@CTStyle",
                        "System.String", DependancyService.ParamDirection.Input, (object)listdocketStyles[DelivIndex].StyleCode.Trim());

            SqlParam[1] = DependancyService.SQLParameter("@CTVarn",
                        "System.String", DependancyService.ParamDirection.Input, (object)listdocketStyles[DelivIndex].VarnCode.Trim());

            DataTable dtCostsdbCostMRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtCostsdbCostMRec.Rows.Count > 0)
            {
                listCostdbCostMRec_l = WpfClassLibrary.Extensions.ToList<CostdbCostMRec>(dtCostsdbCostMRec);

                SQLWrite.SQLWriteCommand("[dbo].[GetCostdbCTMatsRec]", SQLWriteClass.SqlCmdType.PROCEDURE);
                SqlParam = new SqlParameter[1];

                SqlParam[0] = DependancyService.SQLParameter("@CostdbID",
                            "System.Int32", DependancyService.ParamDirection.Input, (object)listCostdbCostMRec_l[0].CostdbID);

                DataTable dtCostdbCTMatsRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

                if (dtCostdbCTMatsRec.Rows.Count > 0)
                {
                    listCostdbCTMatsRec_l = WpfClassLibrary.Extensions.ToList<CostdbCTMatsRec>(dtCostdbCTMatsRec);
                    DataTable dtCusprefsCusPrefsSiblRec = null;
                    bool bFound = false;

                    #region // Cusprefs.CusPrefsMRec
                    var sQueryCTMatsRec = (from CostdbCTMatsRec in listCostdbCTMatsRec_l
                        select CostdbCTMatsRec).Count(v =>
                        {
                            #region // [dbo].[GetCusprefsCusPrefsMRec]
                            SQLWrite.SQLWriteCommand("[dbo].[GetCusprefsCusPrefsMRec]", SQLWriteClass.SqlCmdType.PROCEDURE);
                            SqlParam = new SqlParameter[10];

                            SqlParam[0] = DependancyService.SQLParameter("@CTStyle",
                                        "System.String", DependancyService.ParamDirection.Input, (object)listdocketStyles[DelivIndex].StyleCode.Trim());

                            SqlParam[1] = DependancyService.SQLParameter("@Varn",
                                        "System.String", DependancyService.ParamDirection.Input, (object)listdocketStyles[DelivIndex].VarnCode.Trim());

                            SqlParam[2] = DependancyService.SQLParameter("@Part",
                                        "System.Int16", DependancyService.ParamDirection.Input, (object)(short)v.CTMatPart);

                            SqlParam[3] = DependancyService.SQLParameter("@Type",
                                        "System.Int16", DependancyService.ParamDirection.Input, (object)(short)v.CTMatType);

                            SqlParam[4] = DependancyService.SQLParameter("@Code",
                                        "System.String", DependancyService.ParamDirection.Input, (object)v.CTMatCode.Trim());

                            SqlParam[5] = DependancyService.SQLParameter("@Colr",
                                        "System.Int16", DependancyService.ParamDirection.Input, (object)(short)v.CTMatColr);

                            SqlParam[6] = DependancyService.SQLParameter("@Colr1",
                                        "System.Int16", DependancyService.ParamDirection.Input, (object)(short)v.CTMatColr1);

                            SqlParam[7] = DependancyService.SQLParameter("@Supl",
                                        "System.Int16", DependancyService.ParamDirection.Input, (object)(short)v.CTMatSupl);

                            SqlParam[8] = DependancyService.SQLParameter("@Whse",
                                        "System.Int16", DependancyService.ParamDirection.Input, (object)(short)v.CTMatWhse);

                            SqlParam[9] = DependancyService.SQLParameter("@Locn",
                                        "System.Int16", DependancyService.ParamDirection.Input, (object)(short)v.CTMatLocn);
                            #endregion

                            DataTable dtCusprefsCusPrefsMRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

                            #region // Verify Cusprefs.CusPrefsSiblRec
                            if (dtCusprefsCusPrefsMRec.Rows.Count > 0)
                            {
                                SQLWrite.SQLWriteCommand("[dbo].[GetCusprefsCusPrefsSiblRec]", SQLWriteClass.SqlCmdType.PROCEDURE);
                                SqlParam = new SqlParameter[1];

                                SqlParam[0] = DependancyService.SQLParameter("@CusPrefsMRecID",
                                            "System.String", DependancyService.ParamDirection.Input, (object)dtCusprefsCusPrefsMRec.Rows[0]["ID"].ToString());

                                dtCusprefsCusPrefsSiblRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

                                if (dtCusprefsCusPrefsSiblRec.Rows.Count > 0)
                                {
                                    listCusprefsCusPrefsSiblRec = WpfClassLibrary.Extensions.ToList<CusprefsCusPrefsSiblRec>(dtCusprefsCusPrefsSiblRec);

                                    var sQueryCusPrefsSiblRec = (from CusprefsCusPrefsSiblRec in listCusprefsCusPrefsSiblRec
                                        select CusprefsCusPrefsSiblRec).Count(w =>
                                        {  // Note - Could  not find a value for right of CSPRFSELCustNumber
                                            if (w.CSPRFSELCustNumber == CustomerNo && w.CSPRFSELCustDelAddrs == listdocketStyles[DelivIndex].DeliveryPoint)
                                                bFound = true;

                                            return true;
                                        });
                                }
                            }
                            else
                            {
                                #region // [dbo].[GetCusprefsCusPrefsMRec]
                                SQLWrite.SQLWriteCommand("[dbo].[GetCusprefsCusPrefsMRec]", SQLWriteClass.SqlCmdType.PROCEDURE);
                                SqlParam = new SqlParameter[8];

                                SqlParam[0] = DependancyService.SQLParameter("@Part",
                                            "System.Int16", DependancyService.ParamDirection.Input, (object)(short)v.CTMatPart);

                                SqlParam[1] = DependancyService.SQLParameter("@Type",
                                            "System.Int16", DependancyService.ParamDirection.Input, (object)(short)v.CTMatType);

                                SqlParam[2] = DependancyService.SQLParameter("@Code",
                                            "System.String", DependancyService.ParamDirection.Input, (object)v.CTMatCode.Trim());

                                SqlParam[3] = DependancyService.SQLParameter("@Colr",
                                            "System.Int16", DependancyService.ParamDirection.Input, (object)(short)v.CTMatColr);

                                SqlParam[4] = DependancyService.SQLParameter("@Colr1",
                                            "System.Int16", DependancyService.ParamDirection.Input, (object)(short)v.CTMatColr1);

                                SqlParam[5] = DependancyService.SQLParameter("@Supl",
                                            "System.Int16", DependancyService.ParamDirection.Input, (object)(short)v.CTMatSupl);

                                SqlParam[6] = DependancyService.SQLParameter("@Whse",
                                            "System.Int16", DependancyService.ParamDirection.Input, (object)(short)v.CTMatWhse);

                                SqlParam[7] = DependancyService.SQLParameter("@Locn",
                                            "System.Int16", DependancyService.ParamDirection.Input, (object)(short)v.CTMatLocn);
                                #endregion

                                dtCusprefsCusPrefsMRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

                                if (dtCusprefsCusPrefsMRec.Rows.Count > 0)
                                {
                                    SQLWrite.SQLWriteCommand("[dbo].[GetCusprefsCusPrefsSiblRec]", SQLWriteClass.SqlCmdType.PROCEDURE);
                                    SqlParam = new SqlParameter[1];

                                    SqlParam[0] = DependancyService.SQLParameter("@CusPrefsMRecID",
                                                "System.String", DependancyService.ParamDirection.Input, (object)dtCusprefsCusPrefsMRec.Rows[0]["ID"].ToString());

                                    dtCusprefsCusPrefsSiblRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

                                    if (dtCusprefsCusPrefsSiblRec.Rows.Count > 0)
                                    { 
                                        var sQueryCusPrefsSiblRec = (from CusprefsCusPrefsSiblRec in listCusprefsCusPrefsSiblRec
                                        select CusprefsCusPrefsSiblRec).Count(w =>
                                        {  // Note - Could  not find a value for right of CSPRFSELCustNumber
                                            if (w.CSPRFSELCustNumber == CustomerNo && w.CSPRFSELCustDelAddrs == listdocketStyles[DelivIndex].DeliveryPoint)
                                                bFound = true;

                                            return true;
                                        });
                                    }
                                }
                            }
                            #endregion

                            if (bFound)
                            {
                                #region // Cusprefs.CusPrefsSiblRec
                                var sQueryCusPrefsSiblRec = (from CusprefsCusPrefsSiblRec in listCusprefsCusPrefsSiblRec
                                    select CusprefsCusPrefsSiblRec).Count(w =>
                                    {
                                        if (w.CSPRFSELCosting > 0.0001)
                                        {
                                            DocketOrgCosting = new DocketOrgCostings();
                                            listDocketOrgCosting.Add(DocketOrgCosting);
                                            DocketOrgCosting.ColrID = ColrsQtys.ID;

                                            DocketOrgCosting.OrgSpareFlag1 = v.CTSpareFlag1;
                                            DocketOrgCosting.OrgSpareFlag2 = v.CTSpareFlag2;
                                            DocketOrgCosting.OrgSpareFlag3 = v.CTSpareFlag3;

                                            DocketOrgCosting.OrgMatPart = w.CSPRFSELMatPart;
                                            DocketOrgCosting.OrgMatType = w.CSPRFSELMatType;

                                            DocketOrgCosting.OrgMatCode = w.CSPRFSELMatCode;

                                            DocketOrgCosting.OrgMatColr = w.CSPRFSELMatColr;
                                            DocketOrgCosting.OrgMatColr1 = 0;
                                            DocketOrgCosting.OrgMatSupl = w.CSPRFSELMatSupl;

                                            if (v.CTMatWhse > 0)
                                                DocketOrgCosting.OrgMatWhse = w.CSPRFSELMatWhse;
                                            else
                                                DocketOrgCosting.OrgMatWhse = 1;

                                            if (v.CTMatLocn > 0)
                                                DocketOrgCosting.OrgMatLocn = w.CSPRFSELMatLocn;
                                            else
                                                DocketOrgCosting.OrgMatLocn = 1;

                                            DocketOrgCosting.OrgCosting = w.CSPRFSELCosting;
                                            DocketOrgCosting.OrgMatPrice = w.CSPRFSELPrice;
                                        }

                                        return true;
                                    });
                                #endregion
                            }
                            else
                            {
                                DocketOrgCosting = new DocketOrgCostings();
                                listDocketOrgCosting.Add(DocketOrgCosting);
                                DocketOrgCosting.ColrID = ColrsQtys.ID;

                                DocketOrgCosting.OrgSpareFlag1 = v.CTSpareFlag1;
                                DocketOrgCosting.OrgSpareFlag2 = v.CTSpareFlag2;
                                DocketOrgCosting.OrgSpareFlag3 = v.CTSpareFlag3;
                                DocketOrgCosting.OrgMatPart = v.CTMatPart;
                                DocketOrgCosting.OrgMatType = v.CTMatType;

                                DocketOrgCosting.OrgMatCode = v.CTMatCode;

                                DocketOrgCosting.OrgMatColr = v.CTMatColr;
                                DocketOrgCosting.OrgMatColr1 = v.CTMatColr1;
                                DocketOrgCosting.OrgMatSupl = v.CTMatSupl;

                                if (v.CTMatWhse > 0)
                                    DocketOrgCosting.OrgMatWhse = v.CTMatWhse;
                                else
                                    DocketOrgCosting.OrgMatWhse = 1;

                                if (v.CTMatLocn > 0)
                                    DocketOrgCosting.OrgMatLocn = v.CTMatLocn;
                                else
                                    DocketOrgCosting.OrgMatLocn = 1;

                                DocketOrgCosting.OrgCosting = v.CTCosting;
                                DocketOrgCosting.OrgMatPrice = v.CTMatPrice;

                                //===================================================================================

                                #region // Colrcomb.ColrCombSibl
                                SQLWrite.SQLWriteCommand("[dbo].[GetColrcombColrCombMain]", SQLWriteClass.SqlCmdType.PROCEDURE);
                                SqlParam = new SqlParameter[5];

                                SqlParam[0] = DependancyService.SQLParameter("@Style",
                                            "System.String", DependancyService.ParamDirection.Input, (object)listCostdbCostMRec_l[0].CTStyle);

                                SqlParam[1] = DependancyService.SQLParameter("@Varn",
                                            "System.String", DependancyService.ParamDirection.Input, (object)listCostdbCostMRec_l[0].CTVarn);

                                SqlParam[2] = DependancyService.SQLParameter("@MatPart",
                                            "System.Int16", DependancyService.ParamDirection.Input, (object)DocketOrgCosting.OrgMatPart);

                                SqlParam[3] = DependancyService.SQLParameter("@MatType",
                                            "System.Int16", DependancyService.ParamDirection.Input, (object)DocketOrgCosting.OrgMatType);

                                SqlParam[4] = DependancyService.SQLParameter("@ColrNo",
                                            "System.Int16", DependancyService.ParamDirection.Input, (object)ColrsQtys.ColourNo);

                                DataTable dtColrcombColrCombMain = SQLWrite.ExecuteDataTableQuery(SqlParam);
                                DataTable dtColrcombColrCombSibl = null;

                                if (dtColrcombColrCombMain.Rows.Count > 0)
                                {
                                    SQLWrite.SQLWriteCommand("[dbo].[GetColrcombColrCombSibl]", SQLWriteClass.SqlCmdType.PROCEDURE);
                                    SqlParam = new SqlParameter[1];

                                    SqlParam[0] = DependancyService.SQLParameter("@CombMainID",
                                                "System.Int32", DependancyService.ParamDirection.Input, (object)dtColrcombColrCombMain.Rows[0]["ID"]);

                                    dtColrcombColrCombSibl = SQLWrite.ExecuteDataTableQuery(SqlParam);
                                }

                                if (listCostdbCTMatsRec_l.IndexOf(v) == 0) // listdocketColrsQtys[DelivIndex].IndexOf(ColrsQtys) == 0
                                {
                                    if (dtColrcombColrCombSibl != null && dtColrcombColrCombSibl.Rows.Count > 0)
                                    {
                                        DocketOrgCosting.OrgMatColr = (short)dtColrcombColrCombSibl.Rows[0]["CLCMMatColr"];
                                        DocketOrgCosting.OrgMatSupl = (short)dtColrcombColrCombSibl.Rows[0]["CLCMMatSupl"];
                                        DocketOrgCosting.OrgMatCode = dtColrcombColrCombSibl.Rows[0]["CLCMMatCode"].ToString();
                                    }
                                    else
                                        DocketOrgCosting.OrgMatColr = ColrsQtys.ColourNo;
                                }
                                else
                                {
                                    if (v.CTSpareFlag1 == 1)	//DTM
                                        DocketOrgCosting.OrgMatColr = ColrsQtys.ColourNo;
                                    else
                                    {
                                        if (dtColrcombColrCombSibl != null && (short)dtColrcombColrCombSibl.Rows[0]["CLCMMatColr"] > 0)
                                        {
                                            DocketOrgCosting.OrgMatColr = (short)dtColrcombColrCombSibl.Rows[0]["CLCMMatColr"];
                                            DocketOrgCosting.OrgMatCode = dtColrcombColrCombSibl.Rows[0]["CLCMMatCode"].ToString();
                                            DocketOrgCosting.OrgMatSupl = (short)dtColrcombColrCombSibl.Rows[0]["CLCMMatSupl"];
                                        }
                                        else
                                            DocketOrgCosting.OrgMatColr = v.CTMatColr;
                                    }
                                }
                                #endregion
                            }

                            return true;
                        });
                    #endregion
                }
            }
            #endregion

            listCostdbCostMRec = listCostdbCostMRec_l;
            listCostdbCTMatsRec = listCostdbCTMatsRec_l;
        }
        public static void GetMatSuppliedQuantity(List<DocketMainData> listdocketMainData, List<MatRequiremts> ListMatRequiremts, DataTable dtParametersRec, SQLWriteClass SQLWrite)
        {
            SQLWrite.SQLWriteCommand("[dbo].[GetMatsupldMATSUPLDMainRec]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[1];

            SqlParam[0] = DependancyService.SQLParameter("@MATSUPLDDocketNumber",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)listdocketMainData[0].DocketNoIssued);

            DataTable dtMatsupldMATSUPLDMainRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtMatsupldMATSUPLDMainRec.Rows.Count > 0)
            {
                SQLWrite.SQLWriteCommand("[dbo].[GetMatsupldMATSUPLDSiblRec]", SQLWriteClass.SqlCmdType.PROCEDURE);
                SqlParam = new SqlParameter[1];

                SqlParam[0] = DependancyService.SQLParameter("@MATSUPLDMainRecID",
                        "System.Int32", DependancyService.ParamDirection.Input, (object)dtMatsupldMATSUPLDMainRec.Rows[0]["ID"]);

                DataTable dtMatsupldMATSUPLDSiblRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

                if (dtMatsupldMATSUPLDSiblRec.Rows.Count > 0)
                {
                    List<MatsupldMATSUPLDSiblRec> listMatsupldMATSUPLDSiblRec = WpfClassLibrary.Extensions.ToList<MatsupldMATSUPLDSiblRec>(dtMatsupldMATSUPLDSiblRec);

                    var sQuery = (from MatRequiremts in ListMatRequiremts
                        select MatRequiremts).Count(x =>
                        {
                            var sQueryMatsupld = (from Matsupld in listMatsupldMATSUPLDSiblRec
                                where Matsupld.MATSUPLDMatType == x.MatType &&
                                Matsupld.MATSUPLDMatCode.Trim() == x.MatCode.Trim() &&
                                Matsupld.MATSUPLDMatColr == x.MatColr &&
                                Matsupld.MATSUPLDMatColr1 == x.MatColr1 &&
                                Matsupld.MATSUPLDMatSupl == x.MatSupl &&
                                Matsupld.MATSUPLDMatWhse == x.MatWhse &&
                                Matsupld.MATSUPLDMatLocn == x.MatLocn
                                select Matsupld).Count(y =>
                                {
                                    x.Supplied += (double)y.MATSUPLDMatSupplied;

                                    //----------------------------------------------------------------						
                                    for (int i = 0; i < 128; i++)
                                    {
                                        x.SuppliedSizes[i] += y.MATSUPLDSuppliedSizes[i];
                                    }
                                    //----------------------------------------------------------------

                                    return true;
                                });
                            return true;
                        });
                }
            }
        }
        public static void GetMatStockQuantity(List<DocketMainData> listdocketMainData, List<MatRequiremts> ListMatRequiremts, DataTable dtParametersRec, SQLWriteClass SQLWrite)
        {
            SqlParameter[] SqlParam = null;

            var sQuery = (from MatRequiremts in ListMatRequiremts
                          select MatRequiremts).Count(x =>
                          {
                              if (x.SpareFlag1 == 0)
                                  x.SpareFlag1 = null;

                              if (x.MatPart > 0)
                                  x.MatPartDesc = WgmateDBUtilClass.GetGmParamsDescr(4, (short)x.MatPart, ref dtParametersRec);
                              else x.MatPartDesc = "";

                              x.MatTypeDesc = WgmateDBUtilClass.GetGmParamsDescr(1, x.MatType, ref dtParametersRec);
                              x.MatColrDesc = WgmateDBUtilClass.GetGmParamsDescr(2, x.MatColr, ref dtParametersRec);
                              x.MatSuplDesc = WgmateDBUtilClass.GetClientName(2, x.MatSupl, ref SQLWrite);

                              #region // Matalcn.MAMainRec
                              SQLWrite.SQLWriteCommand("[dbo].[GetMatalcnMAMainRec]", SQLWriteClass.SqlCmdType.PROCEDURE);
                              SqlParam = new SqlParameter[7];

                              SqlParam[0] = DependancyService.SQLParameter("@MAFileNo",
                                          "System.Int32", DependancyService.ParamDirection.Input, (object)listdocketMainData[0].CustOrderNoIssued);

                              SqlParam[1] = DependancyService.SQLParameter("@MAMatType",
                                          "System.Int16", DependancyService.ParamDirection.Input, (object)x.MatType);

                              SqlParam[2] = DependancyService.SQLParameter("@MAMatCode",
                                          "System.String", DependancyService.ParamDirection.Input, (object)x.MatCode);

                              SqlParam[3] = DependancyService.SQLParameter("@MAMatSupl",
                                          "System.Int16", DependancyService.ParamDirection.Input, (object)x.MatSupl);

                              SqlParam[4] = DependancyService.SQLParameter("MAMatColr",
                                          "System.Int16", DependancyService.ParamDirection.Input, (object)x.MatColr);

                              SqlParam[5] = DependancyService.SQLParameter("@MAMatWhse",
                                          "System.Int16", DependancyService.ParamDirection.Input, (object)x.MatWhse);

                              SqlParam[6] = DependancyService.SQLParameter("@MAMatLocn",
                                          "System.Int16", DependancyService.ParamDirection.Input, (object)x.MatLocn);

                              DataTable dtMatalcnMAMainRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

                              if (dtMatalcnMAMainRec.Rows.Count > 0)
                              {
                                  double[] MAMatAllocSizes = null;
                                  x.DockMatAllocated = (double)dtMatalcnMAMainRec.Rows[0]["MAMatAllocated"];
                                  WpfClassLibrary.SQLArrayConvert.StringToDoubleArray(dtMatalcnMAMainRec.Rows[0]["MAMatAllocSizes"].ToString(), ref MAMatAllocSizes);

                                  if (dtMatalcnMAMainRec.Rows[0]["MAMatSizeKey"].ToString().Trim().Length > 0)
                                  {
                                      x.MatSizeKey = 1;

                                      for (int i = 0; i < 128; i++)
                                          x.DockMatAllocatedSizes[i] = MAMatAllocSizes[i];
                                  } 
                                  else
                                      x.MatSizeKey = 0;
                              }
                              #endregion

                              #region // Rollsdb.RollsMRec - DocketRequiremts

                              SQLWrite.SQLWriteCommand("[dbo].[GetRollsdbRollsMRecDocketRequiremts]", SQLWriteClass.SqlCmdType.PROCEDURE);
                              SqlParam = new SqlParameter[7];

                              SqlParam[0] = DependancyService.SQLParameter("@RMatType",
                                          "System.Int16", DependancyService.ParamDirection.Input, (object)x.MatType);

                              SqlParam[1] = DependancyService.SQLParameter("@RMatCode",
                                          "System.String", DependancyService.ParamDirection.Input, (object)x.MatCode);

                              SqlParam[2] = DependancyService.SQLParameter("@RMatColr",
                                          "System.Int16", DependancyService.ParamDirection.Input, (object)x.MatColr);

                              SqlParam[3] = DependancyService.SQLParameter("@RMatColr1",
                                          "System.Int16", DependancyService.ParamDirection.Input, (object)x.MatColr1);

                              SqlParam[4] = DependancyService.SQLParameter("@RMatSupl",
                                          "System.Int16", DependancyService.ParamDirection.Input, (object)x.MatSupl);

                              SqlParam[5] = DependancyService.SQLParameter("@RMatWhse",
                                          "System.Int16", DependancyService.ParamDirection.Input, (object)x.MatWhse);

                              SqlParam[6] = DependancyService.SQLParameter("@RMatLocn",
                                          "System.Int16", DependancyService.ParamDirection.Input, (object)x.MatLocn);

                              DataTable dtDocketRequiremts = SQLWrite.ExecuteDataTableQuery(SqlParam);

                              if (dtDocketRequiremts.Rows.Count > 0)
                              {
                                  x.IFileMultiWhseLocn = (short)dtDocketRequiremts.Rows[0]["WhseLocnGThanTwo"];

                                  if ((double)dtDocketRequiremts.Rows[0]["RMatStockInTots"] > 0.001)
                                  {
                                      x.Stock = (double)dtDocketRequiremts.Rows[0]["RMatStockInTots"];
                                      x.IOtherStock = 1;
                                  }
                                  else
                                  {
                                      x.Stock = 0.0;
                                      x.IOtherStock = 0;
                                  }

                                  SQLWrite.SQLWriteCommand("[dbo].[GetRollsdbRMatSizes]", SQLWriteClass.SqlCmdType.PROCEDURE);
                                  SqlParam = new SqlParameter[1];

                                  SqlParam[0] = DependancyService.SQLParameter("@RollsID",
                                              "System.Int32", DependancyService.ParamDirection.Input, (object)dtDocketRequiremts.Rows[0]["RMatStockInTots"]);

                                  DataTable dtRollsdbRMatSizes = SQLWrite.ExecuteDataTableQuery(SqlParam);

                                  if (dtRollsdbRMatSizes.Rows.Count > 0)
                                  {
                                      double[] RMatSizesAmnt = null;
                                      WpfClassLibrary.SQLArrayConvert.StringToDoubleArray(dtRollsdbRMatSizes.Rows[0]["RMatSizesAmnt"].ToString(), ref RMatSizesAmnt);

                                      for (int i = 0; i < 128; i++)
                                      {
                                          if (x.RequiredSizes[i] > 0.0)
                                          {
                                              if (RMatSizesAmnt[i] > 0.0)
                                                  x.StockSizes[i] = RMatSizesAmnt[i];
                                              else
                                                  x.StockSizes[i] = 0.0;
                                          }
                                          else
                                              x.StockSizes[i] = 0.0;

                                          x.Stock += x.StockSizes[i];
                                      }// end for
                                  }

                                  if ((double)x.Stock < 0.009 || (double)x.Stock < -0.009)
                                      x.Stock = null;
                              }
                              #endregion

                              return true;
                          });

            ListMatRequiremts = (from MatRequiremts in ListMatRequiremts
                                 orderby MatRequiremts.MatType
                                 select MatRequiremts).ToList();
        }
        public static void ReadOrigCostingForAllColours(ref List<CostdbCostMRec> listCostdbCostMRec, List<DocketStyles> listdocketStyles, 
                                                            List<List<DocketColrsQtys>> listdocketColrsQtys, List<List<DocketOrgCostings>> listdocketOrgCostings, 
                                                                List<CostdbCTMatsRec> listCostdbCTMatsRec, SQLWriteClass SQLWrite, short CustomerNo,  short DelivIndex)
        {
            // SqlParameter[] SqlParam = null;
            List<CostdbCostMRec> listCostdbCostMRec_l = null;

            try
            {   // ReadOrigCostingForAllColours
                var sQuery = (from DocketColrsQtys in listdocketColrsQtys[DelivIndex]
                              select DocketColrsQtys).Count(x =>
                              {
                                  // Get First Org of Colour
                                  List<DocketOrgCostings> listOrgCostings = (from DocketOrgCostings in listdocketOrgCostings[DelivIndex]
                                                                             where DocketOrgCostings.ColrID == x.ID
                                                                            select DocketOrgCostings).ToList();

                                  if (listOrgCostings.Count == 0 || listOrgCostings[0].OrgMatType  == 0)
                                  {
                                      WpfClassLibrary.WgmateDBUtilClass.ReadOrigCosting(listdocketStyles, listdocketColrsQtys, ref listdocketOrgCostings,
                                                                                          ref listCostdbCostMRec_l, ref listCostdbCTMatsRec, x, CustomerNo, DelivIndex, SQLWrite);

                                      int IndexColor = listdocketColrsQtys[DelivIndex].IndexOf(x);
                                      double RMatCost = WpfClassLibrary.WgmateDBUtilClass.GetRollsdbRollsMRecRMatCost((short)listdocketOrgCostings[DelivIndex][IndexColor].OrgMatType, // [0].OrgMatType
                                                                                                      listdocketOrgCostings[DelivIndex][IndexColor].OrgMatCode.Trim(),
                                                                                                      (short)listdocketOrgCostings[DelivIndex][IndexColor].OrgMatColr,
                                                                                                      (short)listdocketOrgCostings[DelivIndex][IndexColor].OrgMatColr1,
                                                                                                      (short)listdocketOrgCostings[DelivIndex][IndexColor].OrgMatSupl,
                                                                                                      (short)listdocketOrgCostings[DelivIndex][IndexColor].OrgMatWhse,
                                                                                                      (short)listdocketOrgCostings[DelivIndex][IndexColor].OrgMatLocn,
                                                                                                      ref SQLWrite);
                                      if (RMatCost > 0.001)
                                          listdocketOrgCostings[DelivIndex][IndexColor].OrgMatPrice = RMatCost; // [0].OrgMatPrice
                                  }

                                  return true;
                              });

                listdocketOrgCostings[DelivIndex] = (from DocketOrgCostings in listdocketOrgCostings[DelivIndex]
                                                     orderby DocketOrgCostings.ColrID
                                                     select DocketOrgCostings).ToList();

                listCostdbCostMRec = listCostdbCostMRec_l;
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }
        }
        public static void GetMatSuppliedQuantity(List<DocketMatIssued> listdocketMatIssued, List<MatRequiremts> listMatRequiremts)
        {
            List<MatRequiremts> listMatRequiremts_l = listMatRequiremts;

            var sQuery = (from DocketMatIssued in listdocketMatIssued
                          select DocketMatIssued).Count(x =>
                          {
                              var sQueryMat = (from MatRequiremts in listMatRequiremts_l
                                               where x.MatPart == MatRequiremts.MatPart &&
                                               x.MatType == MatRequiremts.MatType &&
                                               x.MatCode == MatRequiremts.MatCode &&
                                               x.MatColr == MatRequiremts.MatColr &&
                                               x.MatColr1 == MatRequiremts.MatColr1 &&
                                               x.MatSupl == MatRequiremts.MatSupl &&
                                               x.MatWhse == MatRequiremts.MatWhse &&
                                               x.MatLocn == MatRequiremts.MatLocn
                                               select MatRequiremts).Count(y =>
                                               {
                                                   if (x.Supplied.HasValue && x.Supplied > 0)
                                                       y.Supplied = x.Supplied;
                                                   else
                                                       y.Supplied = 0.0;

                                                   double[] SuppliedSizes = null;
                                                   WpfClassLibrary.SQLArrayConvert.StringToDoubleArray(x.SuppliedSizes, ref SuppliedSizes);

                                                   //----------------------------------------------------------------						
                                                   for (int i = 0; i < 128; i++)
                                                   {
                                                       y.SuppliedSizes[i] = x.SuppliedSizes[i];
                                                   }
                                                   //----------------------------------------------------------------		

                                                   return true;
                                               });

                              return true;
                          });

            listMatRequiremts = listMatRequiremts_l;
        }
        public static void EvaluateToIssue(List<MatRequiremts> listMatRequiremts)
        {
            var sQuery = (from MatRequiremts in listMatRequiremts
                select MatRequiremts).Count(x =>
                {
                    if (!x.Supplied.HasValue) x.Supplied = 0.0;

                    if (x.Stock >= (x.Required - x.Supplied))
                        x.Issue = x.Required - (double)x.Supplied;
                    else
                    {
                        if (x.Stock > 0.0)
                            x.Issue = (double)x.Stock;
                    }// if - else

                    for (int i = 0; i < 128; i++)
                    {
                        if (x.StockSizes[i] >= (x.RequiredSizes[i] - x.SuppliedSizes[i]))
                            x.IssueSizes[i] = (x.RequiredSizes[i] - x.SuppliedSizes[i]);
                        else
                        {
                            if (x.StockSizes[i] > 0.0)
                                x.IssueSizes[i] = x.StockSizes[i];
                        }// if - else

                        x.Issue += x.IssueSizes[i];
                    }// end for

                    //=======================================================================================
                    if (x.Issue.HasValue && x.Stock.HasValue)
                        if (Math.Round((double)x.Issue + 0.1) <= x.Stock)
                            x.Issue = Math.Round((double)x.Issue + 0.1);
                    //=======================================================================================

                    if (!x.Issue.HasValue || x.Issue < 0.001)
                        x.Issue = 0.0;

                    if (x.Required > 0.001)
                        x.Outstanding = x.Required - (double)x.Supplied + x.Issue;

                    if (!x.DockMatAllocated.HasValue || x.DockMatAllocated == 0 || x.DockMatAllocated < 0.001)
                        x.DockMatAllocated = null;

                    if (!x.Supplied.HasValue || x.Supplied == 0 || x.Supplied < 0.001)
                        x.Supplied = null;

                    if (!x.Issue.HasValue || x.Issue == 0 || x.Issue < 0.001)
                        x.Issue = null;

                    if (!x.Outstanding.HasValue || ((double)x.Outstanding < 0.009 && Math.Sign((double)x.Outstanding) == 1 || Math.Sign((double)x.Outstanding) == 0) || ((double)x.Outstanding > -0.009 && Math.Sign((double)x.Outstanding) == -1))
                        x.Outstanding = null;

                    return true;
                });
        }
        public static bool IfAnyIssued(List<MatRequiremts> listMatRequiremts)
        {
            bool bIssued = false;

            var sQuery = (from MatRequiremts in listMatRequiremts
                          select MatRequiremts).Count(x =>
                          {
                              if (x.Issue > 0.2 || x.Issue < -0.2)
                                  bIssued = true;

                              return true;
                          });

            return bIssued;
        }
        #endregion

        #region // Wadmdir
        public static short GetWadmdirWDIRFactoringRecWDIRQualityOfWork(int ClientType, int ClientNo, ref SQLWriteClass SQLWrite)
        {
            SQLWrite.SQLWriteCommand("[dbo].[GetWadmdirWDIRFactoringRecWDIRQualityOfWork]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[2];

            SqlParam[0] = DependancyService.SQLParameter("@WDIRDAClientType",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)ClientType);

            SqlParam[1] = DependancyService.SQLParameter("@WDIRDAClientNo",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)ClientNo);

            short WDIRQualityOfWorkc = (short) SQLWrite.ExecuteQueryFunction(SqlParam);

            return WDIRQualityOfWorkc;
        }
        public static double GetWadmdirWDIRFactoryInfoWDIRMaxStDaysPerWk(short ClientType, short ClientNo, ref SQLWriteClass SQLWrite)
        {
            SQLWrite.SQLWriteCommand("[dbo].[GetWadmdirWDIRFactoryInfoWDIRMaxStDaysPerWk]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[2];

            SqlParam[0] = DependancyService.SQLParameter("@WDIRClientType",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)ClientType);

            SqlParam[1] = DependancyService.SQLParameter("@WDIRClientNo",
                    "System.Int16", DependancyService.ParamDirection.Input, (object)ClientNo);

            double? WDIRMaxStDaysPerWk = (double)SQLWrite.ExecuteQueryFunction(SqlParam);

            return WDIRMaxStDaysPerWk == null ? 0.0 : (double)WDIRMaxStDaysPerWk;
        }
        public static string GetClientName(int ClientType, int ClientNo, ref SQLWriteClass SQLWrite)
        {
            string sClientName = "";

            SQLWrite.SQLWriteCommand("[dbo].[GetWadmdirWDIRMainRecName]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[2];

            SqlParam[0] = DependancyService.SQLParameter("@WDIRClientType",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)ClientType);

            SqlParam[1] = DependancyService.SQLParameter("@WDIRClientNo",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)ClientNo);

            sClientName = (string)SQLWrite.ExecuteQueryFunction(SqlParam);

            return sClientName;
        }
        public static string GetClientCode(int ClientType, int ClientNo, ref SQLWriteClass SQLWrite)
        {
            string sClientCode = "";

            SQLWrite.SQLWriteCommand("[dbo].[GetWadmdirWDIRMainRecWDIRClientCode]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[2];

            SqlParam[0] = DependancyService.SQLParameter("@WDIRClientType",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)ClientType);

            SqlParam[1] = DependancyService.SQLParameter("@WDIRClientNo",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)ClientNo);

            sClientCode = (string)SQLWrite.ExecuteQueryFunction(SqlParam);

            return sClientCode;
        }
        public static WadmdirWDIRMainRec GetClientRecord(int ClientType, int ClientNo, ref SQLWriteClass SQLWrite)
        {
            SQLWrite.SQLWriteCommand("[dbo].[GetWadmdirWDIRMainRec]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[2];

            SqlParam[0] = DependancyService.SQLParameter("@WDIRClientType",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)ClientType);

            SqlParam[1] = DependancyService.SQLParameter("@WDIRClientNo",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)ClientNo);

            DataTable dtClientName = SQLWrite.ExecuteDataTableQuery(SqlParam);
            List<WadmdirWDIRMainRec> listWadmdirWDIRMainRec = WpfClassLibrary.Extensions.ToList<WadmdirWDIRMainRec>(dtClientName);

            return listWadmdirWDIRMainRec.Count > 0 ? listWadmdirWDIRMainRec[0] : null;
        }

        // Suspended Account
        public static int GetWadmdirWDIRMainRecWDIRPriorityOther4(int ClientType, int ClientNo, ref SQLWriteClass SQLWrite)
        {
            int WDIRPriorityOther4 = 0;

            SQLWrite.SQLWriteCommand("[dbo].[GetWadmdirWDIRMainRecWDIRPriorityOther4]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[2];

            SqlParam[0] = DependancyService.SQLParameter("@WDIRClientType",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)ClientType);

            SqlParam[1] = DependancyService.SQLParameter("@WDIRClientNo",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)ClientNo);

            WDIRPriorityOther4 = (int)SQLWrite.ExecuteQueryFunction(SqlParam);

            return WDIRPriorityOther4;
        }
        public static List<WadmdirWDIRMainRecNotes> GetWadmdirWDIRMainRecNotesByClient(int ClientType, int ClientNo, ref SQLWriteClass SQLWrite)
        {
            SQLWrite.SQLWriteCommand("[dbo].[GetWadmdirWDIRMainRecNotesByClient]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[2];

            SqlParam[0] = DependancyService.SQLParameter("@WDIRClientType",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)ClientType);

            SqlParam[1] = DependancyService.SQLParameter("@WDIRClientNo",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)ClientNo);

            DataTable dtWDIRMainRecNotes = SQLWrite.ExecuteDataTableQuery(SqlParam);
            List<WadmdirWDIRMainRecNotes> listWadmdirWDIRMainRecNotes = WpfClassLibrary.Extensions.ToList<WadmdirWDIRMainRecNotes>(dtWDIRMainRecNotes);

            return listWadmdirWDIRMainRecNotes.Count > 0 ? listWadmdirWDIRMainRecNotes : null;
        }
        public static WadmdirWDIRMainRec GetClientRecordByCode(int ClientType, string ClientCode, ref SQLWriteClass SQLWrite)
        {
            SQLWrite.SQLWriteCommand("[dbo].[GetWadmdirWDIRMainRecByCode]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[2];

            SqlParam[0] = DependancyService.SQLParameter("@WDIRClientType",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)ClientType);

            SqlParam[1] = DependancyService.SQLParameter("@WDIRClientCode",
                    "System.String", DependancyService.ParamDirection.Input, (object)ClientCode);

            DataTable dtClientName = SQLWrite.ExecuteDataTableQuery(SqlParam);
            List<WadmdirWDIRMainRec> listWadmdirWDIRMainRec = WpfClassLibrary.Extensions.ToList<WadmdirWDIRMainRec>(dtClientName);

            return listWadmdirWDIRMainRec.Count > 0 ? listWadmdirWDIRMainRec[0] : null;
        }
        public static WadmdirWDIRDelAddrRec GetWDIRDelAddrRec(int ClientType, int ClientNo, int DelAddrNo, ref SQLWriteClass SQLWrite)
        {
            SQLWrite.SQLWriteCommand("[dbo].[GetWadmdirWDIRDelAddrRec]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[3];

            SqlParam[0] = DependancyService.SQLParameter("@WDIRDAClientType",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)ClientType);

            SqlParam[1] = DependancyService.SQLParameter("@WDIRDAClientNo",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)ClientNo);

            SqlParam[2] = DependancyService.SQLParameter("@WDIRDADelAddrNo",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)DelAddrNo);

            DataTable dtWDIRDelAddrRec = SQLWrite.ExecuteDataTableQuery(SqlParam);
            List<WadmdirWDIRDelAddrRec> listWDIRDelAddrRec = WpfClassLibrary.Extensions.ToList<WadmdirWDIRDelAddrRec>(dtWDIRDelAddrRec);

            return listWDIRDelAddrRec.Count > 0 ? listWDIRDelAddrRec[0] : null;
        }
        public static List<WadmdirWDIRDelRecNotes> GetWadmdirWDIRDelRecNotes(int DelivAddrID, ref SQLWriteClass SQLWrite)
        {
            SQLWrite.SQLWriteCommand("[dbo].[GetWadmdirWDIRDelRecNotes]", SQLWriteClass.SqlCmdType.PROCEDURE);
            List<WadmdirWDIRDelRecNotes> listWDIRDelRecNotes = null;
            SqlParameter[] SqlParam = new SqlParameter[1];

            SqlParam[0] = DependancyService.SQLParameter("@DelivAddrID",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)DelivAddrID);

            DataTable dtWDIRDelRecNotes = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtWDIRDelRecNotes.Rows.Count > 0)
                listWDIRDelRecNotes = WpfClassLibrary.Extensions.ToList<WadmdirWDIRDelRecNotes>(dtWDIRDelRecNotes);

            return listWDIRDelRecNotes;
        }
        public static string GetWDIRDelAddrRecClientName(int ClientType, int ClientNo, int DelAddrNo, ref SQLWriteClass SQLWrite)
        {
            SQLWrite.SQLWriteCommand("[dbo].[GetWadmdirWDIRDelAddrRec]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[3];

            SqlParam[0] = DependancyService.SQLParameter("@WDIRDAClientType",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)ClientType);

            SqlParam[1] = DependancyService.SQLParameter("@WDIRDAClientNo",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)ClientNo);

            SqlParam[2] = DependancyService.SQLParameter("@WDIRDADelAddrNo",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)DelAddrNo);

            DataTable dtWDIRDelAddrRec = SQLWrite.ExecuteDataTableQuery(SqlParam);
            List<WadmdirWDIRDelAddrRec> listWDIRDelAddrRec = WpfClassLibrary.Extensions.ToList<WadmdirWDIRDelAddrRec>(dtWDIRDelAddrRec);

            return listWDIRDelAddrRec.Count > 0 ? listWDIRDelAddrRec[0].WDIRDAClientName : "";
        }
        public static string GetWadmdirWDIRInvAddrRecClientName(int ClientType, int ClientNo, int InvAddrNo, ref SQLWriteClass SQLWrite)
        {
            SQLWrite.SQLWriteCommand("[dbo].[GetWadmdirWDIRInvAddrRecClientName]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[3];

            SqlParam[0] = DependancyService.SQLParameter("@WDIRIAClientType",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)ClientType);

            SqlParam[1] = DependancyService.SQLParameter("@WDIRIAClientNo",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)ClientNo);

            SqlParam[2] = DependancyService.SQLParameter("@WDIRIAInvAddrNo",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)InvAddrNo);

            DataTable dtWDIRDelAddrRec = SQLWrite.ExecuteDataTableQuery(SqlParam);
            List<WadmdirWDIRDelAddrRec> listWDIRDelAddrRec = WpfClassLibrary.Extensions.ToList<WadmdirWDIRDelAddrRec>(dtWDIRDelAddrRec);

            return listWDIRDelAddrRec.Count > 0 ? listWDIRDelAddrRec[0].WDIRDAClientName : "";
        }
        public static WadmdirWDIRInvAddrRec GetWadmdirWDIRInvAddrRec(int ClientType, int ClientNo, int InvAddrNo, ref SQLWriteClass SQLWrite)
        {
            SQLWrite.SQLWriteCommand("[dbo].[GetWadmdirWDIRInvAddrRec]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[3];

            SqlParam[0] = DependancyService.SQLParameter("@WDIRIAClientType",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)ClientType);

            SqlParam[1] = DependancyService.SQLParameter("@WDIRIAClientNo",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)ClientNo);

            SqlParam[2] = DependancyService.SQLParameter("@WDIRIAInvAddrNo",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)InvAddrNo);

            DataTable dtWDIRDelAddrRec = SQLWrite.ExecuteDataTableQuery(SqlParam);
            List<WadmdirWDIRInvAddrRec> listWDIRInvAddrRec = WpfClassLibrary.Extensions.ToList<WadmdirWDIRInvAddrRec>(dtWDIRDelAddrRec);

            return listWDIRInvAddrRec.Count > 0 ? listWDIRInvAddrRec[0] : null;
        }
        public static WadmdirWDIRFactoringRec GetWadmdirWDIRFactoringRec(int ClientType, int ClientNo, int DelAddrNo, ref SQLWriteClass SQLWrite)
        {
            SQLWrite.SQLWriteCommand("[dbo].[GetWadmdirWDIRDelAddrRec]", SQLWriteClass.SqlCmdType.PROCEDURE);
            WadmdirWDIRFactoringRec WDIRFactoringRec = null;
            SqlParameter[] SqlParam = new SqlParameter[3];

            SqlParam[0] = DependancyService.SQLParameter("@WDIRFAClientType",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)ClientType);

            SqlParam[1] = DependancyService.SQLParameter("@WDIRFAClientNo",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)ClientNo);

            SqlParam[2] = DependancyService.SQLParameter("@WDIRFAFactAddrNo",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)DelAddrNo);

            DataTable dtWDIRFactoringRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtWDIRFactoringRec.Rows.Count > 0)
            {
                List<WadmdirWDIRFactoringRec> listWDIRFactoringRec = WpfClassLibrary.Extensions.ToList<WadmdirWDIRFactoringRec>(dtWDIRFactoringRec);
                WDIRFactoringRec = listWDIRFactoringRec[0];
            }

            return WDIRFactoringRec;
        }
        public static string GetWadmdirWDIRFactoringRecClientName(int ClientType, int ClientNo, int DelAddrNo, ref SQLWriteClass SQLWrite)
        {
            SQLWrite.SQLWriteCommand("[dbo].[GetWadmdirWDIRFactoringRecClientName]", SQLWriteClass.SqlCmdType.PROCEDURE);
            SqlParameter[] SqlParam = new SqlParameter[3];
            string WDIRFAClientName = "";

            SqlParam[0] = DependancyService.SQLParameter("@WDIRFAClientType",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)ClientType);

            SqlParam[1] = DependancyService.SQLParameter("@WDIRFAClientNo",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)ClientNo);

            SqlParam[2] = DependancyService.SQLParameter("@WDIRFAFactAddrNo",
                    "System.Int32", DependancyService.ParamDirection.Input, (object)DelAddrNo);

            DataTable dtWDIRFactoringRec = SQLWrite.ExecuteDataTableQuery(SqlParam);

            if (dtWDIRFactoringRec.Rows.Count > 0)
            {
                List<WadmdirWDIRFactoringRec> listWDIRFactoringRec = WpfClassLibrary.Extensions.ToList<WadmdirWDIRFactoringRec>(dtWDIRFactoringRec);
                WadmdirWDIRFactoringRec WDIRFactoringRec = listWDIRFactoringRec[0];
                WDIRFAClientName = WDIRFactoringRec.WDIRFAClientName.Trim();
            }

            return WDIRFAClientName;
        }
        #endregion
    }
}
