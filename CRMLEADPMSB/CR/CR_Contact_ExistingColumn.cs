// Decompiled with JetBrains decompiler
// Type: PX.Objects.CR.CR_Contact_ExistingColumn
// Assembly: CRMLEADPMSB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: BA3FB156-B7E5-4249-A9FC-ED75D42F2979
// Assembly location: C:\Users\QuantumLingual107\AppData\Local\Temp\Nywihyp\7ad39fc3ac\Bin\CRMLEADPMSB.dll

using System;
using CRMLEADPMSB;
using PX.Data;
using PX.Objects.CR.MassProcess;
using PX.SM;

namespace PX.Objects.CR
{
  [PXNonInstantiatedExtension]
  public class CRContactExistingColumn : PXCacheExtension<Contact>
  {

      [PXDBString(3)]
      [PXDefault("H1", PersistingCheck = PXPersistingCheck.Nothing)]
      [PXUIField(DisplayName = "Phone 3 Type")]
      [PhoneTypes]
      [PXMassMergableField]
      public virtual string Phone3Type { get; set; }

      //#region ConvertedBy
      //public abstract class convertedBy : PX.Data.BQL.BqlGuid.Field<convertedBy> { }

      //[PXDBGuid(BqlField = typeof(Standalone.CRLead.convertedBy))]
      //[PXSelector(typeof(Users.pKID), SubstituteKey = typeof(Users.username), DescriptionField = typeof(Users.fullName), CacheGlobal = true, DirtyRead = true, ValidateValue = false)]
      //[PXUIField(DisplayName = "Converted By")]
      //public virtual Guid? ConvertedBy { get; set; }
      //#endregion
    }
}
