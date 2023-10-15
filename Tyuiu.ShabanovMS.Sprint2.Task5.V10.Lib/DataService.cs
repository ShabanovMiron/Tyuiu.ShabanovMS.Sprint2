using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ShabanovMS.Sprint2.Task5.V10.Lib
//Дата некоторого дня характеризуется тремя натуральными числами:
// g (год), m (порядковый номер месяца) и n (число). По заданным g, n и m определить дату предыдущего дня. Заданный год не является високосным.
{
    public class DataService : ISprint2Task5V10
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {

            switch (n)
            {
                case 1:
                    switch (m)
                    {
                        case 1:
                            n = 31;
                            m = 12;
                            g--;
                            break;
                        default:
                            m--;
                            switch (m)
                            {
                                case 1:
                                case 3:
                                case 5:
                                case 7:
                                case 8:
                                case 10:
                                case 12:
                                    n = 31;
                                    break;
                                case 2:
                                    n = 28;
                                    break;
                                default:
                                    n = 30;
                                    break;
                            }
                            break;
                    }
                    break;
                default:
                    n--;
                    break;
            }
            string res = Convert.ToString(n + "." + m + "." + g);
            return res;
        }
    }
}
