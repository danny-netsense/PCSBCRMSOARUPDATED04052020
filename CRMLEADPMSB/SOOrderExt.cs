// Decompiled with JetBrains decompiler
// Type: PX.Objects.SO.SOOrderExt
// Assembly: CRMLEADPMSB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: BA3FB156-B7E5-4249-A9FC-ED75D42F2979
// Assembly location: C:\Users\QuantumLingual107\AppData\Local\Temp\Nywihyp\7ad39fc3ac\Bin\CRMLEADPMSB.dll

using PX.Data;

namespace PX.Objects.SO
{
  public class SOOrderExt : PXCacheExtension<SOOrder>
  {
    [PXDBString(20)]
    [PXUIField(DisplayName = "Case ID")]
    public virtual string UsrCaseID { get; set; }

    [PXDBBool]
    [PXUIField(DisplayName = "Old Calculation")]
    [PXDefault(false, PersistingCheck = PXPersistingCheck.Nothing)]
    public virtual bool? UsrOldCalc { get; set; }

    [PXDBString(400)]
    [PXUIField(DisplayName = "Reject Reason")]
    public virtual string UsrRejectReason { get; set; }
         

    public abstract class usrCaseID : IBqlField, IBqlOperand
    {
    }

    public abstract class usrOldCalc : IBqlField, IBqlOperand
    {
    }

    public abstract class usrRejectReason : IBqlField, IBqlOperand
    {
    }
  }
}
