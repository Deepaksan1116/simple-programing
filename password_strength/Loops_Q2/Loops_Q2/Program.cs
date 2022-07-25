using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region loops - Q2 - Q1
            //Console.WriteLine("Enter your number ");
            //int num = int.Parse(Console.ReadLine());
            //int sum = 0;
            //while (num > 0)
            //{
            //    num = num / 10;
            //    sum++;
            //}
            //Console.WriteLine(sum);
            #endregion
            #region loops - Q2 - Q2
            //Console.WriteLine("Enter your number");
            //uint number = uint.Parse(Console.ReadLine());
            //uint sum = 0;
            //while (number != 0)
            //{
            //    uint rem = number % 10;
            //    number = number / 10;
            //    sum++;
            //}
            //if (sum % 2 == 0)
            //{
            //    Console.WriteLine("This is the even length");
            //}
            //else
            //{
            //    Console.WriteLine("This is the odd length");
            //}          
            #endregion
            #region loops - Q2 - Q3
            //Console.WriteLine("Enter your number ");
            //uint number = uint.Parse(Console.ReadLine());
            //uint rem = 0;
            //uint sum = 0;
            //while (number != 0)
            //{
            //    rem = number % 10;
            //    number = number / 10;
            //    sum = sum + rem;
            //}
            //Console.WriteLine(sum);
            #endregion
            #region loops - Q2 - Q4
            //Console.WriteLine("Enter your number ");
            //int num = int.Parse(Console.ReadLine());
            //int sum = 0;
            //bool isskip = false;
            //while (num != 0)
            //{
            //    int rem = num % 10;
            //    if (!isskip)
            //    {
            //        sum += rem;
            //    }
            //    isskip = !isskip;
            //    num = num / 10;
            //}
            //Console.WriteLine("This even length "+sum);
            #endregion
            #region loops - Q2 - Q5
            //Console.WriteLine("Enter your number ");
            //int num = int.Parse(Console.ReadLine());
            //int sum = 0;
            //bool isskip = true;
            //while (num != 0)
            //{
            //    int rem = num % 10;
            //    if (!isskip)
            //    {
            //        sum += rem;
            //    }
            //    isskip = !isskip;
            //    num = num / 10;
            //}
            //Console.WriteLine("Your odd position is " + sum);
            #endregion
            #region loops - Q2 - Q6
            //Console.WriteLine("Enter your number");
            //uint number = uint.Parse(Console.ReadLine());
            //uint rem = 0;
            //uint count = 0;
            //while (number > 0)
            //{
            //    rem = number % 10;
            //    number = number / 10;
            //    if (rem % 2 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine("Your even count is = "+count);
            #endregion
            #region loops - Q2 - Q7
            //Console.WriteLine("Enter your number");
            //uint number = uint.Parse(Console.ReadLine());
            //uint count = 1;
            //uint rem = 0;
            //while (number > 0)
            //{
            //    number = number / 10;
            //    rem = number % 10;

            //    if (rem % 2 != 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine("Your odd count is = "+count);
            #endregion
            #region lopps - Q2 - Q8
            //Console.WriteLine("Enter your number ");
            //uint number = uint.Parse(Console.ReadLine());
            //uint sum = 0;
            //while (number!=0)
            //{
            //    uint rem = number % 10;
            //    number = number / 10;
            //    if (rem % 2 != 0)
            //    {             
            //        sum = sum + rem;
            //    }
            //}
            //Console.WriteLine("Your sum of odd digits = "+sum);
            #endregion
            #region loops - Q2 - Q9
            //Console.WriteLine("Enter your number ");
            //uint number = uint.Parse(Console.ReadLine());
            //uint sum = 0;
            //while (number != 0)
            //{
            //    uint rem = number % 10;
            //    number = number / 10;
            //    if (rem % 2 == 0)
            //    {
            //        sum = sum + rem;
            //    }
            //}
            //Console.WriteLine("Your sum of digit is = "+sum);
            #endregion
            #region loops - Q2 - Q10
            //Console.WriteLine("Enter your number");
            //uint number = uint.Parse(Console.ReadLine());
            //uint rem = 0;
            //while (number > 0)
            //{
            //    rem = number % 10;
            //    number = number / 10;
            //    Console.WriteLine("You last digit is = " + rem);
            //    break;
            //}
            #endregion
            #region loops - Q2 - Q11
            //Console.WriteLine("Enter your number ");
            //uint number = uint.Parse(Console.ReadLine());
            //uint rem = 0;
            //while (number > 0)
            //{
            //    rem = number % 10;
            //    number = number / 10;
            //}
            //Console.WriteLine("Your first digit is = " + rem);
            #endregion
            #region loops - Q2 - Q12
           // Console.WriteLine("Enter your number");
           // uint number = uint.Parse(Console.ReadLine());
           // uint rem = 0;
           // uint output = number % 10;
           //// Console.WriteLine("Your last digit is = " + number % 10);
           // while (number > 0)
           // {
           //     rem = number % 10;
           //     number = number / 10;
           // }
           // if (rem == output)
           // {
           //     Console.WriteLine("true");
           // }
           // else
           // {
           //     Console.WriteLine("false");
           // }
           //// Console.WriteLine("Your first digit is = " + rem);
            #endregion
            #region loops - Q2 - Q13
            //Console.WriteLine("Enter your number ");
            //uint number = uint.Parse(Console.ReadLine());
            //uint max = 0;
            //while (number != 0)
            //{
            //    uint rem = number % 10;
            //    if (rem > max)
            //    {
            //        max = rem;
            //    }
            //    number = number / 10;
            //}
            //Console.WriteLine(max);
            #endregion
            #region loops - Q2 - Q14
            //Console.WriteLine("Enter your number");
            //uint number = uint.Parse(Console.ReadLine());
            //uint max = 0;
            //uint position = 0;
            //uint reminder = 0;
            //uint sum = 0;
            //while (number != 0)
            //{
            //    reminder = number % 10;
            //    number = number / 10;
            //    if (reminder > max)
            //    {
            //        max = reminder;
            //        position = sum;
            //    }
            //    sum++;
            //}
            //Console.WriteLine(Math.Pow(10, position) + "s");
            #endregion
            #region loops - Q2 - Q15
            //Console.WriteLine("Enter your number");
            //uint number = uint.Parse(Console.ReadLine());
            //uint mini = 9;
            //uint reminder = 0;
            //while (number != 0)
            //{
            //    reminder = number % 10;
            //    if (reminder < mini)
            //    {
            //        mini = reminder;
            //    }
            //    number = number / 10;
            //}
            //Console.WriteLine(mini);



            //Console.WriteLine("Enter the number : ");
            //int number = int.Parse(Console.ReadLine());

            //int min = 9;
            //int reminder = 0;

            //while (number != 0)
            //{
            //    reminder = number % 10;
            //    number = number / 10;

            //    if (reminder < min)
            //    {
            //        min = reminder;

            //    }
            //    Console.WriteLine(min);

            //}





            #endregion
            #region loops - Q2 - Q16
            //Console.WriteLine("Enter your number");
            //uint number = uint.Parse(Console.ReadLine());
            //uint min = 9;
            //uint position = 0;
            //uint reminder = 0;
            //uint sum = 0;
            //while (number != 0)
            //{
            //    reminder = number % 10;
            //    number = number / 10;
            //    if (reminder < min)
            //    {
            //        min = reminder;
            //        position = sum;
            //    }
            //    sum++;
            //}

            //Console.WriteLine(Math.Pow(10, position) + "s");
            #endregion
            #region loops - Q2 - Q17
            //Console.WriteLine("Enter your number ");
            //uint reverse = 0;
            //uint rem = 0;
            // uint number = uint.Parse(Console.ReadLine());
            // while (number != 0)
            // {
            //     rem = number % 10;
            //     number = number / 10;
            //     reverse = reverse * 10 + rem;
            // }
            // Console.WriteLine("Your reverse number is = "+reverse);
            #endregion
            #region loops - Q2 - Q18
            //Console.WriteLine("Enter your number");
            //uint number = uint.Parse(Console.ReadLine());
            //uint rem = 0;
            //uint sum = 0;
            //uint output = 0;
            //while (number != 0)
            //{
            //    rem = number % 10;
            //    number = number / 10;
            //    sum = rem + sum;
            //    output = sum;
            //    if (output > 9)
            //    {
            //        rem = output % 10;
            //        output = output / 10;
            //        output = output + rem;
            //    }
            //}
            //Console.WriteLine(output);
            #endregion
            #region loops - Q2 - Q19
           // Console.WriteLine("Enter your number");
           // int number = int.Parse(Console.ReadLine());
           // int rem = 0;
           // int temp = number;
           //int output = 0;
           // while (number != 0)
           // {
           //     temp = number;
           //     rem = number % 10;
           //     number = number / 10;
           //     output += temp % rem;
           // }
           // if (output == 0)
           // {
           //     Console.WriteLine("true");
           // }
           // else 
           // {
           //     Console.WriteLine("false");
           // }  
            #endregion
            #region loops - Q2 - Q20
            //Console.WriteLine("Enter your number");
            //int number = int.Parse(Console.ReadLine());
            //int rem = 0;
            //Console.WriteLine("Enter your divisible number");
            //int k = int.Parse(Console.ReadLine());
            //int temp = number;
            //int output = 0;
            //while (number != 0)
            //{
            //    temp = number;
            //    rem = number % 10;
            //    number = number / 10;
            //    output += temp % k;
            //}
            //if (output == 0)
            //{
            //    Console.WriteLine("true");
            //}
            //else
            //{
            //    Console.WriteLine("false");
            //}
            #endregion
            #region loops - Q2 - Q21
            //Console.WriteLine("Enter your number");
            //uint number = uint.Parse(Console.ReadLine());
            //uint last_num = (uint)number % 10;
            //uint rem = 0;
            //while (number != 0)
            //{
            //    rem = number % 10;
            //    number = number / 10;
            //}
            //if (last_num == rem)
            //{
            //    Console.WriteLine("This number is palindrome");
            //}
            //else
            //{
            //    Console.WriteLine("This number is not palindrome");
            //}
            #endregion
            #region loops - Q2 - Q22
            //Console.WriteLine("Enter your number");
            //uint number = uint.Parse(Console.ReadLine());
            //uint number1 = number;
            //uint reverse = 0;
            //while (number != 0)
            //{
            //    uint rem = number % 10;
            //    number = number / 10;
            //    reverse = reverse * 10 + rem;
            //}
            //if (reverse == number1)
            //{
            //    Console.WriteLine("This number is palindrome");
            //}
            //else
            //{
            //    Console.WriteLine("This number is not palindrome");
            //}

            #endregion
            #region loops - Q2 - Q23
            //Console.WriteLine("Enter your number");
            //int number = int.Parse(Console.ReadLine());
            //int max = 0;
            //for (int i = 9; i >= 0; i--)
            //{
            //    int temp = number;
            //    while (temp != 0)
            //    {
            //        int rem = temp % 10;
            //        if (rem == i)
            //        {
            //            max = max * 10 + i;
            //        }
            //        temp = temp / 10;
            //    }
            //}
            //Console.WriteLine(max);
            #endregion
            #region loops - Q2 - Q24
            //Console.WriteLine("Enter your number");
            //int number = int.Parse(Console.ReadLine());
            //int min = 0;
            //for (int i = 0; i <= 9; i++)
            //{
            //    int temp = number;
            //    while (temp != 0)
            //    {
            //        int rem = temp % 10;
            //        if (rem == i)
            //        {
            //            min = min * 10 + i;
            //        }
            //        temp = temp / 10;
            //    }
            //}
            //Console.WriteLine(min);
            #endregion
        }
    }
}