using System;
using System.Collections.Generic;
using System.Text;

namespace OOP04
{
    internal class InterNationalShipment:Shipment,ITrackable,IInsurable
    {
        private string destinationcountry;

        public string DestinationCountry
        {
            get { return destinationcountry; }
            set
            {
                if (string.IsNullOrEmpty(value))

                    Console.WriteLine("invalid code");

                else

                    destinationcountry = value;
            }
        }
        private decimal customerfee;

        public decimal CustomerFee
        {
            get { return customerfee; }
            set
            {
                if (value < 0)
                    Console.WriteLine("invalid");
                else
                    customerfee = value;
            }
        }
        public override decimal EstimatedCost
        {
            get { return DeliveryFee + (Weight * 5) + CustomerFee; }
        }

        public InterNationalShipment(string Strackingcode, string Sdecription, decimal Sweight, decimal Sdeliveryfee, DeliveryAddress destination, string v, decimal Scustomerfee) : base(Strackingcode, Sdecription, Sweight, Sdeliveryfee, destination)
        {
            customerfee = Scustomerfee;
        }

        public virtual string GenerateCustomsReport()
        {
            return $"Customs Report for {DestinationCountry}: Fee is {customerfee} EGP.";
        }

        public string GetTrackingStatus() => $"Shipment {Trackingcode} has been Delivered.";
        public decimal CalculateInsurance() => EstimatedCost * 0.12m;
        public override void PrintShipment()
        {
            Console.WriteLine("Express Shipment");
            Console.WriteLine($"Tracking Code : {Trackingcode}");
            Console.WriteLine($"Description   : {description}");
            Console.WriteLine($"Weight        : {Weight} KG");
            Console.WriteLine($"Delivery Fee  : {DeliveryFee} EGP");
            Console.WriteLine($"Customer Fee  : {customerfee} EGP");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
            Console.WriteLine($"Destination Country: {DestinationCountry} EGP");
        }
    }
}
