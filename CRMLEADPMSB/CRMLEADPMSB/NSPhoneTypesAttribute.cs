// Decompiled with JetBrains decompiler
// Type: CRMLEADPMSB.NSPhoneTypesAttribute
// Assembly: CRMLEADPMSB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: BA3FB156-B7E5-4249-A9FC-ED75D42F2979
// Assembly location: C:\Users\QuantumLingual107\AppData\Local\Temp\Nywihyp\7ad39fc3ac\Bin\CRMLEADPMSB.dll

using PX.Data;

namespace CRMLEADPMSB
{
    public class NSPhoneTypesAttribute : PXStringListAttribute
    {
        public const string Business1 = "B1";
        public const string Business2 = "B2";
        public const string Business3 = "B3";
        public const string BusinessAssistant1 = "BA1";
        public const string BusinessFax = "BF";
        public const string Home = "H1";
        public const string HomeFax = "HF";
        public const string Cell = "C";

        public NSPhoneTypesAttribute() : base(
            new string[8]  {
        "B1", "B2",  "B3",  "BA1",  "BF",  "H1",  "HF",  "C"  },
            new string[8] {
        "Business 1",  "Business 2",   "Business 3",   "Extension No:",  "Business Fax",
        nameof (Home),   "Home Fax",   nameof (Cell)   })
        { }


        public class business1 : PX.Data.BQL.BqlString.Constant<business1>
        {
            public business1() : base("B1") { }
        }

        public class business2 : PX.Data.BQL.BqlString.Constant<business2>
        {
            public business2() : base("B2")
            {
            }
        }

        public class business3 : PX.Data.BQL.BqlString.Constant<business3>
        {
            public business3() : base("B3")
            {
            }
        }

        public class businessAssistant1 : PX.Data.BQL.BqlString.Constant<businessAssistant1>
        {
            public businessAssistant1() : base("BA1")
            {
            }
        }

        public class businessFax : PX.Data.BQL.BqlString.Constant<businessFax>
        {
            public businessFax() : base("BF")
            {
            }
        }

        public class home : PX.Data.BQL.BqlString.Constant<home>
        {
            public home() : base("H1")
            {
            }
        }

        public class homeFax : PX.Data.BQL.BqlString.Constant<homeFax>
        {
            public homeFax() : base("HF")
            {
            }
        }

        public class cell : PX.Data.BQL.BqlString.Constant<cell>
        {
            public cell() : base("C")
            {
            }
        }
    }
}
