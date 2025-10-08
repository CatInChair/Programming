using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Генератор уникальных идентификаторов
    /// </summary>
    public class IdGenerator
    {
        private static int _idCount = 0;
        
        /// <summary>
        /// Создает следующий идентификатор
        /// </summary>
        /// <returns>Новый идентификатор</returns>
        public static int getNextId()
        {
            return _idCount++;
        }
    }
}
