using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    
    public partial class frmDataGenerator : Form
    {
        Microsoft.Office.Interop.Excel.Application xlApp = null;
        Microsoft.Office.Interop.Excel.Workbook xlWorkBook = null;
        Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet = null;
        int iColumns, totalWorksheets;
        string[] arrColumnDatatype, arrIsNullable;

        void loadWorkbook(string xlFile)
        {
            try
            {
                xlApp = new Microsoft.Office.Interop.Excel.Application();
                xlWorkBook = xlApp.Workbooks.Open(xlFile);
            }
            catch (Exception ex)
            { }
        }

        void loadWorksheets()
        {
            totalWorksheets = xlApp.Worksheets.Count;
            cboSheets.Items.Clear();

            for (int loopCounter = 1; loopCounter <= totalWorksheets; loopCounter++)
            {
                cboSheets.Items.Add(xlWorkBook.Sheets[loopCounter].Name);
            }
        }

        void loadDataFromWorksheet(string worksheet)
        {
            lstFields.Items.Clear();
            xlWorkSheet = xlWorkBook.Sheets[worksheet];
            iColumns = Convert.ToInt32(txtColumns.Text);

            arrColumnDatatype = new string[iColumns];
            arrIsNullable = new string[iColumns];

            for (int loopCounter = 1; loopCounter <= iColumns; loopCounter++)
            {
                lstFields.Items.Add(xlWorkSheet.Cells[1, loopCounter].Value);                
            }
        }

       

        public frmDataGenerator()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = ofdOpenFileDialog.ShowDialog();
            txtFilepath.Text = ofdOpenFileDialog.FileName;


        }

        private void btnLoadSheets_Click(object sender, EventArgs e)
        {
            this.loadWorkbook(txtFilepath.Text);
            this.loadWorksheets();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.loadDataFromWorksheet(cboSheets.Text);
        }
    }
}
