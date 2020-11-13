//// Decompiled with JetBrains decompiler
//// Type: PX.Objects.CR.CR_Contact_ExistingColumn
//// Assembly: PCSBCRMSOARUPDATED, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
//// MVID: 182865F4-07BB-4D2C-9E47-9E96DF45516C
//// Assembly location: C:\Users\QuantumLingual107\AppData\Local\Temp\Vihywod\7ad39fc3ac\Bin\PCSBCRMSOARUPDATED.dll

using PX.Data;
using PX.Objects.CR.MassProcess;
using PX.Objects.CS;

namespace PX.Objects.CR
{
    [PXNonInstantiatedExtension]
    public class CRContactExistingColumn : PXCacheExtension<Contact>
    {
        [PXDBString(1, IsFixed = true)]
        [PXUIField(DisplayName = "Source")]
        [NSCRMSources]
        [PXMassMergableField]
        public string Source { get; set; }

        [PXDBString(1)]
        [PXUIField(DisplayName = "Aspen Status")]
        [PXStringList(new string[] { "P", "N", "L", "C", "O" }, new string[] { "Pending Negotiation", "Not Interested", "Pending Loan", "Confirmed Sale", "Others" })]
        public virtual string UsrLeadstage { get; set; }

        [PXDBString(30)]
        [PXUIField(DisplayName = "Region")]
        [PXSelector(typeof(Search<CSAttributeDetail.valueID, Where<CSAttributeDetail.attributeID, Equal<CRContactExistingColumn._Region>, And<CSAttributeDetail.disabled, Equal<boolFalse>>>>), CacheGlobal = false, DescriptionField = typeof(CSAttributeDetail.description))]
        public virtual string Usrregion { get; set; }

        [PXDBString(30)]
        [PXUIField(DisplayName = "Industry")]
        [PXSelector(typeof(Search<CSAttributeDetail.valueID, Where<CSAttributeDetail.attributeID, Equal<CRContactExistingColumn._Industry>, And<CSAttributeDetail.disabled, Equal<boolFalse>>>>), CacheGlobal = false, DescriptionField = typeof(CSAttributeDetail.description))]
        public virtual string Usrindustry { get; set; }

        [PXDBBool]
        [PXUIField(DisplayName = "Campaign Attended")]
        public virtual bool? UsrCampAttend { get; set; }

        [PXDBString(50)]
        [PXUIField(DisplayName = "Position Title")]
        //[PXSelector(typeof(Search<CSAttributeDetail.valueID, Where<CSAttributeDetail.attributeID, Equal<_EmpPOS>, And<CSAttributeDetail.disabled, Equal<boolFalse>>>>), CacheGlobal = true, SubstituteKey = typeof(CSAttributeDetail.description))]

        [PXSelector(typeof(Search<CSAttributeDetail.valueID, Where<CSAttributeDetail.attributeID, Equal<_EmpPOS>, And<CSAttributeDetail.disabled, Equal<boolFalse>>>, OrderBy<Asc<CSAttributeDetail.description>>>),
            typeof(CSAttributeDetail.disabled),
            typeof(CSAttributeDetail.valueID),
            typeof(CSAttributeDetail.description),
            CacheGlobal = true, DescriptionField = typeof(CSAttributeDetail.description))]
        public virtual string UsrPosTitle { get; set; }



        public abstract class usrLeadstage : IBqlField, IBqlOperand
        {
        }

        public abstract class usrregion : IBqlField, IBqlOperand
        {
        }

        public abstract class usrindustry : IBqlField, IBqlOperand
        {
        }

        public abstract class usrCampAttend : IBqlField, IBqlOperand
        {
        }

        public abstract class usrPosTitle : IBqlField, IBqlOperand
        {
        }

        public class _Industry : PX.Data.BQL.BqlString.Constant<_Industry>
        {
            public _Industry() : base("INDUSTRIES")
            {
            }
        }

        public class _EmpPOS : PX.Data.BQL.BqlString.Constant<_EmpPOS>
        {
            public _EmpPOS() : base("EMPPOS")
            {
            }
        }
        public class _desc : PX.Data.BQL.BqlString.Constant<_desc>
        {
            public _desc() : base("Project manager")
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
