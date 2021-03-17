using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] keys;
        TValue[] values;

        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public int Length { get; internal set; }

        public void Add(TKey Id, TValue Name)
        {
            TKey[] tempKey = keys;
            TValue[] tempValue = values;

            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                keys[i] = tempKey[i];                
            }

            keys[keys.Length - 1] = Id;

            for (int i = 0; i < tempValue.Length; i++)
            {
                values[i] = tempValue[i];
            }
                        
            values[values.Length - 1] = Name;
        }
        
    }    
}
