using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UKPostCode
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            do
            {
                Console.WriteLine("Enter Postcode to Validate - Enter in Capital Letters");
                String postcode = Console.ReadLine();

                if (IsPostCode(postcode))
                { Console.WriteLine(" VALID UK Postcode"); }
                else
                { Console.WriteLine(" INVALID UK Postcode"); }

                Console.WriteLine("Press 'Enter' Key to Continue Checking Manual Inputted Postcodes Validity \n or Press 'Esc' to run BATCH JOBS \n");

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

            Console.WriteLine("Running BATCH JOBS...VALIDATING POSTCODES IN #import_data file \n");

            //create a reader for input data file
            var reader = new StreamReader(File.OpenRead(@"../../Resources/import_data.csv"));
            var lineHead = reader.ReadLine();

            //Dictionary for getting the input data
            Dictionary<int, string> pCodeData = new Dictionary<int, string>();

            //create a writer for writing data into 2 output file
            //Non matching output file
            var csvFailedOutput = new StringBuilder();
            //Matching output file
            var csvSucceededOutput = new StringBuilder();
            string csvRowHead = string.Format("{0},{1}", "row_id", "postcode");
            //write hearders for output files
            csvFailedOutput.AppendLine(csvRowHead);
            csvSucceededOutput.AppendLine(csvRowHead);

            string csvRowFail = null;
            string csvRowSucceed = null;

            //Read the input data file into Dictionary
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                pCodeData.Add(Convert.ToInt32(values[0]), values[1]);
            }

            //Sort the dictionary
            var list = pCodeData.Keys.ToList();
            list.Sort();

            //To collect performance of matching validity of postcodes
            Stopwatch stopWatchFail = new Stopwatch();
            Stopwatch stopWatchPass = new Stopwatch();

            Console.WriteLine("Processing NON-MATCHING POSTCODES VALIDATION...\n");
            stopWatchFail.Start();
            //update the postcode data which fails postcode validation
            foreach (var key in list)
            {             
                if (!IsPostCode(pCodeData[key]))
                {
                    csvRowFail = string.Format("{0},{1}", key, pCodeData[key]);
                    csvFailedOutput.AppendLine(csvRowFail);
                }
            }
            stopWatchFail.Stop();
            TimeSpan tsFail = stopWatchFail.Elapsed;
            Console.WriteLine("TIME TO PROCESS NON-MATCHING POSTCODES : " + tsFail + "\n");

            Console.WriteLine("Processing MATCHING POSTCODES VALIDATION...\n");
            stopWatchPass.Start();
            //update the postcode data which passes postcode validation
            foreach (var key in list)
            {               
                if (IsPostCode(pCodeData[key]))
                {
                    csvRowSucceed = string.Format("{0},{1}", key, pCodeData[key]);
                    csvSucceededOutput.AppendLine(csvRowSucceed);
                }
            }
            stopWatchPass.Stop();
            TimeSpan tsPass = stopWatchPass.Elapsed;
            Console.WriteLine("TIME TO PROCESS MATCHING POSTCODES : "+tsPass + "\n");

            //Write data in the File ---Failed Validation
            Console.WriteLine("GENEREATING FILE CONTAINING FAILED POSTCODES VALIDATION...#../Resources/failed_validation.csv\n");
            File.WriteAllText(@"../../Resources/failed_validation.csv", csvFailedOutput.ToString());

            //Write data in the File ---Failed Validation
            Console.WriteLine("GENEREATING FILE CONTAINING FAILED POSTCODES VALIDATION...#../Resources/succeeded_validation.csv\n");
            File.WriteAllText(@"../../Resources/succeeded_validation.csv", csvSucceededOutput.ToString());
            Console.WriteLine("JOBS COMPLETED \n");
           
            Console.WriteLine("CLICK ENTER KEY TO EXIT APPLICATION");
            Console.ReadKey();

        }

        public static bool IsPostCode(string postcode)
        {
            return (
               //Regex.IsMatch(postcode, "(^GIR\\s0AA$)") ||
               //Regex.IsMatch(postcode, "(^[A-PR-UWYZ][0-9][0-9]?\\s[0-9][ABD-HJLNP-UW-Z]{2}$)") ||
               //Regex.IsMatch(postcode, "(^[A-PR-UWYZ][A-HK-Y][0-9](?<!(BR|FY|HA|HD|HG|HR|HS|HX|JE|LD|SM|SR|WC|WN|ZE)[0-9])[0-9]\\s[0-9][ABD-HJLNP-UW-Z]{2}$)") ||
               //Regex.IsMatch(postcode, "(^[A-PR-UWYZ][A-HK-Y](?<!AB|LL|SO)[0-9]\\s[0-9][ABD-HJLNP-UW-Z]{2}$)") ||
               //Regex.IsMatch(postcode, "(^WC[0-9][A-Z]\\s[0-9][ABD-HJLNP-UW-Z]{2}$)") ||
               //Regex.IsMatch(postcode, "(^[A-PR-UWYZ][0-9][A-HJKPSTUW]\\s[0-9][ABD-HJLNP-UW-Z]{2}$)") ||
               //Regex.IsMatch(postcode, "(^[A-PR-UWYZ][A-HK-Y][0-9][ABEHMNPRVWXY]\\s[0-9][ABD-HJLNP-UW-Z]{2}$)")


               Regex.IsMatch(postcode, "(GIR\\s0AA)") ||
               Regex.IsMatch(postcode, "([A-PR-UWYZ][0-9][0-9]?\\s[0-9][ABD-HJLNP-UW-Z]{2})") ||
               Regex.IsMatch(postcode, "([A-PR-UWYZ][A-HK-Y][0-9](?<!(BR|FY|HA|HD|HG|HR|HS|HX|JE|LD|SM|SR|WC|WN|ZE)[0-9])[0-9]\\s[0-9][ABD-HJLNP-UW-Z]{2})") ||
               Regex.IsMatch(postcode, "([A-PR-UWYZ][A-HK-Y](?<!AB|LL|SO)[0-9]\\s[0-9][ABD-HJLNP-UW-Z]{2})") ||
               Regex.IsMatch(postcode, "(WC[0-9][A-Z]\\s[0-9][ABD-HJLNP-UW-Z]{2})") ||
               Regex.IsMatch(postcode, "([A-PR-UWYZ][0-9][A-HJKPSTUW]\\s[0-9][ABD-HJLNP-UW-Z]{2})") ||
               Regex.IsMatch(postcode, "([A-PR-UWYZ][A-HK-Y][0-9][ABEHMNPRVWXY]\\s[0-9][ABD-HJLNP-UW-Z]{2})")
                );
        }




    }
}
