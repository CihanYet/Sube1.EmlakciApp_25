using System;

namespace Sube1.EmlakciLib
{
    public class Ev
    {
        public static int sayac = 0;

        public Ev()
        {
            sayac++;
        }
        public Ev(int odasayisi, int katno, double alan, string semt = "Kızılay")
        {
            this.Odasayisi = odasayisi;
            this.Katno = katno;
            this.Semt = semt;
            this.Alan = alan;
            sayac++;
        }

        public Ev(int odasayisi, int katno, double alan)
        {
            this.Odasayisi = odasayisi;
            this.Katno = katno;
            this.Semt = "Kızılay";
            this.Alan = alan;
            sayac++;
        }

        private int odasayisi;//field       
        private string semt;
        public string Buyukluk { get; private set; }

        //Alan
        //50-75:Küçük ev
        //75-120: Orta büyüklükte ev
        //>120: Büyük ev

        //Auto-Property: Get ve set bloklarında işlem yapılmayacağı zaman kullanılır.
        public int Katno { get; set; }

        //Lambda ile tek satırlı property örnekleri      
        public string Semt { get => semt; set => semt = value.ToUpper(); }//Property
        public int Odasayisi { get => odasayisi; set => odasayisi = Math.Abs(value); }

        //Metodlarla yapılan Getter ve Setter'lar
        public void SetOdaSayisi(int odasayisi) => this.Odasayisi = Math.Abs(odasayisi);
        public int GetOdaSayisi() => this.Odasayisi;

        //Full Property: Get ve Set bloklarında çok satırlı işlemler yapmak için kullanılır.
        //private int myVar;

        //public int MyProperty
        //{
        //    get
        //    { 
        //        //Burada başka işlemler yapılabilir.
        //        return myVar;                
        //    }
        //    set
        //    { 
        //        myVar = value;
        //        //Burada başka işlemler yapılabilir.
        //    }
        //}       

        private double alan;//field

        public double Alan//full property
        {
            get { return alan; }
            set
            {
                if (value<50)
                {
                    throw new Exception("Min alan değeri 50 olmalıdır");
                }
                alan = value;
                if (this.alan > 50 && this.alan < 75)
                {
                    this.Buyukluk = "Küçük Ev";
                }
                else if (this.alan > 75 && this.alan < 120)
                {
                    this.Buyukluk = "Orta büyüklükte ev";
                }
                else
                {
                    this.Buyukluk = "Büyük ev";
                }
            }
        }


        public string EvBilgileri()
        {
            return $"Oda Sayısı:{this.Odasayisi}\nKat no:{this.Katno}\nAlan:{this.Alan}\nSemt:{this.Semt}\nBüyüklük:{this.Buyukluk}";
        }

    }
}

//Constructor-Yapıcı Metod-Kurucu Metod
//Görevi: Bir classtan nesne türetilirken çalışır ve class içindeki fieldlara varsayılan değer atamalarını yapar.
//Her classta mutlaka vardır. Varsayılan olarak parametre almazlar. bu constructorlara default constructor da denir.
//İsimleri class adı ile aynıdır. Farklı isimle tanımlamazlar.
//Geri dönüş tipleri yoktur.
//Classlardan nesne türetildilğinde çalışan ilk metoddur.
//ctor code snippeti ile default constructor oluşturulabilir. ctor+tab

//Bir class içinde static olarak tanımlanan üyelere, class ismi ile erişilir ve bu üyeler program çalıştığı sürece bellekte tutulurlar. Nesnelerden bağımsız, class'a ait yapılar.

//Kapsülleme (Encapsulation) İlkesi: Class içerisinde yapılan işlerin, class dışından gizlenmesidir. Örn: odasayisi field'ına değer atama işlemi yapmak için öncelikle field private yapıldı, sonrasında bu fielda erişebilen public SetOdaSayisi(int odasayisi) metodu yazıldı. Bu metod içinde gelen değerin mutlak değeri alınarak odasayisi fieldına aktarıldı ve bu işlemden bu metodu kullananların bilgisi olmadı.
