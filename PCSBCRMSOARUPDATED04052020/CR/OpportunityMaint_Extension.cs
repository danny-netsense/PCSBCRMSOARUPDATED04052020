using PX.Data;
using PX.Data.Update;
using PX.Objects.AR;
using PX.Objects.CM;
using PX.Objects.CM.Extensions;
using PX.Objects.IN;
using PX.Objects.PO;
using PX.Objects.SO;
using System;
using System.Collections;
using System.Collections.Generic;

namespace PX.Objects.CR
{
    public class OpportunityMaint_Extension : PXGraphExtension<OpportunityMaint>
    {
        //[PXViewName(Messages.CreateSalesOrder)]
        //[PXCopyPasteHiddenView]
        //public PXFilter<OpportunityMaint.CreateSalesOrderFilter>
        //    CreateOrderParamsExt;

        public PXSetup<PX.Objects.GL.Company> Company;

        protected virtual void CROpportunity_CuryID_FieldUpdating(PXCache cache, PXFieldUpdatingEventArgs e)
        {
            SOSetupExt sOSetupExt;
            SOSetup sOSetup = PXSelect<SOSetup>.Select(this.Base);
            if (sOSetup != null)
            {
                sOSetupExt = PXCache<SOSetup>.GetExtension<SOSetupExt>(sOSetup);
                if (sOSetupExt.UsrOpporCuryType != null)
                {
                    CM.Extensions.CurrencyInfo ci = PXSetup<CM.Extensions.CurrencyInfo>.Select(this.Base);
                    ci.CuryRateTypeID = sOSetupExt.UsrOpporCuryType;
                }
            }
        }


        protected virtual void CROpportunity_CuryID_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e)
        {
            foreach (CROpportunityProducts line in Base.Products.Select())
            {
                CROpportunityProductsExt extension2 = (CROpportunityProductsExt)PXCache<CROpportunityProducts>.GetExtension<CROpportunityProductsExt>(line);
                extension2.UsrSellingPrce = this.CalcSellingPriceEngine(cache, line);
                line.CuryUnitPrice = (extension2.UsrSellingPrce);
                //Base.Opportunity.View.RequestRefresh();

                Base.Products.Cache.SetValueExt(line, "curyUnitPrice", line.CuryUnitPrice);
                Base.Products.View.RequestRefresh();
                Base.Opportunity.View.RequestRefresh();
            }

        }

        public void _(Events.FieldUpdated<CM.Extensions.CurrencyInfo.sampleRecipRate> e)
        {
            foreach (CROpportunityProducts line in Base.Products.Select())
            {

                CROpportunityProductsExt extension2 = (CROpportunityProductsExt)PXCache<CROpportunityProducts>.GetExtension<CROpportunityProductsExt>(line);
                extension2.UsrSellingPrce = this.CalcSellingPriceEngine(null, line);
                line.CuryUnitPrice = (extension2.UsrSellingPrce);
                //Base.Opportunity.View.RequestRefresh();

                Base.Products.Cache.SetValueExt(line, "curyUnitPrice", line.CuryUnitPrice);
                Base.Products.View.RequestRefresh();
                Base.Opportunity.View.RequestRefresh();
            }
        }


        protected void CROpportunityProducts_UsrCustDuty_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e)
        {

            //CROpportunityProducts row = (CROpportunityProducts)e.Row;
            //((CROpportunityProductsExt)PXCache<CROpportunityProducts>.GetExtension<CROpportunityProductsExt>((CROpportunityProducts)e.Row)).UsrSellingPrce = this.CalcSellingPriceEngine(cache, row);
            Calculate(cache, e);
        }

        protected void CROpportunityProducts_UsrInboundTrans_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e)
        {
            //CROpportunityProducts row = (CROpportunityProducts)e.Row;
            //((CROpportunityProductsExt)PXCache<CROpportunityProducts>.GetExtension<CROpportunityProductsExt>((CROpportunityProducts)e.Row)).UsrSellingPrce = this.CalcSellingPriceEngine(cache, row);
            Calculate(cache, e);
        }
        protected void CROpportunityProducts_UsrHiddenCost_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e)
        {
            //CROpportunityProducts row = (CROpportunityProducts)e.Row;
            //((CROpportunityProductsExt)PXCache<CROpportunityProducts>.GetExtension<CROpportunityProductsExt>((CROpportunityProducts)e.Row)).UsrSellingPrce = this.CalcSellingPriceEngine(cache, row);
            Calculate(cache, e);
        }
        protected void CROpportunityProducts_UsrMarkupPerc_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e)
        {
            //CROpportunityProducts row = (CROpportunityProducts)e.Row;
            //((CROpportunityProductsExt)PXCache<CROpportunityProducts>.GetExtension<CROpportunityProductsExt>((CROpportunityProducts)e.Row)).UsrSellingPrce = this.CalcSellingPriceEngine(cache, row);
            Calculate(cache, e);
        }

        protected void CROpportunityProducts_UsrSupplDisc_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e)
        {
            //CROpportunityProducts row = (CROpportunityProducts)e.Row;
            //((CROpportunityProductsExt)PXCache<CROpportunityProducts>.GetExtension<CROpportunityProductsExt>((CROpportunityProducts)e.Row)).UsrSellingPrce = this.CalcSellingPriceEngine(cache, row);
            Calculate(cache, e);
        }

        protected void CROpportunityProducts_UsrSupplPrce_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e)
        {
            //CROpportunityProducts row = (CROpportunityProducts)e.Row;
            //((CROpportunityProductsExt)PXCache<CROpportunityProducts>.GetExtension<CROpportunityProductsExt>((CROpportunityProducts)e.Row)).UsrSellingPrce = this.CalcSellingPriceEngine(cache, row);
            Calculate(cache, e);
        }

        protected void CROpportunityProducts_UsrSalesTax_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e)
        {
            Calculate(cache, e);
        }

        protected void CROpportunityProducts_UsrSellingPrce_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e)
        {
            CROpportunityProducts row = (CROpportunityProducts)e.Row;
            CROpportunityProductsExt extension = (CROpportunityProductsExt)PXCache<CROpportunityProducts>.GetExtension<CROpportunityProductsExt>(row);
            row.CuryUnitPrice = (extension.UsrSellingPrce);
        }


        //'----------

        protected void CROpportunityProducts_UsrSupplPrceCury_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e)
        {
            CROpportunityProducts row = (CROpportunityProducts)e.Row;
            CROpportunityProductsExt extension = (CROpportunityProductsExt)PXCache<CROpportunityProducts>.GetExtension<CROpportunityProductsExt>(row);
            extension.UsrSupplPrce = extension.UsrSupplPrceCury * (extension.UsrSupplCuryRate == null ? 0 : extension.UsrSupplCuryRate);
            Base.Products.Cache.SetValueExt(row, "usrSupplPrce", extension.UsrSupplPrce);
            Base.Products.View.RequestRefresh();
        }

        protected void CROpportunityProducts_UsrSupplCuryID_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e)
        {
            CROpportunityProducts row = (CROpportunityProducts)e.Row;
            CROpportunityProductsExt extension = (CROpportunityProductsExt)PXCache<CROpportunityProducts>.GetExtension<CROpportunityProductsExt>(row);
            if (extension.UsrSupplCuryTypeID == null)
            {
                extension.UsrSupplCuryTypeID = GetDefaultCuryType();
            }
            CM.Extensions.CurrencyInfo ci = PXSetup<CM.Extensions.CurrencyInfo>.Select(this.Base);
            extension.UsrSupplCuryRate = GetCuryRate(cache, extension.UsrSupplCuryID, ci.BaseCuryID, extension.UsrSupplCuryTypeID);
            extension.UsrSupplPrce = extension.UsrSupplPrceCury * extension.UsrSupplCuryRate;
            Base.Products.Cache.SetValueExt(row, "usrSupplPrce", extension.UsrSupplPrce);
            Base.Products.View.RequestRefresh();
        }
        protected void CROpportunityProducts_UsrSupplCuryTypeID_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e)
        {
            CROpportunityProducts row = (CROpportunityProducts)e.Row;
            CROpportunityProductsExt extension = (CROpportunityProductsExt)PXCache<CROpportunityProducts>.GetExtension<CROpportunityProductsExt>(row);
            CM.Extensions.CurrencyInfo ci = PXSetup<CM.Extensions.CurrencyInfo>.Select(this.Base);
            extension.UsrSupplCuryRate = GetCuryRate(cache, extension.UsrSupplCuryID, ci.BaseCuryID, extension.UsrSupplCuryTypeID);
            extension.UsrSupplPrce = extension.UsrSupplPrceCury * extension.UsrSupplCuryRate;
            Base.Products.Cache.SetValueExt(row, "usrSupplPrce", extension.UsrSupplPrce);
            Base.Products.View.RequestRefresh();
        }

        private string GetDefaultCuryType()
        {
            //PXSelect<CM.CurrencyRateType, Where<CM.CurrencyRateType.curyRateTypeID, Equal<Argument<string>>>> curyType;

            //if (curyType.Select("WEBUY").Count > 0)
            //{
            return "WEBUY";
            //}
            //else
            //{
            //return "";
            //}

        }

        private class defaultCuryTypeDet : PX.Data.BQL.BqlString.Constant<defaultCuryTypeDet>
        {
            public defaultCuryTypeDet() : base("WEBUY")
            {
            }
        }

        private decimal GetCuryRate(PXCache cache, string fromCuryID, string toCuryID, string CuryTypeID)
        {

            if (string.Equals(fromCuryID, toCuryID, StringComparison.OrdinalIgnoreCase))
            {
                return 1;
            }

            PX.Objects.CM.CurrencyRate cr = PXSelectReadonly<PX.Objects.CM.CurrencyRate,
                             Where<PX.Objects.CM.CurrencyRate.toCuryID, Equal<Required<PX.Objects.CM.CurrencyInfo.baseCuryID>>,
                             And<PX.Objects.CM.CurrencyRate.fromCuryID, Equal<Required<PX.Objects.CM.CurrencyInfo.curyID>>,
                             And<PX.Objects.CM.CurrencyRate.curyRateType, Equal<Required<PX.Objects.CM.CurrencyInfo.curyRateTypeID>>,
                             And<PX.Objects.CM.CurrencyRate.curyEffDate, LessEqual<Required<PX.Objects.CM.CurrencyInfo.curyEffDate>>>>>>,
                             OrderBy<Desc<PX.Objects.CM.CurrencyRate.curyEffDate>>>.SelectWindowed(cache.Graph, 0, 1, toCuryID, fromCuryID, CuryTypeID, DateTime.Now.Date);

            if (cr == null)
            {
                return 0;
            }
            return cr.CuryRate == null ? 0 : (decimal)cr.CuryRate;
        }

        //-------

        private void Calculate(PXCache cache, PXFieldUpdatedEventArgs e)
        {
            CROpportunityProducts row = (CROpportunityProducts)e.Row;
            CROpportunityProductsExt extension = (CROpportunityProductsExt)PXCache<CROpportunityProducts>.GetExtension<CROpportunityProductsExt>(row);
            extension.UsrSellingPrce = this.CalcSellingPriceEngine(cache, row);
            row.CuryUnitPrice = (extension.UsrSellingPrce);
            Base.Products.Cache.SetValueExt(row, "curyUnitPrice", row.CuryUnitPrice);
            Base.Products.View.RequestRefresh();
            Base.Opportunity.View.RequestRefresh();

        }


        protected void CROpportunityProducts_InventoryID_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e)
        {
            ////CROpportunityProducts row = (CROpportunityProducts)e.Row;
            ////CROpportunityProductsExt extension2 = (CROpportunityProductsExt)PXCache<CROpportunityProducts>.GetExtension<CROpportunityProductsExt>(row);
            ////POVendorInventory poVendorInventory = (PXSelect<POVendorInventory, Where<POVendorInventory.inventoryID,
            ////   Equal<Required<POVendorInventory.inventoryID>>>, OrderBy<Desc<POVendorInventory.createdDateTime>>>.Select(Base, row.InventoryID));
            ////if (poVendorInventory != null)
            ////    extension2.UsrSupplPrce = poVendorInventory.LastPrice;
            ////extension2.UsrSellingPrce = this.CalcSellingPriceEngine(cache, row);
        }

        // private Decimal? CalcSellingPriceEngine(PXCache cache, PXFieldUpdatedEventArgs e)
        private Decimal? CalcSellingPriceEngine(PXCache cache, CROpportunityProducts row)
        {
            Decimal? nullable1 = new Decimal?(new Decimal(0));
            Decimal? nullable2 = new Decimal?(new Decimal(0));
            Decimal? nullable3 = new Decimal?(new Decimal(0));
            Decimal? nullable4 = new Decimal?(new Decimal(0));
            Decimal? nullable5 = new Decimal?(new Decimal(0));
            //CROpportunityProducts row = (CROpportunityProducts)e.Row;
            CROpportunityExt extension1 = (CROpportunityExt)PXCache<CROpportunity>.GetExtension<CROpportunityExt>(((PXSelectBase<CROpportunity>)this.Base.Opportunity).Current);
            CROpportunityProductsExt extension2 = (CROpportunityProductsExt)PXCache<CROpportunityProducts>.GetExtension<CROpportunityProductsExt>(row);
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
                nullable8 = (extension2.UsrCustDuty == null ? 0 : extension2.UsrCustDuty) + (extension2.UsrSalesTax == null ? 0 : extension2.UsrSalesTax);
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
                nullable8 = (extension2.UsrCustDuty == null ? 0 : extension2.UsrCustDuty) + (extension2.UsrSalesTax == null ? 0 : extension2.UsrSalesTax);
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

            CM.Extensions.CurrencyInfo ci = PXSetup<CM.Extensions.CurrencyInfo>.Select(this.Base);
            decimal excRate = ci.SampleRecipRate == null ? 1 : (decimal)ci.SampleRecipRate;

            decimal _return = amount * excRate;
            _return = _return + (extension2.UsrHiddenCost == null ? 0 : (decimal)extension2.UsrHiddenCost);   //Hidden cost will add after final Calculative Amount
            return _return;
        }
        protected void CROpportunity_UsrOldCalc_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e, PXFieldUpdated InvokeBaseHandler)
        {
            Decimal? nullable1 = new Decimal?(new Decimal(0));
            Decimal? nullable2 = new Decimal?(new Decimal(0));
            Decimal? nullable3 = new Decimal?(new Decimal(0));
            Decimal? nullable4 = new Decimal?(new Decimal(0));
            CROpportunityExt extension1 = (CROpportunityExt)PXCache<CROpportunity>.GetExtension<CROpportunityExt>((CROpportunity)e.Row);
            using (IEnumerator<PXResult<CROpportunityProducts>> enumerator = ((PXSelectBase<CROpportunityProducts>)this.Base.Products).Select(new object[0]).GetEnumerator())
            {
                while (((IEnumerator)enumerator).MoveNext())
                {
                    CROpportunityProducts CROpportunityProducts = enumerator.Current;
                    CROpportunityProductsExt extension2 = (CROpportunityProductsExt)PXCache<CROpportunityProducts>.GetExtension<CROpportunityProductsExt>(CROpportunityProducts);
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
                        CROpportunityProductsExt CROpportunityProductsExt = extension2;
                        nullable5 = nullable11;
                        nullable6 = nullable13;
                        Decimal? nullable14 = nullable5.HasValue & nullable6.HasValue ? new Decimal?(nullable5.GetValueOrDefault() + nullable6.GetValueOrDefault()) : new Decimal?();

                        decimal amount = nullable14 == null ? 0 : (decimal)nullable14;
                        CM.Extensions.CurrencyInfo ci = PXSetup<CM.Extensions.CurrencyInfo>.Select(this.Base);
                        decimal excRate = ci.SampleRecipRate == null ? 1 : (decimal)ci.SampleRecipRate;

                        CROpportunityProductsExt.UsrSellingPrce = (amount * excRate) + (extension2.UsrHiddenCost == null ? 0 : (decimal)extension2.UsrHiddenCost);   //Hidden cost will add after final Calculative Amount
                        ((PXSelectBase<CROpportunityProducts>)this.Base.Products).Update(CROpportunityProducts);
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
                        CROpportunityProductsExt CROpportunityProductsExt = extension2;
                        nullable5 = nullable11;
                        nullable6 = nullable14;
                        Decimal? nullable15 = nullable5.HasValue & nullable6.HasValue ? new Decimal?(nullable5.GetValueOrDefault() / nullable6.GetValueOrDefault()) : new Decimal?();

                        decimal amount = nullable15 == null ? 0 : (decimal)nullable15;
                        CM.Extensions.CurrencyInfo ci = PXSetup<CM.Extensions.CurrencyInfo>.Select(this.Base);
                        decimal excRate = ci.SampleRecipRate == null ? 1 : (decimal)ci.SampleRecipRate;

                        CROpportunityProductsExt.UsrSellingPrce = (amount * excRate) + (extension2.UsrHiddenCost == null ? 0 : (decimal)extension2.UsrHiddenCost);   //Hidden cost will add after final Calculative Amount
                        ((PXSelectBase<CROpportunityProducts>)this.Base.Products).Update(CROpportunityProducts);
                    }
                }
            }
        ((PXView)((PXSelectBase)this.Base.Products).View).RequestRefresh();
        }




        ////public delegate void CreateShipmentDelegate(SOOrder order, int? SiteID, DateTime? ShipDate, bool? useOptimalShipDate, string operation, DocumentList<SOShipment> list);
        ////[PXOverride]
        ////public virtual void CreateShipment(SOOrder order, int? SiteID, DateTime? ShipDate, bool? useOptimalShipDate, string operation, DocumentList<SOShipment> list, CreateShipmentDelegate baseMethod)
        ////{
        ////    //Code before base call
        ////    baseMethod(order, SiteID, ShipDate, useOptimalShipDate, operation, list);
        ////    //Code after base call
        ////}

        //[PXOverride]
        //protected virtual IEnumerable CreateSalesOrder(PXAdapter adapter)
        //{

        //    this.Base.createSalesOrder.Press(adapter);
        //    return adapter.Get();
        //}


       
        //public PXAction<CROpportunity> createSalesOrder;
        //[PXUIField(DisplayName = Messages.CreateSalesOrder, MapEnableRights = PXCacheRights.Update, MapViewRights = PXCacheRights.Select)]
        //[PXButton(ImageKey = PX.Web.UI.Sprite.Main.DataEntry)]
        //public virtual IEnumerable CreateSalesOrder(PXAdapter adapter)
        //{

        //    SOSetupExt sOSetupExt;
        //    SOSetup sOSetup = PXSelect<SOSetup>.Select(this.Base);
        //    if (sOSetup != null)
        //    {
        //        sOSetupExt = PXCache<SOSetup>.GetExtension<SOSetupExt>(sOSetup);
        //        if (sOSetupExt.UsrSOCuryType != null)
        //        {
        //            CM.Extensions.CurrencyInfo ci = PXSetup<CM.Extensions.CurrencyInfo>.Select(this.Base);
        //            ci.CuryRateTypeID = sOSetupExt.UsrSOCuryType;
        //        }
        //    }

        //    Base.createSalesOrder.Press(adapter);

        //    if (sOSetup != null)
        //    {
        //        sOSetupExt = PXCache<SOSetup>.GetExtension<SOSetupExt>(sOSetup);
        //        if (sOSetupExt.UsrOpporCuryType != null)
        //        {
        //            CM.Extensions.CurrencyInfo ci = PXSetup<CM.Extensions.CurrencyInfo>.Select(this.Base);
        //            ci.CuryRateTypeID = sOSetupExt.UsrOpporCuryType;
        //        }
        //    }
        //    return adapter.Get();

        //    ////foreach (CROpportunity opportunity in adapter.Get())
        //    ////{
        //    ////    SOSetupExt sOSetupExt;
        //    ////    SOSetup sOSetup = PXSelect<SOSetup>.Select(this.Base);
        //    ////    if (sOSetup != null)
        //    ////    {
        //    ////        sOSetupExt = PXCache<SOSetup>.GetExtension<SOSetupExt>(sOSetup);
        //    ////        if (sOSetupExt.UsrSOCuryType != null)
        //    ////        {
        //    ////            CM.Extensions.CurrencyInfo ci = PXSetup<CM.Extensions.CurrencyInfo>.Select(this.Base);
        //    ////            ci.CuryRateTypeID = sOSetupExt.UsrSOCuryType;
        //    ////            Base.Opportunity.Cache.SetValueExt(opportunity, "curyID", opportunity.CuryID);
        //    ////        }
        //    ////    }

        //    ////}
        //    ////return Base.createSalesOrder.Press(adapter);

        //    //foreach (CROpportunity opportunity in adapter.Get())
        //    //{
        //    //    Customer customer = (Customer)PXSelect<Customer, Where<Customer.bAccountID, Equal<Current<CROpportunity.bAccountID>>>>
        //    //        .SelectSingleBound(this, new object[] { opportunity });
        //    //    if (customer == null)
        //    //    {
        //    //        throw new PXException(Messages.ProspectNotCustomer);
        //    //    }

        //    //    if (CreateOrderParams.AskExtFullyValid((graph, viewName) => { }, DialogAnswerType.Positive))
        //    //    {
        //    //        Actions.PressSave();
        //    //        PXLongOperation.StartOperation(this, delegate ()
        //    //        {
        //    //            var grapph = PXGraph.CreateInstance<OpportunityMaint>();
        //    //            grapph.Opportunity.Current = opportunity;
        //    //            grapph.CreateOrderParams.Current = CreateOrderParams.Current;
        //    //            grapph.DoCreateSalesOrder(CreateOrderParams.Current);
        //    //        });
        //    //    }
        //    //    yield return opportunity;
        //    //}

        //}


    }





}