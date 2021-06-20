using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OOP_Examples.Abstract
{
    public class FileLog : LogBase
    {
        public override void WriteErrorLog()
        {
            Console.WriteLine("File Log tarafindan WriteErrorLog metodu cagirildi.");
        }

        public override void WriteLog()
        {
            Console.WriteLine("File Log tarafindan WriteLog metodu cagirildi.");
        }
    }
}
