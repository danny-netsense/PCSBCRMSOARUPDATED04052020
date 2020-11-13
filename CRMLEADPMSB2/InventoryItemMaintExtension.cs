// Decompiled with JetBrains decompiler
// Type: MyProject.InventoryItemMaintExtension
// Assembly: CRMLEADPMSB2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 1D293427-6FA2-4530-ABEA-D4C25BB424EA
// Assembly location: C:\Users\QuantumLingual107\AppData\Local\Temp\Nywihyp\7ad39fc3ac\Bin\CRMLEADPMSB2.dll

using PX.Data;
using PX.Objects.IN;

namespace MyProject
{
    public class InventoryItemMaintExtension : PXGraphExtension<InventoryItemMaint>
    {
        protected void InventoryItem_RowSelected(
          PXCache sender,
          PXRowSelectedEventArgs e,

          PXRowSelected del)
        {
            del?.Invoke(sender, e);

        }

    }
}
