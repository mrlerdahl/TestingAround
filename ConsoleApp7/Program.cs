using System;
using System.Collections.Generic;

namespace ConsoleApp7
{
    class Program
    {
        //static List<int> MyList = new List<int>();
        //public static void FillValues()
        //{
        //    MyList.Add(1);
        //    MyList.Add(2);
        //    MyList.Add(3);
        //    MyList.Add(4);
        //    MyList.Add(5);
        //}

        //Rotating a string with one for loop
        public static string Rotate(string input)
        {
            string rotatedInput = string.Empty;
            int rotateAmount = input.Length - 2;
            for (int i = 0; i < input.Length; i++)
            {
                if(rotateAmount >= input.Length - 2 && rotateAmount < input.Length)
                {
                    rotatedInput += input[rotateAmount++];
                    continue;
                }
                
                
                if(rotateAmount == input.Length)
                {
                    rotateAmount = 0;
                }

                rotatedInput += input[rotateAmount++];
            }

            return rotatedInput;
        }

        //Rotating an array two loops
        public static string RotateTwo(string input)
        {
            string newString = string.Empty;
            int rotatePositionAmount = 5;

            for (int i = input.Length - rotatePositionAmount; i < input.Length; i++)
            {
                newString += input[i];
            }
            for (int i = 0; i < input.Length - rotatePositionAmount; i++)
            {
                newString += input[i];
            }

            return newString;
        }
        static void Main(string[] args)
        {
            //FillValues();
            //foreach (var i in Filter())
            //{
            //    Console.WriteLine(i);
            //}

            Console.WriteLine(Rotate("ABCDEfg"));
            Console.WriteLine(RotateTwo("ABCDEfg"));
        }

        //static IEnumerable<int> Filter()
        //{
            
        //    foreach (var i in MyList)
        //    {
        //        if( i > 3)
        //        {
        //            yield return i;
        //        }
        //    }
            
        //}
    }
}
