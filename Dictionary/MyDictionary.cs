using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    
    class MyDictionary<T,V>
    {
        T[] keys;
        V[] values;
        public MyDictionary()
        {
            keys = new T[0];
            values = new V[0];
        }

        public void Add1(T key,V value)
        {
            T[] tempArray_Key = keys;
            V[] tempArray_Value = values;

            keys = new T[keys.Length + 1];
            for (int i = 0; i < tempArray_Key.Length; i++)
            {
                keys[i] = tempArray_Key[i];
            }

            keys[keys.Length - 1] = key;

            values = new V[values.Length + 1];
            for (int i = 0; i <tempArray_Value.Length; i++)
            {
                values[i] = tempArray_Value[i];
            }

            values[values.Length - 1] = value;
        }
       
    }
}
