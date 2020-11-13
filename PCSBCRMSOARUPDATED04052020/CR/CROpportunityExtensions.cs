using PX.Common;
using PX.Data.EP;
using PX.Data;
using PX.Objects.AR;
using PX.Objects.CM;
using PX.Objects.CR.MassProcess;
using PX.Objects.CR.Standalone;
using PX.Objects.CS;
using PX.Objects.GL;
using PX.Objects.PM;
using PX.Objects.PO;
using PX.Objects.TX;
using PX.Objects;
using PX.TM;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;

namespace PX.Objects.CR
{
  public class CROpportunityExt : PXCacheExtension<PX.Objects.CR.CROpportunity>
  {
    #region UsrOldCalc
    [PXDBBool]
    [PXUIField(DisplayName="Old Calculation", Visibility = PXUIVisibility.Invisible)]
    [PXDefault(false, PersistingCheck = PXPersistingCheck.Nothing)]
    public virtual bool? UsrOldCalc { get; set; }
    public abstract class usrOldCalc : PX.Data.BQL.BqlBool.Field<usrOldCalc> { }
    #endregion
  }
}