using PX.Data.ReferentialIntegrity.Attributes;
using PX.Data;
using PX.Objects.CS;
using PX.Objects.EP;
using PX.Objects.GL;
using PX.Objects.SO;
using PX.Objects;
using System.Collections.Generic;
using System;
using PX.Objects.CM;

namespace PX.Objects.SO
{
    public class SOSetupExt : PXCacheExtension<PX.Objects.SO.SOSetup>
    {
        #region UsrOpporCuryType
        [PXUIField(DisplayName = "Opportunity Currency Type")]
        [PXDBString(6, IsUnicode = true)]
        [PXSelector(typeof(CurrencyRateType.curyRateTypeID))]
        public virtual string UsrOpporCuryType { get; set; }
        public abstract class usrOpporCuryType : PX.Data.BQL.BqlString.Field<usrOpporCuryType> { }
        #endregion

        #region UsrSQuotCuryType
        [PXUIField(DisplayName = "Sales Quote Currency Type")]
        [PXDBString(6, IsUnicode = true)]
        [PXSelector(typeof(CurrencyRateType.curyRateTypeID))]

        public virtual string UsrSQuotCuryType { get; set; }
        public abstract class usrSQuotCuryType : PX.Data.BQL.BqlString.Field<usrSQuotCuryType> { }
        #endregion

        #region UsrSOCuryType
        [PXUIField(DisplayName = "Sales Order Currency Type")]
        [PXDBString(6, IsUnicode = true)]
        [PXSelector(typeof(CurrencyRateType.curyRateTypeID))]
        public virtual string UsrSOCuryType { get; set; }
        public abstract class usrSOCuryType : PX.Data.BQL.BqlString.Field<usrSOCuryType> { }
        #endregion
    }
}