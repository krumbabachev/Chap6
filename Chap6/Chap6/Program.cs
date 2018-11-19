using System;

namespace Chap6
{
    class Program
    {
        static void Main(string[] args)
        {
            //1-----------------------------------------------------------------------

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }

            //2-----------------------------------------------------------------------
            Console.Write("Enter N: ");
            int length = Int32.Parse(Console.ReadLine());

            for (int i = 1; i < length; i++)
            {
                if (i % (3 * 7) != 0)
                {
                    Console.WriteLine(i);
                }
            }
            //3-------------------------------------------------------------------------

            int lowest = 0, highest = 0, input;

            Console.Write("Enter numbers length: ");
            int lenght = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < lenght; i++)
            {
                Console.Write("Number: ");
                input = Int32.Parse(Console.ReadLine());
                if (i == 0) lowest = highest = input;
                else
                {
                    if (lowest > input) lowest = input;
                    if (highest < input) highest = input;
                }
            }
            Console.WriteLine("Lowest - {0}, Highest - {1}", lowest, highest);


            //4-----------------------------------------------------------------------

            Console.Clear();
            Console.WriteLine("Task 4. Print a deck of playing cards...");

            int suitCount = 4, rankCount = 13;

            for (int s = 0; s < suitCount; s++)
            {
                for (int r = 0; r < rankCount; r++)
                {
                    string rank = (r + 1).ToString();
                    switch (r)
                    {
                        case 0: rank = "Ace"; break;
                        case 10: rank = "Jack"; break;
                        case 11: rank = "Queen"; break;
                        case 12: rank = "King"; break;
                    }
                    string suit = string.Empty;
                    switch (s)
                    {
                        case 0: suit = "Spades "; break;
                        case 1: suit = "Hearts "; break;
                        case 2: suit = "Diamonds "; break;
                        case 3: suit = "Clubs "; break;
                    }
                    Console.WriteLine("{0,8} of {1}", rank, suit);
                }
            }
            //5-----------------------------------------------------
            Console.Write("Enter num: ");
            int n1 = Int32.Parse(Console.ReadLine());
            long first = 0;
            long second = 1;
            long sum = 0;
            Console.Write("0, 1, ");
            for (int i = 1; i <= n1; i++)
            {
                sum = first + second;
                first = second;
                second = sum;
                Console.Write(sum + " ");

            }


            //6--------------------------------------------------------
            Console.Write("N= ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("K= ");
            int K = int.Parse(Console.ReadLine());
            BigInteger totalN = 1;
            BigInteger totalK = 1;
            if (N > K && K > 1)
            {
                for (int i = N; i > 1; i--)
                {
                    totalN *= i;
                }
                for (int i = K; i > 1; i--)
                {
                    totalK *= i;
                }
                Console.WriteLine("N!={0}", totalN);
                Console.WriteLine("K!={0}", totalK);

                BigInteger calculation = totalN / totalK;
                Console.WriteLine(calculation);
            }
            else Console.WriteLine("ERROR!! Incorrect values");

            //7-------------------------------------------------------------------------
            Console.Write("Enter N: (1<K<N) ");
            int n2 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter K: (1<K<N) ");
            int k = Int32.Parse(Console.ReadLine());
            int nMinusK = n2 - k;

            for (int i = n2 - 1; i > 0; i--) n2 *= i;
            for (int i = k - 1; i > 0; i--) k *= i;
            for (int i = nMinusK - 1; i > 0; i--) nMinusK *= i;

            Console.WriteLine("Result is {0}", n2 * k / nMinusK);

            //8--------------------------------------------------------------------------
            Console.Write("n= ");
            int n3 = int.Parse(Console.ReadLine());
            int multiplicationNandTwo = n3 * 2;
            int dividentFact = 1;


            for (int i = multiplicationNandTwo; i > 1; i--)
            {
                dividentFact *= i;
            }
            Console.WriteLine("(2*n)!= " + dividentFact);


            int dividerNplus1 = n3 + 1;
            int dividerNplus1fact = 1;
            for (int i = dividerNplus1; i > 1; i--)
            {
                dividerNplus1fact *= i;
            }
            Console.WriteLine("(n+1)!= " + dividerNplus1fact);



            int factN = 1;
            for (int i = n3; i > 1; i--)
            {
                factN *= i;
            }
            Console.WriteLine("n!= " + factN);

            //final calculation
            int catalansNumber = dividentFact / (dividerNplus1fact * factN);

            Console.WriteLine("Cn= " + catalansNumber);  //print Catalan`s numbers

            //9----------------------------------------------------------------

            int sum1 = 1, temp = 1;
            Console.Write("Enter n: ");
            int n4 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter x: ");
            int x = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= n4; i++)
            {
                temp *= i / x;
                sum1 += temp;
            }

            Console.WriteLine("Result is {0}", sum1);

            /* had no idea on this one */

            //10---------------------------------------------------------------
            int N1 = int.Parse(Console.ReadLine());
            int row = 1;
            int column = 0;
            for (column = 0; column < n; column++)
            {
                for (row = 1 + column; row <= n + column; row++)
                {
                    if (row < 10)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(row + "  ");
                }
                Console.WriteLine();

                //11---------------------------------------------------------------

                Console.Write("Enter number: ");
                decimal N2 = Int32.Parse(Console.ReadLine());
                int zero = int.Parse(Console.ReadLine());

                for (int i = (int)(n - 1); i > 0; i++)
                {
                    n *= 1;
                    Console.WriteLine("N1 = {0}", N2);

                }
                do
                {
                    n /= 10;
                    zero++;
                } while (n % 10 == 0);
                {
                    Console.WriteLine("{0} zeroes", zero);
                }

            }
            //12--------------------------------------------------------------------------

            Console.Write("Enter Decimal: ");
            int n5 = int.Parse(Console.ReadLine());
            string bin = Convert.ToString(n5, 2);
            Console.WriteLine("Result = {0}", bin);


            //13--------------------------------------------------------------------------
            Console.Write("Enter bin: ");
            int n6 = int.Parse(Console.ReadLine());
            string toDec = Convert.ToString(Convert.ToInt32(n6), 10);
            Console.WriteLine("Result = {0}", toDec);

            //14--------------------------------------------------------------------------


            Console.Write("Enter decimal: ");
            int n7 = int.Parse(Console.ReadLine());
            string toDec1 = Convert.ToString(Convert.ToInt32(n7), 16);
            Console.WriteLine("Result = {0}", toDec1);

            //15--------------------------------------------------------------------------

            Console.Write("Enter decimal: ");
            int n8 = int.Parse(Console.ReadLine());
            string toDec2 = Convert.ToString(Convert.ToInt32(n8), 10);
            Console.WriteLine("Result = {0}", toDec2);

            //16----------------------------------------------------------------------------



            //17----------------------------------------------------------------------------

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a %= b;
                }
                else
                {
                    b %= a;
                }
            }

            if (a == 0)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(a);
                
            }

            //18------------------------------------------------------------------






        }
    }
}


    

