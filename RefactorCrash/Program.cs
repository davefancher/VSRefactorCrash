using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorCrash
{
    using Services;

    class Program
    {
        static void Main(string[] args)
        {
            MakeCrash(new MyService());
        }

        private static void MakeCrash(IService svc)
        {
            svc.DoSomething();
        }
    }
}
