using System;
using static System.Console;

//Name: James Shoemaker
//Date: 04/11/2020
//Program Description: Calculate a fine for overdue books by passing the method into main.

namespace FineForOverdueBooksMod4
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity;
            int overdue;
            



            Write("Please enter the number of books checked out: ");
            quantity = int.Parse(ReadLine());

            Write("Please enter the number of days the books are overdue: ");
            overdue = int.Parse(ReadLine());

            double result;
            result = CalcFine1(quantity, overdue);
            WriteLine(" Your total fine is - {0}", result.ToString("C"));






        }

        private static double CalcFine1(int quantity, int overdue)
        {
            double fine;
            if (quantity <= 7)
                fine = quantity * overdue * .10;
            else
                fine = quantity * (.70 + (overdue - 7) * .20);



            return fine;


        }
    
    }
}
