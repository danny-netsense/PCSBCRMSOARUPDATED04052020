// Decompiled with JetBrains decompiler
// Type: PX.Objects.SO.SOShipmentEntry_Extension
// Assembly: CRMLEADPMSB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: BA3FB156-B7E5-4249-A9FC-ED75D42F2979
// Assembly location: C:\Users\QuantumLingual107\AppData\Local\Temp\Nywihyp\7ad39fc3ac\Bin\CRMLEADPMSB.dll

using PX.Data;
using System.Collections;

namespace PX.Objects.SO
{
    public class SOShipmentEntry_Extension : PXGraphExtension<SOShipmentEntry>
    {
        public PXAction<SOShipment> tracking;

        [PXUIField]
        [PXButton]
        public virtual IEnumerable Tracking(PXAdapter adapter)
        {
            SOShipment current = ((PXSelectBase<SOShipment>)this.Base.Document).Current;
            SOShipmentExt extension = (SOShipmentExt)PXCache<SOShipment>.GetExtension<SOShipmentExt>(current);
            if (string.IsNullOrEmpty(extension.UsrTrackingNbr) || string.IsNullOrEmpty(current.ShipVia))
            {
                ((PXSelectBase<SOShipment>)this.Base.Document).Ask("Error", "Tracking No/Ship Via Cannot be Empty", (MessageButtons)0, (MessageIcon)1);
            }
            else
            {
                switch (current.ShipVia)
                {
                    case "CITY":
                        throw new PXRedirectToUrlException(string.Format("http://www.citylinkexpress.com/my/home.aspx", (object)extension.UsrTrackingNbr), (PXBaseRedirectException.WindowMode)3, nameof(Tracking) + current.ShipVia);
                    case "DHL":
                        throw new PXRedirectToUrlException(string.Format("http://www.dhl.com/en/express/tracking.html?AWB={0}&brand=DHL", (object)extension.UsrTrackingNbr), (PXBaseRedirectException.WindowMode)3, nameof(Tracking) + current.ShipVia);
                    case "FEDEX":
                        throw new PXRedirectToUrlException(string.Format("https://www.fedex.com/apps/fedextrack/?action=track&cntry_code=my&trackingnumber={0}", (object)extension.UsrTrackingNbr), (PXBaseRedirectException.WindowMode)3, nameof(Tracking) + current.ShipVia);
                    case "FWD":
                        ((PXSelectBase<SOShipment>)this.Base.Document).Ask("Info", "Not Implemented", (MessageButtons)0, (MessageIcon)4);
                        break;
                    case "GDEX":
                        ((PXSelectBase<SOShipment>)this.Base.Document).Ask("Info", "Not Implemented", (MessageButtons)0, (MessageIcon)4);
                        break;
                    case "NWIDE":
                        ((PXSelectBase<SOShipment>)this.Base.Document).Ask("Info", "Not Implemented", (MessageButtons)0, (MessageIcon)4);
                        break;
                    case "OTH":
                        ((PXSelectBase<SOShipment>)this.Base.Document).Ask("Info", "Not Implemented", (MessageButtons)0, (MessageIcon)4);
                        break;
                    case "TNT":
                        throw new PXRedirectToUrlException(string.Format("https://www.tnt.com/express/en_my/site/shipping-tools/tracking.html?cons={0}&searchType=CON&source=home_widget", (object)extension.UsrTrackingNbr), (PXBaseRedirectException.WindowMode)3, nameof(Tracking) + current.ShipVia);
                    case "TNTT":
                        ((PXSelectBase<SOShipment>)this.Base.Document).Ask("Info", "Not Implemented", (MessageButtons)0, (MessageIcon)4);
                        break;
                    case "UPS":
                        throw new PXRedirectToUrlException(string.Format("https://www.ups.com/WebTracking/track?loc=en_MY", (object)extension.UsrTrackingNbr), (PXBaseRedirectException.WindowMode)3, nameof(Tracking) + current.ShipVia);
                }
            }
            return adapter.Get();
        }

    }
}
