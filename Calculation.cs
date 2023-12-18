using System;
using System.Collections.Generic;
using System.Text;

namespace mid_term
{
    //this is interface of tax
    interface Tax
    {
        void TotalTax(double money);
    }

    //calculation class inherit tax and calculate data
    class Calculation : Tax
    {
        public void TotalTax(double money)
        {
            double tax = 15.2, result;            
            result = (money * tax) / 100;
            Console.WriteLine("\tYour Tax Is            : $" + result);
            result = money + result;            
            Console.WriteLine("\tYour Total Bill Is     : $" + result);
        }
    }
}
