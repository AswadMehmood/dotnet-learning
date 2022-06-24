using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    internal class Village:Address
    {
        public string villageName = "";

        public Village() { }

        public Village (Address address)
        {
            cityName = address.cityName;
            districtName = address.districtName;
            provinceName = address.provinceName;
            houseNumber = address.houseNumber;
            streetNumber = address.streetNumber;

            if (address is Village)
            {
                var villageAddress = address as Village;
                villageName = villageAddress.villageName;

            }

        }

        public string GetFullAddress()
        {
            string fullAddress = "";
            fullAddress += "House " + Convert.ToString(houseNumber) + ", ";
            fullAddress += "Street " + Convert.ToString(streetNumber) + ", ";
            fullAddress += "Village " + villageName + ", ";
            fullAddress += "City " + cityName + ", ";
            fullAddress += "Province " + provinceName;
            return fullAddress;
        }

        public string GetShortAddress()
        {
            string shortAddress = "";
            shortAddress += Convert.ToString(houseNumber) + ", ";
            shortAddress += "St " + Convert.ToString(streetNumber) + ", ";
            shortAddress += "Village " + villageName ;
            return shortAddress;
        }
    }
}
