namespace WindowsFormsApplication1
{
    partial class frmDataGenerator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstFields = new System.Windows.Forms.ListBox();
            this.txtFilepath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoadSheets = new System.Windows.Forms.Button();
            this.cboSheets = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtColumns = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cboDataType = new System.Windows.Forms.ComboBox();
            this.chkIsNullable = new System.Windows.Forms.CheckBox();
            this.txtRange = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSaveSchema = new System.Windows.Forms.Button();
            this.ofdOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lstFields
            // 
            this.lstFields.FormattingEnabled = true;
            this.lstFields.Location = new System.Drawing.Point(36, 122);
            this.lstFields.Name = "lstFields";
            this.lstFields.Size = new System.Drawing.Size(206, 238);
            this.lstFields.TabIndex = 0;
            // 
            // txtFilepath
            // 
            this.txtFilepath.Location = new System.Drawing.Point(85, 12);
            this.txtFilepath.Name = "txtFilepath";
            this.txtFilepath.Size = new System.Drawing.Size(391, 20);
            this.txtFilepath.TabIndex = 1;
            this.txtFilepath.Text = "C:\\Users\\mayur\\Documents\\Candidate List  - SWAG 1177 (1).xlsx";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(482, 12);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(49, 20);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "File path:";
            // 
            // btnLoadSheets
            // 
            this.btnLoadSheets.Location = new System.Drawing.Point(85, 39);
            this.btnLoadSheets.Name = "btnLoadSheets";
            this.btnLoadSheets.Size = new System.Drawing.Size(131, 23);
            this.btnLoadSheets.TabIndex = 4;
            this.btnLoadSheets.Text = "Load Worksheets";
            this.btnLoadSheets.UseVisualStyleBackColor = true;
            this.btnLoadSheets.Click += new System.EventHandler(this.btnLoadSheets_Click);
            // 
            // cboSheets
            // 
            this.cboSheets.FormattingEnabled = true;
            this.cboSheets.Location = new System.Drawing.Point(307, 40);
            this.cboSheets.Name = "cboSheets";
            this.cboSheets.Size = new System.Drawing.Size(121, 21);
            this.cboSheets.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Worksheets:";
            // 
            // txtColumns
            // 
            this.txtColumns.Location = new System.Drawing.Point(470, 39);
            this.txtColumns.Name = "txtColumns";
            this.txtColumns.Size = new System.Drawing.Size(67, 20);
            this.txtColumns.TabIndex = 7;
            this.txtColumns.Text = "58";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(434, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cols:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(550, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Rows:";
            // 
            // txtRows
            // 
            this.txtRows.Location = new System.Drawing.Point(586, 39);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(67, 20);
            this.txtRows.TabIndex = 9;
            this.txtRows.Text = "10";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(437, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "Load Schema from Selected Worksheet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "DataType";
            // 
            // cboDataType
            // 
            this.cboDataType.FormattingEnabled = true;
            this.cboDataType.Items.AddRange(new object[] {
            "Integer",
            "Date",
            "String"});
            this.cboDataType.Location = new System.Drawing.Point(343, 122);
            this.cboDataType.Name = "cboDataType";
            this.cboDataType.Size = new System.Drawing.Size(213, 21);
            this.cboDataType.TabIndex = 12;
            // 
            // chkIsNullable
            // 
            this.chkIsNullable.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkIsNullable.Location = new System.Drawing.Point(270, 158);
            this.chkIsNullable.Name = "chkIsNullable";
            this.chkIsNullable.Size = new System.Drawing.Size(91, 24);
            this.chkIsNullable.TabIndex = 14;
            this.chkIsNullable.Text = "Is Nullable";
            this.chkIsNullable.UseVisualStyleBackColor = true;
            // 
            // txtRange
            // 
            this.txtRange.Location = new System.Drawing.Point(343, 188);
            this.txtRange.Name = "txtRange";
            this.txtRange.Size = new System.Drawing.Size(100, 20);
            this.txtRange.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(270, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Range:";
            // 
            // btnSaveSchema
            // 
            this.btnSaveSchema.Location = new System.Drawing.Point(522, 316);
            this.btnSaveSchema.Name = "btnSaveSchema";
            this.btnSaveSchema.Size = new System.Drawing.Size(131, 23);
            this.btnSaveSchema.TabIndex = 17;
            this.btnSaveSchema.Text = "Save Schema";
            this.btnSaveSchema.UseVisualStyleBackColor = true;
            // 
            // ofdOpenFileDialog
            // 
            this.ofdOpenFileDialog.FileName = "openFileDialog1";
            // 
            // frmDataGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 443);
            this.Controls.Add(this.btnSaveSchema);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRange);
            this.Controls.Add(this.chkIsNullable);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboDataType);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRows);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtColumns);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboSheets);
            this.Controls.Add(this.btnLoadSheets);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFilepath);
            this.Controls.Add(this.lstFields);
            this.Name = "frmDataGenerator";
            this.Text = "Data Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstFields;
        private System.Windows.Forms.TextBox txtFilepath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoadSheets;
        private System.Windows.Forms.ComboBox cboSheets;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtColumns;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboDataType;
        private System.Windows.Forms.CheckBox chkIsNullable;
        private System.Windows.Forms.TextBox txtRange;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSaveSchema;
        private System.Windows.Forms.OpenFileDialog ofdOpenFileDialog;
    }
}

