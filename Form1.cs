using System;
using System.IO;
using System.Net;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace ExchangeRateTool
{
    public partial class MainForm : Form
    {
        ExchangeRates exchangeRates;

        public MainForm()
        {
            InitializeComponent();
            this.currency.SelectedItem = "ARS";
        }

        private void Update_Click(object sender, EventArgs e)
        {
            Thread thread_update = new Thread(new ThreadStart(delegate ()
            {
                try
                {
                    this.Invoke(new Action(() =>
                    {
                        this.notification.ShowBalloonTip(0, "ExchangeRateTool", "正在更新...", ToolTipIcon.Info);
                        this.status.Text = "正在更新";
                        this.exchangeRates.Update();
                        this.exchangeRates.Save();
                        this.status.Text = "就绪";
                    }));
                    
                }
                catch (WebException we)
                {
                    this.Invoke(new Action(() =>
                    {
                        this.status.Text = "网络连接失败";
                        this.notification.ShowBalloonTip(0, "ExchangeRateTool", "网络连接失败\n" + we.Message, ToolTipIcon.Error);
                    }));
                    
                }
            }));
            thread_update.IsBackground = true;
            thread_update.Start();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            Thread thread_load = new Thread(new ThreadStart(delegate ()
            {
                this.exchangeRates = new ExchangeRates();
                if (File.Exists(Constant.LATEST_RATES_PATH))
                {
                    try
                    {
                        this.exchangeRates.Load();
                        this.Invoke(new Action(() =>
                        {
                            this.status.Text = "正在加载缓存";
                        }));
                    }
                    catch (Newtonsoft.Json.JsonException je)
                    {
                        this.Invoke(new Action(() =>
                        {
                            this.status.Text = "读取缓存失败 正在重新获取数据";
                            this.notification.ShowBalloonTip(0, "错误", "读取缓存失败", ToolTipIcon.Error);
                        }));
                        this.exchangeRates.Update();
                        this.exchangeRates.Save();
                    }
                }
                else
                {
                    this.Invoke(new Action(() =>
                    {
                        this.status.Text = "正在更新";
                    }));
                    this.exchangeRates.Update();
                    this.exchangeRates.Save();
                }
                this.Invoke(new Action(() =>
                {
                    this.status.Text = "就绪";
                }));
            }));

            thread_load.IsBackground = true;
            thread_load.Start();

        }

        private void origin_TextChanged(object sender, EventArgs e)
        {
            if (this.origin.Text == "")
            {
                this.cny.Text = "0";
                return;
            }
            Type type = this.exchangeRates.Rates.rates.GetType();
            PropertyInfo propertyInfo = type.GetProperty(this.currency.SelectedItem.ToString());
            double rate = (double)propertyInfo.GetValue(this.exchangeRates.Rates.rates, null);
            this.cny.Text = (Convert.ToDouble(this.origin.Text) / rate).ToString();
        }

        private void currency_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.origin.Text == "")
            {
                this.cny.Text = "0";
                return;
            }
            Type type = this.exchangeRates.Rates.rates.GetType();
            PropertyInfo propertyInfo = type.GetProperty(this.currency.SelectedItem.ToString());
            double rate = (double)propertyInfo.GetValue(this.exchangeRates.Rates.rates, null);
            this.cny.Text = (Convert.ToDouble(this.origin.Text) / rate).ToString();
        }
    }

}
