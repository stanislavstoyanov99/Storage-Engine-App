﻿using System;

namespace StorageEngine
{
    public static class RandomExtensions
    {
        // Fisher-Yates algorithm
        public static void Shuffle<T> (this Random rnd, T[] array)
        {
            int n = array.Length;
            while (n > 1)
            {
                int k = rnd.Next(n--);
                T temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
        }
    }
}
