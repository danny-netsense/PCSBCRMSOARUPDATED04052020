﻿// Decompiled with JetBrains decompiler
// Type: PX.Objects.AP.AP_VendorR_ExistingColumn
// Assembly: PCSBCRMSOARUPDATED, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 182865F4-07BB-4D2C-9E47-9E96DF45516C
// Assembly location: C:\Users\QuantumLingual107\AppData\Local\Temp\Vihywod\7ad39fc3ac\Bin\PCSBCRMSOARUPDATED.dll

using PX.Data;
using PX.Objects.CR;
using System;

namespace PX.Objects.AP
{
    [PXNonInstantiatedExtension]
    public class APVendorRExistingColumn : PXCacheExtension<VendorR>
    {
        [PXMergeAttributes]
        [PXCustomizeSelectorColumns(new Type[] { typeof(Vendor.acctCD), typeof(Vendor.acctName), typeof(Vendor.type), typeof(BAccount.acctReferenceNbr), typeof(BAccountExt.usrIndustry), typeof(BAccountExt.usrRegion) })]
        public string AcctCD { get; set; }
    }
}
