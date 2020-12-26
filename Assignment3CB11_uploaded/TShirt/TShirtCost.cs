using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TShirt
{
    class TShirtCost
    {
        private IPayment _payment;

        private TShirt shirt;

        public TShirtCost(TShirt shirt,IPayment payment)
        {
            this.shirt = shirt;
            _payment = payment;
        }

        public void SetPayment(IPayment payment) =>
            _payment = payment;

        public double ShirtCost() =>
            _payment.TotalCost(shirt.Cost());
    }
}
