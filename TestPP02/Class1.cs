using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPP02
{
    public class Class1
    {
        public static Tuple<double,double,string> tarifMin(bool radio, double min)
        {
            double rub = 0;
            double ost = 0;
            string message;
            if (radio)
            {
                if (min <= 200)
                {
                    rub = min * 0.7;
                    message = $"К оплате: {rub.ToString("F2")} руб.";
                    return Tuple.Create(rub, ost,message);
                    
                }
                else
                {
                    rub = (200 * 0.7) + ((min - 200) * 1.6);
                    ost = min - 200;
                    message = $"К оплате: {rub.ToString("F2")} руб.\nОстаток: {ost}";
                    return Tuple.Create(rub, ost,message);
                }
            }
            else
            {
                if(min <= 100)
                {
                    rub = min * 0.3;
                    message = $"К оплате: {rub.ToString("F2")} руб.";
                    return Tuple.Create(rub, ost, message);
                }
                else
                {
                    rub = (100 * 0.3) + ((min - 100)*1.6);
                    ost = min - 100;
                    message = $"К оплате: {rub.ToString("F2")} руб.\nОстаток: {ost}";
                    return Tuple.Create(rub, ost, message);
                }
            }
        }
    }
}
