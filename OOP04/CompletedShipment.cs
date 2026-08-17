using System;
using System.Collections.Generic;
using System.Text;

namespace OOP04
{
    internal sealed class CompletedShipment:Shipment
    {
        public CompletedShipment(string Strackingcode, string Sdecription, decimal Sweight, decimal Sdeliveryfee, DeliveryAddress destination) : base(Strackingcode, Sdecription, Sweight, Sdeliveryfee, destination)
        {

        }
        public override void PrintShipment()
        {
            Console.WriteLine("TrackingCode: " + Trackingcode);
            Console.WriteLine("Description: " + description);
            Console.WriteLine("Weight: " + Weight + " KG");
            Console.WriteLine("DeliveryFee: " + DeliveryFee + " EGP");
            Console.WriteLine("Destination: " + Destination.GetFullAddress());
            Console.WriteLine("Estimated Cost: " + EstimatedCost + " EGP");
        }
    }
}
