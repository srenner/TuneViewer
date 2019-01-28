using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuneViewer.Models
{
    public class VersionInfo
    {
        public double FileFormat { get; set; }
        public string FirmwareInfo { get; set; }
        public int Pages { get; set; }
        public string Signature { get; set; }
    }
}
