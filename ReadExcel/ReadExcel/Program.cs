using System;
using System.Data;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using ExcelDataReader;
using OfficeOpenXml;

class Program
{
    static void Main(string[] args)
    {
        //UsingClosedXML();
        //UsingCSV();
        //UsingEPPlus();
        UsingExcelDataReader();
    }

    private static void UsingClosedXML()
    {
        // Need to use Nuget to intall ClosedXML
        // Specify the path to your Excel file
        string filePath = @".\Employees.xlsx";

        // Open the workbook and select the first worksheet
        using (var workbook = new XLWorkbook(filePath))
        {
            var worksheet = workbook.Worksheet(1); // Assuming the data is on the first sheet

            // Get the used range of the worksheet
            var rows = worksheet.RangeUsed().RowsUsed();

            // Iterate through each row
            foreach (var row in rows)
            {
                // Loop through each cell in the row
                foreach (var cell in row.Cells())
                {
                    string tabs = "\t";
                    // Print the cell value
                    if (cell.GetValue<string>().Count() < 9)
                    {
                        tabs += "\t";
                    }
                    Console.Write(cell.GetValue<string>() + tabs);
                }

                Console.WriteLine(); // New line after each row
            }
        }
        Console.WriteLine("Press any Key to Continue.");
        Console.ReadKey();
    }

    private static void UsingCSV()
    {
        // Specify the path to your CSV file
        string filePath = @".\Employees.csv";

        // Open the file and read each line
        using (var reader = new StreamReader(filePath))
        {
            // Read the file line by line
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();

                // Split the line into columns (assuming comma is the delimiter)
                var values = line.Split(',');

                // Print each value in the row, separated by tabs
                foreach (var value in values)
                {
                    Console.Write(value + "\t");
                }

                Console.WriteLine(); // Move to the next line after each row
            }
        }
        Console.WriteLine("Press any Key to Continue.");
        Console.ReadKey();
    }

    private static void UsingEPPlus()
    {
        // Need to use Nuget to intall EPPlus (also needs a licence for commercial use)
        // Specify the path to your Excel file
        string filePath = @"Employees.xlsx";

        // Load the Excel file
        FileInfo fileInfo = new FileInfo(filePath);

        // Ensure that EPPlus works with non-commercial use, if applicable
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

        using (ExcelPackage package = new ExcelPackage(fileInfo))
        {
            // Get the first worksheet in the Excel file
            ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

            // Get the number of rows and columns
            int rowCount = worksheet.Dimension.Rows;
            int colCount = worksheet.Dimension.Columns;

            // Iterate through the rows and columns to read data
            for (int row = 1; row <= rowCount; row++)
            {
                for (int col = 1; col <= colCount; col++)
                {
                    string tabs = "\t";
                    // Print the cell value
                    if (worksheet.Cells[row, col].Text.Count() < 9)
                    {
                        tabs += "\t";
                    }
                    Console.Write(worksheet.Cells[row, col].Text + tabs);
                }
                Console.WriteLine(); // New line after each row
            }
        }
        Console.WriteLine("Press any Key to Quit.");
        Console.ReadKey();
    }

    private static void UsingExcelDataReader()
    {
        // Need to use Nuget to intall ExcelDataReader and ExcelDataReader.DataSet
        // Path to the Excel file
        string filePath = @"Employees.xlsx";

        // Ensure the ExcelDataReader configuration works with the proper encoding system
        System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

        // Open the Excel file as a stream
        using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
        {
            // Create the ExcelDataReader
            using (var reader = ExcelReaderFactory.CreateReader(stream))
            {
                // Read the Excel file into a DataSet (you can treat it like a database table)
                var result = reader.AsDataSet();

                // Iterate through each DataTable (each worksheet in the Excel file)
                foreach (DataTable table in result.Tables)
                {
                    Console.WriteLine($"Sheet: {table.TableName}");

                    // Iterate through each row in the table
                    foreach (DataRow row in table.Rows)
                    {
                        // Iterate through each column in the row
                        foreach (var cell in row.ItemArray)
                        {
                            string tabs = "\t";
                            // Print the cell value
                            if (cell is double || (cell is string && ((string)cell).Count() < 9))
                            {
                                tabs += "\t";
                            }
                            Console.Write(cell + tabs);
                        }
                        Console.WriteLine(); // New line after each row
                    }

                    Console.WriteLine(); // Extra line between sheets
                }
            }
        }

        Console.WriteLine("Press any Key to Quit.");
        Console.ReadKey();
    }
}
