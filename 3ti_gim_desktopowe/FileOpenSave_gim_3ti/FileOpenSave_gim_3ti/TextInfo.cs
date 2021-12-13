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
            Lines = _lines.Count(line=>line.Trim().Length>0);
            Chars = CountChar(_lines);
            Letters = CountChar(_lines,true);
        }

        public int CountChar(List<string> lines, bool isLetter=false) {
            int result = 0;
            foreach (string line in lines) {
                result += isLetter ? line.Count(item=>Char.IsLetter(item)):line.Length;
            }

            return result;
        }
        public int Lines { get; set; }
        public int Chars { get; set; }
        public int Letters { get; set; }

        public int GetNotEmptyLines() {
            return 0;//todo
        }
    }
}
