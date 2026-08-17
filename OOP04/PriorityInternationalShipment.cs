using System;
using System.Collections.Generic;
using System.Text;

namespace OOP04
{
    internal class PriorityInternationalShipment:InterNationalShipment
    {
        public PriorityInternationalShipment(string Strackingcode, string Sdecription, decimal Sweight, decimal Sdeliveryfee, DeliveryAddress destination, decimal Scustomerfee) : base(Strackingcode, Sdecription, Sweight, Sdeliveryfee, destination, Scustomerfee)
        {

        }

        public sealed override string GenerateCustomsReport()
        {
            return $"Customs Report for {DestinationCountry}: Fee is {CustomerFee} EGP.";
        }

        public override void PrintShipment()
        {
            Console.WriteLine("Express Shipment");
            Console.WriteLine($"Tracking Code : {Trackingcode}");
            Console.WriteLine($"Description   : {description}");
            Console.WriteLine($"Weight        : {Weight} KG");
            Console.WriteLine($"Delivery Fee  : {DeliveryFee} EGP");
            Console.WriteLine($"Customer Fee  : {CustomerFee} EGP");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
            Console.WriteLine($"Destination Country: {DestinationCountry} EGP");
        }
    }
}
