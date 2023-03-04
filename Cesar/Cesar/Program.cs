using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст для перевода в шифр полностью в нижнем регистре");
            string text = Convert.ToString(Console.ReadLine());
            Cesar CaesarCipher = new Cesar(text);
            Console.WriteLine(Cesar.Encryption(text));
            string crypt = Cesar.Encryption(text);
            Console.WriteLine(Cesar.Decryption(crypt));
            Console.ReadKey(true);
        }
    }
}
