using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuneViewer.Models
{
    public class Tune
    {
        public VersionInfo VersionInfo { get; set; }


        public int Cylinders { get; set; }

        public AFRTable AFRTable1 { get; set; }
    }
}
