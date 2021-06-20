using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OOP_Examples.Encapsulation
{
    class Kapsulleme
    { 
        public class Ogrenci
        {

            private string ogrenciAdSoyad;

            public string OgrenciAdSoyad
            {
                get { return ogrenciAdSoyad; }
                set { ogrenciAdSoyad = value; }
            }

            private string bolum;

            public string Bolum
            {
                get { return bolum; }
                set { bolum = value; }
            }

            private int ogrenciNo;

            public int OgrenciNo
            {
                get { return ogrenciNo; }
                set
                {
                    if (value < 0)
                    {
                        ogrenciNo = 0;
                    }
                    else
                    {
                        ogrenciNo = value;
                    }
                }
            }

            public void Yazdir()
            {
                Console.WriteLine("Ogrencinin Adi Soyadi : " + ogrenciAdSoyad);
                Console.WriteLine("Ogrencinin Bolumu : " + bolum);
                Console.WriteLine("Ogrencinin Numarasi : " + ogrenciNo);
            } 
        }

        //static void Main(string[] args)
        //{
        //    Ogrenci yeni = new Ogrenci();
        //    yeni.OgrenciAdSoyad = "Sevdanur GENC";
        //    yeni.Bolum = "Bilgisayar Programciligi";
        //    yeni.OgrenciNo = 777;
        //    yeni.Yazdir();
        //    Console.ReadKey();
        //}
    }
}
