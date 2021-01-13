﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace GsPL
{
    static class Library
    {
        public static string[] lines = new string[1];
        public static string[,] ints;
        public static string[,] strings;

        public static void AddValue(ref string[] arr, string value)
        {
            string[] newArr = new string[arr.Length + 1];

            for (int i = 0; i < arr.Length; i++)
                newArr[i] = arr[i];

            newArr[newArr.Length - 1] = value;
            arr = newArr;
        }
        public static void AddValuesTypes(ref string[,] arr, string name, string value)
        {
            string[,] newArr = new string[arr.Length + 1, 2];

            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i, 0] = arr[i, 0];
                newArr[i, 1] = arr[i, 1];
            }
            newArr[newArr.Length - 1, 1] = value;
            newArr[newArr.Length - 1, 0] = name;
            arr = newArr;
        }
    }
}
