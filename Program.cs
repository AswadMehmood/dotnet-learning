using dotnet_learning.Models;
using Models;
using System.Text.RegularExpressions;

namespace dotnet_learning
{
    internal class Program
    {
        static public AddressBook addressBook = new AddressBook();

        static void Main(string[] args)
        {

            string[] fileLines = GetFileLines();

            for (int i = 0; i < fileLines.Length; i++)
            {
                fileLines[i] = fileLines[i].ToLower();

                if (fileLines[i].Contains("sector"))
                {
                    City cityAddress = ParseCityAddress(fileLines[i]);
                    addressBook.addresses.Add(cityAddress);
                }
                else
                {
                    Village villageAddress = ParseVillageAddress(fileLines[i]);
                    addressBook.addresses.Add(villageAddress);
                }
            }
            Console.WriteLine("print");
        }

        private static Village ParseVillageAddress(string fileLine)
        {
            Village villageAddress = new Village();
            string[] splitString = fileLine.Split(",");
            foreach (string addressBit in splitString)
            {
                if (addressBit.Contains("house"))
                {
                    string output = Regex.Match(addressBit, @"[0-9]+").Value.Trim();
                    villageAddress.houseNumber = Convert.ToInt32(output);
                }
                else if (addressBit.Contains("street"))
                {
                    string output = Regex.Match(addressBit, @"[0-9]+").Value.Trim();
                    villageAddress.streetNumber = Convert.ToInt32(output);
                }
                else if (addressBit.Contains("village"))
                {
                    string output = addressBit.Replace("village", "").Trim();
                    villageAddress.villageName = output;
                }
                else if (addressBit.Contains("city"))
                {
                    string output = addressBit.Replace("city", "").Trim();
                    villageAddress.cityName = output;
                }
                else if (addressBit.Contains("district"))
                {
                    string output = addressBit.Replace("district", "").Trim();
                    villageAddress.districtName = output;
                }
                else
                {
                    villageAddress.provinceName = addressBit.Trim();
                }

            }
            return villageAddress;
        }

        private static City ParseCityAddress(string fileLine)
        {
            City cityAddress = new City();
            string[] splitString = fileLine.Split(",");
            foreach (string addressBit in splitString)
            {
                if (addressBit.Contains("house"))
                {
                    string output = Regex.Match(addressBit, @"[0-9]+").Value.Trim();
                    cityAddress.houseNumber = Convert.ToInt32(output);
                }
                else if (addressBit.Contains("street"))
                {
                    string output = Regex.Match(addressBit, @"[0-9]+").Value.Trim();
                    cityAddress.streetNumber = Convert.ToInt32(output);
                }
                else if (addressBit.Contains("sector"))
                {
                    string output = addressBit.Replace("sector", "").Trim();
                    cityAddress.sectreName = output;
                }
                else if (addressBit.Contains("city"))
                {
                    string output = addressBit.Replace("city", "").Trim();
                    cityAddress.cityName = output;
                }
                else if (addressBit.Contains("district"))
                {
                    string output = addressBit.Replace("district", "").Trim();
                    cityAddress.districtName = output;
                }
                else
                {
                    cityAddress.provinceName = addressBit.Trim();
                }
            }
            return cityAddress;
        }

        private static string[] GetFileLines()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = desktopPath + "\\Addresses.txt";
            return File.ReadAllLines(filePath);
        }
    }
}