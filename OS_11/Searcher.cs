using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;

namespace OS_11
{
    class Searcher
    {
        string path;
        public long Size { get; set; }

        public Searcher(string _path)
        {
            path = _path;
            Size = 0;
        }

        public void countSize()
        {
            Size = RsdnDirectory.countSize(path);
        }
    }
}
