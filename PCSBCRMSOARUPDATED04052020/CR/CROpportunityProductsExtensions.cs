using PX.Data.ReferentialIntegrity.Attributes;
using PX.Data;
using PX.Objects.AR;
using PX.Objects.CM.Extensions;
using PX.Objects.Common.Discount.Attributes;
using PX.Objects.Common.Discount;
using PX.Objects.Common;
using PX.Objects.CR;
using PX.Objects.CS;
using PX.Objects.GL;
using PX.Objects.IN;
using PX.Objects.PM;
using PX.Objects.SO;
using PX.Objects.TX;
using PX.Objects;
using System.Collections.Generic;
using System;

namespace PX.Objects.CR
{
    public class CROpportunityProductsExt : PXCacheExtension<PX.Objects.CR.CROpportunityProducts>
    {
        #region UsrSupplDisc
        [PXDBDecimal(2)]
        [PXUIField(DisplayName = "Supplier Disc.(%)")]
        [PXDefault(TypeCode.Decimal, "0.0", PersistingCheck = PXPersistingCheck.Nothing)]
        public virtual Decimal? UsrSupplDisc { get; set; }
        public abstract class usrSupplDisc : PX.Data.BQL.BqlDecimal.Field<usrSupplDisc> { }
        #endregion

        #region UsrCustDuty
        [PXDBDecimal(2)]
        [PXUIField(DisplayName = "Custom Duty(%)")]
        [PXDefault(TypeCode.Decimal, "0.0", PersistingCheck = PXPersistingCheck.Nothing)]
        public virtual Decimal? UsrCustDuty { get; set; }
        public abstract class usrCustDuty : PX.Data.BQL.BqlDecimal.Field<usrCustDuty> { }
        #endregion

        #region UsrMarkupPerc
        [PXDBDecimal(2)]
        [PXUIField(DisplayName = "Markup(%)")]
        [PXDefault(TypeCode.Decimal, "0.0", PersistingCheck = PXPersistingCheck.Nothing)]
        public virtual Decimal? UsrMarkupPerc { get; set; }
        public abstract class usrMarkupPerc : PX.Data.BQL.BqlDecimal.Field<usrMarkupPerc> { }
        #endregion

        #region UsrInboundTrans
        [PXDBDecimal(4)]
        [PXUIField(DisplayName = "Inbound Transport(RM)")]
        [PXDefault(TypeCode.Decimal, "0.0", PersistingCheck = PXPersistingCheck.Nothing)]
        public virtual Decimal? UsrInboundTrans { get; set; }
        public abstract class usrInboundTrans : PX.Data.BQL.BqlDecimal.Field<usrInboundTrans> { }
        #endregion

        #region UsrHiddenCost
        [PXDBDecimal(4)]
        [PXUIField(DisplayName = "Hidden Cost")]
        [PXDefault(TypeCode.Decimal, "0.0", PersistingCheck = PXPersistingCheck.Nothing)]
        public virtual Decimal? UsrHiddenCost { get; set; }
        public abstract class usrHiddenCost : PX.Data.BQL.BqlDecimal.Field<usrInboundTrans> { }
        #endregion

        #region UsrSellingPrce
        [PXDBDecimal(2)]
        [PXUIField(DisplayName = "Selling Price")]
        [PXDefault(TypeCode.Decimal, "0.0", PersistingCheck = PXPersistingCheck.Nothing)]
        public virtual Decimal? UsrSellingPrce { get; set; }
        public abstract class usrSellingPrce : PX.Data.BQL.BqlDecimal.Field<usrSellingPrce> { }
        #endregion

        #region UsrSupplPrce
        [PXDBDecimal(4)]
        [PXUIField(DisplayName = "Supplier Price(RM)")]
        [PXDefault(TypeCode.Decimal, "0.0", PersistingCheck = PXPersistingCheck.Nothing)]
        public virtual Decimal? UsrSupplPrce { get; set; }
        public abstract class usrSupplPrce : PX.Data.BQL.BqlDecimal.Field<usrSupplPrce> { }
        #endregion




        #region UsrSupplPrceCury
        [PXDBDecimal]
        [PXUIField(DisplayName = "Supplier Price(Cury)")]
        [PXDefault(TypeCode.Decimal, "0.0", PersistingCheck = PXPersistingCheck.Nothing)]
        public virtual Decimal? UsrSupplPrceCury { get; set; }
        public abstract class usrSupplPrceCury : PX.Data.BQL.BqlDecimal.Field<usrSupplPrceCury> { }
        #endregion


        #region UsrSupplCuryID
        //[PXDBInt]
        //[PXUIField(DisplayName = "Currency")]
        [PXDBString(5, IsUnicode = true, InputMask = ">LLLLL")]
        [PXDefault(typeof(Search<CRSetup.defaultCuryID>), PersistingCheck = PXPersistingCheck.Nothing)]
        [PXSelector(typeof(Currency.curyID))]
        [PXUIField(DisplayName = "Currency", Visibility = PXUIVisibility.SelectorVisible)]
        public virtual String UsrSupplCuryID { get; set; }
        public abstract class usrSupplCuryID : PX.Data.BQL.BqlInt.Field<usrSupplCuryID> { }
        #endregion

        #region UsrSupplCuryTypeID
        //[PXDBInt]
        [PXUIField(DisplayName = "Currency Type")]
        [PXDBString(6, IsUnicode = true)]
        [PXSelector(typeof(CurrencyRateType.curyRateTypeID))]
        public virtual String UsrSupplCuryTypeID { get; set; }
        public abstract class usrSupplCuryTypeID : PX.Data.BQL.BqlInt.Field<usrSupplCuryTypeID> { }
        #endregion

        #region UsrSupplCuryRate
        [PXDBDecimal]
        [PXUIField(DisplayName = "Currency Rate")]
        [PXDefault(TypeCode.Decimal, "0.0", PersistingCheck = PXPersistingCheck.Nothing)]
        public virtual Decimal? UsrSupplCuryRate { get; set; }
        public abstract class usrSupplCuryRate : PX.Data.BQL.BqlDecimal.Field<usrSupplCuryRate> { }
        #endregion

        #region UsrSalesTax
        [PXDBDecimal]
        [PXUIField(DisplayName = "Sales Tax(%)")]
        [PXDefault(TypeCode.Decimal, "0.0", PersistingCheck = PXPersistingCheck.Nothing)]
        public virtual Decimal? UsrSalesTax { get; set; }
        public abstract class usrSalesTax : PX.Data.BQL.BqlDecimal.Field<usrSalesTax> { }
        #endregion
    }
}