using System;
using System.Collections.Generic;
using dotnet_learning.Models;
using Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_learning.Composers
{
    internal class JsonComposer
    {
        public static string ComposeJson(AddressBook addressBook)
        {
            string output = "";
            foreach (Address address in addressBook.addresses)
            {
                output += "{";

                output += "\"houseNumber\"";
                output += ":";
                output += "\"" + address.houseNumber.ToString() + "\"";
                output += ", ";

                output += "\"streetNumber\"";
                output += ":";
                output += "\"" + address.streetNumber.ToString() + "\"";
                output += ", ";

                if (address is City)
                {
                    City city = new City(address);
                    output += "\"sectreName\"";
                    output += ":";
                    output += "\"" + city.sectreName + "\"";
                    output += ", ";

                    output += "\"subSecter\"";
                    output += ":";
                    output += "\"" + city.subSecter.ToString() + "\"";
                    output += ", ";
                }
                else
                {
                    Village village = new Village(address);
                    output += "\"villageName\"";
                    output += ":";
                    output += "\"" + village.villageName + "\"";
                    output += ", ";
                }

                output += "\"cityName\"";
                output += ":";
                output += "\"" + address.cityName + "\"";
                output += ", ";

                output += "\"districtName\"";
                output += ":";
                output += "\"" + address.districtName + "\"";
                output += ", ";

                output += "\"provinceName\"";
                output += ":";
                output += "\"" + address.provinceName + "\"";

                output += "}\n";
            }
            return output;
        }
    }
}
