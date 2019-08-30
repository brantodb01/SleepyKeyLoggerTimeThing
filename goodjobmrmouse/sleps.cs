using System;
using System.Collections.Generic;
using System.Text;

namespace goodjobmrmouse
{
    class sleps
    {
        DateTime Date;
        int numberslepts = 0;
        public List<DateTime> sakovia = new List<DateTime>();
        DateTime bucky;


        public sleps()
        {
            Date = DateTime.Now;

        }

        public void increment()
        {
            numberslepts += 1;
            bucky = DateTime.Now;
            sakovia.Add(bucky);
        }

        public void reading()
        {
            Console.Write("\n");
            for (int i = 0; i<sakovia.Count; i++)
            {
                
                Console.WriteLine(sakovia[i]);
            }
        }
        
        public void writing()
        { 
            for(int i = 0; i<sakovia.Count; i++)
            {
                System.IO.File.AppendAllText(string.Format(@"{1}\mrmouse\{0:dddd, dd MMMM yyyy}.txt", Date, Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) ), string.Format("{0:MM/dd/yyyy HH:mm:ss} \r\n", sakovia[i]));
            }
        }
        
    }
}
