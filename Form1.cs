using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;

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

        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(delegate ()
            {
                this.exchangeRates = new ExchangeRates();
                if (File.Exists(Constant.LATEST_RATES_PATH))
                {
                    this.exchangeRates.Load();
                }
                else
                {
                    this.Invoke(new Action(() =>
                    {
                        this.status.Text = "正在更新数据";
                    }));
                    this.exchangeRates.Update();
                    this.exchangeRates.Save();
                }
                this.Invoke(new Action(() =>
                {
                    this.status.Text = "就绪";
                }));
            }));
            thread.IsBackground = true;
            thread.Start();
            
        }
    }
    
}
