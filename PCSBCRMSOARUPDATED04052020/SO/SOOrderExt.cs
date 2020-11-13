// Decompiled with JetBrains decompiler
// Type: PX.Objects.SO.SOOrderExt
// Assembly: CRMLEADPMSB2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1D293427-6FA2-4530-ABEA-D4C25BB424EA
// Assembly location: C:\Users\QuantumLingual107\AppData\Local\Temp\Nywihyp\7ad39fc3ac\Bin\CRMLEADPMSB2.dll

using PX.Data;

namespace PX.Objects.SO
{
    public class SOOrderExt : PXCacheExtension<SOOrder>
    {
        [PXDBString(20)]
        [PXUIField(DisplayName = "Case ID")]
        public virtual string UsrCaseID { get; set; }

        [PXDefault(false, PersistingCheck = PXPersistingCheck.Nothing)]
        [PXUIField(DisplayName = "Old Calculation",Visibility =PXUIVisibility.Invisible)]
        public virtual bool? UsrOldCalc { get; set; }

        [PXDBString(400)]
        [PXUIField(DisplayName = "Reject Reason")]
        public virtual string UsrRejectReason { get; set; }

        [PXDefault(false, PersistingCheck = PXPersistingCheck.Nothing)]
        [PXDBBool]
        [PXUIField(DisplayName = "Order Acknowledgement")]
        public virtual bool? UsrOrdAcknlmt { get; set; }

        [PXDefault(false, PersistingCheck = PXPersistingCheck.Nothing)]
        [PXDBBool]
        [PXUIField(DisplayName = "Customer Enquiry")]
        public virtual bool? UsrCstEnqry { get; set; }

        [PXDBString(20)]
        [PXUIField(DisplayName = "Opportunity Number")]
        public virtual string UsrOpNum { get; set; }


        public abstract class usrCaseID : IBqlField, IBqlOperand
        {
        }

        public abstract class usrOldCalc : IBqlField, IBqlOperand
        {
        }

        public abstract class usrRejectReason : IBqlField, IBqlOperand
        {
        }

        public abstract class usrOrdAcknlmt : IBqlField, IBqlOperand
        {
        }

        public abstract class usrCstEnqry : IBqlField, IBqlOperand
        {
        }

        public abstract class usrOpNum : IBqlField, IBqlOperand
        {
        }
    }
}
