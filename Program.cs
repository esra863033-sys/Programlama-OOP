
using Etkinlik;
using System.Globalization;
using System.Net.Http.Headers;

class Program
{
    static void Main(string[] args)
    {
        ProductsList productList = new ProductsList();
        Console.WriteLine("--Ürün Listesi--");
        productList.ShowAllProduct();

        Console.WriteLine("Id giriniz: ");
        int id = Convert.ToInt32(Console.ReadLine());


        Products secilenUrun = productList.GetProductWithId(id);

        
        if (secilenUrun != null)
        {
            Console.WriteLine("Fiyatı: " + secilenUrun.Price); 

            Console.WriteLine("Ödeme yöntemi seçiniz: 1. Kredi Kartı, 2. Banka Kartı, 3. Havale ");
            string secim = Console.ReadLine();

            if (secim == "1")
            {
                
                CrediCartPayment odeme = new CrediCartPayment(1000m); 
                odeme.Pay(secilenUrun.Price); 
            }
        }
        else
        {
            Console.WriteLine("Girdiğiniz ID'ye ait ürün bulunamadı!");
        }
    }
}
