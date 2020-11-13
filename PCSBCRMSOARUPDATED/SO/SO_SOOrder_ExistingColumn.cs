// Decompiled with JetBrains decompiler
// Type: PX.Objects.SO.SO_SOOrder_ExistingColumn
// Assembly: PCSBCRMSOARUPDATED, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 182865F4-07BB-4D2C-9E47-9E96DF45516C
// Assembly location: C:\Users\QuantumLingual107\AppData\Local\Temp\Vihywod\7ad39fc3ac\Bin\PCSBCRMSOARUPDATED.dll

using PX.Data;

namespace PX.Objects.SO
{
    [PXNonInstantiatedExtension]
    public class SOSOOrderExistingColumn : PXCacheExtension<SOOrder>
    {
        [PXDBString(40, IsUnicode = true)]
        [PXUIField(DisplayName = "Revision no.")]
        public string CustomerRefNbr { get; set; }

    }
}
