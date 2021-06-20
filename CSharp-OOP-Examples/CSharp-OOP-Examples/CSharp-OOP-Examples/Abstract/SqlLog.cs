using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_OOP_Examples.Abstract
{
    public class SqlLog : LogBase
    {
        public override void WriteErrorLog()
        {
            Console.WriteLine("Sql Log tarafinda WriteErrorLog metodu cagirildi.");
        }

        public override void WriteLog()
        {
            Console.WriteLine("Sql Log tarafinda WrtieLog metodu cagirildi.");
        }
    }
}
