using Sube1.EmlakciLib;

namespace Sube1.EmlakciApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var evim = new Ev();
            //evim.alan = 100;
            //evim.semt = "Gazi";
            //evim.katno = 2;
            //evim.odasayisi = 3;
            //string bilgi = evim.EvBilgileri();
            //Console.WriteLine(bilgi);

            //Ev evim2 = new Ev();
            //evim2.odasayisi = 2;
            //evim2.katno = 5;
            //evim2.semt = "Gazi";
            //evim2.alan = 120; 
            //Console.WriteLine(evim2.EvBilgileri());

            //var evim3 = new Ev(2, 3, 120);
            //Console.WriteLine(evim3.EvBilgileri());

            //Console.WriteLine($"Bellekteki ev sayısı:{Ev.sayac}");

            try
            {
                var evim = new Ev();
                evim.Alan = 40;
                evim.Odasayisi = 3;
                evim.Semt = "Gazi";
                evim.Katno = 2;
                //evim.Buyukluk = "Küçük Ev";
                Console.WriteLine(evim.Buyukluk);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

           
        }
    }
}
//Ev evim = new Ev();//Ev classından nesne türetildi
//evim: Referans. Nesnelerin bellekteki adresini tutarlar.Belleğin STACK bölgesinde tutulurlar
//Ev: Class. Classlar aynı zamanda bir veri tipidir.
//new: Bellekte nesne oluşturmaya yarayan anahtar sözcük
//Nesne: new anahtar sözcüğü ile HEAP bölgesinde oluşturulurlar.
//Erişim Belirleyiciler(Access Modifiers)
//private: Sadece class içinden erişilebilir üyelerdir
//public: Class içinde tanımlanan üyeye her yerden erişim imkanı sağlar
//DRY: Don't Repeat Yourself