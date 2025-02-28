namespace ConsoleApp1.Services;

public class SumOfDigitsService
{
    public static void Run()
    {
        Console.WriteLine("Rakamlarının toplamını öğrenmek istediğiniz sayıyı giriniz: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        for (int i = number; i > 0; i /= 10)
        {
            sum += i % 10;
        }
        Console.WriteLine($"Rakamların toplamı: {sum}");
    }
}