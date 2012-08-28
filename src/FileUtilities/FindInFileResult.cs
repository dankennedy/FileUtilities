namespace FileUtilities
{
    public class FindInFileResult
    {
        public FindInFileResult()
        {
            FoundAtLine = -1;
            FoundAtCharIndex = -1;
            FoundAtBytePosition = -1;
            SurroundingText = string.Empty;
        }

        public string Criteria { get; set; }
        public int FoundAtLine { get; set; }
        public int FoundAtCharIndex { get; set; }
        public int FoundAtBytePosition { get; set; }
        public string SurroundingText { get; set; }
        public int SurroundingTextStartLine { get; set; }
        public bool Success { get { return FoundAtLine > -1 || FoundAtBytePosition > -1; } }
    }
}