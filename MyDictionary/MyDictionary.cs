using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] id;
        TValue[] isim;

        public MyDictionary()
        {
            id = new TKey[0];
            isim = new TValue[0];
        }

        public int Length { get; internal set; }

        public void Add(TKey Id, TValue Name)
        {
            TKey[] tempKey = id;
            TValue[] tempValue = isim;

            id = new TKey[id.Length + 1];
            isim = new TValue[isim.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                id[i] = tempKey[i];                
            }

            id[id.Length - 1] = Id;

            for (int i = 0; i < tempValue.Length; i++)
            {
                isim[i] = tempValue[i];
            }
                        
            isim[isim.Length - 1] = Name;
        }

        public int Count
        {
            get { return isim.Length; }
        }

        public void Listele()
        {
            for (int i = 0; i < isim.Length; i++)
            {
                Console.WriteLine("Sıra: " + id[i] +" "+ "Meyve adı: " + isim[i]);
            }
        }
    }    
}
