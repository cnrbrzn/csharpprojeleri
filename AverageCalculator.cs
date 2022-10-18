using System;

namespace ortalamahesaplama
{
    public class AvaregeCalculator
    {
        public int[] Fibonacci(int value)
        {
            int[] fArray = new int[value];
            int firstNumber =1;
            int secoundNumber=1;
            int temp;
            fArray[0]=firstNumber;
            fArray[1]=secoundNumber;
            for (int i = 2; i < value; i++)
            {
                temp = secoundNumber;
                secoundNumber = firstNumber + secoundNumber;
                firstNumber = temp;
                fArray[i]=secoundNumber;
            }
            return fArray;
        }
    }
}