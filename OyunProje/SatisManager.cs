using System;
using System.Collections.Generic;
using System.Text;

namespace OyunProje
{
    class ISatisManager:KampanyaYeni
    {
        public void Add(KampanyaYeni kampanya) 
        {
            Console.WriteLine(kampanya.kampanyaAdi + "Eklendi");
        
        }
        public void Update(KampanyaYeni kampanya)
        {
            Console.WriteLine(kampanya.kampanyaAdi + "Güncellendi");
        
        }
        public void Delete(KampanyaYeni kampanya)
        {
            Console.WriteLine(kampanya.kampanyaAdi + "Silindi");

        }

    }
}
