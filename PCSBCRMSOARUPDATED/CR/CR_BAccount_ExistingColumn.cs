// Decompiled with JetBrains decompiler
// Type: PX.Objects.CR.CR_BAccount_ExistingColumn
// Assembly: PCSBCRMSOARUPDATED, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 182865F4-07BB-4D2C-9E47-9E96DF45516C
// Assembly location: C:\Users\QuantumLingual107\AppData\Local\Temp\Vihywod\7ad39fc3ac\Bin\PCSBCRMSOARUPDATED.dll

using PX.Data;
using System;

namespace PX.Objects.CR
{
    [PXNonInstantiatedExtension]
    public class CRBAccountExistingColumn : PXCacheExtension<BAccount>
    {
        [PXMergeAttributes]
        [PXCustomizeSelectorColumns(new Type[] { typeof(BAccount.acctCD), typeof(BAccount.acctName), typeof(BAccount.type), typeof(BAccount.acctReferenceNbr), typeof(BAccount.parentBAccountID), typeof(BAccount.ownerID), typeof(BAccountExt.usrIndustry), typeof(BAccountExt.usrRegion) })]
        public string AcctCD { get; set; }
    }
}
