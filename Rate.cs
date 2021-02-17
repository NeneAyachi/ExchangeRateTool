using Newtonsoft.Json;
using System.IO;
using System.Net;

namespace ExchangeRateTool
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class RatesData
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
            catch(WebException e)
            {
                throw e;
            }
            catch(JsonException je)
            {
                throw je;
            }
        }
        public void Save()
        {
            try
            {
                if (!File.Exists(Constant.CONFIG_PATH))
                {
                    //TODO
                }
                StreamWriter file = new StreamWriter(Constant.LATEST_RATES_PATH, false, System.Text.Encoding.UTF8);
                string json = JsonConvert.SerializeObject(this.Rates, Formatting.Indented);
                file.WriteLine(json);
                file.Flush();
                file.Close();

            }
            catch(IOException ioe)
            {
                throw ioe;
            }
            catch(JsonException je)
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
