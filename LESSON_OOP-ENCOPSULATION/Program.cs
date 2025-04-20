using LESSON_OOP_ENCOPSULATION;

class Program
{
    public static void Main(string[] args)
    {
        ////1
        //Person person = new Person();

        //Console.Write("Ismingizni kiriting! - ");
        //person.Name = Console.ReadLine().ToString();

        //Console.Write("Yoshingizni kiriting! - ");
        //person.Age = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine($"Sizning ismingiz: {person.Name}");
        //if (!(person.Age <= 0))
        //    Console.WriteLine($"Sizning yoshingiz: {person.Age}");


        ////2
        //Salary salary = new Salary();

        //main:
        //Console.WriteLine("1. Hisob raqamni tekshirish. \n2. Hisob raqamga depozit qilish.");
        //int selected = Convert.ToInt32(Console.ReadLine());

        //if (selected == 1)
        //{
        //    salary.GetBalance();
        //}
        //else if (selected == 2)
        //{
        //    Console.Write("Necha pul depozit qilmoqchisiz? - ");
        //    salary.DepositBalance(Convert.ToDouble(Console.ReadLine()));
        //}

        //goto main;


        ////3
        //Employee employee = new Employee();

        //employee.Name = "Abdullox";
        //employee.Position = "Cyber Security";

        //mainMenu:
        //Console.WriteLine("1. Ismi \n2. Lavozimi \n3. Maoshi \n0. Exit");
        //int selectedMenu = Convert.ToInt32(Console.ReadLine());

        //if (selectedMenu == 1)
        //{
        //    Console.WriteLine($"Ismi: {employee.Name}");
        //}
        //else if (selectedMenu == 2)
        //{
        //    Console.WriteLine($"Lavozimi: {employee.Position}");
        //}
        //else if (selectedMenu == 3)
        //{
        //    salaryMenu:
        //    Console.WriteLine("1. Maoshini tekshirish \n2. Yangi maosh kiritish \n0. Exit");
        //    int selectedMenu3 = Convert.ToInt32(Console.ReadLine());

        //    if (selectedMenu3 == 1)
        //    {
        //        Console.WriteLine($"Maosh: {employee.GetSalary()}");
        //    }
        //    else if (selectedMenu3 == 2)
        //    {
        //        Console.Write("Yangi maosh kiritish - ");
        //        int newSalary = Convert.ToInt32(Console.ReadLine());

        //        employee.SetSalary(newSalary);
        //    }
        //    else if (selectedMenu3 == 0)
        //    {
        //        goto mainMenu;
        //    }
        //    goto salaryMenu;
        //}
        //else if (selectedMenu == 0)
        //{
        //    goto exit;
        //}

        //Console.WriteLine();

        //goto mainMenu;
        //exit:;


        ////4


        ////5
        Temperature temperature = new Temperature();

        var result = temperature.GetTemperature();

        Console.WriteLine($"Temperature: {result}°C");


        ////6


    }
}