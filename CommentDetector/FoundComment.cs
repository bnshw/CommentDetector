using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommentDetector
{
    public class FoundComment
    {
        public string FoundPath { get; }
        public int FoundLine { get; }

        public FoundComment(string foundPath, int foundLine)
        {
            FoundPath = foundPath;
            FoundLine = foundLine;
        }
    }
}
