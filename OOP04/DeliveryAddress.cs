using System;
using System.Collections.Generic;
using System.Text;

namespace OOP04
{
    internal class DeliveryAddress
    {
        #region prop
        public int buildingnum { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        #endregion

        public DeliveryAddress(string City, string Street, int BuildingNum)
        {
            city = City;
            street = Street;
            buildingnum = BuildingNum;
        }
        public string GetFullAddress()
        {
            return $"{city}:{street}:{buildingnum}";
        }
        public override string ToString()
        {
            return $"city: {city},street: {street},buildingnum: {buildingnum}";
        }
    }
}

