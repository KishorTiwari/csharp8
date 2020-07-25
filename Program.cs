using System;

namespace csharp8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Index and Range
            char[] vowels = {'a', 'e', 'i', 'o', 'u'};


            Console.WriteLine(vowels[^1]); // relative to last elemet, char

            Console.WriteLine(vowels[^2]); //refers to the second-to-last-element, char

            char[] firstFive = vowels[..5]; //5 characters from the begining, range

            char[] first1 = vowels[..1]; //1 character from the begining, range

            char[] lastThree = vowels[2..]; //skip till second character

            //could also be passed as variable
            Range firstTwoRange = 0..2;
            Index last = ^1;
            
            Wl(string.Join(',',  lastThree));
        }




        static void Wl(string content){
            Console.WriteLine(content);
        }
    }
}
