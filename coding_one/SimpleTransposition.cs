using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codes1.coding_one
{
    class SimpleTransposition
    {
        public string Code(string str, string tabletranp)
        {
            str = " " + str;
            tabletranp = " " + tabletranp;
            string code = "";

            string[] array1 = new string[str.Length];

            for (int i = 1; i < str.Length; i++)
            {
               array1[int.Parse(tabletranp[i].ToString())] = str[i].ToString(); 
               
            }

            return String.Join("",array1);
        }
    }
}
