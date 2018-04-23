using NUnit.Framework;
using NUnit.Framework.Internal.Commands;
using System;

namespace CSharp_Fundamentals
{
    [TestFixture]
    public class StringsAndItsOperations
    {
        /// <summary>
        /// String is diffrent then previues types we talk about
        /// values of string we are passing in quotation marks
        /// 
        /// Create new string with your name and then add them together
        /// </summary>
        [Test]
        public void Bascis_Of_Strings()
        {
            string Example = "This is example string";
            string Space = " ";
            string Name = "Przemyslaw Gozdzik";

            Assert.AreEqual("This is example string Przemyslaw Gozdzik", Example + Space + Name);
            
        }

        /// <summary>
        ///  string is  first Reference Type you see (We will talk more about them later)
        ///  which means he doesn't have to have value.
        ///  use string.Empty;
        ///  create new strings itsEmpty and make it empty
        /// </summary>
        [Test]
        public void String_Initialization()
        {
            string itsEmpty = "Przemek";
            Assert.That(itsEmpty, Is.EqualTo("Przemek"));
        }

        /// <summary>
        /// + is not best way of adding string
        ///  use string.Concat();
        ///  put sentence together
        /// </summary>
        [Test]
        public void Adding_String()
        {
            string first = "pancakes.";
            string second = "I like";
            string space = " ";
            string result = string.Concat(second, space, first);

            string.Concat(second, first);

            Assert.AreEqual(result, "I like pancakes.");
        }

        /// <summary>
        /// There is few more ways of cosntructing strings for example if you need add values of other variables inside you can do
        /// https://docs.microsoft.com/en-us/dotnet/api/system.string.format?view=netframework-4.7.1#Starting
        /// create string with both x and y insed
        /// </summary>
        [Test]
        public void String_Format()
        {
            int x = 500;
            int y = 453;
       
            string result = $"suma {x} i {y} wynosi 953";

            Console.WriteLine(result);

            //decimal exampleDecimal = new decimal(10.5);

            //double X = 140000000000000000000000000.001;
            //double Y = 0.0000000000000000000000000008;

            //var add = X + Y;
            //var subtract = X - Y;
            //Console.WriteLine($"{add} {subtract}");

            StringAssert.Contains(x.ToString(),result);
            StringAssert.Contains(y.ToString(),result);
        }

        /// <summary>
        /// From theString return word "thing".
        /// hint use Substring() method
        /// </summary>
        [Test]
        public void Substrings()
        {
            var theString =
                "The interesting thing about London is that there are always stylish surprises around every corner.";
            string result = theString.Substring(16, 5);
            
            Assert.AreEqual(result, "thing");
        }

        [Test]
        public void Split()
        {
            var theString =
                "The interesting thing about London is that there are always stylish surprises around every corner.";
            string[] result = theString.Split(' ');

            Assert.AreEqual(result[2], "thing"); //zaczynamy liczenie od 0, dlatego tutaj chcemy aby result zwrócił nam [2]
        }
    }
}