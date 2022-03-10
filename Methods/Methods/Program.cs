using System;

namespace Methods
{
    class Program
    {
        #region Tasks
        static void Main(string[] args)
        {
            int[] number = { 2, 5, 46, 24, 79, 110, 500, 3, 7, 50 };
            Array(number);

            //Console.WriteLine("Enter anything number: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //Third(num);

        }

        public static int Array(int[] number)
        {

            int max = number[0];

            //first way
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] > max)
                    max = number[i];
            }


            //second way
            //foreach (int maxNum in number)
            //{
            //    if (maxNum > max)
            //        max = maxNum;

            //}


            Console.WriteLine("Maximal number: " + max);

            return max;
        }
        public static int Third(int num)
        {
            int tempVar = 3;
            int newNum = num;
           

            while(num > 0)
            {
                int remind = num % 10;
                tempVar *= 10;
                num /= 10;
              
            }
            int total = tempVar + newNum;
            Console.WriteLine("New number: " +total);
            return total;
        }
        
        #endregion
    }
}
