﻿using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.RyabtsevNE.Sprint4.Task0.V16.Lib
{
    public class DataService : ISprint4Task0V16
    {
        public int GetMultEvenArrEl(int[] array)
        {
            int multi = 1;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 == 0)
                {
                    multi *= array[i];
                }
            }
            return multi;
        }
    }
}
