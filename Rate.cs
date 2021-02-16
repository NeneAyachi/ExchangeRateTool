using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
using System.IO;
namespace ExchangeRateTool
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Rates
    {
        public double CNY;
        public double AED;
        public double ARS;
        public double AUD;
        public double BGN;
        public double BRL;
        public double BSD;
        public double CAD;
        public double CHF;
        public double CLP;
        public double COP;
        public double CZK;
        public double DKK;
        public double DOP;
        public double EGP;
        public double EUR;
        public double FJD;
        public double GBP;
        public double GTQ;
        public double HKD;
        public double HRK;
        public double HUF;
        public double IDR;
        public double ILS;
        public double INR;
        public double ISK;
        public double JPY;
        public double KRW;
        public double KZT;
        public double MVR;
        public double MXN;
        public double MYR;
        public double NOK;
        public double NZD;
        public double PAB;
        public double PEN;
        public double PHP;
        public double PKR;
        public double PLN;
        public double PYG;
        public double RON;
        public double RUB;
        public double SAR;
        public double SEK;
        public double SGD;
        public double THB;
        public double TRY;
        public double TWD;
        public double UAH;
        public double USD;
        public double UYU;
        public double ZAR;
    }

    public class CurrentRates
    {
        public string currency;
        public string date;
        public int time_last_updated;
        public Rates rates;
    }

    public class ExchangeRates
    {
        public CurrentRates currentRates;
        static string API = "https://api.exchangerate-api.com/v4/latest/CNY";
        public void Update()
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(ExchangeRates.API);
                request.Method = "GET";
                request.Timeout = 20000;
                HttpWebResponse res = (HttpWebResponse)request.GetResponse();
                StreamReader stream = new StreamReader(res.GetResponseStream());
                string json = stream.ReadToEnd();
                this.currentRates = JsonConvert.DeserializeObject<CurrentRates>(json);
            }
            catch(JsonException e)
            {
                
            }
        }
        public void Save()
        {
            string path = "latestrates.json";
            if (!File.Exists(path))
            {
                //TODO
            }
            StreamWriter file = new StreamWriter(path, false, System.Text.Encoding.UTF8);
            string json = JsonConvert.SerializeObject(this.currentRates, Formatting.Indented);
            file.WriteLine(json);
            file.Flush();
            file.Close();
        }
    }


}
