﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using Provider;


namespace AccessToPapers
{
    public partial class AccessToPapers
    {
        BasePapersDataSet PapersDataSet;
        Provider.Provider provider = new Provider.Provider();
        SourceType DataType;
        string TargetData;

        public AccessToPapers(SourceType DataType, string TargetData)
        {
            this.DataType = DataType;
            this.TargetData = TargetData;
            PapersDataSet = provider.GetAllData(TargetData, DataType);
        }
    }
}
