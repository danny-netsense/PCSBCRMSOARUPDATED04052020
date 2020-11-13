using System;
using PX.Data;
using System.Collections;
using System.Collections.Generic;
using PX.Objects.PO;
using PX.Objects.SO;

namespace PX.Objects.CR
{
    public class QuoteMaint_Extension : PXGraphExtension<QuoteMaint>
    {


        public PXSetup<PX.Objects.GL.Company> Company;

        protected virtual void CRQuote_CuryID_FieldUpdating(PXCache cache, PXFieldUpdatingEventArgs e)
        {
            SOSetupExt sOSetupExt;
            SOSetup sOSetup = PXSelect<SOSetup>.Select(this.Base);
            if (sOSetup != null)
            {
                sOSetupExt = PXCache<SOSetup>.GetExtension<SOSetupExt>(sOSetup);
                if (sOSetupExt.UsrSQuotCuryType != null)
                {
                    CM.Extensions.CurrencyInfo ci = PXSetup<CM.Extensions.CurrencyInfo>.Select(this.Base);
                    ci.CuryRateTypeID = sOSetupExt.UsrSQuotCuryType;
                }
            }
        }
        protected virtual void CRQuote_CuryID_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e)
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

        protected void CROpportunityProducts_UsrSellingPrce_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e)
        {
            CROpportunityProducts row = (CROpportunityProducts)e.Row;
            CROpportunityProductsExt extension = (CROpportunityProductsExt)PXCache<CROpportunityProducts>.GetExtension<CROpportunityProductsExt>(row);
            row.CuryUnitPrice = (extension.UsrSellingPrce);

            Base.Products.Cache.SetValueExt(row, "curyUnitPrice", row.CuryUnitPrice);
            Base.Products.View.RequestRefresh();
            Base.Opportunity.View.RequestRefresh();
        }


        //'----------
        protected void CROpportunityProducts_UsrSalesTax_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e)
        {
            Calculate(cache, e);
        }

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
            CROpportunityProductsExt extension = cache.GetExtension<CROpportunityProductsExt>(row);
            //CROpportunityProductsExt extension = (CROpportunityProductsExt)PXCache<CROpportunityProducts>.GetExtension<CROpportunityProductsExt>(row);
            extension.UsrSellingPrce = this.CalcSellingPriceEngine(cache, row);
            Base.Products.Cache.SetValue<CROpportunityProductsExt.usrSellingPrce>(extension, extension.UsrSellingPrce);
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
            CROpportunityProductsExt extension2 = (CROpportunityProductsExt)PXCache<CROpportunityProducts>.GetExtension<CROpportunityProductsExt>(row);
            Decimal? nullable6;

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

            decimal amount = nullable6 == null ? 0 : (decimal)nullable6;

            CM.Extensions.CurrencyInfo ci = PXSetup<CM.Extensions.CurrencyInfo>.Select(this.Base);
            decimal excRate = ci.SampleRecipRate == null ? 1 : (decimal)ci.SampleRecipRate;

            decimal _return = amount * excRate;
            _return = _return + (extension2.UsrHiddenCost == null ? 0 : (decimal)extension2.UsrHiddenCost);   //Hidden cost will add after final Calculative Amount
            return _return;
        }

    }
}