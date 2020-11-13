// Decompiled with JetBrains decompiler
// Type: PX.Objects.CR.OpportunityMaint_Extension
// Assembly: PCSBCRMSOARUPDATED, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 182865F4-07BB-4D2C-9E47-9E96DF45516C
// Assembly location: C:\Users\QuantumLingual107\AppData\Local\Temp\Vihywod\7ad39fc3ac\Bin\PCSBCRMSOARUPDATED.dll

using PX.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace PX.Objects.CR
{
    public class OpportunityMaint_Extension : PXGraphExtension<OpportunityMaint>
    {
        //[PXOverride]
        //public virtual IEnumerable CreateContact(PXAdapter adapter, OpportunityMaint_Extension.CreateContactDelegate BaseMethod)
        //{
        //    CROpportunity current = ((PXSelectBase<CROpportunity>)this.Base.OpportunityCurrent).Current;
        //    if (current == null)
        //        return adapter.Get();
        //    ((PXActionCollection)((PXGraph)this.Base).Actions).PressSave();
        //    CRContact crContact = ((PXSelectBase<CRContact>)this.Base.Opportunity_Contact).SelectSingle(new object[0]);
        //    CRAddress crAddress = ((PXSelectBase<CRAddress>)this.Base.Opportunity_Address).SelectSingle(new object[0]);
        //    ContactMaint instance1 = (ContactMaint)PXGraph.CreateInstance<ContactMaint>();
        //    Contact instance2 = (Contact)((PXSelectBase)instance1.ContactCurrent).Cache.CreateInstance();
        //    Contact contact = ((PXSelectBase)instance1.ContactCurrent).Cache.Insert((object)instance2) as Contact;
        //    contact.FullName = (crContact.FullName);
        //    contact.Title = (crContact.Title);
        //    contact.FirstName = (crContact.FirstName);
        //    contact.LastName = (crContact.LastName);
        //    contact.Salutation = (crContact.Salutation);
        //    contact.EMail = (crContact.Email);
        //    contact.WebSite = (crContact.WebSite);
        //    contact.Phone1 = (crContact.Phone1);
        //    contact.Phone1Type = (crContact.Phone1Type);
        //    contact.Phone2 = (crContact.Phone2);
        //    contact.Phone2Type = (crContact.Phone2Type);
        //    contact.Phone3 = (crContact.Phone3);
        //    contact.Phone3Type = (crContact.Phone3Type);
        //    contact.Fax = (crContact.Fax);
        //    contact.FaxType = (crContact.FaxType);
        //    CRContactExistingColumn extension1 = (CRContactExistingColumn)PXCache<Contact>.GetExtension<CRContactExistingColumn>(contact);
        //    CROpportunityExt extension2 = (CROpportunityExt)PXCache<CROpportunity>.GetExtension<CROpportunityExt>(current);
        //    extension1.Usrindustry = extension2.Usrindustry;
        //    extension1.Usrregion = extension2.Usrregion;
        //    if (current.BAccountID.HasValue)
        //        contact.BAccountID = (current.BAccountID);
        //    ((PXSelectBase)instance1.ContactCurrent).Cache.Update((object)contact);
        //    Address address = (Address)((PXSelectBase)instance1.AddressCurrent).Cache.Current;
        //    if (address == null)
        //    {
        //        Address instance3 = (Address)((PXSelectBase)instance1.AddressCurrent).Cache.CreateInstance();
        //        address = ((PXSelectBase)instance1.AddressCurrent).Cache.Insert((object)instance3) as Address;
        //    }
        //    address.AddressLine1 = (crAddress.AddressLine1);
        //    address.AddressLine2 = (crAddress.AddressLine2);
        //    address.City = (crAddress.City);
        //    address.CountryID = (crAddress.CountryID);
        //    address.State = (crAddress.State);
        //    address.PostalCode = (crAddress.PostalCode);
        //    ((PXSelectBase)instance1.AddressCurrent).Cache.Update((object)address);
        //    contact.DefAddressID = (address.AddressID);
        //    ((PXSelectBase<CROpportunity>)this.Base.OpportunityCurrent).Current.ContactID = (contact.ContactID);
        //    ((PXSelectBase<CROpportunity>)instance1.Opportunities).Current = (current);
        //    ((PXSelectBase)instance1.Opportunities).Cache.SetStatus((object)((PXSelectBase<CROpportunity>)instance1.Opportunities).Current, (PXEntryStatus)1);
        //    if (((PXGraph)this.Base).IsContractBasedAPI)
        //        throw new PXRedirectRequiredException((PXGraph)instance1, "Contact");
        //    ((PXAction)((PXGraph<ContactMaint, Contact, Contact.displayName>)instance1).Save).Press();
        //    return adapter.Get();
        //}

        //[PXOverride]
        //public virtual IEnumerable CreateAccount(PXAdapter adapter, OpportunityMaint_Extension.CreateAccountDelegate BaseMethod)
        //{
        //    List<CROpportunity> crOpportunityList = new List<CROpportunity>(adapter.Get().Cast<CROpportunity>());
        //    using (List<CROpportunity>.Enumerator enumerator = crOpportunityList.GetEnumerator())
        //    {
        //        while (enumerator.MoveNext())
        //        {
        //            // ISSUE: object of a compiler-generated type is created
        //            // ISSUE: variable of a compiler-generated type
        //            OpportunityMaint_Extension cDisplayClass30 = new OpportunityMaint_Extension.\u003C\u003Ec__DisplayClass3_0();
        //            // ISSUE: reference to a compiler-generated field
        //            cDisplayClass30.\u003C\u003E4__this = this;
        //            // ISSUE: reference to a compiler-generated field
        //            cDisplayClass30.opp = enumerator.Current;
        //            if (((PXView)((PXSelectBase)this.Base.AccountInfo).View).get_Answer() == 0)
        //            {
        //                ((PXSelectBase)this.Base.AccountInfo).Cache.Clear();
        //                (((PXSelectBase)this.Base.AccountInfo).Cache.Insert() as OpportunityMaint.CreateAccountsFilter).set_LinkContactToAccount(new bool?(true));
        //            }
        //            if (((PXSelectBase<OpportunityMaint.CreateAccountsFilter>)this.Base.AccountInfo).AskExt() != 6)
        //                return (IEnumerable)crOpportunityList;
        //            bool flag = !((PXFilter<OpportunityMaint.CreateAccountsFilter>)this.Base.AccountInfo).VerifyRequired();
        //            if (PXResultset<BAccount>.op_Implicit(PXSelect<BAccount, Where<BAccount.acctCD, Equal<Required<BAccount.acctCD>>>>.SelectSingleBound((PXGraph)this.Base, (object[])null, new object[1]
        //            {
        //    (object) ((PXSelectBase<OpportunityMaint.CreateAccountsFilter>) this.Base.AccountInfo).Current.BAccountID
        //            })) != null)
        //            {
        //                ((PXSelectBase)this.Base.AccountInfo).Cache.RaiseExceptionHandling<OpportunityMaint.CreateAccountsFilter.bAccountID>((object)((PXSelectBase<OpportunityMaint.CreateAccountsFilter>)this.Base.AccountInfo).Current, (object)((PXSelectBase<OpportunityMaint.CreateAccountsFilter>)this.Base.AccountInfo).Current.BAccountID, (Exception)new PXSetPropertyException("Business Account '{0}' already exists.", new object[1]
        //                {
        //      (object) ((PXSelectBase<OpportunityMaint.CreateAccountsFilter>) this.Base.AccountInfo).Current.BAccountID
        //                }));
        //                return (IEnumerable)crOpportunityList;
        //            }
        //            if (flag)
        //                return (IEnumerable)crOpportunityList;
        //            ((PXAction)this.Base.Save).Press();
        //            // ISSUE: method pointer
        //            PXLongOperation.StartOperation((PXGraph)this.Base, new PXToggleAsyncDelegate((object)cDisplayClass30, __methodptr(\u003CCreateAccount\u003Eb__0)));
        //        }
        //    }
        //    return (IEnumerable)crOpportunityList;
        //}

        //public void ConvertToAccount(CROpportunity opportunity, OpportunityMaint.CreateAccountsFilter param)
        //{
        //    BusinessAccountMaint instance = (BusinessAccountMaint)PXGraph.CreateInstance<BusinessAccountMaint>();
        //    object baccountId = (object)param.BAccountID;
        //    ((PXSelectBase)instance.BAccount).Cache.RaiseFieldUpdating<BAccount.acctCD>((object)null, ref baccountId);
        //    BAccount baccount1 = new BAccount();
        //    baccount1.AcctCD = ((string)baccountId);
        //    baccount1.AcctName = (param.get_AccountName());
        //    baccount1.Type = ("PR");
        //    baccount1.ParentBAccountID = (opportunity.ParentBAccountID);
        //    baccount1.ClassID = (param.get_AccountClass());
        //    baccount1.WorkgroupID = (opportunity.WorkgroupID);
        //    baccount1.OwnerID = (opportunity.OwnerID);
        //    baccount1.CampaignSourceID = (opportunity.CampaignSourceID);
        //    BAccount baccount2 = baccount1;
        //    BAccountExt extension1 = (BAccountExt)PXCache<BAccount>.GetExtension<BAccountExt>(baccount2);
        //    CROpportunityExt extension2 = (CROpportunityExt)PXCache<CROpportunity>.GetExtension<CROpportunityExt>(opportunity);
        //    extension1.UsrIndustry = extension2.Usrindustry;
        //    extension1.UsrRegion = extension2.Usrregion;
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
        //    ((CRAttributeList<BAccount>)instance.Answers).CopyAllAttributes((object)baccount3, (object)opportunity);
        //    if (((PXSelectBase<Location>)instance.DefLocation).Current != null)
        //        ((PXSelectBase<Location>)instance.DefLocation).Current.CTaxZoneID = (opportunity.TaxZoneID);
        //    bool? contactToAccount = param.get_LinkContactToAccount();
        //    bool flag = true;
        //    if (contactToAccount.GetValueOrDefault() == flag && contactToAccount.HasValue)
        //    {
        //        Contact contact = PXResultset<Contact>.op_Implicit(PXSelect<Contact, Where<Contact.contactID, Equal<Required<CROpportunity.contactID>>>>.Select((PXGraph)instance, new object[1]
        //        {
        //  (object) opportunity.ContactID
        //        }));
        //        if (contact != null)
        //        {
        //            ((CRAttributeList<BAccount>)instance.Answers).CopyAttributes((object)baccount3, (object)contact);
        //            contact.BAccountID = (baccount3.BAccountID);
        //            contact.Status = ("C");
        //            contact.MajorStatus = (new int?(4));
        //            ((PXSelectBase<Contact>)instance.Contacts).Update(contact);
        //        }
        //    }
        //    Contact contact1 = this.FillFromOpportunityContact(PXCache<Contact>.CreateCopy(PXResultset<Contact>.op_Implicit(PXSelect<Contact, Where<Contact.contactID, Equal<Current<BAccount.defContactID>>>>.SelectSingleBound((PXGraph)instance, new object[1]
        //    {
        //(object) baccount3
        //    }, new object[0]))));
        //    contact1.ContactType = ("AP");
        //    contact1.FullName = (baccount3.AcctName);
        //    contact1.ContactID = (baccount3.DefContactID);
        //    contact1.DefAddressID = (baccount3.DefAddressID);
        //    contact1.BAccountID = (baccount3.BAccountID);
        //    ((PXSelectBase<Contact>)instance.DefContact).Update(contact1);
        //    Address address = this.FillFromOpportunityAddress(PXCache<Address>.CreateCopy(PXResultset<Address>.op_Implicit(PXSelect<Address, Where<Address.addressID, Equal<Current<BAccount.defAddressID>>>>.SelectSingleBound((PXGraph)instance, new object[1]
        //    {
        //(object) baccount3
        //    }, new object[0]))));
        //    address.AddressID = (baccount3.DefAddressID);
        //    address.BAccountID = (baccount3.BAccountID);
        //    ((PXSelectBase<Address>)instance.AddressCurrent).Update(address);
        //    opportunity.BAccountID = (baccount3.BAccountID);
        //    ((PXSelectBase)instance.Opportunities).Cache.RaiseFieldUpdated<CROpportunity.bAccountID>((object)opportunity, (object)null);
        //    opportunity.LocationID = (baccount3.DefLocationID);
        //    using (IEnumerator<PXResult<CRPMTimeActivity>> enumerator = PXSelect<CRPMTimeActivity, Where<CRPMTimeActivity.refNoteID, Equal<Required<CROpportunity.noteID>>>>.Select((PXGraph)instance, new object[1]
        //    {
        //(object) opportunity.NoteID
        //    }).GetEnumerator())
        //    {
        //        while (((IEnumerator)enumerator).MoveNext())
        //        {
        //            CRPMTimeActivity crpmTimeActivity = PXResult<CRPMTimeActivity>.op_Implicit(enumerator.Current);
        //            ((CRActivity)crpmTimeActivity).BAccountID = (baccount3.BAccountID);
        //            ((PXSelectBase)instance.Activities).Cache.Update((object)crpmTimeActivity);
        //        }
        //    }
        //  ((PXSelectBase<CROpportunity>)instance.Opportunities).Current = (opportunity);
        //    ((PXSelectBase)instance.OpportunityLink).Cache.SetStatus((object)((PXSelectBase<CROpportunity>)instance.Opportunities).Current, (PXEntryStatus)1);
        //    if (((PXGraph)this.Base).IsContractBasedAPI)
        //        throw new PXRedirectRequiredException((PXGraph)instance, "Business Account");
        //    ((PXAction)((PXGraph<BusinessAccountMaint, BAccount>)instance).Save).Press();
        //}

        private Contact FillFromOpportunityContact(Contact Contact)
        {
            CRContact crContact = ((PXSelectBase<CRContact>)this.Base.Opportunity_Contact).SelectSingle(new object[0]);
            Contact.FullName = (crContact.FullName);
            Contact.Title = (crContact.Title);
            Contact.FirstName = (crContact.FirstName);
            Contact.LastName = (crContact.LastName);
            Contact.Salutation = (crContact.Salutation);
            Contact.EMail = (crContact.Email);
            Contact.WebSite = (crContact.WebSite);
            Contact.Phone1 = (crContact.Phone1);
            Contact.Phone1Type = (crContact.Phone1Type);
            Contact.Phone2 = (crContact.Phone2);
            Contact.Phone2Type = (crContact.Phone2Type);
            Contact.Phone3 = (crContact.Phone3);
            Contact.Phone3Type = (crContact.Phone3Type);
            Contact.Fax = (crContact.Fax);
            Contact.FaxType = (crContact.FaxType);
            return Contact;
        }

        private Address FillFromOpportunityAddress(Address Address)
        {
            CRAddress crAddress = ((PXSelectBase<CRAddress>)this.Base.Opportunity_Address).SelectSingle(new object[0]);
            Address.AddressLine1 = (crAddress.AddressLine1);
            Address.AddressLine2 = (crAddress.AddressLine2);
            Address.City = (crAddress.City);
            Address.CountryID = (crAddress.CountryID);
            Address.State = (crAddress.State);
            Address.PostalCode = (crAddress.PostalCode);
            return Address;
        }

        public delegate void CreateContactDelegate(PXAdapter adapter);

        public delegate void CreateAccountDelegate(PXAdapter adapter);

        
    }
}
