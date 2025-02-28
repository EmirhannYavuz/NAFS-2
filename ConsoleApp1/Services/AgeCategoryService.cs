namespace ConsoleApp1.Services;

public class AgeCategoryService
{
    public static void Run()
    {
        List<int> ages = new List<int>();

        Console.WriteLine("Yaşınızı giriniz: ");
        int userAge = Convert.ToInt32(Console.ReadLine());
        ages.Add(userAge);

        foreach (var age in ages)
        {
            if (age >= 0 && age <= 12)
            {
                Console.WriteLine("Çocuk");
            }
            else if (age >= 13 && age <= 19)
            {
                Console.WriteLine("Genç");
            }
            else if (age >= 20 && age <= 64)
            {
                Console.WriteLine("Yetişkin");
            }
            else
            {
                Console.WriteLine("Yaşlı");
            }
        }
    }
}
    