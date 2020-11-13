// Decompiled with JetBrains decompiler
// Type: PX.Objects.SO.SOOrderExt
// Assembly: PCSBCRMSOARUPDATED, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 182865F4-07BB-4D2C-9E47-9E96DF45516C
// Assembly location: C:\Users\QuantumLingual107\AppData\Local\Temp\Vihywod\7ad39fc3ac\Bin\PCSBCRMSOARUPDATED.dll

using PX.Data;
using PX.Objects.CS;

namespace PX.Objects.SO
{
    public class SOOrderExt : PXCacheExtension<SOOrder>
    {
        [PXDBBool]
        [PXDefault(false, PersistingCheck = PXPersistingCheck.Nothing)]
        [PXUIField(DisplayName = "YES")]
        public virtual bool? UsrLegalReq { get; set; }

        [PXDBBool]
        [PXDefault(true, PersistingCheck = PXPersistingCheck.Nothing)]
        [PXUIField(DisplayName = "NO")]
        public virtual bool? UsrNLegalReq { get; set; }

        [PXDBBool]
        [PXDefault(false, PersistingCheck = PXPersistingCheck.Nothing)]
        [PXUIField(DisplayName = "YES")]
        public virtual bool? UsrProjectInsReq { get; set; }

        [PXDBBool]
        [PXDefault(true, PersistingCheck = PXPersistingCheck.Nothing)]
        [PXUIField(DisplayName = "NO")]
        public virtual bool? UsrNProjectInsReq { get; set; }

        [PXDBBool]
        [PXDefault(false, PersistingCheck = PXPersistingCheck.Nothing)]
        [PXUIField(DisplayName = "YES")]
        public virtual bool? UsrContractPnlty { get; set; }

        [PXDBBool]
        [PXDefault(true, PersistingCheck = PXPersistingCheck.Nothing)]
        [PXUIField(DisplayName = "NO")]
        public virtual bool? UsrNContractPnlty { get; set; }

        [PXDBBool]
        [PXDefault(false, PersistingCheck = PXPersistingCheck.Nothing)]
        [PXUIField(DisplayName = "YES")]
        public virtual bool? UsrCorrectCstCen { get; set; }

        [PXDBBool]
        [PXDefault(true, PersistingCheck = PXPersistingCheck.Nothing)]
        [PXUIField(DisplayName = "NO")]
        public virtual bool? UsrNCorrectCstCen { get; set; }

        [PXDBBool]
        [PXDefault(false, PersistingCheck = PXPersistingCheck.Nothing)]
        [PXUIField(DisplayName = "YES")]
        public virtual bool? UsrCorrectPOValue { get; set; }

        [PXDBBool]
        [PXDefault(true, PersistingCheck = PXPersistingCheck.Nothing)]
        [PXUIField(DisplayName = "NO")]
        public virtual bool? UsrNCorrectPOValue { get; set; }

        [PXDBBool]
        [PXDefault(false, PersistingCheck = PXPersistingCheck.Nothing)]
        [PXUIField(DisplayName = "YES")]
        public virtual bool? UsrCorrectIncoterm { get; set; }

        [PXDBBool]
        [PXDefault(true, PersistingCheck = PXPersistingCheck.Nothing)]
        [PXUIField(DisplayName = "NO")]
        public virtual bool? UsrNCorrectIncoterm { get; set; }

        [PXDBBool]
        [PXDefault(false, PersistingCheck = PXPersistingCheck.Nothing)]
        [PXUIField(DisplayName = "YES")]
        public virtual bool? UsrCorrectPayTerm { get; set; }

        [PXDBBool]
        [PXDefault(true, PersistingCheck = PXPersistingCheck.Nothing)]
        [PXUIField(DisplayName = "NO")]
        public virtual bool? UsrNCorrectPayTerm { get; set; }

        [PXDBBool]
        [PXDefault(false, PersistingCheck = PXPersistingCheck.Nothing)]
        [PXUIField(DisplayName = "YES")]
        public virtual bool? UsrCorrectQtRefNo { get; set; }

        [PXDBBool]
        [PXDefault(true, PersistingCheck = PXPersistingCheck.Nothing)]
        [PXUIField(DisplayName = "NO")]
        public virtual bool? UsrNCorrectQtRefNo { get; set; }

        [PXDBBool]
        [PXDefault(false, PersistingCheck = PXPersistingCheck.Nothing)]
        [PXUIField(DisplayName = "YES")]
        public virtual bool? UsrSpecialInst { get; set; }

        [PXDBBool]
        [PXDefault(true, PersistingCheck = PXPersistingCheck.Nothing)]
        [PXUIField(DisplayName = "NO")]
        public virtual bool? UsrNSpecialInst { get; set; }

        [PXDBString(250)]
        [PXUIField(DisplayName = "")]
        public virtual string UsrRemarkSpecialInst { get; set; }

        [PXDBString(250)]
        [PXUIField(DisplayName = "")]
        public virtual string UsrRemarkContractPnlty { get; set; }

        [PXDBString(250)]
        [PXUIField(DisplayName = "")]
        public virtual string UsrRemarkLegalReq { get; set; }

        [PXDBString(250)]
        [PXUIField(DisplayName = "")]
        public virtual string UsrRemarkProjInsReq { get; set; }

        [PXDBString(250)]
        [PXUIField(DisplayName = "")]
        public virtual string UsrRemarkCorrCstCtr { get; set; }

        [PXDBString(250)]
        [PXUIField(DisplayName = "")]
        public virtual string UsrRemarkCorrPOVal { get; set; }

        [PXDBString(250)]
        [PXUIField(DisplayName = "")]
        public virtual string UsrRemarkCorrIntocom { get; set; }

        [PXDBString(250)]
        [PXUIField(DisplayName = "")]
        public virtual string UsrRemarkPayTerm { get; set; }

        [PXDBString(250)]
        [PXUIField(DisplayName = "")]
        public virtual string UsrRemarkQutRefNo { get; set; }

        [PXDBString(100)]
        [PXUIField(DisplayName = " End User")]
        public virtual string UsrEndUser { get; set; }

        [PXDBString(10)]
        [PXUIField(DisplayName = "End User Industry")]
        [PXSelector(typeof(Search<CSAttributeDetail.valueID, Where<CSAttributeDetail.attributeID, Equal<SOOrderExt._Industry>, And<CSAttributeDetail.disabled, Equal<boolFalse>>>>), CacheGlobal = false, DescriptionField = typeof(CSAttributeDetail.description))]
        public virtual string UsrEndUsrInd { get; set; }

        [PXDBString(30)]
        [PXUIField(DisplayName = "Business Unit")]
        [PXSelector(typeof(Search<CSAttributeDetail.valueID, Where<CSAttributeDetail.attributeID, Equal<SOOrderExt._CC>, And<CSAttributeDetail.disabled, Equal<boolFalse>>>>), CacheGlobal = true, SubstituteKey = typeof(CSAttributeDetail.description))]
        public virtual string UsrBusUnit { get; set; }

        [PXDBString(20)]
        [PXUIField(DisplayName = "Opportunity Number")]
        public virtual string UsrOpNum { get; set; }



        public abstract class usrLegalReq : IBqlField, IBqlOperand
        {
        }

        public abstract class usrNLegalReq : IBqlField, IBqlOperand
        {
        }

        public abstract class usrProjectInsReq : IBqlField, IBqlOperand
        {
        }

        public abstract class usrNProjectInsReq : IBqlField, IBqlOperand
        {
        }

        public abstract class usrContractPnlty : IBqlField, IBqlOperand
        {
        }

        public abstract class usrNContractPnlty : IBqlField, IBqlOperand
        {
        }

        public abstract class usrCorrectCstCen : IBqlField, IBqlOperand
        {
        }

        public abstract class usrNCorrectCstCen : IBqlField, IBqlOperand
        {
        }

        public abstract class usrCorrectPOValue : IBqlField, IBqlOperand
        {
        }

        public abstract class usrNCorrectPOValue : IBqlField, IBqlOperand
        {
        }

        public abstract class usrCorrectIncoterm : IBqlField, IBqlOperand
        {
        }

        public abstract class usrNCorrectIncoterm : IBqlField, IBqlOperand
        {
        }

        public abstract class usrCorrectPayTerm : IBqlField, IBqlOperand
        {
        }

        public abstract class usrNCorrectPayTerm : IBqlField, IBqlOperand
        {
        }

        public abstract class usrCorrectQtRefNo : IBqlField, IBqlOperand
        {
        }

        public abstract class usrNCorrectQtRefNo : IBqlField, IBqlOperand
        {
        }

        public abstract class usrSpecialInst : IBqlField, IBqlOperand
        {
        }

        public abstract class usrNSpecialInst : IBqlField, IBqlOperand
        {
        }

        public abstract class usrRemarkSpecialInst : IBqlField, IBqlOperand
        {
        }

        public abstract class usrRemarkContractPnlty : IBqlField, IBqlOperand
        {
        }

        public abstract class usrRemarkLegalReq : IBqlField, IBqlOperand
        {
        }

        public abstract class usrRemarkProjInsReq : IBqlField, IBqlOperand
        {
        }

        public abstract class usrRemarkCorrCstCtr : IBqlField, IBqlOperand
        {
        }

        public abstract class usrRemarkCorrPOVal : IBqlField, IBqlOperand
        {
        }

        public abstract class usrRemarkCorrIntocom : IBqlField, IBqlOperand
        {
        }

        public abstract class usrRemarkPayTerm : IBqlField, IBqlOperand
        {
        }

        public abstract class usrRemarkQutRefNo : IBqlField, IBqlOperand
        {
        }

        public abstract class usrEndUser : IBqlField, IBqlOperand
        {
        }

        public abstract class usrEndUsrInd : IBqlField, IBqlOperand
        {
        }

        public abstract class usrBusUnit : IBqlField, IBqlOperand
        {
        }

        public abstract class usrOpNum : IBqlField, IBqlOperand
        {
        }

        public class _Industry : PX.Data.BQL.BqlString.Constant<_Industry>
        {
            public _Industry() : base("INDUSTRIES")
            {
            }
        }

        private class _CC : PX.Data.BQL.BqlString.Constant<_CC>
        {
            public _CC() : base("CC")
            {
            }
        }
    }
}
