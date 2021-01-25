using System;

namespace OyunProje
{
    class Program
    {
        static void Main(string[] args)
        {
            OyuncuManager oyuncu1 = new OyuncuManager();
            oyuncu1.TcNo = "12345678901";
            oyuncu1.OyuncuAdi = "Sevda";
            oyuncu1.OyuncuSoyad = "Yücel";
            oyuncu1.DogumTarih = 1997;
           
            oyuncu1.Add(oyuncu1);

            OyuncuManager oyuncu2 = new OyuncuManager();
            oyuncu2.TcNo = "12345670135";
            oyuncu2.OyuncuAdi = "Leyla";
            oyuncu2.OyuncuSoyad = "Aral";
            oyuncu2.DogumTarih = 1998;

            oyuncu2.Add(oyuncu2);

            KampanyaYeni kampanya1 = new KampanyaYeni();
            kampanya1.kampanyaAdi = "3 Al 1 Öde";
            kampanya1.GecerlilikSüresi = "2 Ay";

            
            


        }
    }
}
