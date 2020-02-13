using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codes1.coding_one
{
    class slogan
    {
        public string Code(string key,string text)
        {
            string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            string new_alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";


            key = new string(key.Distinct().ToArray());//удаляем повторяющиеся символы

            for (int i = 0; i < key.Length; i++)
                {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (alphabet[j] == key[i])
                    {
                        new_alphabet = new_alphabet.Replace(key[i],' ');    
                    }
                }
            }

            new_alphabet = key+new_alphabet;

            new_alphabet = new_alphabet.Replace(" ", "");
            string code_text = "";

            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < new_alphabet.Length; j++)
                {
                    if (text[i] == alphabet[j])
                        code_text += new_alphabet[j];
                }
            }          
            return code_text;
        }


        
        public string GetSloganAlf(string key, string text)
        {
            string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            string new_alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";


            key = new string(key.Distinct().ToArray());//удаляем повторяющиеся символы

            for (int i = 0; i < key.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (alphabet[j] == key[i])
                    {
                        new_alphabet = new_alphabet.Replace(key[i], ' ');
                    }
                }
            }

            new_alphabet = key + new_alphabet;

            new_alphabet = new_alphabet.Replace(" ", "");
            return new_alphabet;
        }




    }
}
