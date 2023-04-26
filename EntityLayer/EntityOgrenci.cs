using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace EntityLayer
{
    public class EntityOgrenci
    {
        private string ad;
        private string soyad;
        private int ogrid;
        private string numara;
        private string fotograf;
        private string bakiye;
        private string sifre;


        public string AD
        {
            get { return ad; }
            set { ad = value; }
        }
        public string SOYAD
        {
            get { return soyad; }
            set { soyad = value; }
        }
        public int OGRID
        {
            get { return ogrid; }
            set { ogrid = value; }
        }
        public string NUMARA
        {
            get { return numara; }
            set { numara = value; }
        }
        public string FOTOGRAF
        {
            get { return fotograf; }
            set { fotograf = value; }
        }
        public string BAKIYE
        {
            get { return bakiye; }
            set { bakiye = value; }
        }
        public string SIFRE
        {
            get { return sifre; }
            set { sifre = value; }
        }
    }
}
