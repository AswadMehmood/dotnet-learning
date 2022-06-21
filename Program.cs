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
            // Get Desktop Path
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = desktopPath + "\\Addresses.txt";
            string[] fileLines = File.ReadAllLines(filePath);

            for (int i = 0; i < fileLines.Length; i++)
            {
                fileLines[i] = fileLines[i].ToLower();
                if (fileLines[i].Contains("sector"))
                {
                    City cityAddress = new City();
                    string[] splitString = fileLines[i].Split(",");
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

                    addressBook.addresses.Add(cityAddress);

                }
                else
                {
                    Village villageAddress = new Village();
                    string[] splitString = fileLines[i].Split(",");
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

                    addressBook.addresses.Add(villageAddress);

                }
            }
            Console.WriteLine("print");
        }
    }
}