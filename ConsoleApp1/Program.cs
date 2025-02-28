// See https://aka.ms/new-console-template for more information

using ConsoleApp1.Services;

Console.WriteLine("Servislerimiz:");
Console.WriteLine("1. Sayıların Rakamları Toplamını Bulma");
Console.WriteLine("2. Geçerli Sayı Girişi");
Console.WriteLine("3. Yaş Kategorisini Belirleme");
Console.WriteLine("4. Tekrar Eden Sayıları Bulma");
Console.WriteLine("5. En Uzun ve En Kısa Kelimeyi Bulma");
Console.WriteLine("6. Cümledeki Kelimeleri Alfabetik Sıralama");

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
        SumOfDigitsService.Run();
        break;
    case 2:
        ValidNumberInputService.Run();
        break;
    case 3:
        AgeCategoryService.Run();
        break;
    case 4:
        RepeatedElementsService.Run();
        break;
    case 5:
        WordLengthCheckerService.Run();
        break;
    case 6:
        SentenceSortService.Run();
        break;
}