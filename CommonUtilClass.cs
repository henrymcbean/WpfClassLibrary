using System;
using System.IO;
using System.Data;
using System.Linq;
using System.Text;
using System.Runtime;
using WpfClassLibrary.Model;
using System.Threading.Tasks;
using System.Windows.Threading;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace WpfClassLibrary
{
    public enum AppViewState { EMPTY, SEARCH, VIEW, EDIT, NEW }

    static public class GlobalConstants
    {
        public const string NULL_DATE = "1900/01/01";
        public const Int16 NoOfWeekDays = 5;
        public const int Grid_Columns = 32;
        public const int Mat_Sizes = 128;

        static public double DecimalPart(double ndValue)
        {
            double decim = ndValue - Math.Truncate(ndValue);
            return decim;
        }
        static public double Truncate(double ndValue)
        {
            return Math.Truncate(ndValue);
        }
    }

    static public class DeepCopy<T>
    {
        public static T MakeDeepCopy(T other)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(ms, other);
                ms.Position = 0;
                return (T)formatter.Deserialize(ms);
            }
        }
    }
    public class CommonUtilClass
    {
        static public DataTable InitializeGridColumns()
        {
            DataTable dtSizesDynamic = new DataTable();

            DataColumn col = new DataColumn("Size Key");

            // Create Size Key Column
            dtSizesDynamic.Columns.Add(col);

            for (int i = 0; i < 128; i++)
            {
                col = new DataColumn("Size " + (i + 1).ToString());
                dtSizesDynamic.Columns.Add(col);
            }

            return dtSizesDynamic;
        }

        static public DataTable GetGmSizes(DataTable dtSizesRec)
        {
            string[] sSizes = new string[128];
            List<GmsizesGMSizesRec> listSizesRec;
            DataTable dtSizesDynamic_l = InitializeGridColumns();
            List<List<string>> listGmSizes = new List<List<string>>();

            if (dtSizesRec.Rows.Count > 0)
            {
                listSizesRec = WpfClassLibrary.Extensions.ToList<GmsizesGMSizesRec>(dtSizesRec);

                foreach (GmsizesGMSizesRec listGmsizes in listSizesRec)
                {
                    int i = 0;
                    DataRow row = dtSizesDynamic_l.NewRow();
                    row["Size Key"] = listGmsizes.GMSizeKey;
                    List<string> ListItem = new List<string>();

                    if (listGmsizes.GMSizes.Trim().Length > 0)
                    {
                        SQLArrayConvert.StringToStringArray(listGmsizes.GMSizes, ref sSizes);

                        for (;i < sSizes.Length && i < 128; i++)
                        {
                            if (sSizes[i].Trim().Length > 0)
                                row["Size " + (i + 1).ToString()] = sSizes[i];
                            else break;
                        }
                        for (; i < 128; i++) row["Size " + (i + 1).ToString()] = "";
                    }
                    else
                        for (; i < 128; i++) row["Size " + (i + 1).ToString()] = "";

                    dtSizesDynamic_l.Rows.Add(row);
                }
            }

            return dtSizesDynamic_l;
        }
        public static void DelayAction(int millisecond, Action action)
        {
            var timer = new DispatcherTimer();
            timer.Tick += delegate
            {
                action.Invoke();
                timer.Stop();
            };

            timer.Interval = TimeSpan.FromMilliseconds(millisecond);
            timer.Start();
        }
        static public IEnumerable<string> WholeChunks(string str, int chunkSize)
        {
            if (String.IsNullOrEmpty(str)) throw new ArgumentException();
            if (chunkSize < 1) throw new ArgumentException();

            for (int i = 0; i < str.Length; i += chunkSize)
            {
                if (chunkSize + i > str.Length)
                    chunkSize = str.Length - i;

                yield return str.Substring(i, chunkSize);
            }
        }
        static public DataTable GetGmSizes(DataTable dtSizesRec, DataTable dtSizesDynamic_l, int Offset = 0)
        {
            string[] sSizes = new string[128];
            List<GmsizesGMSizesRec> listSizesRec;
            List<List<string>> listGmSizes = new List<List<string>>();

            if (dtSizesRec.Rows.Count > 0)
            {
                listSizesRec = WpfClassLibrary.Extensions.ToList<GmsizesGMSizesRec>(dtSizesRec);

                foreach (GmsizesGMSizesRec listGmsizes in listSizesRec)
                {
                    int i = 0;
                    DataRow row = dtSizesDynamic_l.NewRow();
                    row["Size Key"] = listGmsizes.GMSizeKey;
                    List<string> ListItem = new List<string>();

                    if (listGmsizes.GMSizes.Trim().Length > 0)
                    {
                        SQLArrayConvert.StringToStringArray(listGmsizes.GMSizes, ref sSizes);

                        for (; i < dtSizesDynamic_l.Columns.Count - Offset; i++)
                        {
                            if (sSizes[i].Trim().Length > 0)
                                row["Size " + (i + 1).ToString()] = sSizes[i];
                            else break;
                        }
                        for (; i < dtSizesDynamic_l.Columns.Count - Offset; i++) row["Size " + (i + 1).ToString()] = "";
                    }
                    else
                        for (; i < 128; i++) row["Size " + (i + 1).ToString()] = "";

                    dtSizesDynamic_l.Rows.Add(row);
                }
            }

            return dtSizesDynamic_l;
        }
    }
    public class TupleList<T1, T2> : List<Tuple<T1, T2>>
    {
        public TupleList(T1 item, T2 item2)
        {
            Add(item, item2);
        }
        public void Add(T1 item, T2 item2)
        {
            Add(new Tuple<T1, T2>(item, item2));
        }
    }

    static public class CommandLine
    {
        static public string GetParameter(string Param, string[] CmdArgs)
        {
            string ParamValue = "";

            // Check Command line for Param
            var sQuery = from arg in CmdArgs
                         where arg == Param
                         select arg;

            if (sQuery.ToList().Count > 0)
            {
                for (int index = 1; index < CmdArgs.Length; index += 2)
                {
                    if (CmdArgs[index] == Param)
                        ParamValue = CmdArgs[index + 1];
                }
            }

            return ParamValue;
        }
    }
}
