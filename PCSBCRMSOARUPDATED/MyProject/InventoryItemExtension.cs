// Decompiled with JetBrains decompiler
// Type: MyProject.InventoryItemExtension
// Assembly: PCSBCRMSOARUPDATED, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 182865F4-07BB-4D2C-9E47-9E96DF45516C
// Assembly location: C:\Users\QuantumLingual107\AppData\Local\Temp\Vihywod\7ad39fc3ac\Bin\PCSBCRMSOARUPDATED.dll

using PX.Data;
using PX.Objects.IN;

namespace MyProject
{
    public class InventoryItemExtension : PXCacheExtension<InventoryItem>
    {
        [PXString(255)]
        [PXUIField(DisplayName = "My Custom Field for UI only")]
        public virtual string MyCustomField { get; set; }

        public abstract class myCustomField : IBqlField, IBqlOperand { }

    }
}
