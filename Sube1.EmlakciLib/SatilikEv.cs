using System;
using System.Collections.Generic;
using System.Text;

namespace Sube1.EmlakciLib
{
    public class SatilikEv : Ev
    {
        public SatilikEv()
        {

        }

        public SatilikEv(double satisfiyat, int odasayisi, string semt, int katno, double alan) : base(odasayisi, katno, alan, semt)
        {
            Satisfiyat = satisfiyat;
        }

        public double Satisfiyat { get; set; }

        //public new string EvBilgileri()
        //{
        //    return $"{base.EvBilgileri()}\nSatış Fiyat:{this.Satisfiyat}";
        //}

        public override string EvBilgileri()
        {
            return $"{base.EvBilgileri()}\nSatış Fiyat:{this.Satisfiyat}";
        }
    }
}

//Name Hiding: Türeyen classlarda, base classtaki üye(ler)in ismiyle aynı isimli bir üye tanımlanırsa, artık türeyen class referansıyla base classtaki üyeye erişilemez. 
