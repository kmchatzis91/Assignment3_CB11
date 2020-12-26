using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TShirt
{
    class CreditCard : IPayment
    {
        public double Fee { get; set; } = 1.2;

        public double TotalCost(int TShirtPrice)
        {
            return TShirtPrice * Fee;
        }
    }
}
