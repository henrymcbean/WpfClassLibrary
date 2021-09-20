using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections.Generic;

namespace WpfClassLibrary
{
    public class DataTableAccess
    {
        /// <summary>
        /// Query Table on two Field
        /// </summary>
        /// <param name="dtTable"></param>
        /// <param name="ColName1"></param>
        /// <param name="ColName2"></param>
        /// <param name="Value1"></param>
        /// <param name="Value2"></param>
        /// <returns>"IEnumerable<DataRow>"</returns>
        static public IEnumerable<DataRow> GetTableRows(ref DataTable dtTable, string ColName1, string ColName2, string Value1, string Value2)
        {
            string sQuery = ColName1 + " = " + Value1 + " AND " + ColName2 + " = " + Value2;
            var results = dtTable.Select(sQuery);

            return results;
        }

        /// <summary>
        /// Query Table with passed in Query
        /// </summary>
        /// <param name="dtTable"></param>
        /// <param name="sQuery"></param>
        /// <returns>"IEnumerable<DataRow>"</returns>
        static public IEnumerable<DataRow> GetTableRows(ref DataTable dtTable, string sQuery)
        {
            var results = dtTable.Select(sQuery);

            return results;
        }
    }
}
