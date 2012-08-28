using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FileUtilities
{
    public class FileHandler
    {
        private FileInfo _fileInfo;

        public FileHandler(string filePath)
        {
            FilePath = filePath;
        }

        public string FilePath { get; private set; }

        public FileInfo FileInfo
        {
            get { return _fileInfo ?? (_fileInfo = new FileInfo(FilePath)); }
        }

        public int CountRows()
        {
            using (var reader = new StreamReader(FilePath))
            {
                var buffer = new char[32 * 1024]; // Read 32K chars at a time
                int total = 0;
                int read;
                while ((read = reader.Read(buffer, 0, buffer.Length)) > 0)
                    for (int i = 0; i < read; i++)
                    {
                        if (buffer[i] == '\n')
                            total++;
                    }
                return total;
            }
        }

        public string ReadSubsetOfLines(int startLine, int numberOfLines)
        {
            var lines = new StringBuilder();
            int lineNumber = 1;
            using (var reader = new StreamReader(FilePath))
            {
                while (lineNumber < startLine)
                {
                    if (reader.ReadLine() == null)
                        return string.Empty;

                    lineNumber++;
                }

                string line;
                while (lineNumber < (startLine + numberOfLines) &&
                      (line = reader.ReadLine()) != null)
                {
                    lines.AppendLine(line);

                    lineNumber++;
                }
            }

            return lines.ToString();
        }

        public DateTime DateCreated { get { return FileInfo.CreationTime; } }

        public DateTime DateUpdated { get { return FileInfo.LastWriteTime; } }

        public long Size { get { return FileInfo.Length; } }

        public string SizeString
        {
            get
            {
                return String.Format(new FileSizeFormatProvider(), "{0:fs}", Size);
            }
        }

        public FindInFileResult FindByLine(int startLine, string criteria)
        {
            const int queueBufferSize = 100;
            var result = new FindInFileResult{Criteria = criteria};
            var lines = new StringBuilder();
            var lineBuffer = new Queue<string>(queueBufferSize);
            int lineNumber = 1;

            using (var reader = new StreamReader(FilePath))
            {
                string line;
                while (lineNumber < startLine)
                {
                    if ((line = reader.ReadLine()) == null)
                        return result;

                    if (lineBuffer.Count == queueBufferSize)
                        lineBuffer.Dequeue();

                    lineBuffer.Enqueue(line);
                    lineNumber++;
                }

                while ((line = reader.ReadLine()) != null)
                {
                    lineNumber++;

                    if (lineBuffer.Count == queueBufferSize)
                        lineBuffer.Dequeue();

                    lineBuffer.Enqueue(line);

                    var charIndex = line.IndexOf(criteria, StringComparison.OrdinalIgnoreCase);
                    if (charIndex > -1)
                    {
                        // we've found the criteria so return a string buffer
                        // surrounding the result
                        result.FoundAtLine = lineNumber;
                        result.FoundAtCharIndex = charIndex;
                        result.SurroundingTextStartLine = lineNumber;

                        // take the last 5 lines from the buffer
                        foreach (var l in lineBuffer.ToArray()
                                                    .Skip(Math.Max(0, lineBuffer.Count - 5))
                                                    .Take(5))
                        {
                            lines.AppendLine(l);
                            result.SurroundingTextStartLine--;
                        }

                        lineNumber = 1;
                        while ((line = reader.ReadLine()) != null && 
                                lineNumber < (queueBufferSize - 5))
                        {
                            lines.AppendLine(line);
                            lineNumber++;
                        }

                        break;
                    }
                }
            }

            result.SurroundingText = lines.ToString();
            return result;
        }

        public string ShowBytes(int numberOfBytes, int startPos)
        {
            if (startPos > FileInfo.Length)
                return "Start position is greater than file length";

            using (var file = File.OpenRead(FilePath))
            {
                file.Seek(startPos, SeekOrigin.Begin);
                var buffer = new byte[numberOfBytes];
                var bytesRead = file.Read(buffer, 0, buffer.Length);
                return Encoding.UTF8.GetString(buffer, 0, bytesRead);
            }
        }

        public FindInFileResult FindByPos(int startpos, string criteria)
        {
            var buffer = new byte[32768];
            int filePos = 0;
            var result = new FindInFileResult {Criteria = criteria};
            using (var file = File.OpenRead(FilePath))
            {
                while (filePos < file.Length)
                {
                    var bytesRead = file.Read(buffer, 0, buffer.Length);
                    var content = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    var criteriaIndex =
                        content.IndexOf(criteria, StringComparison.OrdinalIgnoreCase);

                    if (criteriaIndex > -1)
                    {
                        result.FoundAtBytePosition = filePos + criteriaIndex;
                        file.Seek(-1024, SeekOrigin.Current);
                        bytesRead = file.Read(buffer, 0, buffer.Length);
                        result.SurroundingText = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                        break;
                    }

                    file.Seek(criteria.Length * -1, SeekOrigin.Current);
                    filePos += (buffer.Length - criteria.Length);
                }
            }

            return result;
        }
    }
}