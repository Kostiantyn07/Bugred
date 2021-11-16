using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bugred
{
    public class Helper
    {
        public static string RandomStringGeneration()  
        {
            return DateTime.Now.ToString("ddMMyyyyhhmm");
        }
    }
}
// Может быть 3 хелпера 1 - хелпер для всех, если есть специфеческая логика, то это отдельный хелпер. 
// Если уникальная строка, то класс хелпер общий для всех. Если не все могут использовать, то вынести отдельно.
// Нужно создать папку "Supports" и вынести её отдельно