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

            for (int j = 0; j < alphabet.Length; j++)
            {
                for (int i = 0; i < key.Length; i++)
                {
                    if (alphabet[j] == key[i])
                    {
                        new_alphabet = new_alphabet.Remove(j, 1);
                        new_alphabet += " ";
                    }
                }
            }

            new_alphabet = key+new_alphabet;
            new_alphabet = new_alphabet.Remove(alphabet.Length);
            string code_text = "";
           
            for(int j=0;j<new_alphabet.Length;j++)
             {
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == alphabet[j])
                    code_text += new_alphabet[j];
                    break;
                }
            }          
            return code_text;
        }
    }
}
