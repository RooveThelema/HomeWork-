using System;
using System.Collections.Generic;
using System.Text;

//И-307А Дудников Никита Игоревич

namespace homework
{
    public class MyMath
    {
        public int sum(int[] array)
        {
            int result = 0;
            foreach (var number in array)
            {
                result += number;
            }
            return result;
        }

        public int max(int[] array)
        {
            var result = array[0];
            foreach (var number in array)
            {
                if (number > result)
                {
                    result = number;
                }
            }
            return result;
        }

        public int min(int[] array)
        {
            var result = array[0];
            foreach (var number in array)
            {
                if (number < result)
                {
                    result = number;
                }
            }
            return result;
        }

        public int count(int[] array)
        {
            return array.Length;
        }
    }
}