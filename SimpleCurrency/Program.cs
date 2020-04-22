using System;

namespace SimpleCurrency
{
    class Program
    {
        static void Main(string[] args)
        {
            Backend proccess = new Backend(new CurrencyOnStart());
            proccess.StartUp();
        }
        class CurrencyOnStart : OnLoad
        {
            public void Header()
            {
                Console.WriteLine("============= Program Sederhana Konversi Mata Uang =============");
            }
            public void FormTittle(string message)
            {
                Console.Write(message);
            }
            public void TittleMenu(string message)
            {
                Console.WriteLine(message);
            }
        }
    }
}
