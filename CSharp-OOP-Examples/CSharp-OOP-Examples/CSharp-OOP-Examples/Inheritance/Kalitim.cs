using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OOP_Examples.Inheritance
{
    class Kalitim
    {
        public class Hayvan {

            public double boy;
            public double agirlik;

            public Hayvan() {
                boy = 0.1;
                agirlik = 0.2;
                Console.WriteLine("Hayvan Sinifinin Kurucu Metodudur.");
                
            }

            public void ozellikGoster() {
                Console.WriteLine("Boy = " + boy);
                Console.WriteLine("Agirlik = " + agirlik);
            }
        }

        public class Kedi : Hayvan {

            public string turu;

            public Kedi() {
                agirlik = 70;
                turu = "iskocc";
                Console.WriteLine("Kedi Sinifinin Kurucu Metodudur.");

            }

            public void turGoster() {
                Console.WriteLine("Kedinin turu =  " + turu);
            }
        }

        //static void Main(string[] args)
        //{

        //    Kalitim.Kedi k1 = new Kalitim.Kedi();

        //    k1.agirlik = 5;
        //    k1.boy = 10;
        //    k1.ozellikGoster();
        //    k1.turu = "iskoc";
        //    k1.turGoster();

        //    Console.WriteLine("********************");

        //    Kalitim.Hayvan h1 = new Kalitim.Hayvan();
        //    h1.agirlik = 10;
        //    h1.boy = 20;
        //    h1.ozellikGoster();

        //    Console.WriteLine("********************");

        //    Kalitim.Kedi k2 = new Kalitim.Kedi();
        //    k2.ozellikGoster();
        //    k2.turGoster();

        //    Console.WriteLine("********************");
        //    Kalitim.Hayvan h2 = new Kalitim.Hayvan();



        //    Console.ReadKey();


        //}



    }
}
