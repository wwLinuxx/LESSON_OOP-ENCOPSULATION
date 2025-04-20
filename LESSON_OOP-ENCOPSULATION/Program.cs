using LESSON_OOP_ENCOPSULATION;

class Program
{
    public static void Main(string[] args)
    {
        var person = new Person();

        Console.Write("Ismingizni kiriting! - ");
        person.Name = Console.ReadLine().ToString();

        Console.Write("Yoshingizni kiriting! - ");
        person.Age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Sizning ismingiz: {person.Name}");
        Console.WriteLine($"Sizning yoshingiz: {person.Age}");
    }
}