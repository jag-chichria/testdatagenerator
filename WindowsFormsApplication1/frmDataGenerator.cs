using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmDataGenerator : Form
    {
        DataTable dtSourceData = new DataTable();
        IDictionary<int, ColumnAttribute> columnAttributeStore = null;
        bool loadingData = false;
        public frmDataGenerator()
        {
            InitializeComponent();
            grdData.CellClick += grdData_CellClick;
            grdData.CellEnter += grdData_CellEnter;
            txtDependents.LostFocus += txtDependents_LostFocus;
            txtLength.LostFocus += txtLength_LostFocus;
            txtMin.LostFocus += txtMin_LostFocus;
            txtMax.LostFocus += txtMax_LostFocus;
        }

        void txtMax_LostFocus(object sender, EventArgs e)
        {
            ColumnAttribute columnAttribute = columnAttributeStore.ContainsKey(activeColumn) ?
               columnAttributeStore[activeColumn] : getColumnType(activeColumn, grdData.Rows.Count > 100 ? 100 : grdData.Rows.Count - 2);

            columnAttribute.Range.Max = Convert.ToDouble(txtMax.Text);
            columnAttributeStore[activeColumn] = columnAttribute;
        }

        void txtMin_LostFocus(object sender, EventArgs e)
        {
            ColumnAttribute columnAttribute = columnAttributeStore.ContainsKey(activeColumn) ?
              columnAttributeStore[activeColumn] : getColumnType(activeColumn, grdData.Rows.Count > 100 ? 100 : grdData.Rows.Count - 2);

            columnAttribute.Range.Min = Convert.ToDouble(txtMin.Text);
            columnAttributeStore[activeColumn] = columnAttribute;
        }

        void txtLength_LostFocus(object sender, EventArgs e)
        {
            ColumnAttribute columnAttribute = columnAttributeStore.ContainsKey(activeColumn) ?
               columnAttributeStore[activeColumn] : getColumnType(activeColumn, grdData.Rows.Count > 100 ? 100 : grdData.Rows.Count - 2);

            columnAttribute.Length = Convert.ToInt32(txtLength.Text);
            columnAttributeStore[activeColumn] = columnAttribute;
        }

        void txtDependents_LostFocus(object sender, EventArgs e)
        {
            ColumnAttribute columnAttribute = columnAttributeStore.ContainsKey(activeColumn) ?
               columnAttributeStore[activeColumn] : getColumnType(activeColumn, grdData.Rows.Count > 100 ? 100 : grdData.Rows.Count - 2);

            columnAttribute.Dependents = txtDependents.Text.Trim().Split(',');
            columnAttributeStore[activeColumn] = columnAttribute;
        }

        void grdData_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (loadingData) { return; }
            activeColumn = e.ColumnIndex;
            ShowDataOnCellFocus(activeColumn);
        }

        void grdData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (loadingData) { return; }
            activeColumn = e.ColumnIndex;
            ShowDataOnCellFocus(activeColumn);
        }


        void ShowDataOnCellFocus(int activeColumn)
        {
            ColumnAttribute columnAttribute = columnAttributeStore.ContainsKey(activeColumn) ?
                columnAttributeStore[activeColumn] : getColumnType(activeColumn, grdData.Rows.Count > 100 ? 100 : grdData.Rows.Count - 2);

            if (!columnAttributeStore.ContainsKey(activeColumn))
            { columnAttributeStore.Add(activeColumn, columnAttribute); }

            txtDatatype.Text = columnAttribute.Datatype;
            txtLength.Text = columnAttribute.Length.ToString();
            chkCanBeEmpty.Checked = columnAttribute.CanBeEmpty;
            txtPossibleValues.Text = String.Join(",", columnAttribute.EnumeratedValues.ToArray());
            chkShouldBeNewValue.Checked = columnAttribute.ShouldBeNewValue;
            txtDependents.Text = String.Join(",", columnAttribute.Dependents);
            txtMin.Text = columnAttribute.Range.Min.ToString();
            txtMax.Text = columnAttribute.Range.Max.ToString();
        }

        ColumnAttribute getColumnType(int column, int sampleRows)
        {
            string columnType = null;
            bool isAnyValueEmpty = false;
            List<string> lstEnumeratedValues = new List<string>();
            List<string> possibleValues = new List<string>();
            for (int rowNumber = 0; rowNumber <= sampleRows; rowNumber++)
            {
                DataGridViewRow row = grdData.Rows[rowNumber];
                string value = row.Cells[column].Value.ToString();
                decimal n;
                bool isNumeric = decimal.TryParse(value, out n);
                if (isNumeric && (columnType == "Number" || columnType == null)) { columnType = "Number"; }
                DateTime tempDate;
                bool isDate = DateTime.TryParse(value, out tempDate);
                if (isDate && (columnType == "Date" || columnType == null)) { columnType = "Date"; }
                if (!isAnyValueEmpty) { isAnyValueEmpty = String.IsNullOrEmpty(value); }
                if (!lstEnumeratedValues.Contains(value) && !String.IsNullOrEmpty(value)) { lstEnumeratedValues.Add(value); }
            }

            return new ColumnAttribute()
            {
                EnumeratedValues = lstEnumeratedValues,
                CanBeEmpty = isAnyValueEmpty,
                Datatype = columnType ?? "String",
            };
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = ofdOpenFileDialog.ShowDialog();
            txtFilepath.Text = ofdOpenFileDialog.FileName;
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            this.LoadData(txtFilepath.Text, cboSheets.Text);
            for (int iCounter = 0; iCounter <= grdData.Columns.Count - 1; iCounter++)
            {
                this.ShowDataOnCellFocus(iCounter);
            }
        }

        void LoadData(string filepath, string sheetName)
        {
            loadingData = true;
            columnAttributeStore = new Dictionary<int, ColumnAttribute>();
            System.Data.OleDb.OleDbConnection MyConnection;
            System.Data.OleDb.OleDbDataAdapter MyCommand;
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=1\"";
            MyConnection = new System.Data.OleDb.OleDbConnection(String.Format(connectionString, filepath));
            dtSourceData = new DataTable();
            MyConnection.Open();
            MyCommand = new System.Data.OleDb.OleDbDataAdapter(string.Format(@"select * from [{0}]", sheetName), MyConnection);
            MyConnection.Close();
            MyCommand.Fill(dtSourceData);
            grdData.DataSource = dtSourceData;
            loadingData = false;
        }

        void LoadSchema(string filepath)
        {
            System.Data.OleDb.OleDbConnection MyConnection;
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=1\"";
            MyConnection = new System.Data.OleDb.OleDbConnection(String.Format(connectionString, filepath));

            MyConnection.Open();
            DataTable dtExcel;
            dtExcel = MyConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables, null);
            MyConnection.Close();
            cboSheets.DisplayMember = "TABLE_NAME";
            cboSheets.DataSource = dtExcel;
        }

        private void btnLoadSheets_Click(object sender, EventArgs e)
        {
            this.LoadSchema(txtFilepath.Text);
        }

        private void btnGenerateData_Click(object sender, EventArgs e)
        {
            grdData.DataSource = null;

            this.SavePreloaded();

            int numberOfRowsToAppend = Convert.ToInt32(txtMaxRows.Text);
            pbrProgress.Maximum = numberOfRowsToAppend;

            for (int rowAdd = 1; rowAdd <= numberOfRowsToAppend; rowAdd++)
            {
                //Thread.Sleep(500);
                pbrProgress.Value = rowAdd; Application.DoEvents();

                DataRow row = dtSourceData.Rows[new Random().Next(1, dtSourceData.Rows.Count)];
                FileIO.SaveRow(row.Duplicate(dtSourceData, columnAttributeStore));

                if (stopAppending) { stopAppending = false; break; }
            }

            grdData.DataSource = dtSourceData;

        }

        private void chkShouldBeId_CheckedChanged(object sender, EventArgs e)
        {
            ColumnAttribute columnAttribute = columnAttributeStore.ContainsKey(activeColumn) ?
                columnAttributeStore[activeColumn] : getColumnType(activeColumn, grdData.Rows.Count > 100 ? 100 : grdData.Rows.Count - 2);

            columnAttribute.ShouldBeNewValue = chkShouldBeNewValue.Checked;
            columnAttributeStore[activeColumn] = columnAttribute;
        }
        int activeColumn = 0;
        bool stopAppending = false;

        private void btnStop_Click(object sender, EventArgs e)
        {
            stopAppending = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.SavePreloaded();
        }
        void SavePreloaded()
        {
            IEnumerable<string> columnNames = dtSourceData.Columns.Cast<DataColumn>().
                                  Select(column => column.ColumnName);
            FileIO.AddHeader(columnNames);
            foreach (DataRow row in dtSourceData.Rows)
            {
                FileIO.SaveRow(row);
            }
        }




    }
    public static class FileIO
    {
        private static string fileName;
        private static void SaveToFile(StringBuilder sb)
        {
            File.AppendAllText(fileName, sb.ToString());
        }
        public static void AddHeader(IEnumerable<string> columnNames)
        {
            fileName = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\" + DateTime.Now.Ticks.ToString() + ".csv";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Join(",", columnNames));
            SaveToFile(sb);
        }
        public static void SaveRow(DataRow row)
        {
            StringBuilder sb = new StringBuilder();
            IEnumerable<string> fields = row.ItemArray.Select(field =>
                    string.Concat("\"", field.ToString().Replace("\"", "\"\""), "\""));
            sb.AppendLine(string.Join(",", fields));
            SaveToFile(sb);
        }
    }

    public class ColumnAttribute
    {
        public ColumnAttribute()
        {
            Dependents = new string[0];
            Range = new Range(0, 0);
        }
        public string NewValue(int length)
        {
            double minValue = Range.Min > 0 ? Range.Min : Convert.ToDouble(EnumeratedValues.Min());
            double seedValue = Range.Max > 0 ? Range.Max : Convert.ToDouble(EnumeratedValues.Max());
            double newValue = new Random().NextDouble() * ((seedValue - minValue) + minValue) + new DateTime().Ticks;
            string formatValue = newValue.ToString(new String('#', length));
            if (formatValue.Length < length) { formatValue += new Random().Next(1, 9); }
            return formatValue;
        }

        public bool HasDependent { get { return Dependents.Length > 0; } }
        public string[] Dependents { get; set; }
        public bool CanBeEmpty { get; set; }
        public string Datatype { get; set; }
        public IEnumerable<string> EnumeratedValues { get; set; }
        public bool ShouldBeNewValue { get; set; }
        public bool CanBeIdentifer { get { return !EnumeratedValues.Contains(String.Empty); } }
        public Range Range { get; set; }
        public int Length { get; set; }

    }

    public class Range
    {
        public Range(double min, double max) { this.Min = min; this.Max = max; }
        public double Min { get; set; }
        public double Max { get; set; }
    }

    public static class DataRowExtension
    {
        public static DataRow Duplicate(this DataRow row, DataTable table, IDictionary<int, ColumnAttribute> columnAttributeStore)
        {
            DataRow newRow = table.NewRow();

            foreach (DataColumn column in table.Columns)
            {
                ColumnAttribute columnAttribute = columnAttributeStore[column.Ordinal];
                if (columnAttribute.ShouldBeNewValue)
                {
                    newRow[column] = columnAttribute.NewValue(columnAttribute.Length);
                    if (columnAttribute.HasDependent)
                    {
                        foreach (string s in columnAttribute.Dependents)
                        {
                            if (!String.IsNullOrEmpty(s)) { newRow[s] = newRow[column].ToString() + (new Random().Next(1, 9).ToString()); }
                        }
                    }

                }
                else
                {
                    newRow[column] = row[column];
                }
            }

            return newRow;
        }
    }
}
