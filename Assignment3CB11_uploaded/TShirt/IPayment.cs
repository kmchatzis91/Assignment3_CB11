using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TShirt
{
    public interface IPayment
    {
        double Fee { get; set; }
        double TotalCost(int TShirtPrice); 
    }
}
