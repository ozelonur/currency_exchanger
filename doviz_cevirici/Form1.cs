using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace doviz_cevirici
{
    public partial class Form1 : Form
    {
        double USD, AUD, DKK, EUR, GBP, CHF, SEK, CAD, KWD, NOK, SAR, JPY;
        double amountTRY;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string from = fromComboBox.SelectedItem.ToString();
            string to = toComboBox.SelectedItem.ToString();
            double amount = Convert.ToDouble(amountTextBox.Text);

            Exchange(from,amount);

            
            switch (to)
            {
                case "TRY":
                    resultLabel.Text = amount + " " + from + " : "+amountTRY.ToString() + " TRY";
                    break;
                case "USD":
                    resultLabel.Text = amount +" "+from+" : "+(amountTRY / USD).ToString()+" USD";
                    break;
                case "AUD":
                    resultLabel.Text = amount + " " + from + " : " + (amountTRY / AUD).ToString() + " AUD";
                    break;
                case "DKK":
                    resultLabel.Text = amount + " " + from + " : " + (amountTRY / DKK).ToString() + " DKK";
                    break;
                case "EUR":
                    resultLabel.Text = amount + " " + from + " : " + (amountTRY / EUR).ToString() + " EUR";
                    break;
                case "GBP":
                    resultLabel.Text = amount + " " + from + " : " + (amountTRY / GBP).ToString() + " GBP";
                    break;
                case "CHF":
                    resultLabel.Text = amount + " " + from + " : " + (amountTRY / CHF).ToString() + " CHF";
                    break;
                case "SEK":
                    resultLabel.Text = amount + " " + from + " : " + (amountTRY / SEK).ToString() + " SEK";
                    break;
                case "CAD":
                    resultLabel.Text = amount + " " + from + " : " + (amountTRY / CAD).ToString() + " CAD";
                    break;
                case "KWD":
                    resultLabel.Text = amount + " " + from + " : " + (amountTRY / KWD).ToString() + " KWD";
                    break;
                case "NOK":
                    resultLabel.Text = amount + " " + from + " : " + (amountTRY / NOK).ToString() + " NOK";
                    break;
                case "SAR":
                    resultLabel.Text = amount + " " + from + " : " + (amountTRY / SAR).ToString() + " SAR";
                    break;
                case "JPY":
                    resultLabel.Text = amount + " " + from + " : " + (amountTRY / JPY).ToString() + " JPY";
                    break;
        
            }

        

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fromComboBox.SelectedIndex = 0;
            toComboBox.SelectedIndex = 0;
            string todayXML = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldocument = new XmlDocument();
            xmldocument.Load(todayXML);            
            USD = Convert.ToDouble(xmldocument.SelectSingleNode("Tarih_Date/Currency[@Kod = 'USD']/BanknoteSelling").InnerXml);
            AUD = Convert.ToDouble(xmldocument.SelectSingleNode("Tarih_Date/Currency[@Kod = 'AUD']/BanknoteSelling").InnerXml);
            DKK = Convert.ToDouble(xmldocument.SelectSingleNode("Tarih_Date/Currency[@Kod = 'DKK']/BanknoteSelling").InnerXml);
            EUR = Convert.ToDouble(xmldocument.SelectSingleNode("Tarih_Date/Currency[@Kod = 'EUR']/BanknoteSelling").InnerXml);
            GBP = Convert.ToDouble(xmldocument.SelectSingleNode("Tarih_Date/Currency[@Kod = 'GBP']/BanknoteSelling").InnerXml);
            CHF = Convert.ToDouble(xmldocument.SelectSingleNode("Tarih_Date/Currency[@Kod = 'CHF']/BanknoteSelling").InnerXml);
            SEK = Convert.ToDouble(xmldocument.SelectSingleNode("Tarih_Date/Currency[@Kod = 'SEK']/BanknoteSelling").InnerXml);
            CAD = Convert.ToDouble(xmldocument.SelectSingleNode("Tarih_Date/Currency[@Kod = 'CAD']/BanknoteSelling").InnerXml);
            KWD = Convert.ToDouble(xmldocument.SelectSingleNode("Tarih_Date/Currency[@Kod = 'KWD']/BanknoteSelling").InnerXml);
            NOK = Convert.ToDouble(xmldocument.SelectSingleNode("Tarih_Date/Currency[@Kod = 'NOK']/BanknoteSelling").InnerXml);
            SAR = Convert.ToDouble(xmldocument.SelectSingleNode("Tarih_Date/Currency[@Kod = 'SAR']/BanknoteSelling").InnerXml);
            JPY = Convert.ToDouble(xmldocument.SelectSingleNode("Tarih_Date/Currency[@Kod = 'JPY']/BanknoteSelling").InnerXml);


         
        }

        private void Exchange(string from,double amount)
        {
            
            switch (from)
            {
                case "TRY":
                    amountTRY = amount;
                    break;
                case "USD":
                    amountTRY = amount * USD;
                    break;
                case "AUD":
                    amountTRY = (amount * AUD);
                    break;
                case "DKK":
                    amountTRY = (amount * DKK);
                    break;
                case "EUR":
                    amountTRY = (amount * EUR);
                    break;
                case "GBP":
                    amountTRY = (amount * GBP);
                    break;
                case "CHF":
                    amountTRY = (amount * CHF);
                    break;
                case "SEK":
                    amountTRY = (amount * SEK);
                    break;
                case "CAD":
                    amountTRY = (amount * CAD);
                    break;
                case "KWD":
                    amountTRY = (amount * KWD);
                    break;
                case "NOK":
                    amountTRY = (amount * NOK);
                    break;
                case "SAR":
                    amountTRY = (amount * SAR);
                    break;
                case "JPY":
                    amountTRY = (amount * JPY);
                    break;
            }
        }
    }
}
