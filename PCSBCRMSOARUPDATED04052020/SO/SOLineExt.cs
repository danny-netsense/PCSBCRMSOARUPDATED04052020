// Decompiled with JetBrains decompiler
// Type: PX.Objects.SO.SOLineExt
// Assembly: CRMLEADPMSB2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1D293427-6FA2-4530-ABEA-D4C25BB424EA
// Assembly location: C:\Users\QuantumLingual107\AppData\Local\Temp\Nywihyp\7ad39fc3ac\Bin\CRMLEADPMSB2.dll

using PX.Data;
using PX.Objects.CM;
using System;

namespace PX.Objects.SO
{
    public class SOLineExt : PXCacheExtension<SOLine>
    {
        [PXDefault(TypeCode.Decimal, "0.0", PersistingCheck = PXPersistingCheck.Nothing)]
        [PXUIField(DisplayName = "Supplier Price(RM)")]
        [PXDBDecimal(4)]
        public virtual Decimal? UsrSupplPrce { get; set; }

        [PXUIField(DisplayName = "Supplier Disc.(%)")]
        [PXDBDecimal(2)]
        [PXDefault(TypeCode.Decimal, "0.0", PersistingCheck = PXPersistingCheck.Nothing)]
        public virtual Decimal? UsrSupplDisc { get; set; }

        [PXDBDecimal(2)]
        [PXDefault(TypeCode.Decimal, "0.0", PersistingCheck = PXPersistingCheck.Nothing)]
        [PXUIField(DisplayName = "Custom Duty(%)")]
        public virtual Decimal? UsrCustDuty { get; set; }

        [PXDBDecimal(2)]
        [PXDefault(TypeCode.Decimal, "0.0", PersistingCheck = PXPersistingCheck.Nothing)]
        [PXUIField(DisplayName = "Markup(%)")]
        public virtual Decimal? UsrMarkupPerc { get; set; }

        [PXDefault(TypeCode.Decimal, "0.0", PersistingCheck = PXPersistingCheck.Nothing)]
        [PXUIField(DisplayName = "Inbound Transport(RM)")]
        [PXDBDecimal(4)]
        public virtual Decimal? UsrInboundTrans { get; set; }

        [PXDefault(TypeCode.Decimal, "0.0", PersistingCheck = PXPersistingCheck.Nothing)]
        [PXUIField(DisplayName = "Hidden Cost")]
        [PXDBDecimal(4)]
        public virtual Decimal? UsrHiddenCost { get; set; }

        [PXDBDecimal(4)]
        [PXUIField(DisplayName = "Selling Price")]
        [PXDefault(TypeCode.Decimal, "0.0", PersistingCheck = PXPersistingCheck.Nothing)]
        public virtual Decimal? UsrSellingPrce { get; set; }

        [PXDefault(false)]
        [PXDBBool]
        [PXUIField(DisplayName = "Hide Records")]
        public virtual bool? UsrHideRecords { get; set; }


        public abstract class usrSupplPrce : IBqlField, IBqlOperand
        {
        }

        public abstract class usrSupplDisc : IBqlField, IBqlOperand
        {
        }

        public abstract class usrCustDuty : IBqlField, IBqlOperand
        {
        }

        public abstract class usrMarkupPerc : IBqlField, IBqlOperand
        {
        }

        public abstract class usrInboundTrans : IBqlField, IBqlOperand
        {
        }
        public abstract class usrHiddenCost : IBqlField, IBqlOperand
        {
        }

        public abstract class usrSellingPrce : IBqlField, IBqlOperand
        {
        }

        public abstract class usrHideRecords : IBqlField, IBqlOperand
        {
        }
    }
}
