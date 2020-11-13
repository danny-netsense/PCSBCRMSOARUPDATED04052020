// Decompiled with JetBrains decompiler
// Type: PX.Objects.SO.SOOrderEntry_Extension
// Assembly: CRMLEADPMSB2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1D293427-6FA2-4530-ABEA-D4C25BB424EA
// Assembly location: C:\Users\QuantumLingual107\AppData\Local\Temp\Nywihyp\7ad39fc3ac\Bin\CRMLEADPMSB2.dll

using PX.Data;
using PX.Objects.CM;
using PX.Objects.CR;
using PX.Objects.IN;
using PX.Objects.PO;
using System;
using System.Collections;
using System.Collections.Generic;

namespace PX.Objects.SO
{
    public class SOOrderEntry_Extension : PXGraphExtension<SOOrderEntry>
    {
        protected void SOOrder_RowSelected(PXCache cache, PXRowSelectedEventArgs e)
        {
            SOOrder row = (SOOrder)e.Row;
            SOOrderExt extension = (SOOrderExt)PXCache<SOOrder>.GetExtension<SOOrderExt>(row);
            int num;
            if (extension.UsrCstEnqry.HasValue)
            {
                bool? usrCstEnqry = extension.UsrCstEnqry;
                num = (usrCstEnqry.GetValueOrDefault() ? 0 : (usrCstEnqry.HasValue ? 1 : 0)) == 0 ? 1 : 0;
            }
            else
                Base.Document.Cache.SetValueExt<SOOrderExt.usrCstEnqry>(row, false);
            num = 0;
            if (num != 0)
                return;
            cache.RaiseExceptionHandling<SOOrderExt.usrCstEnqry>((object)row, (object)extension.UsrCstEnqry, (Exception)new PXSetPropertyException(PropertyExceptionText2, (PXErrorLevel)2));

            //Code To Copy Opportunity_ID from opportunities Screen to Sales Order Screen Done By SD
            //SOOrder current = ((PXSelectBase<SOOrder>)this.Base.Document).Current;
            //if (current.OrderType == "SO")
            //{
            //    using (IEnumerator<PXResult<CRRelation>> enumerator = ((PXSelectBase<CRRelation>)this.Base.RelationsLink).Select(new object[0]).GetEnumerator())
            //    {
            //        while (((IEnumerator)enumerator).MoveNext())
            //        {
            //            CRRelation crRelation = (enumerator.Current);



            //            Guid? refNoteId = crRelation.RefNoteID;
            //            Guid? noteId = current.NoteID;
            //            //if ((refNoteId.HasValue == noteId.HasValue ? (refNoteId.HasValue ? (refNoteId.GetValueOrDefault() == noteId.GetValueOrDefault() ? 1 : 0) : 1) : 0) != 0 && crRelation.Role == "SR")
            //            if (crRelation.Role == "SR")
            //            {
            //                CROpportunity crOpportunity = (PXSelect<CROpportunity, Where<CROpportunity.noteID, Equal<Required<CROpportunity.noteID>>>>.Select(Base, crRelation.TargetNoteID));

            //                if (crOpportunity != null)
            //                {
            //                    ((SOOrderExt)PXCache<SOOrder>.GetExtension<SOOrderExt>(current)).UsrOpNum = crOpportunity.OpportunityID;
            //                    break;

            //                }
            //                break;
            //            }
            //        }
            //    }
            //}
            //End of Code
        }

        protected void SOOrder_UsrCstEnqry_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e)
        {
            SOOrder row = (SOOrder)e.Row;
            SOOrderExt extension = (SOOrderExt)PXCache<SOOrder>.GetExtension<SOOrderExt>(row);
            bool? usrCstEnqry = extension.UsrCstEnqry;
            if ((usrCstEnqry.GetValueOrDefault() ? 0 : (usrCstEnqry.HasValue ? 1 : 0)) == 0)
                return;
            cache.RaiseExceptionHandling<SOOrderExt.usrCstEnqry>((object)row, (object)extension.UsrCstEnqry, (Exception)new PXSetPropertyException(PropertyExceptionText, (PXErrorLevel)2));
        }

        protected void SOOrder_UsrOrdAcknlmt_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e)
        {
            SOOrder row = (SOOrder)e.Row;
            SOOrderExt extension = (SOOrderExt)PXCache<SOOrder>.GetExtension<SOOrderExt>(row);
            bool? usrOrdAcknlmt = extension.UsrOrdAcknlmt;
            if ((usrOrdAcknlmt.GetValueOrDefault() ? 0 : (usrOrdAcknlmt.HasValue ? 1 : 0)) == 0)
                return;
            cache.RaiseExceptionHandling<SOOrderExt.usrOrdAcknlmt>((object)row, (object)extension.UsrOrdAcknlmt, (Exception)new PXSetPropertyException(PropertyExceptionText, (PXErrorLevel)2));
        }
        public string PropertyExceptionText = "This Control not marked yet..! ";
        public string PropertyExceptionText2 = "Customer enquiry is not checked..! ";

        protected void SOLine_InventoryID_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e)
        {
            SOLine row = (SOLine)e.Row;
            SOOrderExt extension1 = (SOOrderExt)PXCache<SOOrder>.GetExtension<SOOrderExt>(((PXSelectBase<SOOrder>)this.Base.Document).Current);
            SOLineExt extension2 = (SOLineExt)PXCache<SOLine>.GetExtension<SOLineExt>(row);
            POVendorInventory poVendorInventory = (PXSelect<POVendorInventory, Where<POVendorInventory.inventoryID,
                Equal<Required<POVendorInventory.inventoryID>>>, OrderBy<Desc<POVendorInventory.createdDateTime>>>.Select(Base, row.InventoryID));
            if (poVendorInventory != null)
                extension2.UsrSupplPrce = poVendorInventory.LastPrice;
            extension2.UsrSellingPrce = this.CalcSellingPriceEngine(cache, row);
        }

        protected virtual void SOOrder_CuryID_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e)
        {
            //SOOrder sRow = (SOOrder)e.Row;
            //decimal? TotalLineAmt = 0;
            foreach (SOLine line in Base.Transactions.Select())
            {
                ////SOLineExt extension2 = (SOLineExt)PXCache<SOLine>.GetExtension<SOLineExt>(line);
                ////extension2.UsrSellingPrce = this.CalcSellingPriceEngine(cache, line);
                ////Base.Transactions.View.RequestRefresh();

                //SOLineExt extension = (SOLineExt)PXCache<SOLine>.GetExtension<SOLineExt>(line);
                //extension.UsrSellingPrce = this.CalcSellingPriceEngine(null, line);
                //Base.Transactions.Cache.SetValue<SOLineExt.usrSellingPrce>(line, extension.UsrSellingPrce);

                //line.CuryUnitPrice = (extension.UsrSellingPrce);
                ////SOLine soLine = line;
                ////Decimal? orderQty = line.OrderQty;
                ////Decimal? curyUnitPrice = line.CuryUnitPrice;
                ////Decimal? nullable = orderQty.HasValue & curyUnitPrice.HasValue ? new Decimal?(orderQty.GetValueOrDefault() * curyUnitPrice.GetValueOrDefault()) : new Decimal?();
                ////soLine.CuryLineAmt = (nullable);

                ////Base.Transactions.Cache.SetValueExt(line, "curyUnitPrice", line.CuryUnitPrice);
                ////Base.Transactions.Cache.SetValueExt(line, "unitPrice", line.UnitPrice);


                //Base.Transactions.Cache.SetValueExt<SOLine.curyUnitPrice>(line, line.CuryUnitPrice);
                //Base.Transactions.View.RequestRefresh();
                //Base.Document.View.RequestRefresh();



                SOLineExt extension2 = (SOLineExt)PXCache<SOLine>.GetExtension<SOLineExt>(line);
                extension2.UsrSellingPrce = this.CalcSellingPriceEngine(cache, line);
                line.CuryUnitPrice = (extension2.UsrSellingPrce);
                //Base.Opportunity.View.RequestRefresh();

                Base.Transactions.Cache.SetValueExt(line, "curyUnitPrice", line.CuryUnitPrice);
                Base.Transactions.View.RequestRefresh();
                //TotalLineAmt += line.LineAmt.Value;

            }

            //Base.Document.Cache.SetValueExt<SOOrder.lineTotal>(sRow, TotalLineAmt);
            //Base.Document.View.RequestRefresh();
        }

        public void _(Events.FieldUpdated<CurrencyInfo.sampleRecipRate> e)
        {
            foreach (SOLine line in Base.Transactions.Select())
            {
                //SOLineExt extension2 = (SOLineExt)PXCache<SOLine>.GetExtension<SOLineExt>(line);
                //extension2.UsrSellingPrce = this.CalcSellingPriceEngine(null, line);
                //Base.Transactions.View.RequestRefresh();

                SOLineExt extension = (SOLineExt)PXCache<SOLine>.GetExtension<SOLineExt>(line);
                extension.UsrSellingPrce = this.CalcSellingPriceEngine(null, line);
                Base.Transactions.Cache.SetValue<SOLineExt.usrSellingPrce>(line, extension.UsrSellingPrce);

                line.CuryUnitPrice = (extension.UsrSellingPrce);
                //SOLine soLine = line;
                //Decimal? orderQty = line.OrderQty;
                //Decimal? curyUnitPrice = line.CuryUnitPrice;
                //Decimal? nullable = orderQty.HasValue & curyUnitPrice.HasValue ? new Decimal?(orderQty.GetValueOrDefault() * curyUnitPrice.GetValueOrDefault()) : new Decimal?();
                //soLine.CuryLineAmt = (nullable);
                //Base.Transactions.Cache.SetValueExt(soLine, "curyUnitPrice", soLine.CuryUnitPrice);
                //Base.Transactions.Cache.SetValueExt(line, "curyUnitPrice", line.CuryUnitPrice);
                //Base.Transactions.Cache.SetValueExt(line, "unitPrice", line.UnitPrice);

                Base.Transactions.Cache.SetValueExt<SOLine.curyUnitPrice>(line, line.CuryUnitPrice);
                Base.Transactions.View.RequestRefresh();
                Base.Document.View.RequestRefresh();

            }
        }

        protected void SOLine_UsrCustDuty_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e)
        {
            //SOLine row = (SOLine)e.Row;
            //((SOLineExt)PXCache<SOLine>.GetExtension<SOLineExt>((SOLine)e.Row)).UsrSellingPrce = this.CalcSellingPriceEngine(cache, row);
            Calculate(cache, e);
        }

        protected void SOLine_UsrInboundTrans_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e)
        {
            //SOLine row = (SOLine)e.Row;
            //((SOLineExt)PXCache<SOLine>.GetExtension<SOLineExt>((SOLine)e.Row)).UsrSellingPrce = this.CalcSellingPriceEngine(cache, row);
            Calculate(cache, e);
        }
        protected void SOLine_UsrHiddenCost_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e)
        {
            //SOLine row = (SOLine)e.Row;
            //((SOLineExt)PXCache<SOLine>.GetExtension<SOLineExt>((SOLine)e.Row)).UsrSellingPrce = this.CalcSellingPriceEngine(cache, row);
            Calculate(cache, e);
        }
        protected void SOLine_UsrMarkupPerc_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e)
        {
            //SOLine row = (SOLine)e.Row;
            //((SOLineExt)PXCache<SOLine>.GetExtension<SOLineExt>((SOLine)e.Row)).UsrSellingPrce = this.CalcSellingPriceEngine(cache, row);
            Calculate(cache, e);
        }

        protected void SOLine_UsrSupplDisc_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e)
        {
            //SOLine row = (SOLine)e.Row;
            //((SOLineExt)PXCache<SOLine>.GetExtension<SOLineExt>((SOLine)e.Row)).UsrSellingPrce = this.CalcSellingPriceEngine(cache, row);
            Calculate(cache, e);
        }

        protected void SOLine_UsrSupplPrce_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e)
        {
            //SOLine row = (SOLine)e.Row;
            //((SOLineExt)PXCache<SOLine>.GetExtension<SOLineExt>((SOLine)e.Row)).UsrSellingPrce = this.CalcSellingPriceEngine(cache, row);
            Calculate(cache, e);
        }

        protected void SOLine_UsrSellingPrce_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e)
        {
            SOLine row = (SOLine)e.Row;
            SOLineExt extension = (SOLineExt)PXCache<SOLine>.GetExtension<SOLineExt>(row);
            row.CuryUnitPrice = (extension.UsrSellingPrce);
            //SOLine soLine = row;
            //Decimal? orderQty = row.OrderQty;
            //Decimal? curyUnitPrice = row.CuryUnitPrice;
            //Decimal? nullable = orderQty.HasValue & curyUnitPrice.HasValue ? new Decimal?(orderQty.GetValueOrDefault() * curyUnitPrice.GetValueOrDefault()) : new Decimal?();
            //soLine.CuryLineAmt = (nullable);

            Base.Transactions.Cache.SetValueExt(row, "curyUnitPrice", row.CuryUnitPrice);


            Base.Transactions.View.RequestRefresh();
        }

        private void Calculate(PXCache cache, PXFieldUpdatedEventArgs e)
        {
            SOLine row = (SOLine)e.Row;
            SOLineExt extension = (SOLineExt)PXCache<SOLine>.GetExtension<SOLineExt>(row);
            extension.UsrSellingPrce = this.CalcSellingPriceEngine(cache, row);
            cache.SetValue<SOLineExt.usrSellingPrce>(row, extension.UsrSellingPrce);

            row.CuryUnitPrice = (extension.UsrSellingPrce);
            //SOLine soLine = row;
            //Decimal? orderQty = row.OrderQty;
            //Decimal? curyUnitPrice = row.CuryUnitPrice;
            //Decimal? nullable = orderQty.HasValue & curyUnitPrice.HasValue ? new Decimal?(orderQty.GetValueOrDefault() * curyUnitPrice.GetValueOrDefault()) : new Decimal?();
            //soLine.CuryLineAmt = (nullable);

            //Base.Transactions.Cache.SetValueExt(row, "curyUnitPrice", row.CuryUnitPrice);
            //Base.Transactions.Cache.SetValueExt(row, "unitPrice", row.UnitPrice);

            cache.SetValueExt<SOLine.curyUnitPrice>(row, row.CuryUnitPrice);
            Base.Transactions.View.RequestRefresh();
        }


        // private Decimal? CalcSellingPriceEngine(PXCache cache, PXFieldUpdatedEventArgs e)
        private Decimal? CalcSellingPriceEngine(PXCache cache, SOLine row)
        {
            Decimal? nullable1 = new Decimal?(new Decimal(0));
            Decimal? nullable2 = new Decimal?(new Decimal(0));
            Decimal? nullable3 = new Decimal?(new Decimal(0));
            Decimal? nullable4 = new Decimal?(new Decimal(0));
            Decimal? nullable5 = new Decimal?(new Decimal(0));
            //SOLine row = (SOLine)e.Row;
            SOOrderExt extension1 = (SOOrderExt)PXCache<SOOrder>.GetExtension<SOOrderExt>(((PXSelectBase<SOOrder>)this.Base.Document).Current);
            SOLineExt extension2 = (SOLineExt)PXCache<SOLine>.GetExtension<SOLineExt>(row);
            bool? usrOldCalc = extension1.UsrOldCalc;
            Decimal? nullable6;


            if ((!usrOldCalc.GetValueOrDefault() ? 0 : (usrOldCalc.HasValue ? 1 : 0)) != 0)
            {
                Decimal? nullable7 = extension2.UsrSupplPrce;
                Decimal? usrSupplDisc = extension2.UsrSupplDisc;
                Decimal? nullable8 = usrSupplDisc.HasValue ? new Decimal?(new Decimal(100) - usrSupplDisc.GetValueOrDefault()) : new Decimal?();
                nullable7 = nullable7.HasValue & nullable8.HasValue ? new Decimal?(nullable7.GetValueOrDefault() * nullable8.GetValueOrDefault()) : new Decimal?();
                Decimal? nullable9;
                if (!nullable7.HasValue)
                {
                    nullable8 = new Decimal?();
                    nullable9 = nullable8;
                }
                else
                    nullable9 = new Decimal?(nullable7.GetValueOrDefault() / new Decimal(100));
                Decimal? nullable10 = nullable9;
                nullable7 = nullable10;
                nullable8 = extension2.UsrCustDuty;
                nullable7 = nullable7.HasValue & nullable8.HasValue ? new Decimal?(nullable7.GetValueOrDefault() * nullable8.GetValueOrDefault()) : new Decimal?();
                Decimal? nullable11;
                if (!nullable7.HasValue)
                {
                    nullable8 = new Decimal?();
                    nullable11 = nullable8;
                }
                else
                    nullable11 = new Decimal?(nullable7.GetValueOrDefault() / new Decimal(100));
                Decimal? nullable12 = nullable11;
                nullable7 = nullable10;
                nullable8 = nullable12;
                nullable7 = nullable7.HasValue & nullable8.HasValue ? new Decimal?(nullable7.GetValueOrDefault() + nullable8.GetValueOrDefault()) : new Decimal?();
                nullable8 = extension2.UsrInboundTrans;
                Decimal? nullable13 = nullable7.HasValue & nullable8.HasValue ? new Decimal?(nullable7.GetValueOrDefault() + nullable8.GetValueOrDefault()) : new Decimal?();
                nullable7 = nullable13;
                nullable8 = extension2.UsrMarkupPerc;
                nullable7 = nullable7.HasValue & nullable8.HasValue ? new Decimal?(nullable7.GetValueOrDefault() * nullable8.GetValueOrDefault()) : new Decimal?();
                Decimal? nullable14;
                if (!nullable7.HasValue)
                {
                    nullable8 = new Decimal?();
                    nullable14 = nullable8;
                }
                else
                    nullable14 = new Decimal?(nullable7.GetValueOrDefault() / new Decimal(100));
                Decimal? nullable15 = nullable14;
                nullable7 = nullable13;
                nullable8 = nullable15;
                nullable6 = nullable7.HasValue & nullable8.HasValue ? new Decimal?(nullable7.GetValueOrDefault() + nullable8.GetValueOrDefault()) : new Decimal?();
            }
            else
            {
                Decimal? nullable7 = extension2.UsrSupplPrce == null ? 0 : extension2.UsrSupplPrce;
                Decimal? usrSupplDisc = extension2.UsrSupplDisc == null ? 0 : extension2.UsrSupplDisc;
                Decimal? nullable8 = usrSupplDisc.HasValue ? new Decimal?(new Decimal(100) - usrSupplDisc.GetValueOrDefault()) : new Decimal?();
                nullable7 = nullable7.HasValue & nullable8.HasValue ? new Decimal?(nullable7.GetValueOrDefault() * nullable8.GetValueOrDefault()) : new Decimal?();
                Decimal? nullable9;
                if (!nullable7.HasValue)
                {
                    nullable8 = new Decimal?();
                    nullable9 = nullable8;
                }
                else
                    nullable9 = new Decimal?(nullable7.GetValueOrDefault() / new Decimal(100));
                Decimal? nullable10 = nullable9;
                nullable7 = nullable10;
                nullable8 = extension2.UsrCustDuty == null ? 0 : extension2.UsrCustDuty;
                nullable7 = nullable7.HasValue & nullable8.HasValue ? new Decimal?(nullable7.GetValueOrDefault() * nullable8.GetValueOrDefault()) : new Decimal?();
                Decimal? nullable11;
                if (!nullable7.HasValue)
                {
                    nullable8 = new Decimal?();
                    nullable11 = nullable8;
                }
                else
                    nullable11 = new Decimal?(nullable7.GetValueOrDefault() / new Decimal(100));
                Decimal? nullable12 = nullable11;
                nullable7 = nullable10;
                nullable8 = nullable12;
                nullable7 = nullable7.HasValue & nullable8.HasValue ? new Decimal?(nullable7.GetValueOrDefault() + nullable8.GetValueOrDefault()) : new Decimal?();
                nullable8 = extension2.UsrInboundTrans == null ? 0 : extension2.UsrInboundTrans;
                Decimal? nullable13 = nullable7.HasValue & nullable8.HasValue ? new Decimal?(nullable7.GetValueOrDefault() + nullable8.GetValueOrDefault()) : new Decimal?();
                nullable7 = extension2.UsrMarkupPerc == null ? 0 : extension2.UsrMarkupPerc;
                Decimal? nullable14;
                if (!nullable7.HasValue)
                {
                    nullable8 = new Decimal?();
                    nullable14 = nullable8;
                }
                else
                    nullable14 = new Decimal?(nullable7.GetValueOrDefault() / new Decimal(100));
                nullable7 = nullable14;
                Decimal? nullable15;
                if (!nullable7.HasValue)
                {
                    nullable8 = new Decimal?();
                    nullable15 = nullable8;
                }
                else
                    nullable15 = new Decimal?(new Decimal(1) - nullable7.GetValueOrDefault());
                Decimal? nullable16 = nullable15;
                nullable7 = nullable13;
                nullable8 = nullable16;
                nullable6 = nullable7.HasValue & nullable8.HasValue ? new Decimal?(nullable7.GetValueOrDefault() / nullable8.GetValueOrDefault()) : new Decimal?();
            }

            decimal amount = nullable6 == null ? 0 : (decimal)nullable6;
            CurrencyInfo ci = PXSetup<CurrencyInfo>.Select(this.Base);
            decimal excRate = ci.SampleRecipRate == null ? 1 : (decimal)ci.SampleRecipRate;
            decimal _return = amount * excRate;
            _return = _return + (extension2.UsrHiddenCost == null ? 0 : (decimal)extension2.UsrHiddenCost);   //Hidden cost will add after final Calculative Amount
            return _return;
        }

        protected void SOOrder_UsrOldCalc_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e)
        {
            Decimal? nullable1 = new Decimal?(new Decimal(0));
            Decimal? nullable2 = new Decimal?(new Decimal(0));
            Decimal? nullable3 = new Decimal?(new Decimal(0));
            Decimal? nullable4 = new Decimal?(new Decimal(0));
            SOOrderExt extension1 = (SOOrderExt)PXCache<SOOrder>.GetExtension<SOOrderExt>((SOOrder)e.Row);
            using (IEnumerator<PXResult<SOLine>> enumerator = ((PXSelectBase<SOLine>)this.Base.Transactions).Select(new object[0]).GetEnumerator())
            {
                while (((IEnumerator)enumerator).MoveNext())
                {
                    SOLine soLine = enumerator.Current;
                    SOLineExt extension2 = (SOLineExt)PXCache<SOLine>.GetExtension<SOLineExt>(soLine);
                    bool? usrOldCalc = extension1.UsrOldCalc;
                    Decimal? nullable5;
                    Decimal? nullable6;
                    if ((!usrOldCalc.GetValueOrDefault() ? 0 : (usrOldCalc.HasValue ? 1 : 0)) != 0)
                    {
                        nullable5 = extension2.UsrSupplPrce;
                        nullable6 = extension2.UsrSupplDisc;
                        nullable6 = nullable6.HasValue ? new Decimal?(new Decimal(100) - nullable6.GetValueOrDefault()) : new Decimal?();
                        nullable5 = nullable5.HasValue & nullable6.HasValue ? new Decimal?(nullable5.GetValueOrDefault() * nullable6.GetValueOrDefault()) : new Decimal?();
                        Decimal? nullable7;
                        if (!nullable5.HasValue)
                        {
                            nullable6 = new Decimal?();
                            nullable7 = nullable6;
                        }
                        else
                            nullable7 = new Decimal?(nullable5.GetValueOrDefault() / new Decimal(100));
                        Decimal? nullable8 = nullable7;
                        nullable5 = nullable8;
                        nullable6 = extension2.UsrCustDuty;
                        nullable5 = nullable5.HasValue & nullable6.HasValue ? new Decimal?(nullable5.GetValueOrDefault() * nullable6.GetValueOrDefault()) : new Decimal?();
                        Decimal? nullable9;
                        if (!nullable5.HasValue)
                        {
                            nullable6 = new Decimal?();
                            nullable9 = nullable6;
                        }
                        else
                            nullable9 = new Decimal?(nullable5.GetValueOrDefault() / new Decimal(100));

                        Decimal? nullable10 = nullable9;
                        nullable5 = nullable8;
                        nullable6 = nullable10;
                        nullable5 = nullable5.HasValue & nullable6.HasValue ? new Decimal?(nullable5.GetValueOrDefault() + nullable6.GetValueOrDefault()) : new Decimal?();
                        nullable6 = extension2.UsrInboundTrans;
                        Decimal? nullable11 = nullable5.HasValue & nullable6.HasValue ? new Decimal?(nullable5.GetValueOrDefault() + nullable6.GetValueOrDefault()) : new Decimal?();
                        nullable5 = nullable11;
                        nullable6 = extension2.UsrMarkupPerc;
                        nullable5 = nullable5.HasValue & nullable6.HasValue ? new Decimal?(nullable5.GetValueOrDefault() * nullable6.GetValueOrDefault()) : new Decimal?();
                        Decimal? nullable12;
                        if (!nullable5.HasValue)
                        {
                            nullable6 = new Decimal?();
                            nullable12 = nullable6;
                        }
                        else
                            nullable12 = new Decimal?(nullable5.GetValueOrDefault() / new Decimal(100));
                        Decimal? nullable13 = nullable12;
                        SOLineExt soLineExt = extension2;
                        nullable5 = nullable11;
                        nullable6 = nullable13;
                        Decimal? nullable14 = nullable5.HasValue & nullable6.HasValue ? new Decimal?(nullable5.GetValueOrDefault() + nullable6.GetValueOrDefault()) : new Decimal?();

                        decimal amount = nullable14 == null ? 0 : (decimal)nullable14;
                        CurrencyInfo ci = PXSetup<CurrencyInfo>.Select(this.Base);
                        decimal excRate = ci.SampleRecipRate == null ? 1 : (decimal)ci.SampleRecipRate;

                        soLineExt.UsrSellingPrce = amount * excRate + (extension2.UsrHiddenCost == null ? 0 : (decimal)extension2.UsrHiddenCost);   //Hidden cost will add after final Calculative Amount
                        ((PXSelectBase<SOLine>)this.Base.Transactions).Update(soLine);
                    }
                    else
                    {
                        nullable5 = extension2.UsrSupplPrce;
                        nullable6 = extension2.UsrSupplDisc;
                        nullable6 = nullable6.HasValue ? new Decimal?(new Decimal(100) - nullable6.GetValueOrDefault()) : new Decimal?();
                        nullable5 = nullable5.HasValue & nullable6.HasValue ? new Decimal?(nullable5.GetValueOrDefault() * nullable6.GetValueOrDefault()) : new Decimal?();
                        Decimal? nullable7;
                        if (!nullable5.HasValue)
                        {
                            nullable6 = new Decimal?();
                            nullable7 = nullable6;
                        }
                        else
                            nullable7 = new Decimal?(nullable5.GetValueOrDefault() / new Decimal(100));
                        Decimal? nullable8 = nullable7;
                        nullable5 = nullable8;
                        nullable6 = extension2.UsrCustDuty;
                        nullable5 = nullable5.HasValue & nullable6.HasValue ? new Decimal?(nullable5.GetValueOrDefault() * nullable6.GetValueOrDefault()) : new Decimal?();
                        Decimal? nullable9;
                        if (!nullable5.HasValue)
                        {
                            nullable6 = new Decimal?();
                            nullable9 = nullable6;
                        }
                        else
                            nullable9 = new Decimal?(nullable5.GetValueOrDefault() / new Decimal(100));
                        Decimal? nullable10 = nullable9;
                        nullable5 = nullable8;
                        nullable6 = nullable10;
                        nullable5 = nullable5.HasValue & nullable6.HasValue ? new Decimal?(nullable5.GetValueOrDefault() + nullable6.GetValueOrDefault()) : new Decimal?();
                        nullable6 = extension2.UsrInboundTrans;
                        Decimal? nullable11 = nullable5.HasValue & nullable6.HasValue ? new Decimal?(nullable5.GetValueOrDefault() + nullable6.GetValueOrDefault()) : new Decimal?();
                        nullable5 = extension2.UsrMarkupPerc;
                        Decimal? nullable12;
                        if (!nullable5.HasValue)
                        {
                            nullable6 = new Decimal?();
                            nullable12 = nullable6;
                        }
                        else
                            nullable12 = new Decimal?(nullable5.GetValueOrDefault() / new Decimal(100));
                        nullable5 = nullable12;
                        Decimal? nullable13;
                        if (!nullable5.HasValue)
                        {
                            nullable6 = new Decimal?();
                            nullable13 = nullable6;
                        }
                        else
                            nullable13 = new Decimal?(new Decimal(1) - nullable5.GetValueOrDefault());
                        Decimal? nullable14 = nullable13;
                        SOLineExt soLineExt = extension2;
                        nullable5 = nullable11;
                        nullable6 = nullable14;
                        Decimal? nullable15 = nullable5.HasValue & nullable6.HasValue ? new Decimal?(nullable5.GetValueOrDefault() / nullable6.GetValueOrDefault()) : new Decimal?();

                        decimal amount = nullable15 == null ? 0 : (decimal)nullable15;
                        CurrencyInfo ci = PXSetup<CurrencyInfo>.Select(this.Base);
                        decimal excRate = ci.SampleRecipRate == null ? 1 : (decimal)ci.SampleRecipRate;

                        soLineExt.UsrSellingPrce = amount * excRate + (extension2.UsrHiddenCost == null ? 0 : (decimal)extension2.UsrHiddenCost);   //Hidden cost will add after final Calculative Amount
                        ((PXSelectBase<SOLine>)this.Base.Transactions).Update(soLine);
                    }
                }
            }
          ((PXView)((PXSelectBase)this.Base.Transactions).View).RequestRefresh();
        }

    }
}
