using System;
using System.Collections.Generic;
using System.Text;

namespace OOP04
{
    internal class DeliveryCenter
    {
        public Driver driver { get; set; }
        private Shipment[] shipments = new Shipment[20];

        public Shipment this[int index]
        {
            get
            {
                if (index < 0 || index >= shipments.Length)
                    return null;
                return shipments[index];
            }
            set
            {
                if (index < 0 || index >= shipments.Length)
                    return;
                shipments[index] = value;
            }
        }

        public Shipment this[string trackingCode]
        {
            get
            {
                foreach (var s in shipments)
                {
                    if (s != null && s.Trackingcode == trackingCode)
                        return s;
                }
                return null;
            }
        }

        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] == null)
                {
                    shipments[i] = shipment;
                    return true;
                }
            }
            return false;
        }
        //method
        public bool RemoveShipment(string trackingcode)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] != null && trackingcode == shipments[i].Trackingcode)
                {
                    for (int k = i; k < shipments.Length - 1; k++)
                    {
                        shipments[k] = shipments[k + 1];
                    }
                    shipments[shipments.Length - 1] = null;
                    return true;
                }

            }
            return false;
        }

        public void PrintAllShipments()
        {
            foreach (var j in shipments)
            {
                if (j != null)
                {

                    j.PrintShipment();
                }

            }
        }

        public void PrintTrackingStatuses()
        {
            Console.WriteLine("==========================================");
            Console.WriteLine("Tracking Status\n");
            foreach (var item in shipments)
            {
                if (item is ITrackable trackableItem)
                {
                    Console.WriteLine(trackableItem.GetTrackingStatus());
                    Console.WriteLine();
                }
            }
        }

    }
}
