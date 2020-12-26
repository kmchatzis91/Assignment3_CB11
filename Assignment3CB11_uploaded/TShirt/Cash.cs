using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TShirt
{
    class Cash : IPayment
    {
        public double Fee { get; set; } = 1;

        public double TotalCost(int price)
        {
            return price * Fee;
        }
    }
}
