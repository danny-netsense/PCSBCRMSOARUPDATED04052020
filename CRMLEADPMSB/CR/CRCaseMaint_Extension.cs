// Decompiled with JetBrains decompiler
// Type: PX.Objects.CR.CRCaseMaint_Extension
// Assembly: CRMLEADPMSB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: BA3FB156-B7E5-4249-A9FC-ED75D42F2979
// Assembly location: C:\Users\QuantumLingual107\AppData\Local\Temp\Nywihyp\7ad39fc3ac\Bin\CRMLEADPMSB.dll

using PX.Data;
using PX.Objects.AR;
using PX.Objects.CM;
using PX.Objects.SO;
using System.Collections;


namespace PX.Objects.CR
{
    public class CRCaseMaint_Extension : PXGraphExtension<CRCaseMaint>
    {
        //Create Sales Order from Cases, This customization have been done in a seperate customization file named
        //"PCSBCASEID COPY" by Subhashish Dawn, which is working fine Thanks

        //public PXAction<CRCase> createSO;

        //[PXUIField]
        //[PXLookupButton(CommitChanges = true)]
        //public virtual IEnumerable CreateSO(PXAdapter adapter)
        //{
        //    CRCaseMaint_Extension extension1 = (CRCaseMaint_Extension)((PXGraph)PXGraph.CreateInstance<CRCaseMaint>()).GetExtension<CRCaseMaint_Extension>();
        //    SOOrderEntry instance = (SOOrderEntry)PXGraph.CreateInstance<SOOrderEntry>();
        //    foreach (CRCase crCase in adapter.Get())
        //    {
        //        SOOrder soOrder1 = (PXSelect<SOOrder, Where<SOOrderExt.usrCaseID, Equal<Required<SOOrderExt.usrCaseID>>>>.Select(Base, crCase.CaseCD));
        //        if (soOrder1 != null)
        //        {
        //            //if (((PXSelectBase<CRCase>)this.Base.Case).Ask((ToAsk, (MessageButtons)4, (MessageIcon)2) == WebDialogResult.OK)
        //            if (Base.Case.Ask(ToAsk, MessageButtons.YesNo) == WebDialogResult.Yes)
        //            {
        //                ((PXSelectBase<SOOrder>)instance.Document).Current = ((PXSelectBase<SOOrder>)instance.Document)
        //                    .Search<SOOrder.orderNbr, SOOrder.orderType>((object)soOrder1.OrderNbr, (object)soOrder1.OrderType, new object[0] { });
        //                PXRedirectRequiredException requiredException = new PXRedirectRequiredException((PXGraph)instance, true, "");
        //                ((PXBaseRedirectException)requiredException).Mode = ((PXBaseRedirectException.WindowMode)3);
        //                throw requiredException;
        //            }
        //        }
        //        else
        //        {
        //            //PXResultset<Customer>.op_Implicit(PXSelect<Customer, Where<Customer.bAccountID, Equal<Current<CRCase.customerID>>>>
        //            //    .Select((PXGraph)this.Base, new object[0]));


        //            CurrencyInfo currencyInfo1 = new CurrencyInfo();
        //            currencyInfo1.CuryInfoID = (new long?());
        //            CurrencyInfo currencyInfo2 = ((PXSelectBase<CurrencyInfo>)instance.currencyinfo).Insert(currencyInfo1);
        //            SOOrder soOrder2 = new SOOrder();
        //            soOrder2.OrderType = ("QT");
        //            SOOrder soOrder3 = ((PXSelectBase<SOOrder>)instance.Document).Insert(soOrder2);
        //            SOOrder copy1 = (((PXSelectBase<SOOrder>)instance.Document).Search<SOOrder.orderNbr>((object)soOrder3.OrderNbr, new object[0] { }));
        //            copy1.CuryInfoID = (currencyInfo2.CuryInfoID);
        //            SOOrder copy2 = PXCache<SOOrder>.CreateCopy(((PXSelectBase<SOOrder>)instance.Document).Update(copy1));
        //            SOOrderExt extension2 = (SOOrderExt)PXCache<SOOrder>.GetExtension<SOOrderExt>(copy2);
        //            copy2.CuryID = (currencyInfo2.CuryID);
        //            copy2.OrderDate = (((PXGraph)this.Base).Accessinfo.BusinessDate);
        //            copy2.CustomerID = (crCase.CustomerID);
        //            copy2.OrderDesc = (crCase.Subject);
        //            extension2.UsrCaseID = crCase.CaseCD;
        //            ((PXSelectBase<SOOrder>)instance.Document).Update(copy2);
                    


        //            PXRedirectRequiredException requiredException = new PXRedirectRequiredException((PXGraph)instance, true, "");
        //            ((PXBaseRedirectException)requiredException).Mode = ((PXBaseRedirectException.WindowMode)3);
        //            throw requiredException;
        //        }
        //    }
        //    return adapter.Get();
        //}

        //public string ToAsk = "Confirmation" + "QT is already created for this Case,Do you want to view it...? ";
    }
}
