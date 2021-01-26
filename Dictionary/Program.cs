using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MyDictionary<string, long> persons = new MyDictionary<string, long>();
            persons.Add1("Kerem Yılmaz",12345678901);
            persons.Add1("Hilal Tosun", 78796324504);

            Console.WriteLine("Kişi kaydı oluşturulmuştur.");
        }
    }
}
