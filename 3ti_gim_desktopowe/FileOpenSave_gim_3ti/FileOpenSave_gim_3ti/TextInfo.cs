using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOpenSave_gim_3ti
{
    public class TextInfo {
        private List<string> _lines;

        public TextInfo(List<string> lines) {
            _lines = lines;
            Lines = _lines.Count;
        }

        public int Lines { get; set; }
        public int Chars { get; set; }
        public int Letters { get; set; }

        public int GetNotEmptyLines() {
            return 0;//todo
        }
    }
}
