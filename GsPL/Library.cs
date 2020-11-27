using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace GsPL
{
    static class Library
    {
        public static int V = 100;
        public static string[] lines = new string[V];
        public static string[,] ints = new string[V, 2];
        public static string[,] strings = new string[V, 2]; 
    }
}
