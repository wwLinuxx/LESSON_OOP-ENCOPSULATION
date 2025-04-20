namespace LESSON_OOP_ENCOPSULATION
{
    internal class Time
    {
        private int Hour = 00;
        private int Minute = 00;

        public void SetTime(int hour, int minute)
        {
            if (hour > 24)
                Console.WriteLine("Soatni to'g'ri kiriting!");
            else
                Hour = hour;
            if (minute > 60)
                Console.WriteLine("Minutni to'g'ri kiriting!");
            else 
                Minute = minute;
        }

        public void GetTime()
        {
            Console.WriteLine($"Vaqt: {Hour}:{Minute}");
        }
    } 
}
