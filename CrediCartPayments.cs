
using System;
using System.Collections.Generic;
using System.Text;

namespace Etkinlik
{
    public class CrediCartPayment : Payment
    {
        private decimal toplamBakiye;
        private const decimal komisyon = 8m;


        public CrediCartPayment(decimal bakiye)
        {
            toplamBakiye = bakiye;
        }

        public override void ShowPaymentText(string text)
        {
            Console.WriteLine(text);
        }


        public override void Pay(decimal amount)
        {
            decimal ToplamOdeme = komisyon + amount;

            if (toplamBakiye >= ToplamOdeme)
            {
                toplamBakiye -= ToplamOdeme;
                Console.WriteLine($"Kredi kartı ile {amount} TL ödendi. Komisyon: {komisyon} TL. Kalan bakiye: {toplamBakiye} TL.");
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye. Lütfen bakiyenizi kontrol edin.");
            }
        }

        
    }
}
