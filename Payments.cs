
using System;
using System.Collections.Generic;
using System.Text;

namespace Etkinlik
{
    public abstract class Payment
    {


        public abstract void Pay(decimal amount);
        public abstract void ShowPaymentText(string text);

        public DateTime IslemTarihi { get; set; }


    }
}
