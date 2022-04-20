using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SquadAdmin
{
    public class Load
    {
        public static string currentLayer = "";
        public static string lastCommandSended = "";
        public static string lastRuleSended = "";
        public static string pastedText = "";
        public static string steamID = "SteamID";
        public static string filterName = "";

        static string currentPath = Directory.GetCurrentDirectory();
        static string pathExcel = Path.Combine(currentPath, "Data", "dados.xlsx");

        public List<string> rules = loadSheetData2("regras");
        public List<string> messages = loadSheetData2("avisos");
        public List<string> mapsNames = loadSheetData2("mapas");
        public List<string> gameModes = loadSheetData2("gamemode");
        public DataTable mapLayers = loadSheetData3("layers");
        public DataTable commands = loadSheetData3("comandos");
        public List<string> msgReasons = loadSheetData2("motivos_kick_ban");
        
        private static void getContext()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }

        public bool checkSheet()
        {
            if (!File.Exists(pathExcel))
            {
                return false;
            }
            return true;
        }

        private static List<string> loadSheetData2(string sheetName)
        {
            getContext();

            using (var package = new ExcelPackage(new FileInfo(pathExcel)))
            {
                var sheetRules = package.Workbook.Worksheets[sheetName];
                int numRows = sheetRules.Dimension.End.Row;

                var rows = new List<string>();
                for (int i = 0; i < numRows; i++)
                {
                    if (!String.IsNullOrEmpty(sheetRules.Cells[i + 2, 1].Text))
                    {
                        rows.Add(sheetRules.Cells[i + 2, 1].Text);
                    }

                }
                return rows;
            }
        }

        private static DataTable loadSheetData3(string nameSheet)
        {
            getContext();

            bool hasHeader = true;
            DataTable tbl = new DataTable();
            using (var package = new ExcelPackage(new FileInfo(pathExcel)))
            {
                var ws = package.Workbook.Worksheets[nameSheet];
                int numRows = ws.Dimension.End.Row;

                foreach (var firstRowCell in ws.Cells[1, 1, 1, ws.Dimension.End.Column])
                {
                    tbl.Columns.Add(hasHeader ? firstRowCell.Text : string.Format("Column {0}", firstRowCell.Start.Column));
                }
                var startRow = hasHeader ? 2 : 1;
                for (int rowNum = startRow; rowNum <= ws.Dimension.End.Row; rowNum++)
                {
                    var wsRow = ws.Cells[rowNum, 1, rowNum, ws.Dimension.End.Column];
                    DataRow row = tbl.Rows.Add();
                    foreach (var cell in wsRow)
                    {
                        row[cell.Start.Column - 1] = cell.Text;
                    }
                }

                return tbl;
            }
        }
    }
}
