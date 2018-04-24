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

            for (int i = 0; i < result.Length; i++)
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

        [Test]
        public void many_conditions_for_if_statement()
        {
            var theString =
               "The interesting ththth thing th about London is that there are always stylish surprises around every corner.";
            //  4      4          4     4    4   1     4      4  4    4     4   1       3       4         1     4     2
            string[] result = theString.ToLower().Split(' ');

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i].Length > 4 && result[i].Contains("a"))
                {
                    Console.WriteLine("Długie A");

                }

                else if (result[i].ToLower().Contains("b") || result[i].Contains("c"))
                {
                    Console.WriteLine("Ma B lub C");
                }

                else if (result[i].Length > 6 && !result[i].Contains("e"))
                {
                    Console.WriteLine("Długie bez E");
                }

                else
                {
                    Console.WriteLine("Nic ciekawego");
                }
            }
        }

         [Test]
         public void switch_statement()
         {
            var theString =
               "The interesting ththth thing th about London is that there are always stylish surprises around every corner.";
            
            string[] result= theString.ToLower().Split(' ');
                       
            for (int i = 0; i < result.Length; i++)
            {
                switch (result[i])
                {
                    case "about":
                        Console.WriteLine($"{i} about");
                        break;

                    case "the":
                        Console.WriteLine("something");
                        break;

                    case "interesting":
                    case "always":
                        Console.WriteLine("Harry Potter");
                        break;

                    case "thing":
                        Console.WriteLine("good movie");
                        break;


                    default:
                        Console.WriteLine("nevermind");
                        break;
                }
            }
         }

    }
}