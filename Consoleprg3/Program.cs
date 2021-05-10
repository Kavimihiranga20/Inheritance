using System;

namespace Consoleprg3
{
    class Program
    {
        static void Main(string[] args)
        {
            child child1 = new child();
            child1.sayhi();
        }

        class parent
        { 
        
            public void sayhi()
            {
                Console.WriteLine("Hi world!");
            
            }

            public void saygm()
            {

                Console.WriteLine("Good Morning!");
            }
        
        }

        class child : parent
        { 
        
        }







    }
}
