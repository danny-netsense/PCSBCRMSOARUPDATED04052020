// Decompiled with JetBrains decompiler
// Type: PX.Objects.AP.APAdjustExt
// Assembly: CRMLEADPMSB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: BA3FB156-B7E5-4249-A9FC-ED75D42F2979
// Assembly location: C:\Users\QuantumLingual107\AppData\Local\Temp\Nywihyp\7ad39fc3ac\Bin\CRMLEADPMSB.dll

using PX.Data;
using System;

namespace PX.Objects.AP
{
    public class APAdjustExt : PXCacheExtension<APAdjust>
    {
        [PXDBDecimal(2)]
        [PXUIField(DisplayName = "Orig.Inv Amount", IsReadOnly = true)]
        public virtual Decimal? UsrCuryOrigDocAmt { get; set; }

        public abstract class usrCuryOrigDocAmt : IBqlField, IBqlOperand
        {
        }
    }
}
