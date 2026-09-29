using System;
using System.Collections.Generic;
using System.Text;

//И-307А Дудников Никита Игоревич

namespace homework
{
    public class MyMath
    {
        public double sum(int[] array)
        {
            int result = 0;
            foreach (var number in array)
            {
                result += number;
            }
            return result;
        }

        public double max(int[] array)
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

        public double min(int[] array)
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

        public double count(int[] array)
        {
            return array.Length;
        }
    }
}