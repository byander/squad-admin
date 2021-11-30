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
        static string currentPath = Directory.GetCurrentDirectory();
        static string pathExcel = Path.Combine(currentPath, "Data", "dados.xlsx");

        public string[] rules = loadRules();
        public List<string> mapsNames = loadMapsNames();
        public List<string> gameModes = loadGameMode();

        public DataTable mapLayers = loadMapLayers();

        public void loadAllData()
        {
            rules = loadRules();
            mapsNames = loadMapsNames();
            mapLayers = loadMapLayers();
            gameModes = loadGameMode();
        }

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

        private static string[] loadRules()
        {
            getContext();

            using (var package = new ExcelPackage(new FileInfo(pathExcel)))
            {
                var sheetRules = package.Workbook.Worksheets["regras"];
                int numRows = sheetRules.Dimension.End.Row;

                string[] rows = new string[numRows];
                for (int i = 0; i < numRows; i++)
                {
                    rows[i] = sheetRules.Cells[i + 1, 1].Text;
                }
                return rows;
            }
        }

        private static List<string> loadMapsNames()
        {
            getContext();

            using (var package = new ExcelPackage(new FileInfo(pathExcel)))
            {
                var sheetRules = package.Workbook.Worksheets["mapas"];
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

        private static List<string> loadGameMode()
        {
            getContext();

            using (var package = new ExcelPackage(new FileInfo(pathExcel)))
            {
                var sheetRules = package.Workbook.Worksheets["gamemode"];
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


        private static DataTable loadMapLayers()
        {
            getContext();

            bool hasHeader = true;
            DataTable tbl = new DataTable();
            using (var package = new ExcelPackage(new FileInfo(pathExcel)))
            {
                var ws = package.Workbook.Worksheets["layers"];
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
