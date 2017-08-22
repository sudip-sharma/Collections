using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionClassSample
{
    class Program
    {
        public class CountryDetails
        {
            public string CountryName { get; set; }
            public string CountryCode { get; set; }
            public string CountryCapital { get; set; }
        }

        static void Main(string[] args)
        {
            CountryDetails firstCountry = new CountryDetails { CountryCapital = "New Delhi", CountryCode = "IND", CountryName = "India" };
            CountryDetails secondCountry = new CountryDetails { CountryName = "Russia", CountryCode = "USSR", CountryCapital = "Moscow" };
            CountryDetails thirdCountry = new CountryDetails { CountryCapital = "Canberra", CountryCode = "AUS", CountryName = "Australia" };
            CountryDetails fourthCountry = new CountryDetails { CountryName = "New Zealand", CountryCode = "NZ", CountryCapital = "Wellington" };

            List<CountryDetails> lstCountry = new List<CountryDetails>();
            lstCountry.Add(firstCountry);
            lstCountry.Add(secondCountry);
            lstCountry.Add(thirdCountry);
            lstCountry.Add(fourthCountry);
            string doContinue = string.Empty;

            do
            {
                Console.WriteLine("Please enter the name of the country : ");
                string countryEntered = Console.ReadLine().ToUpper();

                CountryDetails countryToDisplay = lstCountry.Find(x => x.CountryCode == countryEntered);
                if (countryToDisplay == null)
                {
                    Console.WriteLine("The country is invalid");
                }
                else
                {
                    Console.WriteLine("The country name is : {0}, The country capital is {1}", countryToDisplay.CountryName, countryToDisplay.CountryCapital);
                }
                do
                {
                    Console.WriteLine("Do you want to continue : Enter Yes or No");
                    doContinue = Console.ReadLine().ToUpper();
                } while(doContinue != "NO" && doContinue != "YES");
            }
            while (doContinue == "YES");
        }
    }
}
