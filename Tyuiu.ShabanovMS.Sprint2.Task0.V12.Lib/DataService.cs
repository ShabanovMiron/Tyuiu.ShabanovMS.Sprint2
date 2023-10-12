using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ShabanovMS.Sprint2.Task0.V12.Lib
//(True, False, True, False, True, False), при x = 1095, y = 475
{
    public class DataService : ISprint2Task0V12
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];
            res[0] = y + 620 == x; //true
            res[1] = x - 620 != y; //false
            res[2] = y < x; //true
            res[3] = y > x; //false
            res[4] = y <= x; //true
            res[5] = x >= y + 624; //false

            return res;
        }
    }
}
