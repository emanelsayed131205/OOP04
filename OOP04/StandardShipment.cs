using System;
using System.Collections.Generic;
using System.Text;

namespace OOP04
{
    internal class StandardShipment:Shipment,ITrackable,IInsurable
    {
        public StandardShipment(string Strackingcode, string Sdecription, decimal Sweight, decimal Sdeliveryfee, DeliveryAddress destination) : base(Strackingcode, Sdecription, Sweight, Sdeliveryfee, destination)
        {

        }
        public override decimal EstimatedCost => DeliveryFee + (Weight * 3m);

        public override void PrintShipment()
        {
            Console.WriteLine("Standard Shipment\n");
            Console.WriteLine($"Tracking Code : {Trackingcode}");
            Console.WriteLine($"Description   : {description}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }

        public string GetTrackingStatus() => $"Shipment {Trackingcode} is Ready.";

        public decimal CalculateInsurance() => EstimatedCost * 0.05m;
        //public override void PrintShipment()
        //{
        //    Console.WriteLine("Standard Shipment");
        //    base.PrintShipment();
        //}
    }
}
