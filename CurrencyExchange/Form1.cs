using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyExchange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            inputDays.Value = 100;
            inputPrice.Value = 70;
            buyAndSell.Value = 20;
        }

        const double k = 0.5;
        Random rnd = new Random();
        double price;
        int i = 0;
        int days;
        double currentRubles = 1000;
        double currentEuro = 0;
        private void bCalculate_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            price = (double)inputPrice.Value;
            days = (int)inputDays.Value;
            chart1.Series[0].Points.AddXY(0, price);
            ChangeAmount();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i <= days)
            {
                i++;
                price = price * (1 + k * (rnd.NextDouble() - 0.5));
                chart1.Series[0].Points.AddXY(i, price);
            }
            else
            {
                timer1.Stop();
            }
        }

        private void bBuy_Click(object sender, EventArgs e)
        {
            double money = (double)buyAndSell.Value;
            currentRubles -= money * price;
            if(currentRubles < 0)
            {
                timer1.Stop();
            }
            else
            {
                currentEuro += money;
                
            }
            ChangeAmount();
        }

        private void bSell_Click(object sender, EventArgs e)
        {
            double money = (double)buyAndSell.Value;
            currentEuro -= money;
            if (currentEuro < 0)
            {
                timer1.Stop();
            }
            else
            {
                currentRubles += money * price;
                
            }
            ChangeAmount();
        }

        private void ChangeAmount()
        {
            AmountOfRubles.Text = currentRubles.ToString();
            AmountOfEuro.Text = currentEuro.ToString();
        }
    }
}
