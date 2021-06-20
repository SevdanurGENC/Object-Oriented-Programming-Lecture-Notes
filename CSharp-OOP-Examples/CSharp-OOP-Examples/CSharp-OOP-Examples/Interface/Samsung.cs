using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OOP_Examples.Interface
{
    public class Samsung : IBasliklar, IUzunluk
    {
        #region IBasliklar Members
        public string Isim() {
            return "Model : Galaxy - S4";
        }
        public string AnaBaslik() {
            return "Teknoloji";
        }

        public string AltBaslik() {
            return "Telefon";
        }
        #endregion


        #region IUzunluk Members
        public string En()
        {
            return "70.6 mm";
        }

        public string Boy()
        {
            return "136.6 mm";
        }

        public string Kalinlik()
        {
            return "8.6 mm";
        }
         
        string IBasliklar.Yazdir()
        {
            return "IBasliklar Yazdir Metodu";
        }

        string IUzunluk.En()
        {
            throw new NotImplementedException();
        }

        string IUzunluk.Boy()
        {
            throw new NotImplementedException();
        }

        string IUzunluk.Kaliklik()
        {
            throw new NotImplementedException();
        }

        string IUzunluk.Yazdir()
        {
            return "IUzunluk Yazdir Metodu";
        }
        #endregion



        //Samsung S4 = new Samsung();
        //IUzunluk uzunluk = (IUzunluk)S4;
        //IBasliklar baslik = (IBasliklar)S4;

        //Console.WriteLine(S4.Isim());
        //    Console.WriteLine("Ana Baslik : " + S4.AnaBaslik());
        //    Console.WriteLine("Alt Baslik : " + S4.AltBaslik());
        //    Console.WriteLine(baslik.Yazdir());

        //    Console.WriteLine();


        //    Console.WriteLine("En : " + S4.En());
        //    Console.WriteLine("Boy : " + S4.Boy());
        //    Console.WriteLine("Kalinlik : " + S4.Kalinlik());
        //    Console.WriteLine(uzunluk.Yazdir());

        //    Console.ReadKey();




    }
}
