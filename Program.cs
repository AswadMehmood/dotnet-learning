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
                if (fileLines[i].ToLower().Contains("sector"))
                {
                    City cityAddress = new City();
                    string[] splitString = fileLines[i].Split(",");
                    foreach (string addressBit in splitString)
                    {
                        if ( addressBit.Contains("House"))
                        {
                            string output = Regex.Match(addressBit, @"[0-9]+");
                            
                        }
                        
                    }
                    
                }
               
                if (splitString.Count() > 1)
                {
                    if (!String.IsNullOrEmpty(splitString[1]))
                    {
                        // Do nothing
                    }
                }
            }
        }
    }
}