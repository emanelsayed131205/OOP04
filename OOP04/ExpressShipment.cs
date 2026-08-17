using System;
using System.Collections.Generic;
using System.Text;

namespace OOP04
{
    internal class ExpressShipment:Shipment,IInsurable,ITrackable
    {
        private decimal extrafee;

        public decimal ExtraFee
        {
            get { return extrafee; }
            set
            {
                if (value < 0)
                    Console.WriteLine("invalid");
                else
                    extrafee = value;
            }
        }
        public override decimal EstimatedCost
        {
            get { return DeliveryFee + (Weight * 5) + ExtraFee; }
        }

        public ExpressShipment(string Strackingcode, string Sdecription, decimal Sweight, decimal Sdeliveryfee, DeliveryAddress destination, decimal Shiextrafees) : base(Strackingcode, Sdecription, Sweight, Sdeliveryfee, destination)
        {
            extrafee = Shiextrafees;
        }
        
        public string GetTrackingStatus() => $"Shipment {Trackingcode} is Out for Delivery.";
        public decimal CalculateInsurance() => EstimatedCost * 0.08m;

        public override void PrintShipment()
        {
            Console.WriteLine("Express Shipment");
            Console.WriteLine($"Tracking Code : {Trackingcode}");
            Console.WriteLine($"Description   : {description}");
            Console.WriteLine($"Weight        : {Weight} KG");
            Console.WriteLine($"Delivery Fee  : {DeliveryFee} EGP");
            Console.WriteLine($"Extra Fee     : {ExtraFee} EGP");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }
    }
}
