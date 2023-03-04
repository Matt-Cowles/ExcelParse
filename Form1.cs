using System;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelReadWrite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void readBtn_Click(object sender, EventArgs e)
        {
            readFile();
        }

        private void readFile()
        {
            string filePath = "C:\\Users\\Matt\\OneDrive\\Documents\\PC Parts.xlsx";
            Excel.Application excel = new Excel.Application();
            Excel.Workbook wb;
            Excel.Worksheet ws;

            wb = excel.Workbooks.Open(filePath);
            ws = wb.Worksheets[1];

            object cell = ws.Cells[1,1].Value;

            try
            {
                MessageBox.Show(Convert.ToString(cell));
            } 
            catch
            {
                wb.Close(filePath);
            }

            wb.Close(filePath);
        }

        private void writeData()
        {

        }
    }
}