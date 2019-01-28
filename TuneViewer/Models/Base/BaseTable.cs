using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuneViewer.Models.Base
{
    public abstract class BaseTable
    {
        public int Cols { get; set; }
        public int Rows { get; set; }
        public string Name { get; set; }
        public string Units { get; set; }
        public int Digits { get; set; }
    }
}
