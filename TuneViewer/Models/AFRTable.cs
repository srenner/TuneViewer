﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuneViewer.Models
{
    public class AFRTable : Base.BaseTable
    {
        public double[,] Cells { get; set; }
    }
}
