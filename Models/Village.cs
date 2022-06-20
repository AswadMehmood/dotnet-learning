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
