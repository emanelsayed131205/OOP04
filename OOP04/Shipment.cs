using System;
using System.Collections.Generic;
using System.Text;

namespace OOP04
{
    internal abstract class Shipment
    {
        private string trackingCode;

        public string Trackingcode
        {
            get { return trackingCode; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("invalid code");
                }
                else
                {
                    trackingCode = value;
                }

            }
        }


        private string Description;

        public string description
        {
            get { return Description; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("invalid code");
                }
                else
                {
                    Description = value;
                }
            }
        }

        private decimal weight;

        public decimal Weight
        {
            get { return weight; }
            set
            {
                if (value <= 0)
                    Console.WriteLine("invalid weight");
                else
                    weight = value;

            }
        }

        private decimal deliveryfee;

        public decimal DeliveryFee
        {
            get { return deliveryfee; }
            private set
            {
                if (value <= 0)
                    Console.WriteLine("invalid deliveryfee");
                else
                    deliveryfee = value;
            }
        }


        public DeliveryAddress Destination { get; set; }


        public abstract decimal EstimatedCost
        { get; }



        public Shipment(string trackingcode)
        {
            Trackingcode = trackingcode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = default;

        }


        public Shipment(string Strackingcode, string Sdecription, decimal Sweight, decimal Sdeliveryfee, DeliveryAddress destination)
        {
            trackingCode = Strackingcode;
            description = Sdecription;
            weight = Sweight;
            deliveryfee = Sdeliveryfee;
            Destination = destination;
        }


        #region overload oop3
        public void UpdateWeight(decimal neWweight)
        {
            weight = neWweight;
        }
        public void UpdateWeight(decimal neWweight, decimal extraPackingWeight)
        {
            weight = neWweight + extraPackingWeight;
        }



        #endregion


        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
                DeliveryFee = newFee;
        }

        public abstract void PrintShipment();
        //{
            //Console.WriteLine("TrackingCode: " + Trackingcode);
            //Console.WriteLine("Description: " + description);
            //Console.WriteLine("Weight: " + weight + " KG");
            //Console.WriteLine("DeliveryFee: " + DeliveryFee + " EGP");
            //Console.WriteLine("Destination: " + Destination.GetFullAddress());
            //Console.WriteLine("Estimated Cost: " + EstimatedCost + " EGP");
        //}
    }
}
