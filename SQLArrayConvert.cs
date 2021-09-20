using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WpfClassLibrary
{
    public class SQLArrayConvert
    {
        #region // short to delimited string array
        /// <summary>
        /// Convert short array to delimited char array
        /// </summary>
        /// <param name="ArrayVar = Array to convert"></param>
        /// <param name="ArrayString = return delimited array = i,12,1,2,3,4,..."></param>
        /// <param name="Length - Total Length"></param>
        /// <param name="sDim - Dimension i,12 Where i=int 12=dimension lenth"></param>
        static public void ShortArrayToString(short[] ArrayShort, ref String ArrayString, short Length, String sDim)
        {
            ArrayString = string.Format("s,{0},{1}", Length, sDim);

            for (short i = 0; i < Length; i++)
                ArrayString = string.Format("{0},{1}", ArrayString, ArrayShort[i]);
        }

        /// <summary>
        /// Convert short array to delimited char array
        /// </summary>
        /// <param name="ArrayVar = Array to convert"></param>
        /// <param name="ArrayString = return delimited array = i,12,1,2,3,4,..."></param>
        /// <param name="Length - Total Length"></param>
        /// <param name="sDim - Dimension c,12,6 Where i=int 12,6=dimension lenth"></param>
        static public void ShortArrayToString(short[][] ArrayShort, ref String ArrayString, short Length, String sDim)
        {
            ArrayString = string.Format("s,{0},{1}", Length, sDim);
            string[] split = sDim.Split(',');

            for (short i = 0; i < Int16.Parse(split[0]); i++)
                for (short j = 0; j < Int16.Parse(split[1]); j++)
                    ArrayString = string.Format("{0},{1}", ArrayString, ArrayShort[i][j]);
        }

        /// <summary>
        /// Convert short array to delimited char array
        /// </summary>
        /// <param name="ArrayVar = Array to convert"></param>
        /// <param name="ArrayString = return delimited array = i,12,1,2,3,4,..."></param>
        /// <param name="Length - Total Length"></param>
        /// <param name="sDim - Dimension i,12,12,6 Where i=int 12,12,6=dimension lenth"></param>
        static public void ShortArrayToString(short[][][] ArrayShort, ref String ArrayString, short Length, String sDim)
        {
            ArrayString = string.Format("s,{0},{1}", Length, sDim);
            string[] split = sDim.Split(',');

            for (short i = 0; i < Int16.Parse(split[0]); i++)
                for (short j = 0; j < Int16.Parse(split[1]); j++)
                    for (short k = 0; k < Int16.Parse(split[2]); k++)
                        ArrayString = string.Format("{0},{1}", ArrayString, ArrayShort[i][j][k]);
        }
        #endregion
        #region // int to delimited string array
        /// <summary>
        /// Convert Number array to delimited char array
        /// </summary>
        /// <param name="ArrayVar = Array to convert"></param>
        /// <param name="ArrayString = return delimited array = i,12,1,2,3,4,..."></param>
        /// <param name="Length - Total Length"></param>
        /// <param name="sDim - Dimension i,12 Where i=int 12=dimension lenth"></param>
        static public void IntArrayToString(int[] ArrayVar, ref String ArrayString, int Length, String sDim)
        {
            ArrayString = string.Format("i,{0},{1}", Length, sDim);

            for (int i = 0;i < Length;i++)
                ArrayString = string.Format("{0},{1}", ArrayString, ArrayVar[i]);
        }

        /// <summary>
        /// Convert Number array to delimited char array
        /// </summary>
        /// <param name="ArrayVar = Array to convert"></param>
        /// <param name="ArrayString = return delimited array = i,12,1,2,3,4,..."></param>
        /// <param name="Length - Total Length"></param>
        /// <param name="sDim - Dimension c,12,6 Where i=int 12,6=dimension lenth"></param>
        static public void IntArrayToString(int[][] ArrayVar, ref String ArrayString, int Length, String sDim)
        {
            ArrayString = string.Format("i,{0},{1}", Length, sDim);
            string[] split = sDim.Split(',');

            for (int i = 0; i < Int32.Parse(split[0]); i++)
                for (int j = 0; j < Int32.Parse(split[1]); j++)
                    ArrayString = string.Format("{0},{1}", ArrayString, ArrayVar[i][j]);
        }

        /// <summary>
        /// Convert Number array to delimited char array
        /// </summary>
        /// <param name="ArrayVar = Array to convert"></param>
        /// <param name="ArrayString = return delimited array = i,12,1,2,3,4,..."></param>
        /// <param name="Length - Total Length"></param>
        /// <param name="sDim - Dimension i,12,12,6 Where i=int 12,12,6=dimension lenth"></param>
        static public void IntArrayToString(int[][][] ArrayVar, ref String ArrayString, int Length, String sDim)
        {
            ArrayString = string.Format("i,{0},{1}", Length, sDim);
            string[] split = sDim.Split(',');

            for (int i = 0; i < Int32.Parse(split[0]); i++)
                for (int j = 0; j < Int32.Parse(split[1]); j++)
                    for (int k = 0; k < Int32.Parse(split[2]); k++)
                        ArrayString = string.Format("{0},{1}", ArrayString, ArrayVar[i][j][k]);
        }
        #endregion
        #region // long to delimited string array
        /// <summary>
        /// Convert Number array to delimited char array
        /// </summary>
        /// <param name="ArrayLong = Array to convert"></param>
        /// <param name="ArrayString = return delimited array = l,12,1,2,3,4,..."></param>
        /// <param name="Length - Total Length"></param>
        /// <param name="sDim - Dimension l,12,6 Where l=long 12=dimension lenth"></param>
        static public void longArrayToString(long[] ArrayLong, ref String ArrayString, int Length, String sDim)
        {
            ArrayString = string.Format("l,{0},{1}", Length, sDim);

            for (long i = 0; i < Length; i++)
                ArrayString = string.Format("{0},{1}", ArrayString, ArrayLong[i]);
        }
        
        /// <summary>
        /// Convert Number array to delimited char array
        /// </summary>
        /// <param name="ArrayLong = Array to convert"></param>
        /// <param name="ArrayString = return delimited array = l,12,1,2,3,4,..."></param>
        /// <param name="Length - Total Length"></param>
        /// <param name="sDim - Dimension l,12,6 Where l=long 12,6=dimension lenth"></param>
        static public void longArrayToString(long[][] ArrayLong, ref String ArrayString, int Length, String sDim)
        {
            ArrayString = string.Format("l,{0},{1}", Length, sDim);
            string[] split = sDim.Split(',');

            for (long i = 0; i < Int32.Parse(split[0]); i++)
                for (long j = 0; j < Int32.Parse(split[1]); j++)
                    ArrayString = string.Format("{0},{1}", ArrayString, ArrayLong[i][j]);
        }

        /// <summary>
        /// Convert Number array to delimited char array
        /// </summary>
        /// <param name="ArrayLong = Array to convert"></param>
        /// <param name="ArrayString = return delimited array = l,12,1,2,3,4,..."></param>
        /// <param name="Length - Total Length"></param>
        /// <param name="sDim - Dimension l,12,6 Where l=long 12,12,6=dimension lenth"></param>
        static public void longArrayToString(long[][][] ArrayVar, ref String ArrayString, int Length, String sDim)
        {
            ArrayString = string.Format("l,{0},{1}", Length, sDim);
            string[] split = sDim.Split(',');

            for (long i = 0; i < Int16.Parse(split[0]); i++)
                for (long j = 0; j < Int16.Parse(split[1]); j++)
                    for (long k = 0; k < Int16.Parse(split[2]); k++)
                        ArrayString = string.Format("{0},{1}", ArrayString, ArrayVar[i][j][k]);
        }
        #endregion
        #region // double to delimited string array
        /// <summary>
        /// Convert Number array to delimited char array
        /// </summary>
        /// <param name="ArrayLong = Array to convert"></param>
        /// <param name="ArrayString = return delimited array = d,12,1,2,3,4,..."></param>
        /// <param name="Length - Total Length"></param>
        /// <param name="sDim - Dimension d,12,6 Where d=long 12=dimension lenth"></param>
        static public void DoubleArrayToString(double[] ArrayVar, ref String ArrayString, int Length, String sDim)
        {
            ArrayString = string.Format("d,{0},{1}", Length, sDim);

            for (int i = 0; i < Length; i++)
                ArrayString = string.Format("{0},{1}", ArrayString, ArrayVar[i]);
        }

        /// <summary>
        /// Convert Number array to delimited char array
        /// </summary>
        /// <param name="ArrayLong = Array to convert"></param>
        /// <param name="ArrayString = return delimited array = d,12,1,2,3,4,..."></param>
        /// <param name="Length - Total Length"></param>
        /// <param name="sDim - Dimension d,12,6 Where d=long 12,6=dimension lenth"></param>
        static public void DoubleArrayToString(double[][] ArrayVar, ref String ArrayString, int Length, String sDim)
        {
            ArrayString = string.Format("d,{0},{1}", Length, sDim);
            string[] split = sDim.Split(',');

            for (int i = 0; i < Int16.Parse(split[0]); i++)
                for (int j = 0; j < Int16.Parse(split[1]); j++)
                    ArrayString = string.Format("{0},{1}", ArrayString, ArrayVar[i][j]);
        }

        /// <summary>
        /// Convert Number array to delimited char array
        /// </summary>
        /// <param name="ArrayLong = Array to convert"></param>
        /// <param name="ArrayString = return delimited array = d,12,1,2,3,4,..."></param>
        /// <param name="Length - Total Length"></param>
        /// <param name="sDim - Dimension d,12,6 Where d=long 12,12,6=dimension lenth"></param>
        static public void DoubleArrayToString(ref double[][][] ArrayVar, String ArrayString, int Length, String sDim)
        {
            ArrayString = string.Format("d,{0},{1}", Length, sDim);
            string[] split = sDim.Split(',');

            for (int i = 0; i < Int16.Parse(split[0]); i++)
                for (int j = 0; j < Int16.Parse(split[1]); j++)
                    for (int k = 0; k < Int16.Parse(split[2]); k++)
                        ArrayString = string.Format("{0},{1}", ArrayString, ArrayVar[i][j][k]);
        }
        #endregion
        #region // char array to delimited string array
        /// <summary>
        /// Convert char array to delimited char array
        /// </summary>
        /// <param name="ArrayChar = Array to convert"></param>
        /// <param name="ArrayString = return delimited array = c,12,6,1,2,3,4,..."></param>
        /// <param name="Length - Total Length"></param>
        /// <param name="sDim - Dimension c,12,6 Where c=int 12=dimension lenth"></param>
        static public void CharArrayToString(char[][] vStringChar, ref String ArrayString, int niLength, int Length, String sDim)
        {
            ArrayString = string.Format("c,{0},{1}", Length, sDim);

            for (int i = 0; i < Length; i++)
                ArrayString = string.Format("{0},{1}", ArrayString, vStringChar[i]);
        }

        /// <summary>
        /// Convert char array to delimited char array
        /// </summary>
        /// <param name="ArrayChar = Array to convert"></param>
        /// <param name="ArrayString = return delimited array = c,12,6,1,2,3,4,..."></param>
        /// <param name="Length - Total Length"></param>
        /// <param name="sDim - Dimension c,12 Where c=int 12,6=dimension lenth"></param>
        static public void CharArrayToString(char[][][] vStringChar, ref String ArrayString, int niLength, int Length, String sDim)
        {
            ArrayString = string.Format("c,{0},{1}", Length, sDim);
            string[] split = sDim.Split(',');

            for (int i = 0; i < Int16.Parse(split[1]); i++)
                for (int j = 0; j < Int16.Parse(split[1]); j++)
                    ArrayString = string.Format("{0},{1}", ArrayString, vStringChar[i][j]);
        }
        #endregion
        #region // string array to delimited string
        /// <summary>
        /// Convert String array to delimited String array
        /// </summary>
        /// <param name="InArrayString = Array to convert"></param>
        /// <param name="ArrayString = return delimited array = c,12,6,1,2,3,4,..."></param>
        /// <param name="Length - Total Length"></param>
        /// <param name="sDim - Dimension c,12,6 Where c=int 12=dimension lenth"></param>
        static public void StringArrayToString(String[] InArrayString, ref String ArrayString, int Length, String sDim)
        {
            ArrayString = string.Format("c,{0},{1}", Length, sDim);

            for (int i = 0; i < Length; i++)
                ArrayString = string.Format("{0},{1}", ArrayString, InArrayString[i]);
        }
        #endregion

        #region // delimited string to short array
        static public void StringToShortArray(String ArrayString, ref short[] intArray)
        {
            string[] split = ArrayString.Split(',');
            intArray = new short[short.Parse(split[3])];

            for (short i = 0; i < short.Parse(split[3]); i++)
                intArray[i] = short.Parse(split[i + 4]);
        }

        static public void StringToShortArray(String ArrayString, ref short[][] intArray)
        {
            string[] split = ArrayString.Split(',');
            intArray = new short[short.Parse(split[1])][];

            for (short i = 0; i < short.Parse(split[1]); i++)
                intArray[i] = new short[short.Parse(split[2])];

            for (short i = 0; i < short.Parse(split[1]); i++)
                for (short j = 0; i < short.Parse(split[2]); i++)
                    intArray[i][j] = short.Parse(split[i + 2]);
        }

        static public void StringToShortArray(String ArrayString, ref short[][][] intArray)
        {
            string[] split = ArrayString.Split(',');
            intArray = new short[short.Parse(split[1])][][];

            for (short i = 0; i < short.Parse(split[1]); i++)
                intArray[i] = new short[short.Parse(split[2])][];

            for (short i = 0; i < short.Parse(split[1]); i++)
                for (short j = 0; j < short.Parse(split[2]); j++)
                    intArray[i][j] = new short[short.Parse(split[3])];

            for (short i = 0; i < short.Parse(split[1]); i++)
                for (short j = 0; i < short.Parse(split[2]); j++)
                    for (short k = 0; k < short.Parse(split[2]); k++)
                        intArray[i][j][k] = short.Parse(split[i + 2]);
        }
        #endregion
        #region // delimited string to int array
        static public void StringToIntArray(String ArrayString, ref int[] intArray)
        {
            string[] split = ArrayString.Split(',');
            intArray = new int[int.Parse(split[3])];

            for (int i = 0;i < int.Parse(split[3]);i++)
                intArray[i] = int.Parse(split[i+4]);
        }

        static public void StringToIntArray(String ArrayString, ref int[][] intArray)
        {
            string[] split = ArrayString.Split(',');
            intArray = new int[int.Parse(split[1])][];

            for (int i = 0;i < int.Parse(split[1]);i++)
                intArray[i] = new int[int.Parse(split[2])];

            for (int i = 0; i < int.Parse(split[1]); i++)
                for (int j = 0; i < int.Parse(split[2]); i++)
                    intArray[i][j] = int.Parse(split[i + 2]);
        }

        static public void StringToIntArray(String ArrayString, ref int[][][] intArray)
        {
            string[] split = ArrayString.Split(',');
            intArray = new int[int.Parse(split[1])][][];

            for (int i = 0;i < int.Parse(split[1]); i++)
                intArray[i] = new int[int.Parse(split[2])][];

            for (int i = 0; i < int.Parse(split[1]); i++)
                for (int j = 0;j < int.Parse(split[2]); j++)
                    intArray[i][j] = new int[int.Parse(split[3])];

            for (int i = 0; i < int.Parse(split[1]); i++)
                for (int j = 0; i < int.Parse(split[2]); j++)
                    for (int k = 0; k < int.Parse(split[2]); k++)
                    intArray[i][j][k] = int.Parse(split[i + 2]);
        }
        #endregion
        #region // delimited string to long array
        static public void StringToLongArray(String ArrayString, ref long[] longArray)
        {
            string[] split = ArrayString.Split(',');
            longArray = new long[int.Parse(split[3])];

            for (int i = 0; i < int.Parse(split[3]); i++)
                longArray[i] = long.Parse(split[i + 4]);
        }

        static public void StringToLongArray(String ArrayString, ref long[][] longArray)
        {
            string[] split = ArrayString.Split(',');
            longArray = new long[int.Parse(split[2])][];

            for (int i = 0; i < int.Parse(split[2]); i++)
                longArray[i] = new long[int.Parse(split[3])];

            for (int i = 0, k = 0;i < int.Parse(split[2]);i++)
                for (int j = 0;j < int.Parse(split[3]);j++, k++)
                    longArray[i][j] = long.Parse(split[k + 4]);
        }

        static public void StringToLongArray(String ArrayString, ref long[][][] longArray)
        {
            string[] split = ArrayString.Split(',');
            longArray = new long[int.Parse(split[1])][][];

            for (int i = 0; i < int.Parse(split[1]); i++)
                longArray[i] = new long[int.Parse(split[2])][];

            for (int i = 0; i < int.Parse(split[1]); i++)
                for (int j = 0; j < int.Parse(split[2]); j++)
                    longArray[i][j] = new long[int.Parse(split[3])];

            for (int i = 0; i < int.Parse(split[1]); i++)
                for (int j = 0; i < int.Parse(split[2]); j++)
                    for (int k = 0; k < int.Parse(split[2]); k++)
                        longArray[i][j][k] = long.Parse(split[i + 2]);
        }
        #endregion
        #region // delimited string to double array
        static public void StringToDoubleArray(String ArrayString, ref double[] doubleArray)
        {
            string[] split = ArrayString.Split(',');
            doubleArray = new double[int.Parse(split[1])];

            for (int i = 0; i < int.Parse(split[1]); i++)
                doubleArray[i] = double.Parse(split[i + 4]);
        }

        static public void StringToDoubleArray(String ArrayString, ref double[][] doubleArray)
        {
            string[] split = ArrayString.Split(',');
            doubleArray = new double[int.Parse(split[1])][];

            for (int i = 0; i < int.Parse(split[1]); i++)
                doubleArray[i] = new double[int.Parse(split[2])];

            for (int i = 0; i < int.Parse(split[1]); i++)
                for (int j = 0; i < int.Parse(split[2]); i++)
                    doubleArray[i][j] = long.Parse(split[i + 2]);
        }

        static public void StringToDoubleArray(String ArrayString, ref double[][][] doubleArray)
        {
            string[] split = ArrayString.Split(',');
            doubleArray = new double[int.Parse(split[1])][][];

            for (int i = 0; i < int.Parse(split[1]); i++)
                doubleArray[i] = new double[int.Parse(split[2])][];

            for (int i = 0; i < int.Parse(split[1]); i++)
                for (int j = 0; j < int.Parse(split[2]); j++)
                    doubleArray[i][j] = new double[int.Parse(split[3])];

            for (int i = 0; i < int.Parse(split[1]); i++)
                for (int j = 0; i < int.Parse(split[2]); j++)
                    for (int k = 0; k < int.Parse(split[2]); k++)
                        doubleArray[i][j][k] = double.Parse(split[i + 2]);
        }
        #endregion
        #region // delimited string to string array
        static public void StringToStringArray(String ArrayString, ref String[] stringArray)
        {
            string[] split = ArrayString.Split(',');

            int Length = split.Length - 4;

            if (split[split.Length - 1].Length == 0)
                Length = Length - 1;

            stringArray = new String[Length];

            for (int i = 0; i < Length; i++)
                    stringArray[i] = split[i + 4];
        }
        static public void StringToStringArray(String ArrayString, ref String[][] stringArray)
        {
            string[] split = ArrayString.Split(',');
            stringArray = new String[int.Parse(split[2])][];

            for (int i = 0; i < int.Parse(split[2]); i++)
                stringArray[i] = new String[int.Parse(split[3])];

            for (int i = 0, k = 0; i < int.Parse(split[2]); i++)
                for (int j = 0; j < int.Parse(split[3]);j++, k++)
                    stringArray[i][j] = split[k + 4];
        }
        static public void StringToStringArray(String ArrayString, ref String[][][] charArray)
        {
            string[] split = ArrayString.Split(',');
            charArray = new String[int.Parse(split[2])][][];

            for (int i = 0; i < int.Parse(split[2]); i++)
                charArray[i] = new String[int.Parse(split[3])][];

            for (int i = 0; i < int.Parse(split[2]); i++)
                for (int j = 0; j < int.Parse(split[3]); j++)
                    charArray[i][j] = new String[int.Parse(split[4])];

            for (int i = 0, l = 0; i < int.Parse(split[2]); i++)
                for (int j = 0; j < int.Parse(split[3]); j++)
                    for (int k = 0; k < int.Parse(split[4]); k++, l++)
                        charArray[i][j][k] = split[l + 2];
        }
        /*
        static public void StringToStringArray(String ArrayString, ref String[][][][] charArray)
        {
            string[] split = ArrayString.Split(',');
            charArray = new char[int.Parse(split[1])][][][];

            for (int i = 0;i < int.Parse(split[1]); i++)
                charArray[i] = new char[int.Parse(split[2])][][];

            for (int i = 0;i < int.Parse(split[1]); i++)
                for (int j = 0;j < split[i + 2].Length; j++)
                    charArray[i][j] = new char[int.Parse(split[2])][];

            for (int i = 0;i < int.Parse(split[1]); i++)
                for (int j = 0;j < split[i + 2].Length; j++)
                    for (int k = 0;k < split[i + 3].Length; k++)
                        charArray[i][j][k] = new char[int.Parse(split[3])];

            for (int i = 0;i < int.Parse(split[1]); i++)
                for (int j = 0;j < split[i + 2].Length; j++)
                    for (int k = 0;k < split[i + 3].Length; k++)
                        for (int l = 0;l < split[i + 4].Length; k++)
                            charArray[i][j][k][l] = split[i + 2][l];
        }*/
        #endregion
    }
}

public class SQLArrayGenericList
{
    static public void StringToShortList(String ArrayString, ref List<short> GenericList)
    {
        string[] split = ArrayString.Split(',');
        GenericList = new List<short>();

        for (short i = 0; i < short.Parse(split[3]); i++)
            GenericList.Add(short.Parse(split[i + 4]));
    }
    static public void StringToIntList(String ArrayString, ref List<int> GenericList)
    {
        string[] split = ArrayString.Split(',');
        GenericList = new List<int>();

        for (int i = 0; i < int.Parse(split[3]); i++)
            GenericList.Add(int.Parse(split[i + 4]));
    }
    static public void StringToIntList(String ArrayString, ref List<List<int>> GenericList)
    {
        string[] split = ArrayString.Split(','); 
        GenericList = new List<List<int>>(int.Parse(split[1]));

        for (int i = 0; i < GenericList.Count;i++)
            GenericList.Add(new List<int>());

        for (int i = 0; i < GenericList.Count; i++)
            for (int j = 0; i < int.Parse(split[2]); i++)
                GenericList[i].Add(int.Parse(split[j + 2]));
    }
    static public void StringTolongList(String ArrayString, ref List<long> GenericList)
    {
        string[] split = ArrayString.Split(',');
        GenericList = new List<long>();

        for (int i = 0; i < int.Parse(split[3]); i++)
            GenericList.Add(long.Parse(split[i + 4]));
    }
    static public void StringTolongList(String ArrayString, ref List<List<long>> GenericList)
    {
        string[] split = ArrayString.Split(',');
        GenericList = new List<List<long>>(int.Parse(split[1]));

        for (int i = 0; i < GenericList.Count; i++)
            GenericList.Add(new List<long>());

        for (int i = 0; i < GenericList.Count; i++)
            for (int j = 0; i < int.Parse(split[2]); i++)
                GenericList[i].Add(long.Parse(split[j + 2]));
    }
}
