
using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictonary
{
    class Dictonary<TValue, TKey>
    {
        TValue[] values;
        TKey[] keys;

        public Dictonary()
        {
            values = new TValue[0];
            keys = new TKey[0];
        }

        public void Add(TValue val, TKey key)
        {
            TValue[] tempVals = values;
            TKey[] tempKeys = keys;


            values = new TValue[values.Length + 1];
            keys = new TKey[keys.Length + 1];

            for (int i = 0; i < tempVals.Length; i++)
            {
                values[i] = tempVals[i];
                keys[i] = tempKeys[i];


            }
            values[values.Length - 1] = val;
            keys[keys.Length - 1] = key;
        }
        public int Count
        {
            get { return values.Length; }
        }
    }
}