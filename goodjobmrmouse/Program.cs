using System;

namespace goodjobmrmouse
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo keyinfo;

            sleps today = new sleps();
            

            do
            {
                keyinfo = Console.ReadKey();
                if (keyinfo.Key == ConsoleKey.NumPad9)
                {
                    today.increment();
                    today.reading();
                }
            }
            while (keyinfo.Key != ConsoleKey.NumPad7);

            MrDirector bigBobSemple = new MrDirector();



            today.writing();
        }
    }
}
