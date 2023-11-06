using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace şampiyonlar_ligi_kura_çekimi
{
    internal class Takim
    {
        private string takımisim;
        private string takımülke;

        public Takim(string isim, string ülke)
        {
            takımisim = isim;
            takımülke = ülke;
        }
        public string teamname
        {
            get
            {
                return takımisim;
            }
            set
            {
                takımisim = value;
            }
        }
        public string teamcountry
        {
            get
            {
                return takımülke;
            }
            set
            {
                takımülke = value;
            }
        }
        public override string ToString()
        {
            return takımisim + "--" + takımülke;
        }
    }
}
