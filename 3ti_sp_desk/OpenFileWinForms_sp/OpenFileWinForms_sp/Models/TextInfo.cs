using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenFileWinForms_sp.Models
{
    class TextInfo {
        private string _textFile;

        public TextInfo(string textFile) {
            _textFile = textFile;
        }
        public int LineCount { get; set; }
        public int CharCount { get; set; }
        public int AlphaCount { get; set; }
    }
}
