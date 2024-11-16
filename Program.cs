using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SSFConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Get Patient Details
            try
            {
                string url = "https://demoimis.ssf.gov.np/api/api_fhir_r4/Patient/?identifier=20760000042";

                WebRequest request = WebRequest.Create(url);
                request.Method = "GET";
                request.Headers.Add("remote-user", "medicare");
                request.Headers.Add("Authorization", "Basic NzAxOGZoaXJkZW1vOnk1S2VlZVRBdjFmVXZoZmJHakJ3");

                using (WebResponse response = request.GetResponse())
                {
                    if (((HttpWebResponse)response).StatusCode == HttpStatusCode.OK)
                    {
                        using (Stream dataStream = response.GetResponseStream())
                        using (StreamReader reader = new StreamReader(dataStream))
                        {
                            string responseFromServer = reader.ReadToEnd();
                            Console.WriteLine(responseFromServer);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error: " + ((HttpWebResponse)response).StatusCode);
                    }
                }
            }
            catch (WebException e)
            {
                Console.WriteLine("Request error: " + e.Message);

                if (e.Response != null)
                {
                    using (Stream dataStream = e.Response.GetResponseStream())
                    using (StreamReader reader = new StreamReader(dataStream))
                    {
                        string errorResponse = reader.ReadToEnd();
                        Console.WriteLine("Error details: " + errorResponse);
                    }
                }
            }

            //Get Employer Details
            try
            {
                string url = "https://demoimis.ssf.gov.np/api/api_fhir_r4/Employee/CE94CA6C-8A27-4102-BF18-17788F909DD4";

                WebRequest request = WebRequest.Create(url);
                request.Method = "GET";
                request.Headers.Add("remote-user", "medicare");
                request.Headers.Add("Authorization", "Basic NzAxOGZoaXJEZW1vOnk1S2VlZVRBdjFmMVV2ZmhmR2JKdw==");

                using (WebResponse response = request.GetResponse())
                {
                    if (((HttpWebResponse)response).StatusCode == HttpStatusCode.OK)
                    {
                        using (Stream dataStream = response.GetResponseStream())
                        using (StreamReader reader = new StreamReader(dataStream))
                        {
                            string responseFromServer = reader.ReadToEnd();
                            Console.WriteLine(responseFromServer);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error: " + ((HttpWebResponse)response).StatusCode);
                    }
                }
            }
            catch (WebException e)
            {
                Console.WriteLine("Request error: " + e.Message);

                if (e.Response != null)
                {
                    using (Stream dataStream = e.Response.GetResponseStream())
                    using (StreamReader reader = new StreamReader(dataStream))
                    {
                        string errorResponse = reader.ReadToEnd();
                        Console.WriteLine("Error details: " + errorResponse);
                    }
                }
            }

            //Get Practioner Details

            try
            {
                string url = "https://demoimis.ssf.gov.np/api/api_fhir_r4/Practitioner/916D1536-3490-46D9-8473-B8D3A8FA8CCE";

                WebRequest request = WebRequest.Create(url);
                request.Method = "GET";
                request.Headers.Add("remote-user", "medicare");
                request.Headers.Add("Authorization", "Basic NzAxOGZoaXJkZW1vOnk1S2VlZVRBdjFmVXZoZmJHakJ3");

                using (WebResponse response = request.GetResponse())
                {
                    if (((HttpWebResponse)response).StatusCode == HttpStatusCode.OK)
                    {
                        using (Stream dataStream = response.GetResponseStream())
                        using (StreamReader reader = new StreamReader(dataStream))
                        {
                            string responseFromServer = reader.ReadToEnd();
                            Console.WriteLine(responseFromServer);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error: " + ((HttpWebResponse)response).StatusCode);
                    }
                }
            }
            catch (WebException e)
            {
                Console.WriteLine("Request error: " + e.Message);

                if (e.Response != null)
                {
                    using (Stream dataStream = e.Response.GetResponseStream())
                    using (StreamReader reader = new StreamReader(dataStream))
                    {
                        string errorResponse = reader.ReadToEnd();
                        Console.WriteLine("Error details: " + errorResponse);
                    }
                }
            }
        }
    }
}
