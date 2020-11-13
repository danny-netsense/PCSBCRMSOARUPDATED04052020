// Decompiled with JetBrains decompiler
// Type: PX.Objects.CR.LeadMaint_Extension
// Assembly: PCSBCRMSOARUPDATED, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 182865F4-07BB-4D2C-9E47-9E96DF45516C
// Assembly location: C:\Users\QuantumLingual107\AppData\Local\Temp\Vihywod\7ad39fc3ac\Bin\PCSBCRMSOARUPDATED.dll

using PX.Common;
using PX.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PX.Objects.CR
{
    public class LeadMaint_Extension : PXGraphExtension<LeadMaint>
    {
        //[PXOverride]
        //public virtual IEnumerable ConvertToOpportunity(
        //  PXAdapter adapter,
        //  LeadMaint_Extension.ConvertToOpportunityDelegate BaseMethod = null)
        //{
        //    Base.Save.Press();
        //    //bool flag = PXAutonumberingInfo.IsNumberingAutonumbered((PXGraph)this.Base, ((PXSelectBase<CRSetup>)this.Base.Setup).Current.OpportunityNumberingID);
        //    List<Contact> contactList = new List<Contact>(adapter.Get().Cast<Contact>());
        //    using (List<Contact>.Enumerator enumerator = contactList.GetEnumerator())
        //    {
        //        while (enumerator.MoveNext())
        //        {
        //            Contact current = enumerator.Current;
        //            // ISSUE: object of a compiler-generated type is created
        //            // ISSUE: variable of a compiler-generated type
        //            LeadMaint_Extension.\u003C\u003Ec__DisplayClass1_0 cDisplayClass10 = new LeadMaint_Extension.\u003C\u003Ec__DisplayClass1_0()
        //          {
        //    \u003C\u003E4__this = this,
        //    opportunityMaint = (OpportunityMaint)PXGraph.CreateInstance<OpportunityMaint>()
        //  };
        //            // ISSUE: reference to a compiler-generated field
        //            // ISSUE: reference to a compiler-generated field
        //            cDisplayClass10.opportunity = (CROpportunity)((PXSelectBase)cDisplayClass10.opportunityMaint.Opportunity).Cache.Insert();
        //            if (!flag)
        //            {
        //                if (((PXSelectBase<LeadMaint.OpportunityFilter>)this.Base.OpportunityInfo).AskExt() != 1 || !((PXFilter<LeadMaint.OpportunityFilter>)this.Base.OpportunityInfo).VerifyRequired())
        //                    return (IEnumerable)contactList;
        //                if (PXResultset<CROpportunity>.op_Implicit(PXSelect<CROpportunity, Where<CROpportunity.opportunityID, Equal<Required<CROpportunity.opportunityID>>>>.SelectSingleBound((PXGraph)this.Base, (object[])null, new object[1]
        //                {
        //      (object) ((PXSelectBase<LeadMaint.OpportunityFilter>) this.Base.OpportunityInfo).Current.OpportunityID
        //                })) != null)
        //                {
        //                    ((PXSelectBase)this.Base.OpportunityInfo).Cache.RaiseExceptionHandling<LeadMaint.OpportunityFilter.opportunityID>((object)((PXSelectBase<LeadMaint.OpportunityFilter>)this.Base.OpportunityInfo).Current, (object)((PXSelectBase<LeadMaint.OpportunityFilter>)this.Base.OpportunityInfo).Current.OpportunityID, (Exception)new PXSetPropertyException("Opportunity '{0}' already exists.", new object[1]
        //                    {
        //        (object) ((PXSelectBase<LeadMaint.OpportunityFilter>) this.Base.OpportunityInfo).Current.OpportunityID
        //                    }));
        //                    return (IEnumerable)contactList;
        //                }
        //                object opportunityId = (object)((PXSelectBase<LeadMaint.OpportunityFilter>)this.Base.OpportunityInfo).Current.OpportunityID;
        //                // ISSUE: reference to a compiler-generated field
        //                ((PXSelectBase)cDisplayClass10.opportunityMaint.Opportunity).Cache.RaiseFieldUpdating<CROpportunity.opportunityID>((object)null, ref opportunityId);
        //                // ISSUE: reference to a compiler-generated field
        //                cDisplayClass10.opportunity.set_OpportunityID((string)opportunityId);
        //            }
        //            // ISSUE: reference to a compiler-generated field
        //            cDisplayClass10.lead = current;
        //            // ISSUE: method pointer
        //            PXLongOperation.StartOperation((PXGraph)this.Base, new PXToggleAsyncDelegate((object)cDisplayClass10, __methodptr(\u003CConvertToOpportunity\u003Eb__0)));
        //        }
        //    }
        //    return (IEnumerable)contactList;
        //}

        //[PXOverride]
        //public virtual IEnumerable ConvertToBAccount(
        //  PXAdapter adapter,
        //  LeadMaint_Extension.ConvertToBAccountDelegate BaseMethod)
        //{
        //    Base.Save.Press();
        //    List<Contact> contactList = new List<Contact>(adapter.Get().Cast<Contact>());
        //    using (List<Contact>.Enumerator enumerator = contactList.GetEnumerator())
        //    {
        //        while (enumerator.MoveNext())
        //        {
        //            Contact current = enumerator.Current;
        //            // ISSUE: object of a compiler-generated type is created
        //            // ISSUE: variable of a compiler-generated type
        //            LeadMaint_Extension.\u003C\u003Ec__DisplayClass3_0 cDisplayClass30 = new LeadMaint_Extension.\u003C\u003Ec__DisplayClass3_0();
        //            // ISSUE: reference to a compiler-generated field
        //            cDisplayClass30.\u003C\u003E4__this = this;
        //            // ISSUE: reference to a compiler-generated field
        //            // ISSUE: reference to a compiler-generated field
        //            // ISSUE: reference to a compiler-generated field
        //            // ISSUE: method pointer
        //            if (((PXSelectBase<LeadMaint.AccountsFilter>)this.Base.AccountInfo).AskExt(LeadMaint_Extension.\u003C\u003Ec.\u003C\u003E9__3_1 ?? (LeadMaint_Extension.\u003C\u003Ec.\u003C\u003E9__3_1 = new PXView.InitializePanel((object)LeadMaint_Extension.\u003C\u003Ec.\u003C\u003E9, __methodptr(\u003CConvertToBAccount\u003Eb__3_1))), true) != 6)
        //    return (IEnumerable)contactList;
        //            bool flag = !((PXFilter<LeadMaint.AccountsFilter>)this.Base.AccountInfo).VerifyRequired();
        //            if (PXResultset<BAccount>.op_Implicit(PXSelect<BAccount, Where<BAccount.acctCD, Equal<Required<BAccount.acctCD>>>>.SelectSingleBound((PXGraph)this.Base, (object[])null, new object[1]
        //            {
        //    (object) ((PXSelectBase<LeadMaint.AccountsFilter>) this.Base.AccountInfo).Current.BAccountID
        //            })) != null)
        //            {
        //                ((PXSelectBase)this.Base.AccountInfo).Cache.RaiseExceptionHandling<LeadMaint.AccountsFilter.bAccountID>((object)((PXSelectBase<LeadMaint.AccountsFilter>)this.Base.AccountInfo).Current, (object)((PXSelectBase<LeadMaint.AccountsFilter>)this.Base.AccountInfo).Current.BAccountID, (Exception)new PXSetPropertyException("Business Account '{0}' already exists.", new object[1]
        //                {
        //      (object) ((PXSelectBase<LeadMaint.AccountsFilter>) this.Base.AccountInfo).Current.BAccountID
        //                }));
        //                return (IEnumerable)contactList;
        //            }
        //            if (flag)
        //                return (IEnumerable)contactList;
        //            ((PXAction)((PXGraph<LeadMaint, Contact, Contact.displayName>)this.Base).Save).Press();
        //            // ISSUE: reference to a compiler-generated field
        //            cDisplayClass30.lead = current;
        //            // ISSUE: reference to a compiler-generated field
        //            cDisplayClass30.lead.set_ConvertedBy(new Guid?(((PXGraph)this.Base).get_Accessinfo().get_UserID()));
        //            // ISSUE: method pointer
        //            PXLongOperation.StartOperation((PXGraph)this.Base, new PXToggleAsyncDelegate((object)cDisplayClass30, __methodptr(\u003CConvertToBAccount\u003Eb__0)));
        //        }
        //    }
        //    return (IEnumerable)contactList;
        //}

        //public static void ConvertToAccount(Contact contact, LeadMaint.AccountsFilter param, bool IsContractBasedAPI)
        //{
        //    BusinessAccountMaint instance = (BusinessAccountMaint)PXGraph.CreateInstance<BusinessAccountMaint>();
        //    object baccountId = (object)param.BAccountID;
        //    ((PXSelectBase)instance.BAccount).Cache.RaiseFieldUpdating<BAccount.acctCD>((object)null, ref baccountId);
        //    CRContactExistingColumn extension1 = (CRContactExistingColumn)PXCache<Contact>.GetExtension<CRContactExistingColumn>(contact);
        //    BAccount baccount1 = new BAccount();
        //    baccount1.AcctCD = ((string)baccountId);
        //    baccount1.AcctName = (param.get_AccountName());
        //    baccount1.Type = ("PR");
        //    baccount1.ClassID = (param.get_AccountClass());
        //    baccount1.ParentBAccountID = (contact.ParentBAccountID);
        //    baccount1.CampaignSourceID = (contact.CampaignID);
        //    BAccount baccount2 = baccount1;
        //    BAccountExt extension2 = (BAccountExt)PXCache<BAccount>.GetExtension<BAccountExt>(baccount2);
        //    extension2.UsrIndustry = extension1.Usrindustry;
        //    extension2.UsrRegion = extension1.Usrregion;
        //    CRContactClass crContactClass = PXResultset<CRContactClass>.op_Implicit(PXSelect<CRContactClass, Where<CRContactClass.classID, Equal<Current<Contact.classID>>>>.SelectSingleBound((PXGraph)instance, new object[1]
        //    {
        //(object) contact
        //    }, new object[0]));
        //    int num;
        //    if (crContactClass != null)
        //    {
        //        bool? ownerToBaccount = crContactClass.OwnerToBAccount;
        //        bool flag = true;
        //        num = ownerToBaccount.GetValueOrDefault() == flag ? (ownerToBaccount.HasValue ? 1 : 0) : 0;
        //    }
        //    else
        //        num = 0;
        //    if (num != 0)
        //    {
        //        baccount2.WorkgroupID = (contact.WorkgroupID);
        //        baccount2.OwnerID = (contact.OwnerID);
        //    }
        //    try
        //    {
        //        object ownerId = (object)baccount2.OwnerID;
        //        ((PXSelectBase)instance.BAccount).Cache.RaiseFieldVerifying<BAccount.ownerID>((object)baccount2, ref ownerId);
        //    }
        //    catch (PXSetPropertyException ex)
        //    {
        //        baccount2.OwnerID = (new Guid?());
        //    }
        //    BAccount baccount3 = ((PXSelectBase<BAccount>)instance.BAccount).Insert(baccount2);
        //    ((CRAttributeList<BAccount>)instance.Answers).CopyAllAttributes((object)baccount3, (object)contact);
        //    Contact copy = PXCache<Contact>.CreateCopy(PXResultset<Contact>.op_Implicit(PXSelect<Contact, Where<Contact.contactID, Equal<Current<BAccount.defContactID>>>>.SelectSingleBound((PXGraph)instance, new object[1]
        //    {
        //(object) baccount3
        //    }, new object[0])));
        //    Guid? noteId = copy.NoteID;
        //    PXCache<Contact>.RestoreCopy(copy, contact);
        //    copy.ContactType = ("AP");
        //    copy.FullName = (baccount3.AcctName);
        //    copy.ContactID = (baccount3.DefContactID);
        //    copy.BAccountID = (baccount3.BAccountID);
        //    copy.DuplicateStatus = ("NV");
        //    copy.DuplicateFound = (new bool?(false));
        //    copy.WorkgroupID = (new int?());
        //    copy.OwnerID = (new Guid?());
        //    copy.NoteID = (noteId);
        //    Contact contact1 = ((PXSelectBase<Contact>)instance.DefContact).Update(copy);
        //    Address address1 = PXResultset<Address>.op_Implicit(PXSelect<Address, Where<Address.addressID, Equal<Required<Contact.defAddressID>>>>.Select((PXGraph)instance, new object[1]
        //    {
        //(object) contact.DefAddressID
        //    }));
        //    if (address1 == null)
        //        throw new PXException("Default Address does not exists for '{0}'", new object[1]
        //        {
        //  (object) contact.DisplayName
        //        });
        //    address1.BAccountID = (baccount3.BAccountID);
        //    ((PXSelectBase)instance.AddressCurrent).Cache.Clear();
        //    contact1.DefAddressID = (address1.AddressID);
        //    ((PXSelectBase<Contact>)instance.DefContact).Update(contact1);
        //    Address address2 = ((PXSelectBase<Address>)instance.AddressCurrent).Update(address1);
        //    baccount3.DefAddressID = (address2.AddressID);
        //    ((PXSelectBase<BAccount>)instance.BAccount).Update(baccount3);
        //    contact.BAccountID = (baccount3.BAccountID);
        //    contact.DuplicateStatus = ("NV");
        //    contact.DuplicateFound = (new bool?(false));
        //    if (!contact.get_QualificationDate().HasValue)
        //        contact.set_QualificationDate(new DateTime?(PXTimeZoneInfo.Now));
        //    ((PXSelectBase)instance.Contacts).Cache.SetStatus((object)contact, (PXEntryStatus)1);
        //    Location location = PXResultset<Location>.op_Implicit(((PXSelectBase<Location>)instance.DefLocation).Select(new object[0]));
        //    location.DefAddressID = (address2.AddressID);
        //    ((PXSelectBase<Location>)instance.DefLocation).Update(location);
        //    baccount3.NoteID = (PXNoteAttribute.GetNoteID<CRActivity.noteID>(((PXSelectBase)instance.CurrentBAccount).Cache, (object)baccount3));
        //    using (IEnumerator<PXResult<CRPMTimeActivity>> enumerator = PXSelect<CRPMTimeActivity, Where<CRPMTimeActivity.refNoteID, Equal<Required<Contact.noteID>>>>.Select((PXGraph)instance, new object[1]
        //    {
        //(object) contact.NoteID
        //    }).GetEnumerator())
        //    {
        //        while (((IEnumerator)enumerator).MoveNext())
        //        {
        //            CRPMTimeActivity crpmTimeActivity = PXResult<CRPMTimeActivity>.op_Implicit(enumerator.Current);
        //            ((CRActivity)crpmTimeActivity).BAccountID = baccount3.BAccountID;
        //            ((PXSelectBase)instance.Activities).Cache.Update((object)crpmTimeActivity);
        //        }
        //    }
        //    CRSetup crSetup = PXResultset<CRSetup>.op_Implicit(PXSelectReadonly<CRSetup>.Select((PXGraph)instance, new object[0]));
        //    PXNoteAttribute.CopyNoteAndFiles(((PXSelectBase)instance.Contacts).Cache, (object)contact, ((PXSelectBase)instance.CurrentBAccount).Cache, (object)baccount3, (PXNoteAttribute.IPXCopySettings)crSetup);
        //    if (!IsContractBasedAPI)
        //        throw new PXRedirectRequiredException((PXGraph)instance, "Business Account");
        //    ((PXAction)((PXGraph<BusinessAccountMaint, BAccount>)instance).Save).Press();
        //}


        public delegate void ConvertToOpportunityDelegate(PXAdapter adapter);

        public delegate void ConvertToBAccountDelegate(PXAdapter adapter);
    }
}
