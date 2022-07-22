using System;

namespace Ch04Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // string comparision;
           // Console.WriteLine("Enter a number:");
           // double var1=Convert.ToDouble(Console.ReadLine());
           // Console.WriteLine("Enter another number:");
           // double var2 = Convert.ToDouble(Console.ReadLine());
           // if (var1 < var2)
           //     comparision = "less than";
           // else
           // {

           //     if (var1 == var2)
           //         comparision = "equal to";
           //     else
           //         comparision = "greater than";
           //}
           // Console.WriteLine($"The first number is {comparision}" + $"the second number.");

            try
            {
                string comparision;
                Console.WriteLine("Enter a number:");
                double var1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter another number:");
                double var2 = Convert.ToDouble(Console.ReadLine());
                if (var1 < var2)
                    comparision = "less than";
                else
                {

                    if (var1 == var2)
                        comparision = "equal to";
                    else
                        comparision = "greater than";
                }
                Console.WriteLine($"The first number is {comparision}" + $"the second number.");


            }
            catch(Exception ex)
            {

                Console.WriteLine(ex.GetType() + ex.Message + ex.StackTrace);
            }


        }

     




    }
}
