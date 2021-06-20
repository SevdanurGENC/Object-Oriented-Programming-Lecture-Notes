using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OOP_Examples.Polymorphisim
{
    class CokBicimlilik
    {
        public class Uye {
            public string Ad { get; set; }

            public virtual void CikisYap() {
                Console.WriteLine(this.Ad + " kisisi cikis yapti.");
            } 
        }


        public class Admin : Uye {
            public override void CikisYap()
            {
                //base.CikisYap();
                Console.WriteLine(this.Ad + " kisisi icin loglar temizlendi.");
            } 
        }


        //  static void Main(string[] args)
        //{

        //  CokBicimlilik.Uye uyeOrnegi = new CokBicimlilik.Uye { Ad = "Sevdanur GENC" };
        //  uyeOrnegi.CikisYap();

        //  CokBicimlilik.Admin adminOrnegi = new CokBicimlilik.Admin { Ad = "Selcuk GENC" };
        //  adminOrnegi.CikisYap();

        //  Console.ReadKey();


        // }

    }
}
