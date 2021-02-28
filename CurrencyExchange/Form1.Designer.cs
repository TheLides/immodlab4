
namespace CurrencyExchange
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.AmountOfRubles = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bSell = new System.Windows.Forms.Button();
            this.bBuy = new System.Windows.Forms.Button();
            this.bCalculate = new System.Windows.Forms.Button();
            this.inputDays = new System.Windows.Forms.NumericUpDown();
            this.inputPrice = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.AmountOfEuro = new System.Windows.Forms.Label();
            this.buyAndSell = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyAndSell)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.buyAndSell);
            this.panel1.Controls.Add(this.AmountOfEuro);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.AmountOfRubles);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.bSell);
            this.panel1.Controls.Add(this.bBuy);
            this.panel1.Controls.Add(this.bCalculate);
            this.panel1.Controls.Add(this.inputDays);
            this.panel1.Controls.Add(this.inputPrice);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1233, 117);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Количество евро:";
            // 
            // AmountOfRubles
            // 
            this.AmountOfRubles.AutoSize = true;
            this.AmountOfRubles.Location = new System.Drawing.Point(584, 39);
            this.AmountOfRubles.Name = "AmountOfRubles";
            this.AmountOfRubles.Size = new System.Drawing.Size(40, 17);
            this.AmountOfRubles.TabIndex = 8;
            this.AmountOfRubles.Text = "1000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Количество рублей:";
            // 
            // bSell
            // 
            this.bSell.Location = new System.Drawing.Point(745, 61);
            this.bSell.Name = "bSell";
            this.bSell.Size = new System.Drawing.Size(102, 34);
            this.bSell.TabIndex = 6;
            this.bSell.Text = "Sell";
            this.bSell.UseVisualStyleBackColor = true;
            this.bSell.Click += new System.EventHandler(this.bSell_Click);
            // 
            // bBuy
            // 
            this.bBuy.Location = new System.Drawing.Point(745, 11);
            this.bBuy.Name = "bBuy";
            this.bBuy.Size = new System.Drawing.Size(102, 34);
            this.bBuy.TabIndex = 5;
            this.bBuy.Text = "Buy";
            this.bBuy.UseVisualStyleBackColor = true;
            this.bBuy.Click += new System.EventHandler(this.bBuy_Click);
            // 
            // bCalculate
            // 
            this.bCalculate.Location = new System.Drawing.Point(262, 33);
            this.bCalculate.Name = "bCalculate";
            this.bCalculate.Size = new System.Drawing.Size(102, 23);
            this.bCalculate.TabIndex = 4;
            this.bCalculate.Text = "Calculate";
            this.bCalculate.UseVisualStyleBackColor = true;
            this.bCalculate.Click += new System.EventHandler(this.bCalculate_Click);
            // 
            // inputDays
            // 
            this.inputDays.Location = new System.Drawing.Point(97, 59);
            this.inputDays.Name = "inputDays";
            this.inputDays.Size = new System.Drawing.Size(120, 22);
            this.inputDays.TabIndex = 3;
            // 
            // inputPrice
            // 
            this.inputPrice.DecimalPlaces = 4;
            this.inputPrice.Location = new System.Drawing.Point(97, 9);
            this.inputPrice.Name = "inputPrice";
            this.inputPrice.Size = new System.Drawing.Size(120, 22);
            this.inputPrice.TabIndex = 2;
            this.inputPrice.ThousandsSeparator = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Days:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input price:";
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(0, 113);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.IsValueShownAsLabel = true;
            series4.LabelFormat = "f4";
            series4.Legend = "Legend1";
            series4.Name = "Euro";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(1233, 464);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AmountOfEuro
            // 
            this.AmountOfEuro.AutoSize = true;
            this.AmountOfEuro.Location = new System.Drawing.Point(584, 78);
            this.AmountOfEuro.Name = "AmountOfEuro";
            this.AmountOfEuro.Size = new System.Drawing.Size(16, 17);
            this.AmountOfEuro.TabIndex = 10;
            this.AmountOfEuro.Text = "0";
            // 
            // buyAndSell
            // 
            this.buyAndSell.DecimalPlaces = 4;
            this.buyAndSell.Location = new System.Drawing.Point(883, 39);
            this.buyAndSell.Name = "buyAndSell";
            this.buyAndSell.Size = new System.Drawing.Size(120, 22);
            this.buyAndSell.TabIndex = 11;
            this.buyAndSell.ThousandsSeparator = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(421, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Баланс:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 576);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyAndSell)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel1;

        #endregion

        private System.Windows.Forms.NumericUpDown inputDays;
        private System.Windows.Forms.NumericUpDown inputPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button bCalculate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label AmountOfRubles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bSell;
        private System.Windows.Forms.Button bBuy;
        private System.Windows.Forms.Label AmountOfEuro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown buyAndSell;
    }
}

