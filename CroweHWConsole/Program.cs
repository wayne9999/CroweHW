using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using HWDomain;
//using System.Web.Script.Serialization;

namespace CroweHWConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string InputVal;
                Console.WriteLine("Terminate Program: 0");
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
                        using (var client = new WebClient())
                        {
                            client.Headers.Add("Content-Type:application/json");
                            client.Headers.Add("Accept:application/json");
                            var result = client.DownloadString("https://localhost:44322/api/values/0"); //URI  

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
                    default:
                        Console.WriteLine("Not a valid option");
                        break;
                }
            }
            catch (Exception ex)
            {
                var error = ex.Message;
            }

        }

        private static string CleanExtract(string result)
        {
            String DisplayValue = "";
            try
            {
                string cleanArray = result.ToString().Replace("\"", "").Replace("[", "").Replace("]", "");
                string[] arr = cleanArray.Split(',');

                var slist = new List<HelloWorld>();

                foreach (string arrItem in arr)
                {
                    HelloWorld hw = new HelloWorld();
                    hw.name = arrItem;
                    slist.Add(hw);
                    DisplayValue += " " + arrItem;

                }
            }
            catch (Exception ex)
            {
                var error = ex.Message;
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
