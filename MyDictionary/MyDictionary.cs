using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    public class MyDictionary<TKey, TVal>
    {
        TKey[] key;
        TVal[] value;
        TKey[] tempKey;
        TVal[] tempVal;
        public MyDictionary()
        {
            key = new TKey[0];
            value = new TVal[0];
        }
        public void Add(TKey keys,TVal values)
        {
            tempKey = key;
            tempVal = value;
            key = new TKey[key.Length + 1];
            value = new TVal[value.Length + 1];
            for (int i = 0; i < tempKey.Length; i++)
            {
                key[i] = tempKey[i];
            }
            key[key.Length - 1] = keys;
            for (int i = 0; i < tempVal.Length; i++)
            {
                value[i] = tempVal[i];
            }
            value[value.Length - 1] = values;

           
        }
        
        public void Listele()
        {
            for (int i = 0; i < key.Length; i++)
            {
                Console.WriteLine(key[i]+ " "+ value[i] );
            }
        }
    }
}
