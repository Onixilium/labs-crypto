using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codes1.coding_one
{
    class Caesar
    {
        string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        public string code(string text,int key)
        {
            string code = "";
            for (int i = 0; i < text.Length; i++)
            {
                var c = text[i];
                var index = alphabet.IndexOf(c);
                if (index < 0)
                {
                    code += c.ToString();
                }
                else
                {
                    var codeIndex = (alphabet.Length + index + key) % alphabet.Length;
                    code += alphabet[codeIndex];
                }
            }

            return code;
        }

    }
}
