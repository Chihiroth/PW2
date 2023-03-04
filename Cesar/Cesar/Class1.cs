using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cesar
{
    class Cesar
    {
        private static string alph = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        private string text;
        public Cesar(string text)
        {
            this.text = text;
        }
        public static string Encryption(string text)
        {
            var res = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
                for (int j = 0; j < alph.Length; j++)
                    if (text[i] == alph[j]) res.Append(alph[(j + 3) % alph.Length]);

            return res.ToString();
        }
        public static string Decryption(string crypt)
        {
            var res = new StringBuilder();
            for (int i = 0; i < crypt.Length; i++)
                for (int j = 0; j < alph.Length; j++)
                    if (crypt[i] == alph[j]) res.Append(alph[(j - 3 + alph.Length) % alph.Length]);

            return res.ToString();
        }
    }
}

