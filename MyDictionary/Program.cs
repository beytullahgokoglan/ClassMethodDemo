using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> bilgiler = new MyDictionary<string, string>();
            bilgiler.Add("Engin", "Demirog");
            bilgiler.Listele();
        }
    }
}
