using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_encapsulation
{
    public class araba //araba adında bir sınıf
    {
        //özellikleri
        public string marka { get; set; }
        public string model { get; set; }
        public string renk { get; set; }

        private int _kapiSayisi; //kapı sayısı için kapsülleme
            public int KapiSayisi
        {
            get { return _kapiSayisi; }
            set
            {
                if (value == 2 || value == 4)
                {
                    _kapiSayisi = value;
                }
                else
                {
                    Console.WriteLine("Kapı sayısı girişi hatalı. Kapı Sayısı sadece 2 veya 4 olmalı.");
                    _kapiSayisi = -1; // Geçersiz giriş için -1 ataması yapılır
                }
            }
        }

        //constructor
        public araba(string marka, string model, string renk, int kapiSayisi)
        {
            marka = marka;
            model = model;
            renk = renk;
            KapiSayisi = kapiSayisi;

        }

        public void ArabaBilgileriniGoster()
        {
            Console.WriteLine($"Marka: {marka}, Model: {model}, Renk:{renk}");

            //kapı sayısı -1 değilse ekranda göster
            if (KapiSayisi != -1)
            {
                Console.WriteLine($"Kapı sayısı: {KapiSayisi}");

            }
        }
    }
}
