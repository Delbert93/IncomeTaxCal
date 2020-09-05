using IncomeTaxCal;
using Microsoft.Win32;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPFIncome
{
    public interface IFileProvider
    {
        public bool FileExists(string path);
        public IEnumerable<IncomeTaxCalFinder> ReadParametersFromExcel(string path);
        public Task<IEnumerable<IncomeTaxCalFinder>> ReadParametersFromExcelAsync(string path);
        public void ExportToExcel(IEnumerable<IncomeTaxCalFinder> history);
    }

    public class RealFileProvider : IFileProvider
    {
        public bool FileExists(string path) => File.Exists(path);

        public IEnumerable<IncomeTaxCalFinder> ReadParametersFromExcel(string path)
        {
            var rows = new List<IncomeTaxCalFinder>();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
            {
                var sheet = package.Workbook.Worksheets.First();
                for (int row = 2; row <= sheet.Dimension.End.Row; row++)
                {
                    rows.Add(new IncomeTaxCalFinder
                    {
                        Income = (decimal)(double)sheet.Cells[row, 1].Value,
                        State = (string)sheet.Cells[row, 2].Value
                    });
                }
            }
            return rows;
        }

        public async Task<IEnumerable<IncomeTaxCalFinder>> ReadParametersFromExcelAsync(string path)
        {
            return await Task.Run(() =>
            {
                var rows = new List<IncomeTaxCalFinder>();
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
                {
                    var sheet = package.Workbook.Worksheets.First();
                    for (int row = 2; row <= sheet.Dimension.End.Row; row++)
                    {
                        rows.Add(new IncomeTaxCalFinder
                        {
                            Income = (decimal)(double)sheet.Cells[row, 1].Value,
                            State = (string)sheet.Cells[row, 2].Value
                        });
                    }
                }
                return rows;
            });
        }

        public void ExportToExcel(IEnumerable<IncomeTaxCalFinder> history)
        {
            var fileName = getFileName();
            if (fileName == null)
                return;

            if (File.Exists(fileName))
            {
                var result = MessageBox.Show("File already exists, overwrite?", "Overwrite Existing?", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                    File.Delete(fileName);
                else
                    return;
            }

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage package = new ExcelPackage(new FileInfo(fileName)))
            {
                var sheet = package.Workbook.Worksheets.Add("Export");
                sheet.Cells[1, 1].Value = "Income Amount";
                sheet.Cells[1, 2].Value = "State";
                sheet.Cells[1, 3].Value = "Tax Bracket";
                sheet.Cells[1, 4].Value = "New Income Amount";

                var row = 1;
                foreach (var calc in history)
                {
                    row++;
                    sheet.Cells[row, 1].Value = calc.Income;
                    sheet.Cells[row, 2].Value = calc.State;
                    sheet.Cells[row, 3].Value = calc.TaxPercentage;
                    sheet.Cells[row, 4].Value = calc.NewIncome;
                }

                sheet.Tables.Add(sheet.Cells[1, 1, row, 4], "ExcelTable");

                var currencyFormat = "_ $* #,##0.00_-;$* #,##0.00_-;_$* \"-\"??_-;_-@_-";
                sheet.Column(1).Style.Numberformat.Format = currencyFormat;
                sheet.Column(2).Style.Numberformat.Format = "0.000%";
                sheet.Column(4).Style.Numberformat.Format = currencyFormat;

                sheet.Column(1).Width = 18;
                sheet.Column(2).Width = 8;
                sheet.Column(3).Width = 18;
                sheet.Column(4).Width = 25;

                package.Save();
            }

            new Process
            {
                StartInfo = new ProcessStartInfo(fileName)
                {
                    UseShellExecute = true
                }
            }.Start();
        }

        public string getFileName()
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
            openFileDialog.Title = "Locate Excel Output File";
            openFileDialog.CheckFileExists = false;
            openFileDialog.Multiselect = false;
            if(openFileDialog.ShowDialog() ?? false)
            {
                return openFileDialog.FileName;
            }
            return null;
        }
    }
}
