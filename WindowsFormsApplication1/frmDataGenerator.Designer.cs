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
            this.ofdOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pbrProgress = new System.Windows.Forms.ProgressBar();
            this.grpControls = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDependents = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaxRows = new System.Windows.Forms.TextBox();
            this.chkShouldBeNewValue = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGenerateData = new System.Windows.Forms.Button();
            this.txtPossibleValues = new System.Windows.Forms.TextBox();
            this.chkCanBeEmpty = new System.Windows.Forms.CheckBox();
            this.txtDatatype = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboSheets = new System.Windows.Forms.ComboBox();
            this.btnLoadSheets = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFilepath = new System.Windows.Forms.TextBox();
            this.grdData = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.grpControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.SuspendLayout();
            // 
            // ofdOpenFileDialog
            // 
            this.ofdOpenFileDialog.FileName = "openFileDialog1";
            // 
            // pbrProgress
            // 
            this.pbrProgress.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbrProgress.Location = new System.Drawing.Point(0, 0);
            this.pbrProgress.Name = "pbrProgress";
            this.pbrProgress.Size = new System.Drawing.Size(896, 23);
            this.pbrProgress.TabIndex = 35;
            // 
            // grpControls
            // 
            this.grpControls.Controls.Add(this.label9);
            this.grpControls.Controls.Add(this.txtMax);
            this.grpControls.Controls.Add(this.label8);
            this.grpControls.Controls.Add(this.txtMin);
            this.grpControls.Controls.Add(this.btnSave);
            this.grpControls.Controls.Add(this.label7);
            this.grpControls.Controls.Add(this.txtLength);
            this.grpControls.Controls.Add(this.label6);
            this.grpControls.Controls.Add(this.txtDependents);
            this.grpControls.Controls.Add(this.btnStop);
            this.grpControls.Controls.Add(this.label5);
            this.grpControls.Controls.Add(this.txtMaxRows);
            this.grpControls.Controls.Add(this.chkShouldBeNewValue);
            this.grpControls.Controls.Add(this.label4);
            this.grpControls.Controls.Add(this.btnGenerateData);
            this.grpControls.Controls.Add(this.txtPossibleValues);
            this.grpControls.Controls.Add(this.chkCanBeEmpty);
            this.grpControls.Controls.Add(this.txtDatatype);
            this.grpControls.Controls.Add(this.label3);
            this.grpControls.Controls.Add(this.btnLoadData);
            this.grpControls.Controls.Add(this.label2);
            this.grpControls.Controls.Add(this.cboSheets);
            this.grpControls.Controls.Add(this.btnLoadSheets);
            this.grpControls.Controls.Add(this.label1);
            this.grpControls.Controls.Add(this.btnBrowse);
            this.grpControls.Controls.Add(this.txtFilepath);
            this.grpControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpControls.Location = new System.Drawing.Point(0, 23);
            this.grpControls.Name = "grpControls";
            this.grpControls.Size = new System.Drawing.Size(896, 160);
            this.grpControls.TabIndex = 36;
            this.grpControls.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(769, 126);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 23);
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = "Save to File";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(284, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Length:";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(362, 130);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(51, 20);
            this.txtLength.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Dependents:";
            // 
            // txtDependents
            // 
            this.txtDependents.Location = new System.Drawing.Point(362, 107);
            this.txtDependents.Name = "txtDependents";
            this.txtDependents.Size = new System.Drawing.Size(314, 20);
            this.txtDependents.TabIndex = 37;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(769, 97);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(115, 23);
            this.btnStop.TabIndex = 36;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(742, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Number of Rows To Append:";
            // 
            // txtMaxRows
            // 
            this.txtMaxRows.Location = new System.Drawing.Point(827, 47);
            this.txtMaxRows.Name = "txtMaxRows";
            this.txtMaxRows.Size = new System.Drawing.Size(57, 20);
            this.txtMaxRows.TabIndex = 34;
            this.txtMaxRows.Text = "10";
            // 
            // chkShouldBeNewValue
            // 
            this.chkShouldBeNewValue.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkShouldBeNewValue.Location = new System.Drawing.Point(129, 103);
            this.chkShouldBeNewValue.Name = "chkShouldBeNewValue";
            this.chkShouldBeNewValue.Size = new System.Drawing.Size(138, 34);
            this.chkShouldBeNewValue.TabIndex = 33;
            this.chkShouldBeNewValue.Text = "Should be New value?:";
            this.chkShouldBeNewValue.UseVisualStyleBackColor = true;
            this.chkShouldBeNewValue.CheckedChanged += new System.EventHandler(this.chkShouldBeId_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(283, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 42);
            this.label4.TabIndex = 32;
            this.label4.Text = "Enumerated Values:";
            // 
            // btnGenerateData
            // 
            this.btnGenerateData.Location = new System.Drawing.Point(769, 68);
            this.btnGenerateData.Name = "btnGenerateData";
            this.btnGenerateData.Size = new System.Drawing.Size(115, 23);
            this.btnGenerateData.TabIndex = 31;
            this.btnGenerateData.Text = "Generate Data";
            this.btnGenerateData.UseVisualStyleBackColor = true;
            this.btnGenerateData.Click += new System.EventHandler(this.btnGenerateData_Click);
            // 
            // txtPossibleValues
            // 
            this.txtPossibleValues.Location = new System.Drawing.Point(362, 82);
            this.txtPossibleValues.Name = "txtPossibleValues";
            this.txtPossibleValues.Size = new System.Drawing.Size(314, 20);
            this.txtPossibleValues.TabIndex = 30;
            // 
            // chkCanBeEmpty
            // 
            this.chkCanBeEmpty.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkCanBeEmpty.Location = new System.Drawing.Point(29, 110);
            this.chkCanBeEmpty.Name = "chkCanBeEmpty";
            this.chkCanBeEmpty.Size = new System.Drawing.Size(94, 17);
            this.chkCanBeEmpty.TabIndex = 29;
            this.chkCanBeEmpty.Text = "Can Be Empty";
            this.chkCanBeEmpty.UseVisualStyleBackColor = true;
            // 
            // txtDatatype
            // 
            this.txtDatatype.Location = new System.Drawing.Point(107, 82);
            this.txtDatatype.Name = "txtDatatype";
            this.txtDatatype.Size = new System.Drawing.Size(160, 20);
            this.txtDatatype.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Datatype:";
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(586, 47);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(131, 23);
            this.btnLoadData.TabIndex = 26;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Worksheets:";
            // 
            // cboSheets
            // 
            this.cboSheets.FormattingEnabled = true;
            this.cboSheets.Location = new System.Drawing.Point(432, 49);
            this.cboSheets.Name = "cboSheets";
            this.cboSheets.Size = new System.Drawing.Size(121, 21);
            this.cboSheets.TabIndex = 24;
            // 
            // btnLoadSheets
            // 
            this.btnLoadSheets.Location = new System.Drawing.Point(586, 17);
            this.btnLoadSheets.Name = "btnLoadSheets";
            this.btnLoadSheets.Size = new System.Drawing.Size(131, 23);
            this.btnLoadSheets.TabIndex = 23;
            this.btnLoadSheets.Text = "Load Worksheets";
            this.btnLoadSheets.UseVisualStyleBackColor = true;
            this.btnLoadSheets.Click += new System.EventHandler(this.btnLoadSheets_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "File path:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(504, 23);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(49, 20);
            this.btnBrowse.TabIndex = 21;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            // 
            // txtFilepath
            // 
            this.txtFilepath.Location = new System.Drawing.Point(107, 23);
            this.txtFilepath.Name = "txtFilepath";
            this.txtFilepath.Size = new System.Drawing.Size(391, 20);
            this.txtFilepath.TabIndex = 20;
            this.txtFilepath.Text = "C:\\Users\\mayur\\Documents\\Candidate List  - SWAG 1177.xlsx";
            // 
            // grdData
            // 
            this.grdData.AllowUserToAddRows = false;
            this.grdData.AllowUserToDeleteRows = false;
            this.grdData.AllowUserToResizeRows = false;
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdData.Location = new System.Drawing.Point(0, 183);
            this.grdData.Name = "grdData";
            this.grdData.Size = new System.Drawing.Size(896, 317);
            this.grdData.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(420, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Min:";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(469, 131);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(51, 20);
            this.txtMin.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(525, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "Max:";
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(574, 133);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(51, 20);
            this.txtMax.TabIndex = 44;
            // 
            // frmDataGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 500);
            this.Controls.Add(this.grdData);
            this.Controls.Add(this.grpControls);
            this.Controls.Add(this.pbrProgress);
            this.Name = "frmDataGenerator";
            this.Text = "Data Generator";
            this.grpControls.ResumeLayout(false);
            this.grpControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdOpenFileDialog;
        private System.Windows.Forms.ProgressBar pbrProgress;
        private System.Windows.Forms.GroupBox grpControls;
        private System.Windows.Forms.CheckBox chkShouldBeNewValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGenerateData;
        private System.Windows.Forms.TextBox txtPossibleValues;
        private System.Windows.Forms.CheckBox chkCanBeEmpty;
        private System.Windows.Forms.TextBox txtDatatype;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboSheets;
        private System.Windows.Forms.Button btnLoadSheets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFilepath;
        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.TextBox txtMaxRows;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtDependents;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMax;
    }
}