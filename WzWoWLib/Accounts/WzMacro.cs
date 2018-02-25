using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzWoWLib.Accounts
{
    public class WzMacro
    {
        public string Name { get; protected set; }
        public string IconName { get; protected set; }
        public string Text { get; protected set; }
        public string[] Lines { get; protected set; }
        public int Length;

        protected char _quotedSpaceFiller = '\t';

        protected WzMacro()
        {
            this.Lines = new string[0];
        }

        protected void ParseInfoLine(string line)
        {
            if (string.IsNullOrWhiteSpace(line)) return;

            var lineChars = line.ToCharArray();
            var inQuote = false;

            for(int pos=0; pos<lineChars.Length; pos++)
            {
                char ch = lineChars[pos];

                if (ch == '\"') inQuote = !inQuote;

                if (ch == ' ' && inQuote) lineChars[pos] = _quotedSpaceFiller;
            }

            var segments = FixSegments(new String(lineChars).Split(' '));

            this.Name = segments[3];
            this.IconName = segments[4];
        }


        protected string[] FixSegments(string[] vals)
        {
            var results = new List<string>();
            foreach (var val in vals)
            {
                var result = $"{val}".Trim('\"').Replace(_quotedSpaceFiller, ' ');
                results.Add(result);
            }
            return results.ToArray();
        }

        public static WzMacro Parse(string[] lines, int startPos)
        {
            var result = new WzMacro();

            if (lines.Length>0 && startPos<lines.Length)
            {
                var firstLine = lines[startPos];
                // only parse if we know we have a valid first line
                if (string.IsNullOrWhiteSpace(firstLine) || firstLine.StartsWith("VER 3 ") == false) return null;

                result.ParseInfoLine(firstLine);

                var mlines = new List<string>();
                int pos = startPos + 1;
                while (pos < lines.Length)
                {
                    var curLine = lines[pos];

                    if (curLine != "END")
                    {
                        mlines.Add(curLine);
                        result.Length += curLine.Length + 1;
                    } else
                    {
                        result.Lines = mlines.ToArray();
                        result.Text = string.Join("\n", result.Lines);
                        pos = lines.Length + 1;
                    }
                    pos++;
                }
            }

            return result;
        }
    }


    public class WzMacroCollection: Dictionary<string, WzMacro>
    {
        public WzMacroCollection(WzAccount acct) : base(StringComparer.InvariantCultureIgnoreCase)
        {
            if (acct == null) return;

            var macroFile = acct.GetFile("macros-cache.txt");
            if (macroFile == null) macroFile = acct.GetFile("macros-cache.old");

            if (macroFile == null) return;

            var allText = macroFile.ReadLines();

            int pos = 0;

            while (pos<allText.Length)
            {
                var macro = WzMacro.Parse(allText, pos);
                int offset = 2;

                if (macro != null && macro.Lines.Length > 0)
                {
                    this.Add(macro.Name, macro);
                    offset += macro.Lines.Length;
                }

                pos += offset;
            }
        }
    }
}
