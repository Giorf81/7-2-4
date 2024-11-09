namespace _7_2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    class BaseClass
    {
        public virtual int Counter
        {
            get;
            set;
        }
    }

    class DerivedClass : BaseClass
    {
        private int num;
        public override int Counter
        { 
            get { return num; }
            set
            {
                if (num < 0)
                    Console.WriteLine("Что то не так");
                else 
                 num = value;
            }
        }
    }
}
