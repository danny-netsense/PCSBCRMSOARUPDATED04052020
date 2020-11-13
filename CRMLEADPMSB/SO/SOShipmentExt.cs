// Decompiled with JetBrains decompiler
// Type: PX.Objects.SO.SOShipmentExt
// Assembly: CRMLEADPMSB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: BA3FB156-B7E5-4249-A9FC-ED75D42F2979
// Assembly location: C:\Users\QuantumLingual107\AppData\Local\Temp\Nywihyp\7ad39fc3ac\Bin\CRMLEADPMSB.dll

using PX.Data;

namespace PX.Objects.SO
{
    public class SOShipmentExt : PXCacheExtension<SOShipment>
    {
        [PXDBString(100)]
        [PXUIField(DisplayName = "Tracking Number")]
        public virtual string UsrTrackingNbr { get; set; }

        public abstract class usrTrackingNbr : IBqlField, IBqlOperand
        {
        }
    }
}
