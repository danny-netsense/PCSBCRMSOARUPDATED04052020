// Decompiled with JetBrains decompiler
// Type: PX.Objects.GL.JournalEntry_Extension
// Assembly: CRMLEADPMSB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: BA3FB156-B7E5-4249-A9FC-ED75D42F2979
// Assembly location: C:\Users\QuantumLingual107\AppData\Local\Temp\Nywihyp\7ad39fc3ac\Bin\CRMLEADPMSB.dll

using PX.Data;

namespace PX.Objects.GL
{
    public class JournalEntry_Extension : PXGraphExtension<JournalEntry>
    {
        protected void Batch_RowInserted(PXCache cache, PXRowInsertedEventArgs e)
        {
            Batch row = (Batch)e.Row;

        }

    }
}
