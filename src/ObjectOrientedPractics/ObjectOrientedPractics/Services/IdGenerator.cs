using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    public class IdGenerator
    {
        private static int _idCount = 0;
        
        public static int getNextId()
        {
            return _idCount++;
        }
    }
}
