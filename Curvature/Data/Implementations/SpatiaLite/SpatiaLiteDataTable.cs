﻿using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curvature
{
    [ImplementPropertyChanged]
    public class SpatiaLiteDataTable : IDataTable
    {
        // ===========================================================================
        // = Public Properties
        // ===========================================================================
        
        public String Name { get; private set; }
        public DataTableType Type { get; private set; }

        // ===========================================================================
        // = Construction
        // ===========================================================================
        
        public SpatiaLiteDataTable(String inName, DataTableType inType)
        {
            Name = inName;
            Type = inType;
        }
    }
}
