using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TShirt
{
    class BankTransfer : IPayment
    {
        public double Fee { get; set; } = 1.6;

        public double TotalCost(int TShirtPrice)
        {
            return TShirtPrice * Fee;
        }
    }
}
