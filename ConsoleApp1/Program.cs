Random bilgisayar = new Random();
int bakiye = bilgisayar.Next(0, 1000000);
int saat = DateTime.Now.Hour;

if (saat < 12 && saat > 5)
{
    Console.WriteLine($"Günaydın, hoşgeldiniz! Güncel bakiyeniz: {bakiye}");
}
else if (saat >= 12 && saat < 17)
{
    Console.WriteLine($"Tünaydın, hoşgeldiniz! Güncel bakiyeniz: {bakiye}");
}
else
{
    Console.WriteLine($"İyi akşamlar, hoşgeldiniz. Güncel bakiyeniz: {bakiye}");
}

//Menü
Console.WriteLine("\nYapmak istediğiniz işlemi seçiniz:");
Console.WriteLine("1- Para Yatırma");
Console.WriteLine("2- Para Çekme");
Console.WriteLine("3- Kart İade");
int secim = Convert.ToInt32(Console.ReadLine());

int YatırılanTutar = 0;
int cekilenTutar = 0;

switch (secim)
{
    case 1:
        Console.Write("Yatırmak istediğiniz tutarı giriniz: ");
        YatırılanTutar = Convert.ToInt32(Console.ReadLine());
        bakiye += YatırılanTutar;
        Console.WriteLine($"Yeni bakiyeniz {bakiye} TL'dir.");
        break;
    case 2:
        Console.Write("Çekilecek tutarı giriniz: ");
        cekilenTutar = Convert.ToInt32(Console.ReadLine());

        if (cekilenTutar > bakiye)
        {
            Console.WriteLine("Girdiğiniz tutar uygun değil.");
            
            Console.Write("\nİşlem seçiniz: ");
            Console.WriteLine("1- Tekrar tutar gir");
            Console.WriteLine("2- Ana menü");
            Console.WriteLine("3- Kart iadesi");
            int durum = Convert.ToInt32(Console.ReadLine());

            int yeniCekilenTutar = 0;

            switch (durum)
            {
                case 1:
                    Console.Write("Çekmek istediğiniz tutarı giriniz: ");
                    yeniCekilenTutar = Convert.ToInt32(Console.ReadLine());
                    if (yeniCekilenTutar <= bakiye)
                    {
                        bakiye -= yeniCekilenTutar;
                        Console.WriteLine($"Güncel bakiyeniz {bakiye} TL'dir.");
                    }
                    else
                    {
                        Console.WriteLine("Girdiğiniz tutar bakiyeden fazla.");
                    }
                    break;
                case 2:
                    Console.Write("Ana menüye gidiliyor...");
                    break;
                case 3:
                    Console.WriteLine("Kartınız iade ediliyor...");
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim.");
                    break;
            }
        }
        else
        {
            bakiye -= cekilenTutar;
            Console.WriteLine($"Güncel bakiyeniz {bakiye} TL'dir.");
        }
        break;
    case 3:
        Console.WriteLine("Kartınız iade ediliyor.");
        break;
}

Console.WriteLine("Bizi tercih ettiğiniz için teşekkür ederiz. İyi günler dileriz.");
Console.ReadKey();