namespace LESSON_OOP_ENCOPSULATION
{
    internal class Temperature
    {
        public int GetTemperature() {
            Random random = new Random();
            return random.Next(0, 100);
        }
    }
}
