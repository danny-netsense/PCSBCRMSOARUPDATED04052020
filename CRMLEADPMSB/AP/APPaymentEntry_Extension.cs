// Decompiled with JetBrains decompiler
// Type: PX.Objects.AP.APPaymentEntry_Extension
// Assembly: CRMLEADPMSB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: BA3FB156-B7E5-4249-A9FC-ED75D42F2979
// Assembly location: C:\Users\QuantumLingual107\AppData\Local\Temp\Nywihyp\7ad39fc3ac\Bin\CRMLEADPMSB.dll

using PX.Data;

namespace PX.Objects.AP
{
  public class APPaymentEntry_Extension : PXGraphExtension<APPaymentEntry>
  {
    protected void APAdjust_AdjdRefNbr_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e)
    {
      APAdjust row = (APAdjust) e.Row;
      if (row.AdjdRefNbr == null)
        return;
      APInvoice apInvoice = (PXSelect<APInvoice, Where<APInvoice.docType, Equal<Required<APInvoice.docType>>, 
          And<APInvoice.refNbr, Equal<Required<APInvoice.refNbr>>>>>.Select(Base, new object[2]
      {
        (object) row.AdjdDocType,
        (object) row.AdjdRefNbr
      }));
      if (apInvoice != null)
        ((APAdjustExt) PXCache<APAdjust>.GetExtension<APAdjustExt>(row)).UsrCuryOrigDocAmt = ((APRegister) apInvoice).CuryOrigDocAmt;
    }
         
  }
}
