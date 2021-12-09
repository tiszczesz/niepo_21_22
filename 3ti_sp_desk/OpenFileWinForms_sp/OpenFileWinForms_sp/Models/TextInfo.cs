using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenFileWinForms_sp.Models
{
    class TextInfo {
        private List<string> _textFile;

        public TextInfo(List<string> textFile) {
            _textFile = textFile;
            LineCount = GetLinesLinq();
        }

        private int GetLines(bool isEmpty = false) {
            int counter = 0;
            if (isEmpty) return _textFile.Count;
            foreach (string line in _textFile) {
                if (line.Trim().Length > 0  ) counter++;
            }

           // Char.IsLetter('z');
            return counter;
        }
        private int GetLinesLinq(bool isEmpty = false) {
            return isEmpty ? _textFile.Count : _textFile.Count(elem => elem.Trim().Length > 0);
        }
        public int LineCount { get; set; }
        public int CharCount { get; set; }
        public int AlphaCount { get; set; }
        

    }
}
