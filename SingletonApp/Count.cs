using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SingletonExample
{
    internal class Count
    {
        private static Count instance = null;
        public int count = 0;
        private Count()
        {
        }
        public static Count getInstance()
        {
            if (instance == null)
            {
                instance = new Count();
            }
            return instance;
        }
        public void increment ()
        {
            count++;
        }
    }
}
