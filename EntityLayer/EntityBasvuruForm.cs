using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityBasvuruForm
    {
        private int basvuruid;
        public int BASVURUID
        {
            get { return basvuruid; }
            set { basvuruid = value; }
        }
        private int ogrid;
        public int OGRID
        {
            get { return ogrid; }
            set { ogrid = value; }
        }
        private int dersid;
        public int DERSID
        {
            get { return dersid; }
            set { dersid = value; }
        }
    }
}
