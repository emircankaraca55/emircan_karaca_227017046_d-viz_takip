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

namespace emircan_karaca_227017046_döviz_takip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labeltarih.Text = DateTime.Now.ToLongDateString();
            string TCMB_Kur = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var TCMB_xml = new XmlDocument();
            TCMB_xml.Load(TCMB_Kur);

            //USD
            string usdalış;
            string usdsatış;
            usdalış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/ForexBuying").InnerXml;
            labelusdalıs.Text = usdalış;
            usdsatış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/ForexSelling").InnerXml;
            labelusdsatıs.Text = usdsatış;
            //EURO
            string euroalış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/ForexBuying").InnerXml;
            string euroSatış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/ForexSelling").InnerXml;
            labeleuralıs.Text = euroalış;
            labeleursatıs.Text = euroSatış;
            //STERLİN
            string GBPAlış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/ForexBuying").InnerXml;
            string GBPSatış = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/ForexSelling").InnerXml;
            labelgbpalıs.Text = GBPAlış;
            labelgbpsatıs.Text = GBPSatış;
            //JAPON
            string jpy100alıs = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='JPY']/ForexBuying").InnerXml;
            string jpy100satıs = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='JPY']/ForexSelling").InnerXml;
            labeljpyalıs.Text = jpy100alıs;
            labeljpysatıs.Text = jpy100satıs;
            //AZN
            string azn0 = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='AZN']/ForexBuying").InnerXml;
            string azn1 = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='AZN']/ForexSelling").InnerXml;
            labelaznalıs.Text = azn0;
            labelaznsatıs.Text = azn1;
            //AUD
            string AUD0 = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='AUD']/ForexBuying").InnerXml;
            string AUD1 = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='AUD']/ForexSelling").InnerXml;
            audalıs.Text = AUD0;
            audsatıs.Text = AUD1;
            //DKK
            string dkk0= TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='DKK']/ForexBuying").InnerXml;
            string dkk1 = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='DKK']/ForexSelling").InnerXml;
            dkkalıs.Text = dkk0;
            dkksatıs.Text = dkk1;
            //SEK
            string sek0 = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='SEK']/ForexBuying").InnerXml;
            string sek1 = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='SEK']/ForexSelling").InnerXml;
            sekalıs.Text = sek0;
            seksatıs.Text = sek1;
            //CAD
            string cad0 = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='CAD']/ForexBuying").InnerXml;
            string cad1 = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='CAD']/ForexSelling").InnerXml;
            cadalıs.Text = cad0;
            cadsatıs.Text = cad1;
            //BGN
            string bgn0 = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='BGN']/ForexBuying").InnerXml;
            string bgn1 = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='BGN']/ForexSelling").InnerXml;
            bgnalıs.Text = bgn0;
            bgnsatıs.Text = bgn1;
            //RUB
            string rub0 = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='RUB']/ForexBuying").InnerXml;
            string rub1 = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='RUB']/ForexSelling").InnerXml;
            rubalıs.Text = rub0;
            rubsatıs.Text = rub1;
            //CNY
            string cny0 = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='CNY']/ForexBuying").InnerXml;
            string cny1 = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='CNY']/ForexSelling").InnerXml;
            cnyalıs.Text = cny0;
            cnysatıs.Text = cny1;
            //eurousd
            string eurousd0 = TCMB_xml.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/CrossRateOther").InnerXml;
            eurousdalıs.Text = eurousd0;




            /////////////////////////////////////////////////////////////////////////////////////////////
            //string metal = "https://www.borsaistanbul.com/datfile/kmtprfrnsxml";
            //XmlDocument metal_xml = new XmlDocument(metal);
            //metal_xml.Load();
            //string altin = metal_xml.SelectSingleNode("IGE/TL/altindeger").InnerText; altınlabel.Text = altin;
            //string gumus = metal_xml.SelectSingleNode("IGE/TL/gumusdeger").InnerText; labelgumus.Text = gumus;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
