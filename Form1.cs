using System;
using System.Runtime.CompilerServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelReadWrite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string filePath = "";


        private void readBtn_Click(object sender, EventArgs e)
        {
            readData();
        }

        private void readData()
        {
            //string filePath = "C:\\Users\\Matt\\OneDrive\\Documents\\PC Parts.xlsx";
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

        private void openFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filePath = (ofd.FileName);
                filePathText.Text = ofd.FileName;
            }
        }
    }
}