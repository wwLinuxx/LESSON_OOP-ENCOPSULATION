namespace LESSON_OOP_ENCOPSULATION
{
    internal class Person
    {
        private int _age;
        public string Name { get; set; }
        public int Age
        {
            get { return _age; }
            set
            {
                if (!(value <= 0))
                    _age = value;
                else
                    Console.WriteLine("Iltimos 0 dan katta yosh kiriting!");
            }
        }
    }
}
