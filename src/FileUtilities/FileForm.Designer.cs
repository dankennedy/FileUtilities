using System.Windows.Forms;

namespace FileUtilities
{
    partial class FileForm
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
            this.tcActionGroups = new System.Windows.Forms.TabControl();
            this.tabDetails = new System.Windows.Forms.TabPage();
            this.btnFileCountRows = new System.Windows.Forms.Button();
            this.txtFileRows = new System.Windows.Forms.TextBox();
            this.txtFileSize = new System.Windows.Forms.TextBox();
            this.txtFileUpdated = new System.Windows.Forms.TextBox();
            this.txtFileCreated = new System.Windows.Forms.TextBox();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.lblFileRows = new System.Windows.Forms.Label();
            this.lblFilesize = new System.Windows.Forms.Label();
            this.lblFileUpdated = new System.Windows.Forms.Label();
            this.lblFileCreated = new System.Windows.Forms.Label();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.tabByLine = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnFindByRows = new System.Windows.Forms.Button();
            this.txtFindByRowsStartRow = new System.Windows.Forms.TextBox();
            this.txtFindByRows = new System.Windows.Forms.TextBox();
            this.lblFindByRows2 = new System.Windows.Forms.Label();
            this.lblFindByRows1 = new System.Windows.Forms.Label();
            this.lblByLineFilePosition = new System.Windows.Forms.Label();
            this.btnShowRows = new System.Windows.Forms.Button();
            this.txtShowRowsFromLine = new System.Windows.Forms.TextBox();
            this.txtShowNumberOfRows = new System.Windows.Forms.TextBox();
            this.lblShowRows2 = new System.Windows.Forms.Label();
            this.lblShowRows1 = new System.Windows.Forms.Label();
            this.txtByLineResults = new System.Windows.Forms.TextBox();
            this.tabByPosition = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnFindByBytes = new System.Windows.Forms.Button();
            this.txtFindByBytesStart = new System.Windows.Forms.TextBox();
            this.txtFindByBytesCriteria = new System.Windows.Forms.TextBox();
            this.lblFindByBytes2 = new System.Windows.Forms.Label();
            this.lblFindByBytes1 = new System.Windows.Forms.Label();
            this.btnShowBytes = new System.Windows.Forms.Button();
            this.txtShowBytesStart = new System.Windows.Forms.TextBox();
            this.txtShowBytesLength = new System.Windows.Forms.TextBox();
            this.lblShowBytes2 = new System.Windows.Forms.Label();
            this.lblShowBytes1 = new System.Windows.Forms.Label();
            this.txtByBytesResult = new System.Windows.Forms.TextBox();
            this.lblWarning = new System.Windows.Forms.Label();
            this.tcActionGroups.SuspendLayout();
            this.tabDetails.SuspendLayout();
            this.tabByLine.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabByPosition.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcActionGroups
            // 
            this.tcActionGroups.Controls.Add(this.tabDetails);
            this.tcActionGroups.Controls.Add(this.tabByLine);
            this.tcActionGroups.Controls.Add(this.tabByPosition);
            this.tcActionGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcActionGroups.Location = new System.Drawing.Point(0, 0);
            this.tcActionGroups.Name = "tcActionGroups";
            this.tcActionGroups.SelectedIndex = 0;
            this.tcActionGroups.Size = new System.Drawing.Size(622, 556);
            this.tcActionGroups.TabIndex = 1;
            // 
            // tabDetails
            // 
            this.tabDetails.Controls.Add(this.lblWarning);
            this.tabDetails.Controls.Add(this.btnFileCountRows);
            this.tabDetails.Controls.Add(this.txtFileRows);
            this.tabDetails.Controls.Add(this.txtFileSize);
            this.tabDetails.Controls.Add(this.txtFileUpdated);
            this.tabDetails.Controls.Add(this.txtFileCreated);
            this.tabDetails.Controls.Add(this.txtFilePath);
            this.tabDetails.Controls.Add(this.lblFileRows);
            this.tabDetails.Controls.Add(this.lblFilesize);
            this.tabDetails.Controls.Add(this.lblFileUpdated);
            this.tabDetails.Controls.Add(this.lblFileCreated);
            this.tabDetails.Controls.Add(this.lblFilePath);
            this.tabDetails.Location = new System.Drawing.Point(4, 22);
            this.tabDetails.Name = "tabDetails";
            this.tabDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetails.Size = new System.Drawing.Size(614, 530);
            this.tabDetails.TabIndex = 0;
            this.tabDetails.Text = "Details";
            this.tabDetails.UseVisualStyleBackColor = true;
            // 
            // btnFileCountRows
            // 
            this.btnFileCountRows.Location = new System.Drawing.Point(401, 29);
            this.btnFileCountRows.Name = "btnFileCountRows";
            this.btnFileCountRows.Size = new System.Drawing.Size(75, 23);
            this.btnFileCountRows.TabIndex = 21;
            this.btnFileCountRows.Text = "&Refresh";
            this.btnFileCountRows.UseVisualStyleBackColor = true;
            // 
            // txtFileRows
            // 
            this.txtFileRows.Location = new System.Drawing.Point(300, 32);
            this.txtFileRows.Name = "txtFileRows";
            this.txtFileRows.ReadOnly = true;
            this.txtFileRows.Size = new System.Drawing.Size(95, 20);
            this.txtFileRows.TabIndex = 20;
            // 
            // txtFileSize
            // 
            this.txtFileSize.Location = new System.Drawing.Point(59, 84);
            this.txtFileSize.Name = "txtFileSize";
            this.txtFileSize.ReadOnly = true;
            this.txtFileSize.Size = new System.Drawing.Size(190, 20);
            this.txtFileSize.TabIndex = 18;
            // 
            // txtFileUpdated
            // 
            this.txtFileUpdated.Location = new System.Drawing.Point(59, 58);
            this.txtFileUpdated.Name = "txtFileUpdated";
            this.txtFileUpdated.ReadOnly = true;
            this.txtFileUpdated.Size = new System.Drawing.Size(190, 20);
            this.txtFileUpdated.TabIndex = 16;
            // 
            // txtFileCreated
            // 
            this.txtFileCreated.Location = new System.Drawing.Point(59, 32);
            this.txtFileCreated.Name = "txtFileCreated";
            this.txtFileCreated.ReadOnly = true;
            this.txtFileCreated.Size = new System.Drawing.Size(190, 20);
            this.txtFileCreated.TabIndex = 14;
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(59, 6);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(547, 20);
            this.txtFilePath.TabIndex = 11;
            // 
            // lblFileRows
            // 
            this.lblFileRows.AutoSize = true;
            this.lblFileRows.Location = new System.Drawing.Point(260, 35);
            this.lblFileRows.Name = "lblFileRows";
            this.lblFileRows.Size = new System.Drawing.Size(37, 13);
            this.lblFileRows.TabIndex = 19;
            this.lblFileRows.Text = "Rows:";
            // 
            // lblFilesize
            // 
            this.lblFilesize.AutoSize = true;
            this.lblFilesize.Location = new System.Drawing.Point(8, 87);
            this.lblFilesize.Name = "lblFilesize";
            this.lblFilesize.Size = new System.Drawing.Size(30, 13);
            this.lblFilesize.TabIndex = 17;
            this.lblFilesize.Text = "Size:";
            // 
            // lblFileUpdated
            // 
            this.lblFileUpdated.AutoSize = true;
            this.lblFileUpdated.Location = new System.Drawing.Point(8, 61);
            this.lblFileUpdated.Name = "lblFileUpdated";
            this.lblFileUpdated.Size = new System.Drawing.Size(51, 13);
            this.lblFileUpdated.TabIndex = 15;
            this.lblFileUpdated.Text = "Updated:";
            // 
            // lblFileCreated
            // 
            this.lblFileCreated.AutoSize = true;
            this.lblFileCreated.Location = new System.Drawing.Point(8, 35);
            this.lblFileCreated.Name = "lblFileCreated";
            this.lblFileCreated.Size = new System.Drawing.Size(47, 13);
            this.lblFileCreated.TabIndex = 13;
            this.lblFileCreated.Text = "Created:";
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(8, 9);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(26, 13);
            this.lblFilePath.TabIndex = 12;
            this.lblFilePath.Text = "File:";
            // 
            // tabByLine
            // 
            this.tabByLine.Controls.Add(this.splitContainer2);
            this.tabByLine.Location = new System.Drawing.Point(4, 22);
            this.tabByLine.Name = "tabByLine";
            this.tabByLine.Padding = new System.Windows.Forms.Padding(3);
            this.tabByLine.Size = new System.Drawing.Size(614, 530);
            this.tabByLine.TabIndex = 1;
            this.tabByLine.Text = "By Line";
            this.tabByLine.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btnFindByRows);
            this.splitContainer2.Panel1.Controls.Add(this.txtFindByRowsStartRow);
            this.splitContainer2.Panel1.Controls.Add(this.txtFindByRows);
            this.splitContainer2.Panel1.Controls.Add(this.lblFindByRows2);
            this.splitContainer2.Panel1.Controls.Add(this.lblFindByRows1);
            this.splitContainer2.Panel1.Controls.Add(this.lblByLineFilePosition);
            this.splitContainer2.Panel1.Controls.Add(this.btnShowRows);
            this.splitContainer2.Panel1.Controls.Add(this.txtShowRowsFromLine);
            this.splitContainer2.Panel1.Controls.Add(this.txtShowNumberOfRows);
            this.splitContainer2.Panel1.Controls.Add(this.lblShowRows2);
            this.splitContainer2.Panel1.Controls.Add(this.lblShowRows1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.txtByLineResults);
            this.splitContainer2.Size = new System.Drawing.Size(608, 524);
            this.splitContainer2.SplitterDistance = 103;
            this.splitContainer2.TabIndex = 6;
            // 
            // btnFindByRows
            // 
            this.btnFindByRows.Location = new System.Drawing.Point(310, 38);
            this.btnFindByRows.Name = "btnFindByRows";
            this.btnFindByRows.Size = new System.Drawing.Size(75, 23);
            this.btnFindByRows.TabIndex = 16;
            this.btnFindByRows.Text = "Go";
            this.btnFindByRows.UseVisualStyleBackColor = true;
            // 
            // txtFindByRowsStartRow
            // 
            this.txtFindByRowsStartRow.Location = new System.Drawing.Point(233, 40);
            this.txtFindByRowsStartRow.Name = "txtFindByRowsStartRow";
            this.txtFindByRowsStartRow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFindByRowsStartRow.Size = new System.Drawing.Size(71, 20);
            this.txtFindByRowsStartRow.TabIndex = 15;
            this.txtFindByRowsStartRow.Text = "1";
            // 
            // txtFindByRows
            // 
            this.txtFindByRows.Location = new System.Drawing.Point(52, 40);
            this.txtFindByRows.Name = "txtFindByRows";
            this.txtFindByRows.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFindByRows.Size = new System.Drawing.Size(71, 20);
            this.txtFindByRows.TabIndex = 13;
            // 
            // lblFindByRows2
            // 
            this.lblFindByRows2.AutoSize = true;
            this.lblFindByRows2.Location = new System.Drawing.Point(129, 43);
            this.lblFindByRows2.Name = "lblFindByRows2";
            this.lblFindByRows2.Size = new System.Drawing.Size(73, 13);
            this.lblFindByRows2.TabIndex = 14;
            this.lblFindByRows2.Text = "starting at row";
            // 
            // lblFindByRows1
            // 
            this.lblFindByRows1.AutoSize = true;
            this.lblFindByRows1.Location = new System.Drawing.Point(5, 43);
            this.lblFindByRows1.Name = "lblFindByRows1";
            this.lblFindByRows1.Size = new System.Drawing.Size(27, 13);
            this.lblFindByRows1.TabIndex = 12;
            this.lblFindByRows1.Text = "Find";
            // 
            // lblByLineFilePosition
            // 
            this.lblByLineFilePosition.AutoSize = true;
            this.lblByLineFilePosition.Location = new System.Drawing.Point(512, 14);
            this.lblByLineFilePosition.Name = "lblByLineFilePosition";
            this.lblByLineFilePosition.Size = new System.Drawing.Size(64, 13);
            this.lblByLineFilePosition.TabIndex = 11;
            this.lblByLineFilePosition.Text = "Ln: 1  Col: 1";
            // 
            // btnShowRows
            // 
            this.btnShowRows.Location = new System.Drawing.Point(310, 4);
            this.btnShowRows.Name = "btnShowRows";
            this.btnShowRows.Size = new System.Drawing.Size(75, 23);
            this.btnShowRows.TabIndex = 10;
            this.btnShowRows.Text = "Go";
            this.btnShowRows.UseVisualStyleBackColor = true;
            // 
            // txtShowRowsFromLine
            // 
            this.txtShowRowsFromLine.Location = new System.Drawing.Point(233, 6);
            this.txtShowRowsFromLine.Name = "txtShowRowsFromLine";
            this.txtShowRowsFromLine.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtShowRowsFromLine.Size = new System.Drawing.Size(71, 20);
            this.txtShowRowsFromLine.TabIndex = 9;
            this.txtShowRowsFromLine.Text = "1";
            // 
            // txtShowNumberOfRows
            // 
            this.txtShowNumberOfRows.Location = new System.Drawing.Point(52, 6);
            this.txtShowNumberOfRows.Name = "txtShowNumberOfRows";
            this.txtShowNumberOfRows.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtShowNumberOfRows.Size = new System.Drawing.Size(71, 20);
            this.txtShowNumberOfRows.TabIndex = 7;
            this.txtShowNumberOfRows.Text = "1000";
            // 
            // lblShowRows2
            // 
            this.lblShowRows2.AutoSize = true;
            this.lblShowRows2.Location = new System.Drawing.Point(129, 9);
            this.lblShowRows2.Name = "lblShowRows2";
            this.lblShowRows2.Size = new System.Drawing.Size(98, 13);
            this.lblShowRows2.TabIndex = 8;
            this.lblShowRows2.Text = "rows starting at row";
            // 
            // lblShowRows1
            // 
            this.lblShowRows1.AutoSize = true;
            this.lblShowRows1.Location = new System.Drawing.Point(5, 9);
            this.lblShowRows1.Name = "lblShowRows1";
            this.lblShowRows1.Size = new System.Drawing.Size(41, 13);
            this.lblShowRows1.TabIndex = 6;
            this.lblShowRows1.Text = "Display";
            // 
            // txtByLineResults
            // 
            this.txtByLineResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtByLineResults.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtByLineResults.Location = new System.Drawing.Point(0, 0);
            this.txtByLineResults.Multiline = true;
            this.txtByLineResults.Name = "txtByLineResults";
            this.txtByLineResults.ReadOnly = true;
            this.txtByLineResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtByLineResults.Size = new System.Drawing.Size(608, 417);
            this.txtByLineResults.TabIndex = 1;
            this.txtByLineResults.WordWrap = false;
            // 
            // tabByPosition
            // 
            this.tabByPosition.Controls.Add(this.splitContainer1);
            this.tabByPosition.Location = new System.Drawing.Point(4, 22);
            this.tabByPosition.Name = "tabByPosition";
            this.tabByPosition.Padding = new System.Windows.Forms.Padding(3);
            this.tabByPosition.Size = new System.Drawing.Size(614, 530);
            this.tabByPosition.TabIndex = 2;
            this.tabByPosition.Text = "By Position";
            this.tabByPosition.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnFindByBytes);
            this.splitContainer1.Panel1.Controls.Add(this.txtFindByBytesStart);
            this.splitContainer1.Panel1.Controls.Add(this.txtFindByBytesCriteria);
            this.splitContainer1.Panel1.Controls.Add(this.lblFindByBytes2);
            this.splitContainer1.Panel1.Controls.Add(this.lblFindByBytes1);
            this.splitContainer1.Panel1.Controls.Add(this.btnShowBytes);
            this.splitContainer1.Panel1.Controls.Add(this.txtShowBytesStart);
            this.splitContainer1.Panel1.Controls.Add(this.txtShowBytesLength);
            this.splitContainer1.Panel1.Controls.Add(this.lblShowBytes2);
            this.splitContainer1.Panel1.Controls.Add(this.lblShowBytes1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtByBytesResult);
            this.splitContainer1.Size = new System.Drawing.Size(608, 524);
            this.splitContainer1.SplitterDistance = 103;
            this.splitContainer1.TabIndex = 7;
            // 
            // btnFindByBytes
            // 
            this.btnFindByBytes.Location = new System.Drawing.Point(310, 38);
            this.btnFindByBytes.Name = "btnFindByBytes";
            this.btnFindByBytes.Size = new System.Drawing.Size(75, 23);
            this.btnFindByBytes.TabIndex = 16;
            this.btnFindByBytes.Text = "Go";
            this.btnFindByBytes.UseVisualStyleBackColor = true;
            // 
            // txtFindByBytesStart
            // 
            this.txtFindByBytesStart.Location = new System.Drawing.Point(214, 40);
            this.txtFindByBytesStart.Name = "txtFindByBytesStart";
            this.txtFindByBytesStart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFindByBytesStart.Size = new System.Drawing.Size(71, 20);
            this.txtFindByBytesStart.TabIndex = 15;
            this.txtFindByBytesStart.Text = "0";
            // 
            // txtFindByBytesCriteria
            // 
            this.txtFindByBytesCriteria.Location = new System.Drawing.Point(52, 40);
            this.txtFindByBytesCriteria.Name = "txtFindByBytesCriteria";
            this.txtFindByBytesCriteria.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFindByBytesCriteria.Size = new System.Drawing.Size(71, 20);
            this.txtFindByBytesCriteria.TabIndex = 13;
            // 
            // lblFindByBytes2
            // 
            this.lblFindByBytes2.AutoSize = true;
            this.lblFindByBytes2.Location = new System.Drawing.Point(129, 43);
            this.lblFindByBytes2.Name = "lblFindByBytes2";
            this.lblFindByBytes2.Size = new System.Drawing.Size(53, 13);
            this.lblFindByBytes2.TabIndex = 14;
            this.lblFindByBytes2.Text = "starting at";
            // 
            // lblFindByBytes1
            // 
            this.lblFindByBytes1.AutoSize = true;
            this.lblFindByBytes1.Location = new System.Drawing.Point(5, 43);
            this.lblFindByBytes1.Name = "lblFindByBytes1";
            this.lblFindByBytes1.Size = new System.Drawing.Size(27, 13);
            this.lblFindByBytes1.TabIndex = 12;
            this.lblFindByBytes1.Text = "Find";
            // 
            // btnShowBytes
            // 
            this.btnShowBytes.Location = new System.Drawing.Point(310, 4);
            this.btnShowBytes.Name = "btnShowBytes";
            this.btnShowBytes.Size = new System.Drawing.Size(75, 23);
            this.btnShowBytes.TabIndex = 10;
            this.btnShowBytes.Text = "Go";
            this.btnShowBytes.UseVisualStyleBackColor = true;
            // 
            // txtShowBytesStart
            // 
            this.txtShowBytesStart.Location = new System.Drawing.Point(214, 6);
            this.txtShowBytesStart.Name = "txtShowBytesStart";
            this.txtShowBytesStart.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtShowBytesStart.Size = new System.Drawing.Size(71, 20);
            this.txtShowBytesStart.TabIndex = 9;
            this.txtShowBytesStart.Text = "0";
            // 
            // txtShowBytesLength
            // 
            this.txtShowBytesLength.Location = new System.Drawing.Point(52, 6);
            this.txtShowBytesLength.Name = "txtShowBytesLength";
            this.txtShowBytesLength.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtShowBytesLength.Size = new System.Drawing.Size(71, 20);
            this.txtShowBytesLength.TabIndex = 7;
            this.txtShowBytesLength.Text = "8192";
            // 
            // lblShowBytes2
            // 
            this.lblShowBytes2.AutoSize = true;
            this.lblShowBytes2.Location = new System.Drawing.Point(129, 9);
            this.lblShowBytes2.Name = "lblShowBytes2";
            this.lblShowBytes2.Size = new System.Drawing.Size(81, 13);
            this.lblShowBytes2.TabIndex = 8;
            this.lblShowBytes2.Text = "bytes starting at";
            // 
            // lblShowBytes1
            // 
            this.lblShowBytes1.AutoSize = true;
            this.lblShowBytes1.Location = new System.Drawing.Point(5, 9);
            this.lblShowBytes1.Name = "lblShowBytes1";
            this.lblShowBytes1.Size = new System.Drawing.Size(41, 13);
            this.lblShowBytes1.TabIndex = 6;
            this.lblShowBytes1.Text = "Display";
            // 
            // txtByBytesResult
            // 
            this.txtByBytesResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtByBytesResult.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtByBytesResult.Location = new System.Drawing.Point(0, 0);
            this.txtByBytesResult.Multiline = true;
            this.txtByBytesResult.Name = "txtByBytesResult";
            this.txtByBytesResult.ReadOnly = true;
            this.txtByBytesResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtByBytesResult.Size = new System.Drawing.Size(608, 417);
            this.txtByBytesResult.TabIndex = 1;
            this.txtByBytesResult.WordWrap = false;
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Location = new System.Drawing.Point(260, 61);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(229, 13);
            this.lblWarning.TabIndex = 22;
            this.lblWarning.Text = "Note: If possible run this program  on a local file";
            // 
            // FileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 556);
            this.Controls.Add(this.tcActionGroups);
            this.Name = "FileForm";
            this.Text = "FileForm";
            this.tcActionGroups.ResumeLayout(false);
            this.tabDetails.ResumeLayout(false);
            this.tabDetails.PerformLayout();
            this.tabByLine.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            this.splitContainer2.ResumeLayout(false);
            this.tabByPosition.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tcActionGroups;
        private TabPage tabDetails;
        private Button btnFileCountRows;
        private TextBox txtFileRows;
        private TextBox txtFileSize;
        private TextBox txtFileUpdated;
        private TextBox txtFileCreated;
        private TextBox txtFilePath;
        private Label lblFileRows;
        private Label lblFilesize;
        private Label lblFileUpdated;
        private Label lblFileCreated;
        private Label lblFilePath;
        private TabPage tabByLine;
        private SplitContainer splitContainer2;
        private Label lblByLineFilePosition;
        private Button btnShowRows;
        private TextBox txtShowRowsFromLine;
        private TextBox txtShowNumberOfRows;
        private Label lblShowRows2;
        private Label lblShowRows1;
        private TextBox txtByLineResults;
        private TabPage tabByPosition;
        private Button btnFindByRows;
        private TextBox txtFindByRowsStartRow;
        private TextBox txtFindByRows;
        private Label lblFindByRows2;
        private Label lblFindByRows1;
        private SplitContainer splitContainer1;
        private Button btnFindByBytes;
        private TextBox txtFindByBytesStart;
        private TextBox txtFindByBytesCriteria;
        private Label lblFindByBytes2;
        private Label lblFindByBytes1;
        private Button btnShowBytes;
        private TextBox txtShowBytesStart;
        private TextBox txtShowBytesLength;
        private Label lblShowBytes2;
        private Label lblShowBytes1;
        private TextBox txtByBytesResult;
        private Label lblWarning;


    }
}