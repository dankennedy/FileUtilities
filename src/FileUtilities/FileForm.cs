using System;
using System.IO;
using System.Windows.Forms;

namespace FileUtilities
{
    public partial class FileForm : Form
    {
        private delegate int CountDelegate();
        private delegate string ReadLinesDelegate(int startLine, int numberOfLines);
        private delegate FindInFileResult FindInFileDelegate(int startLine, string criteria);

        public FileForm(string filePath)
        {
            InitializeComponent();
            FileHandler = new FileHandler(filePath);
            Load += FileFormLoad;
            txtByLineResults.MouseDown += UpdateCurrentPosition;
            txtByLineResults.KeyUp += UpdateCurrentPosition;
            txtByLineResults.TextChanged += UpdateCurrentPosition;
            btnShowRows.Click += BtnShowRowsClick;
            btnFileCountRows.Click += BtnFileCountRowsClick;
            btnFindByRows.Click += BtnFindByRowsClick;
            CurrentStartLine = 1;

            btnShowBytes.Click += BtnShowBytesClick;
            btnFindByBytes.Click += BtnFindByBytesClick;
        }

        void UpdateCurrentPosition(object sender, EventArgs e)
        {
            var charIndex = txtByLineResults.SelectionStart;
            var line = txtByLineResults.GetLineFromCharIndex(charIndex);
            line += CurrentStartLine;
            var position = txtByLineResults.GetPositionFromCharIndex(charIndex);
            position.X = 0;
            var column = (charIndex - txtByLineResults.GetCharIndexFromPosition(position)) + 1;

            lblByLineFilePosition.Text = string.Format("Ln: {0}   Col: {1}",
                line, column);
        }

        public FileHandler FileHandler { get; private set; }

        public int CurrentStartLine { get; set; }

        private void FileFormLoad(object sender, EventArgs e)
        {
            Text = Path.GetFileName(FileHandler.FilePath);
            txtFilePath.Text = FileHandler.FilePath;
            txtFileCreated.Text = FileHandler.DateCreated.ToShortDateTimeString();
            txtFileUpdated.Text = FileHandler.DateUpdated.ToShortDateTimeString();
            txtFileSize.Text = FileHandler.SizeString;
        }

        private void BtnFileCountRowsClick(object sender, EventArgs e)
        {
            txtFileRows.Text = "Calculating...";
            var invoker = new CountDelegate(FileHandler.CountRows);
            invoker.BeginInvoke(EndCountRows, invoker);
        }

        private void EndCountRows(IAsyncResult ar)
        {
            var invoker = (CountDelegate)ar.AsyncState;
            var result = invoker.EndInvoke(ar);
            txtFileRows.InvokeIfRequired(c => txtFileRows.Text = result.ToString("n0"));
        }

        private void BtnShowRowsClick(object sender, EventArgs e)
        {
            int numberOfLines;
            if (!Int32.TryParse(txtShowNumberOfRows.Text, out numberOfLines))
            {
                MessageBox.Show("Enter a number",
                                "Invalid Number Of Rows",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            int startLine;
            if (!Int32.TryParse(txtShowRowsFromLine.Text, out startLine))
            {
                MessageBox.Show("Enter a number",
                                "Invalid Start Line",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            CurrentStartLine = startLine;
            txtByLineResults.Text = "Reading...";
            var invoker = new ReadLinesDelegate(FileHandler.ReadSubsetOfLines);
            invoker.BeginInvoke(startLine, numberOfLines, EndReadLines, invoker);
        }

        void BtnFindByRowsClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFindByRows.Text))
            {
                MessageBox.Show("Enter your search criteria",
                                "Invalid Search Criteria",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            int startLine;
            if (!Int32.TryParse(txtFindByRowsStartRow.Text, out startLine))
            {
                MessageBox.Show("Enter a number",
                                "Invalid Start Line",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            
            txtByLineResults.Text = "Searching...";
            var invoker = new FindInFileDelegate(FileHandler.FindByLine);
            invoker.BeginInvoke(startLine, txtFindByRows.Text, EndFindByLine, invoker);
        }

        void BtnShowBytesClick(object sender, EventArgs e)
        {
            int numberOfBytes;
            if (!Int32.TryParse(txtShowBytesLength.Text, out numberOfBytes))
            {
                MessageBox.Show("Enter a number",
                                "Invalid Byte Length",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            int startPos;
            if (!Int32.TryParse(txtShowBytesStart.Text, out startPos))
            {
                MessageBox.Show("Enter a number",
                                "Invalid Start Line",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            txtByBytesResult.Text = FileHandler.ShowBytes(numberOfBytes, startPos);
        }

        void BtnFindByBytesClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFindByBytesCriteria.Text))
            {
                MessageBox.Show("Enter your search criteria",
                                "Invalid Search Criteria",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            int startPos;
            if (!Int32.TryParse(txtFindByBytesStart.Text, out startPos))
            {
                MessageBox.Show("Enter a number",
                                "Invalid Start Line",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }


            txtByBytesResult.Text = "Searching...";
            var invoker = new FindInFileDelegate(FileHandler.FindByPos);
            invoker.BeginInvoke(startPos, txtFindByBytesCriteria.Text, EndFindByPos, invoker);
        }


        private void EndReadLines(IAsyncResult ar)
        {
            var invoker = (ReadLinesDelegate)ar.AsyncState;
            var result = invoker.EndInvoke(ar);
            txtByLineResults.InvokeIfRequired(c => txtByLineResults.Text = result);
        }

        private void EndFindByLine(IAsyncResult ar)
        {
            var invoker = (FindInFileDelegate)ar.AsyncState;
            var result = invoker.EndInvoke(ar);
            if (!result.Success)
            {
                txtByLineResults.InvokeIfRequired(c => 
                    txtByLineResults.Text = "Search criteria not found");

                return;
            }

            CurrentStartLine = result.SurroundingTextStartLine;
            txtByLineResults.InvokeIfRequired(c =>
                {
                    
                    txtByLineResults.Text = result.SurroundingText;
                    txtByLineResults.SelectionStart =
                        txtByLineResults.Text.IndexOf(result.Criteria, StringComparison.OrdinalIgnoreCase);
                    txtByLineResults.SelectionLength = result.Criteria.Length;
                    txtByLineResults.ScrollToCaret();
                    txtByLineResults.Focus();
                });
        }

        private void EndFindByPos(IAsyncResult ar)
        {
            var invoker = (FindInFileDelegate)ar.AsyncState;
            var result = invoker.EndInvoke(ar);
            if (!result.Success)
            {
                txtByBytesResult.InvokeIfRequired(c =>
                    txtByBytesResult.Text = "Search criteria not found");

                return;
            }

            txtByBytesResult.InvokeIfRequired(c =>
            {
                txtByBytesResult.Text = result.SurroundingText;
                txtByBytesResult.SelectionStart =
                    txtByBytesResult.Text.IndexOf(result.Criteria, StringComparison.OrdinalIgnoreCase);
                txtByBytesResult.SelectionLength = result.Criteria.Length;
                txtByBytesResult.ScrollToCaret();
                txtByBytesResult.Focus();
            });
        }
    }
}