namespace LESSON_OOP_ENCOPSULATION
{
    internal class Salary
    {
        public double Balance { get; set; } = 0;

        public void GetBalance()
        {
            Console.WriteLine($"Sizning hisobingiz: ${Balance}");
        }

        public void DepositBalance(double value)
        {
            Balance += value;
            Console.WriteLine("Kiritilgan summa balans ga muvaffaqiyatli qo'shildi");
        }
    }
}
