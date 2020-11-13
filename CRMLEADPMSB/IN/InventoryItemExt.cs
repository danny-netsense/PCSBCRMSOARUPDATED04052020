// Decompiled with JetBrains decompiler
// Type: PX.Objects.IN.InventoryItemExt
// Assembly: CRMLEADPMSB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: BA3FB156-B7E5-4249-A9FC-ED75D42F2979
// Assembly location: C:\Users\QuantumLingual107\AppData\Local\Temp\Nywihyp\7ad39fc3ac\Bin\CRMLEADPMSB.dll

using PX.Data;
using PX.Objects.CS;

namespace PX.Objects.IN
{
    public class InventoryItemExt : PXCacheExtension<InventoryItem>
    {
        [PXDBString(30)]
        [PXUIField(DisplayName = "MF Serial Number")]
        public virtual string UsrManSerNo { get; set; }

        [PXDBString(30)]
        [PXUIField(DisplayName = "Model Number")]
        public virtual string UsrModelNo { get; set; }

        [PXDBString(30)]
        [PXUIField(DisplayName = "Sub Category")]
        [PXSelector(typeof(Search<CSAttributeDetail.valueID, Where<CSAttributeDetail.attributeID, Equal<InventoryItemExt._Subcat>, And<CSAttributeDetail.disabled, Equal<boolFalse>>>>), CacheGlobal = true, SubstituteKey = typeof(CSAttributeDetail.description))]
        public virtual string UsrSubCat { get; set; }

        public abstract class usrManSerNo : IBqlField, IBqlOperand
        {
        }

        public abstract class usrModelNo : IBqlField, IBqlOperand
        {
        }

        public abstract class usrSubCat : IBqlField, IBqlOperand
        {
        }

        private class _Subcat : PX.Data.BQL.BqlString.Constant<_Subcat>
        {
            public _Subcat() : base("SUBCAT")
            {
            }
        }

        public class InventoryItemExtension : PXCacheExtension<InventoryItem>
        {
            [PXUIField(DisplayName = "My Custom Field for UI only")]
            [PXString(255)]
            public virtual string MyCustomField { get; set; }


            public abstract class myCustomField : IBqlField, IBqlOperand
            {
            }
        }
    }
}
