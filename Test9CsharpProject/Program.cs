using System;

namespace csharpProject
{
    class program
    {
  
        static void Main()
        {
            bool? areYouaMajor = null;  
            if(areYouaMajor== true)
            {
                Console.WriteLine("You are major");
            }else if(areYouaMajor== false) {
                Console.WriteLine("You are minor");
            }else
            {
                Console.WriteLine("You did not answer the question");
            }
        }
    }
}