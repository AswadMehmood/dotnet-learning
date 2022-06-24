using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    internal class City : Address
    {

        public int subSecter;
        public string sectreName = "";

        public City() { }

        public City(Address address)
        {
            cityName = address.cityName;
            districtName = address.districtName;
            provinceName = address.provinceName;
            houseNumber = address.houseNumber;
            streetNumber = address.streetNumber;
            
            if (address is City)
            {
                var cityAddress = address as City;
                sectreName = cityAddress.sectreName;
                subSecter = cityAddress.subSecter;
            }
        }

        public string GetFullAddress()
        {
            string fullAddress = "";
            fullAddress += "House " + Convert.ToString(houseNumber) + ", ";
            fullAddress += "Street " + Convert.ToString(streetNumber) + ", ";
            fullAddress += "Sub Secter " + Convert.ToString(subSecter) + ", ";
            fullAddress += "Secter " + sectreName + ", ";
            fullAddress += "City " + cityName + ", ";
            fullAddress += "Province " + provinceName;
            return fullAddress;
        }

        public string GetShortAddress()
        {
            string shortAddress = "";
            shortAddress += Convert.ToString(houseNumber) + ", ";
            shortAddress += "St " + Convert.ToString(streetNumber) + ", ";
            shortAddress += "Sec: " + sectreName + "/" + Convert.ToString(subSecter);
            return shortAddress;
        }
    }
}
