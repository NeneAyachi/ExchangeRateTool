
namespace ExchangeRateTool
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.origin = new System.Windows.Forms.TextBox();
            this.Label_CNY = new System.Windows.Forms.Label();
            this.currency = new System.Windows.Forms.ComboBox();
            this.Label_equal = new System.Windows.Forms.Label();
            this.cny = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // origin
            // 
            this.origin.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.origin.Location = new System.Drawing.Point(120, 32);
            this.origin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.origin.Name = "origin";
            this.origin.Size = new System.Drawing.Size(152, 31);
            this.origin.TabIndex = 0;
            // 
            // Label_CNY
            // 
            this.Label_CNY.AutoSize = true;
            this.Label_CNY.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_CNY.Location = new System.Drawing.Point(332, 38);
            this.Label_CNY.Name = "Label_CNY";
            this.Label_CNY.Size = new System.Drawing.Size(51, 25);
            this.Label_CNY.TabIndex = 1;
            this.Label_CNY.Text = "CNY";
            // 
            // currency
            // 
            this.currency.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.currency.FormattingEnabled = true;
            this.currency.Items.AddRange(new object[] {
            "AED",
            "ARS",
            "AUD",
            "BGN",
            "BRL",
            "BSD",
            "CAD",
            "CHF",
            "CLP",
            "CNY",
            "COP",
            "CZK",
            "DKK",
            "DOP",
            "EGP",
            "EUR",
            "FJD",
            "GBP",
            "GTQ",
            "HKD",
            "HRK",
            "HUF",
            "IDR",
            "ILS",
            "INR",
            "ISK",
            "JPY",
            "KRW",
            "KZT",
            "MVR",
            "MXN",
            "MYR",
            "NOK",
            "NZD",
            "PAB",
            "PEN",
            "PHP",
            "PKR",
            "PLN",
            "PYG",
            "RON",
            "RUB",
            "SAR",
            "SEK",
            "SGD",
            "THB",
            "TRY",
            "TWD",
            "UAH",
            "USD",
            "UYU",
            "ZAR"});
            this.currency.Location = new System.Drawing.Point(12, 31);
            this.currency.Name = "currency";
            this.currency.Size = new System.Drawing.Size(102, 32);
            this.currency.Sorted = true;
            this.currency.TabIndex = 2;
            // 
            // Label_equal
            // 
            this.Label_equal.AutoSize = true;
            this.Label_equal.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_equal.Location = new System.Drawing.Point(278, 38);
            this.Label_equal.Name = "Label_equal";
            this.Label_equal.Size = new System.Drawing.Size(26, 25);
            this.Label_equal.TabIndex = 3;
            this.Label_equal.Text = "=";
            // 
            // cny
            // 
            this.cny.AutoSize = true;
            this.cny.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cny.Location = new System.Drawing.Point(476, 38);
            this.cny.Name = "cny";
            this.cny.Size = new System.Drawing.Size(23, 25);
            this.cny.TabIndex = 4;
            this.cny.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 334);
            this.Controls.Add(this.cny);
            this.Controls.Add(this.Label_equal);
            this.Controls.Add(this.currency);
            this.Controls.Add(this.Label_CNY);
            this.Controls.Add(this.origin);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "汇率转换";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox origin;
        private System.Windows.Forms.Label Label_CNY;
        private System.Windows.Forms.ComboBox currency;
        private System.Windows.Forms.Label Label_equal;
        private System.Windows.Forms.Label cny;
    }
}

