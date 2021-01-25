using System;
using System.Collections.Generic;
using System.Text;

namespace OyunProje
{
    class OyuncuManager:ISatisManager
    {
        public string TcNo { get; set; }
        public string OyuncuAdi { get; set; }
        public string OyuncuSoyad { get; set; }
        public int DogumTarih { get; set; }
    }
}
