using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace DataAccess.TcmbService
{
    public class TcmbManager : ItcmbService
    {
        XmlTextReader rdr;
        XmlDocument myxml = new XmlDocument();
        List<string> unitFinance = new List<string>();
        public TcmbManager()
        {
            rdr = new XmlTextReader("http://www.tcmb.gov.tr/kurlar/today.xml");
            // XmlTextReader nesnesini yaratıyoruz ve parametre olarak xml dokümanın urlsini veriyoruz
            // XmlTextReader urlsi belirtilen xml dokümanlarına hızlı ve forward-only giriş imkanı sağlar.
            // XmlDocument nesnesini yaratıyoruz.
            myxml.Load(rdr);
            // Load metodu ile xml yüklüyoruz
        }
        public List<string> GetUnit()
        { 
            XmlNodeList kod = myxml.SelectNodes("/Tarih_Date/Currency/@Kod");
            for (int i = 0; i < 12; i++)
            {
                unitFinance.Add(kod.Item(i).InnerText.ToString());
            }
            unitFinance.Add("TRY");
            return unitFinance;
        }

        public decimal getUnitValue(int UnitId)
        {
            if(UnitId==12)
            {
                return 1;
            }
            XmlNodeList doviz_alis = myxml.SelectNodes("/Tarih_Date/Currency/ForexBuying");
            return Convert.ToDecimal(doviz_alis.Item(UnitId).InnerText.ToString().Replace('.',','));
        }
    }
}
