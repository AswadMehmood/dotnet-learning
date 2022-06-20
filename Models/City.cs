using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    internal class City:Address
    {

        public int subSecter;
        public string sectreName = "";
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
