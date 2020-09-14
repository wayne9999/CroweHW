using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
//using System.Web.Script.Serialization;

namespace CroweHWConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string InputVal;
            Console.WriteLine("Console Only: 1");
            Console.WriteLine("Raw API: 2");
            Console.WriteLine("API Using database: 3");
            Console.Write("Enter Options: ");
            InputVal = Console.ReadLine();

            switch (InputVal)
            {
                case "1":
                    Console.WriteLine("Hello World");
                    break;
                case "2":
                    using (var client = new WebClient())
                    {
                        client.Headers.Add("Content-Type:application/json");
                        client.Headers.Add("Accept:application/json");
                        var result = client.DownloadString("https://localhost:44322/api/values"); //URI  

                        if (result != null)
                        {
                           string DValue = CleanExtract(result);
                            if (!string.IsNullOrEmpty(DValue))
                            {
                                Console.WriteLine("Display: " + DValue);
                            }
                            //Console.WriteLine(Environment.NewLine + result);
                        }
                        else
                        {
                            Console.WriteLine("Value return was Null");
                        }
                        
                    }
                    break;
                case "3":
                    // Statements executed if expression(or variable) = value1
                    break;
                default:
                    Console.WriteLine("Not a valid option");
                    break;
            }



        }

        private static string CleanExtract(string result)
        {
            String DisplayValue = "";
            string cleanArray = result.ToString().Replace("\"", "").Replace("[", "").Replace("]", "");
            string[] arr = cleanArray.Split(',');

            var slist = new List<HelloWorld>();

            foreach (string arrItem in arr)
            {
                HelloWorld hw = new HelloWorld();
                hw.name = arrItem;
                slist.Add(hw);
                DisplayValue += " " + DisplayValue;

            }

            return DisplayValue;
        }

        public void GetAllData()
        {
            using (var client = new WebClient())
            {
                client.Headers.Add("Content-Type:application/json");
                client.Headers.Add("Accept:application/json");
                var result = client.DownloadString("https://localhost:44322/api/values"); //URI  
                Console.WriteLine(Environment.NewLine + result);
            }
        }
    }
}
