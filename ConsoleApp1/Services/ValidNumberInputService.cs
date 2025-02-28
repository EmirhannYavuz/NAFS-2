namespace ConsoleApp1.Services;

public class ValidNumberInputService
{
    public static void Run()
    {
        Console.WriteLine("Lütfen 10 ile 100 arasında bir sayı giriniz: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        while (true)
        {
            if (choice > 10 && choice < 100)
            {
                break;
            }
            else
            {
                Console.WriteLine("Hatalı sayı girdiniz. Lütfen tekrardan 10 ile 100 arasında bir sayı giriniz: ");
                choice = Convert.ToInt32(Console.ReadLine());
            }
        }
        
        Console.WriteLine("Girdiğiniz sayı 10 ile 100 arasında! Girdiğiniz sayı: " + choice);
    }
}