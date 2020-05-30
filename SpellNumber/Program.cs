//Nikhil Kashid Spell the Number

//This is console application for takes a whole number and spells it out in words.
//Enter Number in Console then automatically convert into word.


using System;

namespace SpellNumber
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //Message for Enter the Number
                Console.WriteLine("Enter the Number");

                //Read Number and convert into integer
                var number = Int64.Parse(Console.ReadLine());

                //Call NumberTowords
                var words = NumberTowords(number);

                //Print the output
                Console.WriteLine(words);
            }
        }

        public static string NumberTowords(Int64 i)
        {
            //If value less than 20
            if (i < 20)
            {
                return UnitProvider.Units[i];
            }

            //if value less than 100
            if (i < 100)
            {
                return UnitProvider.Tens[i / 10] + ((i % 10 > 0) ? " " + NumberTowords(i % 10) : "");
            }

            //if value less than 10000 add "Hundred" & "And"
            if (i < 1000)
            {
                return UnitProvider.Units[i / 100] + " Hundred "
                        + ((i % 100 > 0) ? "And " + NumberTowords(i % 100) : "");
            }

            //if value less than 100000 add "Thousand"
            if (i < 100000)
            {
                return NumberTowords(i / 1000) + " Thousand "
                + ((i % 1000 > 0) ? " " + NumberTowords(i % 1000) : "");
            }

            //if value less than 10000000 add "Lakh"
            if (i < 10000000)
            {
                return NumberTowords(i / 100000) + " Lakh "
                        + ((i % 100000 > 0) ? " " + NumberTowords(i % 100000) : "");
            }

            //other
            return NumberTowords(i / 10000000) + " Crore "
                        + ((i % 10000000 > 0) ? " " + NumberTowords(i % 10000000) : "");
        }


        //unit place and Ten's place word
        static public class UnitProvider
        {
            static public string[] Units = new[] { "Zero", "One", "Two", "Three","Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven","Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen",
                            "Seventeen", "Eighteen", "Nineteen" };
            static public string[] Tens = new[]{ "", "", "Twenty", "Thirty", "Forty",
                        "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
        }

    }
}
