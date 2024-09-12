using System;
using System.IO;
using OfficeOpenXml;

class Program
{
	static void Main()
	{
		Console.WriteLine("Please paste the path excel file");
		var path = Console.ReadLine();
		// Specify the path to your Excel file
		var filePath = @$"{path}";

		// Load the Excel file
		FileInfo fileInfo = new FileInfo(filePath);

		// Ensure the EPPlus License context is non-commercial
		ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

		using (ExcelPackage package = new ExcelPackage(fileInfo))
		{
			// Get the first worksheet
			ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

			// Loop through the rows and columns to get the data
			int rows = worksheet.Dimension.Rows;
			int columns = worksheet.Dimension.Columns;

			for (int i = 1; i <= rows; i++)
			{
				for (int j = 1; j <= columns; j++)
				{
					// Get the cell value
					var cellValue = worksheet.Cells[i, j].Value;
					Console.Write($"{cellValue}\t");
				}
				Console.WriteLine();
			}
		}

		Console.ReadLine();	
	}
}