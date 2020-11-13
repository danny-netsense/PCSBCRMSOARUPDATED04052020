// Decompiled with JetBrains decompiler
// Type: PX.Objects.SO.SOLineExt
// Assembly: CRMLEADPMSB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: BA3FB156-B7E5-4249-A9FC-ED75D42F2979
// Assembly location: C:\Users\QuantumLingual107\AppData\Local\Temp\Nywihyp\7ad39fc3ac\Bin\CRMLEADPMSB.dll

using PX.Data;
using System;

namespace PX.Objects.SO
{
  public class SOLineExt : PXCacheExtension<SOLine>
  {
    [PXDBDecimal(2)]
    [PXDefault(TypeCode.Decimal, "0.0", PersistingCheck = PXPersistingCheck.Nothing)]
    [PXUIField(DisplayName = "Supplier Price")]
    public virtual Decimal? UsrSupplPrce { get; set; }

    [PXDBDecimal(2)]
    [PXDefault(TypeCode.Decimal, "0.0", PersistingCheck = PXPersistingCheck.Nothing)]
    [PXUIField(DisplayName = "Supplier Disc.")]
    public virtual Decimal? UsrSupplDisc { get; set; }

    [PXDBDecimal(2)]
    [PXDefault(TypeCode.Decimal, "0.0", PersistingCheck = PXPersistingCheck.Nothing)]
    [PXUIField(DisplayName = "Custom Duty")]
    public virtual Decimal? UsrCustDuty { get; set; }

    [PXDBDecimal(2)]
    [PXDefault(TypeCode.Decimal, "0.0", PersistingCheck = PXPersistingCheck.Nothing)]
    [PXUIField(DisplayName = "Markup %")]
    public virtual Decimal? UsrMarkupPerc { get; set; }

    [PXDBDecimal(2)]
    [PXDefault(TypeCode.Decimal, "0.0", PersistingCheck = PXPersistingCheck.Nothing)]
    [PXUIField(DisplayName = "Inbound Transport")]
    public virtual Decimal? UsrInboundTrans { get; set; }

    [PXDBDecimal(2)]
    [PXDefault(TypeCode.Decimal, "0.0", PersistingCheck = PXPersistingCheck.Nothing)]
    [PXUIField(DisplayName = "Selling Price")]
    public virtual Decimal? UsrSellingPrce { get; set; }

    [PXDBDate]
    [PXUIField(DisplayName = "Deliver By")]
    public virtual DateTime? UsrDeliverBy { get; set; }

    [PXDBDecimal(2)]
    [PXUIField(DisplayName = "Last Cust Price")]
    public virtual Decimal? UsrLstCustPrice { get; set; }

    [PXDBBool]
    [PXUIField(DisplayName = "Hide Report Fields")]
    [PXDefault(false, PersistingCheck = PXPersistingCheck.Nothing)]
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

    public abstract class usrSellingPrce : IBqlField, IBqlOperand
    {
    }

    public abstract class usrDeliverBy : IBqlField, IBqlOperand
    {
    }

    public abstract class usrLstCustPrice : IBqlField, IBqlOperand
    {
    }

    public abstract class usrHideRecords : IBqlField, IBqlOperand
    {
    }
  }
}
