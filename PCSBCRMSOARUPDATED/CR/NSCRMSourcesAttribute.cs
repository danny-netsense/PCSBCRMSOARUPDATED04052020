// Decompiled with JetBrains decompiler
// Type: PX.Objects.CR.NSCRMSourcesAttribute
// Assembly: PCSBCRMSOARUPDATED, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 182865F4-07BB-4D2C-9E47-9E96DF45516C
// Assembly location: C:\Users\QuantumLingual107\AppData\Local\Temp\Vihywod\7ad39fc3ac\Bin\PCSBCRMSOARUPDATED.dll

using PX.Data;

namespace PX.Objects.CR
{
    public class NSCRMSourcesAttribute : PXStringListAttribute
    {
        public const string _CONFERENCE = "C";
        public const string _EXHIBITION = "E";
        public const string _ONLINEADVERT = "O";
        public const string _PHONEENQUIRY = "P";
        public const string _REFERAL = "R";
        public const string _REPEATEDCUSTOMER = "Y";
        public const string _STAFFPERSONALNETWORKING = "Q";
        public const string _SALESCAMPAIGN = "S";
        public const string _SEMINARTALK = "J";
        public const string _TRAINING = "T";
        public const string _WEBSITEENQ = "W";
        public const string _WORKSHOP = "X";

        public NSCRMSourcesAttribute() : base(
            new string[12] { "C", "E", "O", "P", "R", "Y", "S", "J", "Q", "T", "W", "X" },
            new string[12]   {  "Conference",  "Exhibition",   "Online Advert",   "Phone Enquiry",  "Referral",  "Repeated Customer",
                "Sales Campaign",  "Seminar Talk",   "Staff Personal Networking",   "Training",  "Website Enquiry",   "Workshop"  })
        {
        }
    }
}
