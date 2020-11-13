// Decompiled with JetBrains decompiler
// Type: PX.Objects.CR.BAccountExt
// Assembly: PCSBCRMSOARUPDATED, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 182865F4-07BB-4D2C-9E47-9E96DF45516C
// Assembly location: C:\Users\QuantumLingual107\AppData\Local\Temp\Vihywod\7ad39fc3ac\Bin\PCSBCRMSOARUPDATED.dll

using PX.Data;
using PX.Objects.CS;
using PX.Objects.EP;

namespace PX.Objects.CR
{
    public class BAccountExt : PXCacheExtension<BAccount>
    {
        [PXDBString(30)]
        [PXUIField(DisplayName = "Business Unit")]
        [PXSelector(typeof(Search<CSAttributeDetail.valueID, Where<CSAttributeDetail.attributeID, Equal<BAccountExt._CC>, And<CSAttributeDetail.disabled, Equal<boolFalse>>>>), CacheGlobal = true, SubstituteKey = typeof(CSAttributeDetail.description))]
        public virtual string UsrBusUnit { get; set; }

        [PXDBString(10, InputMask = "", IsUnicode = true)]
        [PXUIField(DisplayName = "Industry")]
        [PXSelector(typeof(Search<CSAttributeDetail.valueID, Where<CSAttributeDetail.attributeID, Equal<BAccountExt._Industry>, And<CSAttributeDetail.disabled, Equal<boolFalse>>>>), CacheGlobal = false, DescriptionField = typeof(CSAttributeDetail.description))]
        public virtual string UsrIndustry { get; set; }

        [PXDBString(10, InputMask = "", IsUnicode = true)]
        [PXUIField(DisplayName = "Region")]
        [PXSelector(typeof(Search<CSAttributeDetail.valueID, Where<CSAttributeDetail.attributeID, Equal<BAccountExt._Region>, And<CSAttributeDetail.disabled, Equal<boolFalse>>>>), CacheGlobal = false, DescriptionField = typeof(CSAttributeDetail.description))]
        public virtual string UsrRegion { get; set; }

        [PXDBString(30)]
        [PXUIField(DisplayName = "Account Ref 2")]
        public virtual string UsrAccountRef { get; set; }

        [PXDBString(30)]
        [PXUIField(DisplayName = "Account Ref 3")]
        public virtual string UsrAccountRef3 { get; set; }

        [PXDBString(30)]
        [PXUIField(DisplayName = "Account Ref 4")]
        public virtual string UsrAccountRef4 { get; set; }

        [PXDBString(30)]
        [PXUIField(DisplayName = "Account Ref 5")]
        public virtual string UsrAccountRef5 { get; set; }

        [PXDBString(30)]
        [PXUIField(DisplayName = "Account Ref 6")]
        public virtual string UsrAccountRef6 { get; set; }

        [PXDBString(30)]
        [PXUIField(DisplayName = "Account Ref 7")]
        public virtual string UsrAccountRef7 { get; set; }

        [PXDBString(30)]
        [PXUIField(DisplayName = "Account Ref 8")]
        public virtual string UsrAccountRef8 { get; set; }

        [PXDBString(50)]
        [PXUIField(DisplayName = "Company Reg No.")]
        public virtual string UsrComRegNo { get; set; }

        [PXDBString(50)]
        [PXUIField(DisplayName = "GST NO")]
        public virtual string UsrGSTNO { get; set; }

        [PXDBString(50)]
        [PXUIField(DisplayName = "Division")]
        [PXSelector(typeof(Search<CSAttributeDetail.valueID, Where<CSAttributeDetail.attributeID, Equal<BAccountExt._Division>, And<CSAttributeDetail.disabled, Equal<boolFalse>>>>), CacheGlobal = true, SubstituteKey = typeof(CSAttributeDetail.description))]
        public virtual string UsrEmpDivision { get; set; }

        [PXDBString(50)]
        [PXUIField(DisplayName = "Section Code")]
        [PXSelector(typeof(Search<CSAttributeDetail.valueID, Where<CSAttributeDetail.attributeID, Equal<BAccountExt._Section>, And<CSAttributeDetail.disabled, Equal<boolFalse>>>>), CacheGlobal = true, SubstituteKey = typeof(CSAttributeDetail.description))]
        public virtual string UsrEmpSection { get; set; }

        [PXDBString(50)]
        [PXUIField(DisplayName = "Unit")]
        [PXSelector(typeof(Search<CSAttributeDetail.valueID, Where<CSAttributeDetail.attributeID, Equal<BAccountExt._Unit>, And<CSAttributeDetail.disabled, Equal<boolFalse>>>>), CacheGlobal = true, SubstituteKey = typeof(CSAttributeDetail.description))]
        public virtual string UsrEmpUnit { get; set; }

        [PXDBInt]
        [PXUIField(DisplayName = "Reporting Manager 1")]
        [PXEPEmployeeSelector]
        public virtual int? UsrReportMgr1 { get; set; }

        [PXDBInt]
        [PXUIField(DisplayName = "Reporting Manager 2")]
        [PXEPEmployeeSelector]
        public virtual int? UsrReportMgr2 { get; set; }



        public abstract class usrBusUnit : IBqlField, IBqlOperand
        {
        }

        public abstract class usrIndustry : IBqlField, IBqlOperand
        {
        }

        public abstract class usrRegion : IBqlField, IBqlOperand
        {
        }

        public abstract class usrAccountRef : IBqlField, IBqlOperand
        {
        }

        public abstract class usrAccountRef3 : IBqlField, IBqlOperand
        {
        }

        public abstract class usrAccountRef4 : IBqlField, IBqlOperand
        {
        }

        public abstract class usrAccountRef5 : IBqlField, IBqlOperand
        {
        }

        public abstract class usrAccountRef6 : IBqlField, IBqlOperand
        {
        }

        public abstract class usrAccountRef7 : IBqlField, IBqlOperand
        {
        }

        public abstract class usrAccountRef8 : IBqlField, IBqlOperand
        {
        }

        public abstract class usrComRegNo : IBqlField, IBqlOperand
        {
        }

        public abstract class usrGSTNO : IBqlField, IBqlOperand
        {
        }

        public abstract class usrEmpDivision : IBqlField, IBqlOperand
        {
        }

        public abstract class usrEmpSection : IBqlField, IBqlOperand
        {
        }

        public abstract class usrEmpUnit : IBqlField, IBqlOperand
        {
        }

        public abstract class usrReportMgr1 : IBqlField, IBqlOperand
        {
        }

        public abstract class usrReportMgr2 : IBqlField, IBqlOperand
        {
        }

        private class _CC : PX.Data.BQL.BqlString.Constant<_CC>
        {
            public _CC() : base("CC")
            {
            }
        }

        private class _Division : PX.Data.BQL.BqlString.Constant<_Division>
        {
            public _Division() : base("DIVISION")
            {
            }
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

        public class _Section : PX.Data.BQL.BqlString.Constant<_Section>
        {
            public _Section() : base("SECTION")
            {
            }
        }

        public class _Unit : PX.Data.BQL.BqlString.Constant<_Unit>
        {
            public _Unit() : base("UNIT")
            {
            }
        }
    }

    [PXNonInstantiatedExtension]
    public class EPEPEmployeeExistingColumn : PXCacheExtension<PX.Objects.EP.EPEmployee>
    {
        #region SupervisorID  
        [PXDBInt()]
        [PXEPEmployeeSelector]
        [PXUIField(DisplayName = "Reporting Manager", Visibility = PXUIVisibility.Visible)]
        public int? SupervisorID { get; set; }
        #endregion
    }
}
