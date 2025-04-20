namespace LESSON_OOP_ENCOPSULATION
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        private int Salary { get; set; } = 500;

        public int GetSalary()
        {
            return Salary;
        }

        public void SetSalary(int salary)
        {
            Salary = salary;
            Console.WriteLine("Kiritilgan maosh muvaffaqiyatli saqlandi!.");
        }
    }
}
