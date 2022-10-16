using System;
using System.Linq;
using System.Collections.Generic;

namespace DCPractice3
{
    class Program
    {
        static void Main(string[] args)
        {
            //List1

            List<int> intList = new List<int>();
            List<string> stringList = new List<string>();
            int tmp = 0;

            string convertion = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] convertionMap = convertion.ToCharArray();
            int[] convertionCount = new int[convertionMap.Length];

            for(int i=1;i<10;i++)
            {
                for(int j=1; j<10;j++)
                {
                    intList.Add(i * j);
                }
            }

            //foreach value in List1 to generate List2

            foreach (int num in intList)
            {
                tmp = num % convertionMap.Length;
                stringList.Add(convertionMap[tmp].ToString());
            }

            foreach(string str in stringList)
            {
                Console.Write(str + " ");
            }

            //count strings in List2 to generate int[] count

            foreach(string str in stringList)
            {
                for(int i =0;i< convertionMap.Length;i++)
                {
                    if (convertionMap[i].ToString() == str)
                        convertionCount[i]++;
                }
            }

            Console.WriteLine();
            for(int i = 0;i< convertionCount.Length;i++)
            {
                Console.WriteLine("{0} = {1}" , convertionMap[i] , convertionCount[i]);
            }

            tmp = 0;

            foreach(int i in convertionCount)
            {
                tmp += i;
            }

            Console.WriteLine("\n" + tmp);
        }

       // public static List<string> GetResultString(List<int> outputList , string convertion)
        //{

        //}
    }
}
