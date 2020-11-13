// Decompiled with JetBrains decompiler
// Type: PX.Objects.SO.SOShipmentEntry_Extension
// Assembly: PCSBCRMSOARUPDATED, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 182865F4-07BB-4D2C-9E47-9E96DF45516C
// Assembly location: C:\Users\QuantumLingual107\AppData\Local\Temp\Vihywod\7ad39fc3ac\Bin\PCSBCRMSOARUPDATED.dll

using PX.Data;

namespace PX.Objects.SO
{
    public class SOShipmentEntry_Extension : PXGraphExtension<SOShipmentEntry>
    {
        protected void SOShipment_CustomerID_FieldUpdated(PXCache cache, PXFieldUpdatedEventArgs e)
        {
            SOShipment row = (SOShipment)e.Row;
        }
    }
}
