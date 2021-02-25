using Newtonsoft.Json;
using System.IO;
using System.Net;

namespace ExchangeRateTool
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class RatesData
    {
        public double CNY { get; set; }
        public double AED { get; set; }
        public double ARS { get; set; }
        public double AUD { get; set; }
        public double BGN { get; set; }
        public double BRL { get; set; }
        public double BSD { get; set; }
        public double CAD { get; set; }
        public double CHF { get; set; }
        public double CLP { get; set; }
        public double COP { get; set; }
        public double CZK { get; set; }
        public double DKK { get; set; }
        public double DOP { get; set; }
        public double EGP { get; set; }
        public double EUR { get; set; }
        public double FJD { get; set; }
        public double GBP { get; set; }
        public double GTQ { get; set; }
        public double HKD { get; set; }
        public double HRK { get; set; }
        public double HUF { get; set; }
        public double IDR { get; set; }
        public double ILS { get; set; }
        public double INR { get; set; }
        public double ISK { get; set; }
        public double JPY { get; set; }
        public double KRW { get; set; }
        public double KZT { get; set; }
        public double MVR { get; set; }
        public double MXN { get; set; }
        public double MYR { get; set; }
        public double NOK { get; set; }
        public double NZD { get; set; }
        public double PAB { get; set; }
        public double PEN { get; set; }
        public double PHP { get; set; }
        public double PKR { get; set; }
        public double PLN { get; set; }
        public double PYG { get; set; }
        public double RON { get; set; }
        public double RUB { get; set; }
        public double SAR { get; set; }
        public double SEK { get; set; }
        public double SGD { get; set; }
        public double THB { get; set; }
        public double TRY { get; set; }
        public double TWD { get; set; }
        public double UAH { get; set; }
        public double USD { get; set; }
        public double UYU { get; set; }
        public double ZAR { get; set; }
    }

    public class RatesRaw
    {
        public string @base;
        public string date;
        public int time_last_updated;
        public RatesData rates;
    }

    public class ExchangeRates
    {
        public RatesRaw Rates;
        public void Update()
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Constant.RATES_API);
                request.Method = "GET";
                request.Timeout = 20000;
                HttpWebResponse res = (HttpWebResponse)request.GetResponse();
                StreamReader stream = new StreamReader(res.GetResponseStream());
                string json = stream.ReadToEnd();
                this.Rates = JsonConvert.DeserializeObject<RatesRaw>(json);
            }
            catch (WebException e)
            {
                throw e;
            }
            catch (JsonException je)
            {
                throw je;
            }
        }
        public void Save()
        {
            try
            {
                StreamWriter file = new StreamWriter(Constant.LATEST_RATES_PATH, false, System.Text.Encoding.UTF8);
                string json = JsonConvert.SerializeObject(this.Rates, Formatting.Indented);
                file.WriteLine(json);
                file.Flush();
                file.Close();

            }
            catch (IOException ioe)
            {
                throw ioe;
            }
            catch (JsonException je)
            {
                throw je;
            }
        }
        public void Load()
        {
            try
            {
                StreamReader file = new StreamReader(Constant.LATEST_RATES_PATH, System.Text.Encoding.UTF8);
                string json = file.ReadToEnd();
                this.Rates = JsonConvert.DeserializeObject<RatesRaw>(json);
                file.Close();
            }
            catch (IOException ioe)
            {
                throw ioe;
            }
            catch (JsonException je)
            {
                throw je;
            }
        }
    }


}
