using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace CSharp_Fundamentals
{
    [TestFixture]
    public class ArrayListCollection
    {
        [Test]
        public void Loop_basics()
        {
            var theString =
               "The interesting thing about London is that there are always stylish surprises around every corner.";
            string[] result = theString.Split(' ');

            int iterator = 0;

            do
            {
                Console.WriteLine(result[iterator]);
                iterator++;

            }
            while (result[iterator] != "stylish");
        }

        [Test]
        public void for_loop()
        {
            var theString =
               "The interesting thing about London is that there are always stylish surprises around every corner.";
            string[] result = theString.Split(' ');

            for(int i = 0; i < result.Length;i++)
            {
                Console.WriteLine(i);
            }
        }
        
        [Test]
        public void if_statement()
        {
            var theString =
               "The interesting ththth thing th about London is that there are always stylish surprises around every corner.";
            string[] result = theString.Split(' ');

            for (int i = 0; i < result.Length; i++)
               {
                //  Console.WriteLine(result[i]);
                if (result[i] == "London")
                {
                    Console.WriteLine("Nice city");

                }

                else if (result[i].ToLower().Contains("th"))
                {
                                   
                    if (result[i].Length > 4)
                    {
                        Console.WriteLine("too long");
                    }
                    else
                    {
                        Console.WriteLine("TH");
                    }
                }
                else
                {
                    Console.WriteLine("Nothing");
                }
            }
        }
    }
}