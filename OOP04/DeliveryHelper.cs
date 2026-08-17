using System;
using System.Collections.Generic;
using System.Text;

namespace OOP04
{
    internal interface DeliveryHelper
    {
        public static void PrintShipmentDetails(Shipment shipment)
        {
            if (shipment != null)
            {
                shipment.PrintShipment();
            }
        }
    }
}
