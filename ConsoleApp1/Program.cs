// See https://aka.ms/new-console-template for more information

using ConsoleApp1.Services;

Console.WriteLine("Servislerimiz:");
Console.WriteLine("1. Sayıların Rakamları Toplamını Bulma");
Console.WriteLine("2. Geçerli Sayı Girişi");
Console.WriteLine("3. Yaş Kategorisini Belirleme");
Console.WriteLine("4. Tekrar Eden Sayıları Bulma");
Console.WriteLine("5. En Uzun ve En Kısa Kelimeyi Bulma");
Console.WriteLine("6. Cümledeki Kelimeleri Alfabetik Sıralama");
Console.WriteLine("7. Dizi İşlemleri");
Console.WriteLine("8. Kelimeleri Tersten Yazdırma");
Console.WriteLine("9. Sayı İşlemleri");
Console.WriteLine("10. Listeden 10'dan Küçük Sayıları Çıkarma");
Console.WriteLine("11. Minimum Notu 50 Yapma");

Console.WriteLine("Kullanmak istediğiniz servisi seçiniz (1-11): ");
int choice = Convert.ToInt32(Console.ReadLine());

while (true)
{
    if (choice > 0 && choice <= 11)
    {
        break;
    }
    else
    {
        Console.WriteLine("Geçersiz servis sayısı girdiniz. Lütfen tekrardan 1-11 arasında bir sayı giriniz: ");
        choice = Convert.ToInt32(Console.ReadLine());
    }
}

switch (choice)
{
    case 1:
        Console.WriteLine("--------------------");
        Console.WriteLine("Sayıların rakamları toplamını bulma servisi seçildi.");
        SumOfDigitsService.Run();
        break;
    case 2:
        Console.WriteLine("--------------------");
        Console.WriteLine("Geçerli sayı girişi servisi seçildi.");
        ValidNumberInputService.Run();
        break;
    case 3:
        Console.WriteLine("--------------------");
        Console.WriteLine("Yaş kategorisini belirleme servisi seçildi.");
        AgeCategoryService.Run();
        break;
    case 4:
        Console.WriteLine("--------------------");
        Console.WriteLine("Tekrar eden sayıları bulma servisi seçildi.");
        RepeatedElementsService.Run();
        break;
    case 5:
        Console.WriteLine("--------------------");
        Console.WriteLine("En uzun ve en kısa kelimeyi bulma servisi seçildi.");
        WordLengthCheckerService.Run();
        break;
    case 6:
        Console.WriteLine("--------------------");
        Console.WriteLine("Cümledeki kelimeleri alfabetik sıralama servisi seçildi.");
        SentenceSortService.Run();
        break;
    case 7:
        Console.WriteLine("--------------------");
        Console.WriteLine("Dizi işlemleri servisi seçildi.");
        DynamicStringArrayService.Run();
        break;
    case 8:
        Console.WriteLine("--------------------");
        Console.WriteLine("Kelimeleri tersten yazdırma servisi seçildi.");
        ReverseWordService.Run();
        break;
    case 9:
        Console.WriteLine("--------------------");
        Console.WriteLine("Sayı işlemleri servisi seçildi.");
        NumberProcessorService.Run();
        break;
    case 10:
        Console.WriteLine("--------------------");
        Console.WriteLine("Listeden 10'dan küçük sayıları çıkarma servisi seçildi.");
        RemoveSmallNumbersService.Run();
        break;
    case 11:
        Console.WriteLine("--------------------");
        Console.WriteLine("Minimum notu 50 yapma servisi seçildi.");
        MinimumScoreUpdateService.Run();
        break;
}