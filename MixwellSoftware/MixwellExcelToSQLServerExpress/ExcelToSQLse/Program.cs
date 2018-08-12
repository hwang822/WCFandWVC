﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;

using System.IO;
using System.Reflection;
using ExcelTools = Microsoft.Office;
using Excel = Microsoft.Office.Interop.Excel;
using System.Configuration;

interface IDataBaseTest
{
    void WriteDataToTable(string connection, DataTable data);
    DataTable ReadDataFromTable(string connection);
    DataTable ReadDataFromExcel(string path);
    bool UnitTest(DataTable sorce, DataTable Dist);

}

public class DataBaseTest : IDataBaseTest
{
    public void WriteDataToTable(string connection, DataTable data)
    {
        using (SqlConnection conn = new SqlConnection(connection))
        {
            conn.Open();
            using (SqlBulkCopy bulkCopy = new SqlBulkCopy(conn))
            {
                foreach (DataColumn c in data.Columns)
                {
                    bulkCopy.ColumnMappings.Add(c.ColumnName, c.ColumnName);
                    bulkCopy.DestinationTableName = data.TableName;
                    try
                    {
                        bulkCopy.WriteToServer(data);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }

    }

    public DataTable ReadDataFromTable(string connection)
    {
        DataTable dt = null;

        using (OleDbConnection conn = new OleDbConnection(connection))
        {
            conn.Open();
            string sql = "Select * from Test_tab";
            using (OleDbCommand cmd = new OleDbCommand(sql, conn))
            {
                using (OleDbDataReader rdr = cmd.ExecuteReader())
                {
                    dt.Load(rdr);
                    return dt;
                }
            }
        }
        
    }

    public DataTable ReadDataFromExcel(string path)
    {
        Excel.Application xlApp = new Excel.Application();
        Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(path);
        Excel.Worksheet xlWorksheet = xlWorkbook.Sheets[1]; // assume it is the first sheet
        Excel.Range xlRange = xlWorksheet.UsedRange; // get the entire used range
        int columnsCount = xlRange.Columns.Count;
        int rowsCount = xlRange.Rows.Count;

        var cln = xlRange.Columns;
        var d1 = cln.Item[0];

        DataTable data = new DataTable();
        String col1 = ConfigurationManager.AppSettings["Colunm1"];
        String col2 = ConfigurationManager.AppSettings["Colunm2"];
        String col3 = ConfigurationManager.AppSettings["Colunm3"];
        String col4 = ConfigurationManager.AppSettings["Colunm4"];
        String col5 = ConfigurationManager.AppSettings["Colunm5"];
        String col6 = ConfigurationManager.AppSettings["Colunm6"];

        data.Columns.Add(col1, typeof(string));
        data.Columns.Add(col2, typeof(string));
        data.Columns.Add(col3, typeof(int));
        data.Columns.Add(col4, typeof(int));
        data.Columns.Add(col5, typeof(int));
        data.Columns.Add(col6, typeof(string));


        for (int row = 1; row <= rowsCount; row++)
        {
            data.Rows.Add(Convert.ToString(xlRange.Cells[row, 1]),
                          Convert.ToString(xlRange.Cells[row, 2]),
                          Convert.ToUInt16(xlRange.Cells[row, 3]),
                          Convert.ToUInt16(xlRange.Cells[row, 4]),
                          Convert.ToUInt16(xlRange.Cells[row, 5]),
                          Convert.ToString(xlRange.Cells[row, 6]));
        }       

        return data;
    }

    public bool UnitTest(DataTable sorce, DataTable Dist)
    {
        // not time to add test Scenarios.

        IEnumerable<DataRow> st = from r in sorce.AsEnumerable() select r;
        IEnumerable<DataRow> dt = from r in Dist.AsEnumerable() select r;
        return (st.Equals(dt));
    }

}


class Program
{
    static void Main(string[] args)
    {
        IDataBaseTest test = new DataBaseTest();
        String excelfilepath =  ConfigurationManager.AppSettings["excelpath"];

        DataTable data = test.ReadDataFromExcel(excelfilepath);

        string dbconnection = ConfigurationManager.AppSettings["dbconnection"];
        test.WriteDataToTable(dbconnection, data);

        DataTable dbdata = test.ReadDataFromTable(dbconnection);

        bool testlog = test.UnitTest(data, dbdata);
            
    }
}
















































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































