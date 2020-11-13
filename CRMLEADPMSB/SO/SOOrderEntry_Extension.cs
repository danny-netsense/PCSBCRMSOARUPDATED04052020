// Decompiled with JetBrains decompiler
// Type: PX.Objects.SO.SOOrderEntry_Extension
// Assembly: CRMLEADPMSB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: BA3FB156-B7E5-4249-A9FC-ED75D42F2979
// Assembly location: C:\Users\QuantumLingual107\AppData\Local\Temp\Nywihyp\7ad39fc3ac\Bin\CRMLEADPMSB.dll

using PX.Data;
using PX.Objects.AR;
using PX.Objects.CS;
using PX.Objects.PO;
using System;
using System.Collections;
using System.Collections.Generic;

namespace PX.Objects.SO
{
    public class SOOrderEntry_Extension : PXGraphExtension<SOOrderEntry>
    {
        //protected void SOLine_InventoryID_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e)
        //{
        //    SOLine row = (SOLine)e.Row;
        //    SOOrder current = ((PXSelectBase<SOOrder>)this.Base.Document).Current;
        //    SOOrderExt extension1 = (SOOrderExt)PXCache<SOOrder>.GetExtension<SOOrderExt>(current);
        //    SOLineExt extension2 = (SOLineExt)PXCache<SOLine>.GetExtension<SOLineExt>(row);
        //    POVendorInventory poVendorInventory =
        //        (PXSelect<POVendorInventory, Where<POVendorInventory.inventoryID, Equal<Required<POVendorInventory.inventoryID>>>,
        //        OrderBy<Desc<POVendorInventory.createdDateTime>>>.Select(Base, row.InventoryID));
        //    if (poVendorInventory != null)
        //        extension2.UsrSupplPrce = poVendorInventory.LastPrice;
        //    extension2.UsrSellingPrce = this.CalcSellingPriceEngine(cache, e);
        //    row.CuryUnitPrice = (extension2.UsrSellingPrce);
        //    int? nullable = current.CustomerID;
        //    int num;
        //    if (nullable.HasValue)
        //    {
        //        nullable = row.InventoryID;
        //        num = nullable.HasValue ? 1 : 0;
        //    }
        //    else
        //        num = 0;
        //    if (num == 0)
        //        return;
        //    ARTran arTran = (PXSelect<ARTran, Where<ARTran.inventoryID, Equal<Required<ARTran.inventoryID>>, And<ARTran.customerID,
        //        Equal<Required<ARTran.customerID>>, And<ARTran.released, Equal<boolTrue>>>>, OrderBy<Desc<ARTran.tranDate>>>.
        //        Select(Base, new object[2] { (object)row.InventoryID, (object)current.CustomerID }));
        //    if (arTran != null)
        //        extension2.UsrLstCustPrice = arTran.CuryUnitPrice;
        //}

        //protected void SOLine_UsrCustDuty_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e)
        //{
        //    SOLine row = (SOLine)e.Row;
        //    SOLineExt extension = (SOLineExt)PXCache<SOLine>.GetExtension<SOLineExt>(row);
        //    extension.UsrSellingPrce = this.CalcSellingPriceEngine(cache, e);
        //    row.CuryUnitPrice = (extension.UsrSellingPrce);
        //    SOLine soLine = row;
        //    Decimal? orderQty = row.OrderQty;
        //    Decimal? curyUnitPrice = row.CuryUnitPrice;
        //    Decimal? nullable = orderQty.HasValue & curyUnitPrice.HasValue ? new Decimal?(orderQty.GetValueOrDefault() * curyUnitPrice.GetValueOrDefault()) : new Decimal?();
        //    soLine.CuryLineAmt = (nullable);
        //}

        //protected void SOLine_UsrInboundTrans_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e)
        //{
        //    SOLine row = (SOLine)e.Row;
        //    SOLineExt extension = (SOLineExt)PXCache<SOLine>.GetExtension<SOLineExt>(row);
        //    extension.UsrSellingPrce = this.CalcSellingPriceEngine(cache, e);
        //    row.CuryUnitPrice = (extension.UsrSellingPrce);
        //    SOLine soLine = row;
        //    Decimal? orderQty = row.OrderQty;
        //    Decimal? curyUnitPrice = row.CuryUnitPrice;
        //    Decimal? nullable = orderQty.HasValue & curyUnitPrice.HasValue ? new Decimal?(orderQty.GetValueOrDefault() * curyUnitPrice.GetValueOrDefault()) : new Decimal?();
        //    soLine.CuryLineAmt = (nullable);
        //}

        //protected void SOLine_UsrMarkupPerc_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e)
        //{
        //    SOLine row = (SOLine)e.Row;
        //    SOLineExt extension = (SOLineExt)PXCache<SOLine>.GetExtension<SOLineExt>(row);
        //    extension.UsrSellingPrce = this.CalcSellingPriceEngine(cache, e);
        //    row.CuryUnitPrice = (extension.UsrSellingPrce);
        //    SOLine soLine = row;
        //    Decimal? orderQty = row.OrderQty;
        //    Decimal? curyUnitPrice = row.CuryUnitPrice;
        //    Decimal? nullable = orderQty.HasValue & curyUnitPrice.HasValue ? new Decimal?(orderQty.GetValueOrDefault() * curyUnitPrice.GetValueOrDefault()) : new Decimal?();
        //    soLine.CuryLineAmt = (nullable);
        //}

        //protected void SOLine_UsrSupplDisc_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e)
        //{
        //    SOLine row = (SOLine)e.Row;
        //    SOLineExt extension = (SOLineExt)PXCache<SOLine>.GetExtension<SOLineExt>(row);
        //    extension.UsrSellingPrce = this.CalcSellingPriceEngine(cache, e);
        //    row.CuryUnitPrice = (extension.UsrSellingPrce);
        //    SOLine soLine = row;
        //    Decimal? orderQty = row.OrderQty;
        //    Decimal? curyUnitPrice = row.CuryUnitPrice;
        //    Decimal? nullable = orderQty.HasValue & curyUnitPrice.HasValue ? new Decimal?(orderQty.GetValueOrDefault() * curyUnitPrice.GetValueOrDefault()) : new Decimal?();
        //    soLine.CuryLineAmt = (nullable);
        //}

        //protected void SOLine_UsrSupplPrce_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e)
        //{
        //    SOLine row = (SOLine)e.Row;
        //    SOLineExt extension = (SOLineExt)PXCache<SOLine>.GetExtension<SOLineExt>(row);
        //    extension.UsrSellingPrce = this.CalcSellingPriceEngine(cache, e);
        //    row.CuryUnitPrice = (extension.UsrSellingPrce);
        //    SOLine soLine = row;
        //    Decimal? orderQty = row.OrderQty;
        //    Decimal? curyUnitPrice = row.CuryUnitPrice;
        //    Decimal? nullable = orderQty.HasValue & curyUnitPrice.HasValue ? new Decimal?(orderQty.GetValueOrDefault() * curyUnitPrice.GetValueOrDefault()) : new Decimal?();
        //    soLine.CuryLineAmt = (nullable);
        //}

        //protected void SOLine_UsrSellingPrce_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e)
        //{
        //    SOLine row = (SOLine)e.Row;
        //    SOLineExt extension = (SOLineExt)PXCache<SOLine>.GetExtension<SOLineExt>(row);
        //    row.CuryUnitPrice = (extension.UsrSellingPrce);
        //    SOLine soLine = row;
        //    Decimal? orderQty = row.OrderQty;
        //    Decimal? curyUnitPrice = row.CuryUnitPrice;
        //    Decimal? nullable = orderQty.HasValue & curyUnitPrice.HasValue ? new Decimal?(orderQty.GetValueOrDefault() * curyUnitPrice.GetValueOrDefault()) : new Decimal?();
        //    soLine.CuryLineAmt = (nullable);
        //}

        //private Decimal? CalcSellingPriceEngine(PXCache cache, PXFieldUpdatedEventArgs e)
        //{
        //    Decimal? nullable1 = new Decimal?(Decimal.Zero);
        //    Decimal? nullable2 = new Decimal?(Decimal.Zero);
        //    Decimal? nullable3 = new Decimal?(Decimal.Zero);
        //    Decimal? nullable4 = new Decimal?(Decimal.Zero);
        //    SOLine row = (SOLine)e.Row;
        //    SOOrderExt extension1 = (SOOrderExt)PXCache<SOOrder>.GetExtension<SOOrderExt>(((PXSelectBase<SOOrder>)this.Base.Document).Current);
        //    SOLineExt extension2 = (SOLineExt)PXCache<SOLine>.GetExtension<SOLineExt>(row);
        //    bool? usrOldCalc = extension1.UsrOldCalc;
        //    bool flag = true;
        //    Decimal? nullable5;
        //    if (usrOldCalc.GetValueOrDefault() == flag & usrOldCalc.HasValue)
        //    {
        //        Decimal? nullable6 = extension2.UsrSupplPrce;
        //        Decimal num = new Decimal(100);
        //        Decimal? usrSupplDisc = extension2.UsrSupplDisc;
        //        Decimal? nullable7 = usrSupplDisc.HasValue ? new Decimal?(num - usrSupplDisc.GetValueOrDefault()) : new Decimal?();
        //        Decimal? nullable8 = nullable6.HasValue & nullable7.HasValue ? new Decimal?(nullable6.GetValueOrDefault() * nullable7.GetValueOrDefault() / new Decimal(100)) : new Decimal?();
        //        nullable7 = nullable8;
        //        nullable6 = extension2.UsrMarkupPerc;
        //        Decimal? nullable9 = nullable7.HasValue & nullable6.HasValue ? new Decimal?(nullable7.GetValueOrDefault() * nullable6.GetValueOrDefault() / new Decimal(100)) : new Decimal?();
        //        Decimal? nullable10 = nullable8;
        //        Decimal? nullable11 = nullable9;
        //        nullable6 = nullable10.HasValue & nullable11.HasValue ? new Decimal?(nullable10.GetValueOrDefault() + nullable11.GetValueOrDefault()) : new Decimal?();
        //        nullable7 = extension2.UsrCustDuty;
        //        Decimal? nullable12 = nullable6.HasValue & nullable7.HasValue ? new Decimal?(nullable6.GetValueOrDefault() * nullable7.GetValueOrDefault() / new Decimal(100)) : new Decimal?();
        //        Decimal? nullable13 = nullable8;
        //        Decimal? nullable14 = nullable9;
        //        Decimal? nullable15 = nullable13.HasValue & nullable14.HasValue ? new Decimal?(nullable13.GetValueOrDefault() + nullable14.GetValueOrDefault()) : new Decimal?();
        //        nullable10 = nullable12;
        //        nullable7 = nullable15.HasValue & nullable10.HasValue ? new Decimal?(nullable15.GetValueOrDefault() + nullable10.GetValueOrDefault()) : new Decimal?();
        //        nullable6 = extension2.UsrInboundTrans;
        //        Decimal? nullable16;
        //        if (!(nullable7.HasValue & nullable6.HasValue))
        //        {
        //            nullable10 = new Decimal?();
        //            nullable16 = nullable10;
        //        }
        //        else
        //            nullable16 = new Decimal?(nullable7.GetValueOrDefault() + nullable6.GetValueOrDefault());
        //        nullable5 = nullable16;
        //    }
        //    else
        //    {
        //        Decimal? nullable6 = extension2.UsrSupplPrce;
        //        Decimal num1 = new Decimal(100);
        //        Decimal? usrSupplDisc = extension2.UsrSupplDisc;
        //        Decimal? nullable7 = usrSupplDisc.HasValue ? new Decimal?(num1 - usrSupplDisc.GetValueOrDefault()) : new Decimal?();
        //        Decimal? nullable8 = nullable6.HasValue & nullable7.HasValue ? new Decimal?(nullable6.GetValueOrDefault() * nullable7.GetValueOrDefault() / new Decimal(100)) : new Decimal?();
        //        Decimal num2 = (Decimal)1;
        //        nullable6 = extension2.UsrMarkupPerc;
        //        Decimal num3 = new Decimal(100);
        //        nullable7 = nullable6.HasValue ? new Decimal?(nullable6.GetValueOrDefault() / num3) : new Decimal?();
        //        Decimal? nullable9;
        //        if (!nullable7.HasValue)
        //        {
        //            nullable6 = new Decimal?();
        //            nullable9 = nullable6;
        //        }
        //        else
        //            nullable9 = new Decimal?(num2 - nullable7.GetValueOrDefault());
        //        Decimal? nullable10 = nullable9;
        //        nullable7 = nullable8;
        //        nullable6 = extension2.UsrCustDuty;
        //        Decimal? nullable11 = nullable7.HasValue & nullable6.HasValue ? new Decimal?(nullable7.GetValueOrDefault() * nullable6.GetValueOrDefault() / new Decimal(100)) : new Decimal?();
        //        Decimal? nullable12 = nullable8;
        //        Decimal? nullable13 = nullable10;
        //        Decimal? nullable14 = nullable12.HasValue & nullable13.HasValue ? new Decimal?(nullable12.GetValueOrDefault() / nullable13.GetValueOrDefault()) : new Decimal?();
        //        Decimal? nullable15 = nullable11;
        //        nullable6 = nullable14.HasValue & nullable15.HasValue ? new Decimal?(nullable14.GetValueOrDefault() + nullable15.GetValueOrDefault()) : new Decimal?();
        //        nullable7 = extension2.UsrInboundTrans;
        //        nullable5 = nullable6.HasValue & nullable7.HasValue ? new Decimal?(nullable6.GetValueOrDefault() + nullable7.GetValueOrDefault()) : new Decimal?();
        //    }
        //    return nullable5;
        //}

        //protected void SOOrder_UsrOldCalc_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e)
        //{
        //    Decimal? nullable1 = new Decimal?(Decimal.Zero);
        //    Decimal? nullable2 = new Decimal?(Decimal.Zero);
        //    Decimal? nullable3 = new Decimal?(Decimal.Zero);
        //    SOOrderExt extension1 = (SOOrderExt)PXCache<SOOrder>.GetExtension<SOOrderExt>((SOOrder)e.Row);
        //    using (IEnumerator<PXResult<SOLine>> enumerator = ((PXSelectBase<SOLine>)this.Base.Transactions).Select(new object[0]).GetEnumerator())
        //    {
        //        while (((IEnumerator)enumerator).MoveNext())
        //        {
        //            SOLine soLine = (enumerator.Current);
        //            SOLineExt extension2 = (SOLineExt)PXCache<SOLine>.GetExtension<SOLineExt>(soLine);
        //            bool? usrOldCalc = extension1.UsrOldCalc;
        //            bool flag = true;
        //            Decimal? nullable4;
        //            Decimal? nullable5;
        //            Decimal? nullable6;
        //            Decimal? nullable7;
        //            Decimal? nullable8;
        //            Decimal? nullable9;
        //            if (usrOldCalc.GetValueOrDefault() == flag & usrOldCalc.HasValue)
        //            {
        //                nullable4 = extension2.UsrSupplPrce;
        //                Decimal num = new Decimal(100);
        //                nullable5 = extension2.UsrSupplDisc;
        //                Decimal? nullable10;
        //                if (!nullable5.HasValue)
        //                {
        //                    nullable6 = new Decimal?();
        //                    nullable10 = nullable6;
        //                }
        //                else
        //                    nullable10 = new Decimal?(num - nullable5.GetValueOrDefault());
        //                nullable7 = nullable10;
        //                Decimal? nullable11;
        //                if (!(nullable4.HasValue & nullable7.HasValue))
        //                {
        //                    nullable5 = new Decimal?();
        //                    nullable11 = nullable5;
        //                }
        //                else
        //                    nullable11 = new Decimal?(nullable4.GetValueOrDefault() * nullable7.GetValueOrDefault() / new Decimal(100));
        //                Decimal? nullable12 = nullable11;
        //                nullable7 = nullable12;
        //                nullable4 = extension2.UsrMarkupPerc;
        //                Decimal? nullable13;
        //                if (!(nullable7.HasValue & nullable4.HasValue))
        //                {
        //                    nullable5 = new Decimal?();
        //                    nullable13 = nullable5;
        //                }
        //                else
        //                    nullable13 = new Decimal?(nullable7.GetValueOrDefault() * nullable4.GetValueOrDefault() / new Decimal(100));
        //                Decimal? nullable14 = nullable13;
        //                nullable5 = nullable12;
        //                nullable6 = nullable14;
        //                Decimal? nullable15;
        //                if (!(nullable5.HasValue & nullable6.HasValue))
        //                {
        //                    nullable8 = new Decimal?();
        //                    nullable15 = nullable8;
        //                }
        //                else
        //                    nullable15 = new Decimal?(nullable5.GetValueOrDefault() + nullable6.GetValueOrDefault());
        //                nullable4 = nullable15;
        //                nullable7 = extension2.UsrCustDuty;
        //                Decimal? nullable16;
        //                if (!(nullable4.HasValue & nullable7.HasValue))
        //                {
        //                    nullable6 = new Decimal?();
        //                    nullable16 = nullable6;
        //                }
        //                else
        //                    nullable16 = new Decimal?(nullable4.GetValueOrDefault() * nullable7.GetValueOrDefault() / new Decimal(100));
        //                Decimal? nullable17 = nullable16;
        //                SOLineExt soLineExt = extension2;
        //                nullable8 = nullable12;
        //                nullable9 = nullable14;
        //                nullable6 = nullable8.HasValue & nullable9.HasValue ? new Decimal?(nullable8.GetValueOrDefault() + nullable9.GetValueOrDefault()) : new Decimal?();
        //                nullable5 = nullable17;
        //                Decimal? nullable18;
        //                if (!(nullable6.HasValue & nullable5.HasValue))
        //                {
        //                    nullable9 = new Decimal?();
        //                    nullable18 = nullable9;
        //                }
        //                else
        //                    nullable18 = new Decimal?(nullable6.GetValueOrDefault() + nullable5.GetValueOrDefault());
        //                nullable7 = nullable18;
        //                nullable4 = extension2.UsrInboundTrans;
        //                Decimal? nullable19;
        //                if (!(nullable7.HasValue & nullable4.HasValue))
        //                {
        //                    nullable5 = new Decimal?();
        //                    nullable19 = nullable5;
        //                }
        //                else
        //                    nullable19 = new Decimal?(nullable7.GetValueOrDefault() + nullable4.GetValueOrDefault());
        //                soLineExt.UsrSellingPrce = nullable19;
        //                ((PXSelectBase<SOLine>)this.Base.Transactions).Update(soLine);
        //            }
        //            else
        //            {
        //                nullable4 = extension2.UsrSupplPrce;
        //                Decimal num1 = new Decimal(100);
        //                nullable5 = extension2.UsrSupplDisc;
        //                Decimal? nullable10;
        //                if (!nullable5.HasValue)
        //                {
        //                    nullable6 = new Decimal?();
        //                    nullable10 = nullable6;
        //                }
        //                else
        //                    nullable10 = new Decimal?(num1 - nullable5.GetValueOrDefault());
        //                nullable7 = nullable10;
        //                Decimal? nullable11;
        //                if (!(nullable4.HasValue & nullable7.HasValue))
        //                {
        //                    nullable5 = new Decimal?();
        //                    nullable11 = nullable5;
        //                }
        //                else
        //                    nullable11 = new Decimal?(nullable4.GetValueOrDefault() * nullable7.GetValueOrDefault() / new Decimal(100));
        //                Decimal? nullable12 = nullable11;
        //                Decimal num2 = (Decimal)1;
        //                nullable4 = extension2.UsrMarkupPerc;
        //                Decimal num3 = new Decimal(100);
        //                Decimal? nullable13;
        //                if (!nullable4.HasValue)
        //                {
        //                    nullable5 = new Decimal?();
        //                    nullable13 = nullable5;
        //                }
        //                else
        //                    nullable13 = new Decimal?(nullable4.GetValueOrDefault() / num3);
        //                nullable7 = nullable13;
        //                Decimal? nullable14;
        //                if (!nullable7.HasValue)
        //                {
        //                    nullable4 = new Decimal?();
        //                    nullable14 = nullable4;
        //                }
        //                else
        //                    nullable14 = new Decimal?(num2 - nullable7.GetValueOrDefault());
        //                Decimal? nullable15 = nullable14;
        //                nullable7 = nullable12;
        //                nullable4 = extension2.UsrCustDuty;
        //                Decimal? nullable16;
        //                if (!(nullable7.HasValue & nullable4.HasValue))
        //                {
        //                    nullable5 = new Decimal?();
        //                    nullable16 = nullable5;
        //                }
        //                else
        //                    nullable16 = new Decimal?(nullable7.GetValueOrDefault() * nullable4.GetValueOrDefault() / new Decimal(100));
        //                Decimal? nullable17 = nullable16;
        //                SOLineExt soLineExt = extension2;
        //                nullable9 = nullable12;
        //                nullable8 = nullable15;
        //                nullable5 = nullable9.HasValue & nullable8.HasValue ? new Decimal?(nullable9.GetValueOrDefault() / nullable8.GetValueOrDefault()) : new Decimal?();
        //                nullable6 = nullable17;
        //                Decimal? nullable18;
        //                if (!(nullable5.HasValue & nullable6.HasValue))
        //                {
        //                    nullable8 = new Decimal?();
        //                    nullable18 = nullable8;
        //                }
        //                else
        //                    nullable18 = new Decimal?(nullable5.GetValueOrDefault() + nullable6.GetValueOrDefault());
        //                nullable4 = nullable18;
        //                nullable7 = extension2.UsrInboundTrans;
        //                Decimal? nullable19;
        //                if (!(nullable4.HasValue & nullable7.HasValue))
        //                {
        //                    nullable6 = new Decimal?();
        //                    nullable19 = nullable6;
        //                }
        //                else
        //                    nullable19 = new Decimal?(nullable4.GetValueOrDefault() + nullable7.GetValueOrDefault());
        //                soLineExt.UsrSellingPrce = nullable19;
        //                ((PXSelectBase<SOLine>)this.Base.Transactions).Update(soLine);
        //            }
        //        }
        //    }
        //  ((PXView)((PXSelectBase)this.Base.Transactions).View).RequestRefresh();
        //}

    }
}
