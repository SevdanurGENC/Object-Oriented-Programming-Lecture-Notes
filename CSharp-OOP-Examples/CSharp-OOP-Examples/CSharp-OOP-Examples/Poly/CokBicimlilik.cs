using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OOP_Examples.Poly
{
    class CokBicimlilik
    {
        public class Uye
        {
            public string Ad { get; set; }

            public virtual void CikisYap()
            {
                Console.WriteLine(this.Ad + ": Çıkış yaptım.");
            }
        }

        public class Admin : Uye
        {
            public override void CikisYap()
            {
                base.CikisYap();

                Console.WriteLine(this.Ad + ": Çerezleri temizledim.");
            }
        }
    }
}
