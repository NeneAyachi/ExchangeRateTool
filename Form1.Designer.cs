
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.origin = new System.Windows.Forms.TextBox();
            this.Label_CNY = new System.Windows.Forms.Label();
            this.currency = new System.Windows.Forms.ComboBox();
            this.Label_equal = new System.Windows.Forms.Label();
            this.cny = new System.Windows.Forms.Label();
            this.Update = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.notification = new System.Windows.Forms.NotifyIcon(this.components);
            this.statusStrip1.SuspendLayout();
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
            this.currency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cny.Location = new System.Drawing.Point(454, 38);
            this.cny.Name = "cny";
            this.cny.Size = new System.Drawing.Size(23, 25);
            this.cny.TabIndex = 4;
            this.cny.Text = "0";
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(347, 119);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(102, 31);
            this.Update.TabIndex = 5;
            this.Update.Text = "更新";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 271);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(538, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 16);
            // 
            // notification
            // 
            this.notification.Icon = ((System.Drawing.Icon)(resources.GetObject("notification.Icon")));
            this.notification.Visible = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(538, 293);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.cny);
            this.Controls.Add(this.Label_equal);
            this.Controls.Add(this.currency);
            this.Controls.Add(this.Label_CNY);
            this.Controls.Add(this.origin);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "汇率转换";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox origin;
        private System.Windows.Forms.Label Label_CNY;
        private System.Windows.Forms.ComboBox currency;
        private System.Windows.Forms.Label Label_equal;
        private System.Windows.Forms.Label cny;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.NotifyIcon notification;
    }
}

