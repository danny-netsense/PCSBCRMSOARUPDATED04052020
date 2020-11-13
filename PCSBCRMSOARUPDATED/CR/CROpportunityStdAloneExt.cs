// Decompiled with JetBrains decompiler
// Type: PX.Objects.CR.CROpportunityStdAloneExt
// Assembly: PCSBCRMSOARUPDATED, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 182865F4-07BB-4D2C-9E47-9E96DF45516C
// Assembly location: C:\Users\QuantumLingual107\AppData\Local\Temp\Vihywod\7ad39fc3ac\Bin\PCSBCRMSOARUPDATED.dll

using PX.Data;
using PX.Objects.CR.Standalone;
using PX.Objects.CS;

namespace PX.Objects.CR
{
    public class CROpportunityStdAloneExt : PXCacheExtension<PX.Objects.CR.Standalone.CROpportunity>
    {
        [PXDBString(30)]
        [PXUIField(DisplayName = "Region")]
        [PXSelector(typeof(Search<CSAttributeDetail.valueID, Where<CSAttributeDetail.attributeID, Equal<CROpportunityStdAloneExt._Region>, And<CSAttributeDetail.disabled, Equal<boolFalse>>>>), CacheGlobal = false, DescriptionField = typeof(CSAttributeDetail.description))]
        public virtual string Usrregion { get; set; }

        [PXDBString(30)]
        [PXUIField(DisplayName = "Industry")]
        [PXSelector(typeof(Search<CSAttributeDetail.valueID, Where<CSAttributeDetail.attributeID, Equal<CROpportunityStdAloneExt._Industry>, And<CSAttributeDetail.disabled, Equal<boolFalse>>>>), CacheGlobal = false, DescriptionField = typeof(CSAttributeDetail.description))]
        public virtual string Usrindustry { get; set; }



        public abstract class usrregion : IBqlField, IBqlOperand
        {
        }

        public abstract class usrindustry : IBqlField, IBqlOperand
        {
        }

        public class _Industry : PX.Data.BQL.BqlString.Constant<_Industry>
        {
            public _Industry() : base("INDUSTRIES")
            {
            }
        }

        public class _Region : PX.Data.BQL.BqlString.Constant<_Region>
        {
            public _Region() : base("REGION")
            {
            }
        }
    }
}
