namespace Script
{
    class test
    {
        public int testVar { get; set; }

        public test(int testVar)
        {
            this.testVar = testVar;
        }
        
    }


    class Einstiegspunkt
    {
        static int _mathe = 1;
        static int addOne(ref int i)
        {
            i = i + 1;
            return i;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine($"Mathe davor: {_mathe}");
            Console.WriteLine(addOne(ref _mathe));
            ;
            Console.WriteLine($"Mathe danach: {_mathe}");
        }
    }
}

    



