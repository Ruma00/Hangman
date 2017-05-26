using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hangman_release
{
    public class Class2
    {
        public string choosing_word(int theme)
        {
            string word = String.Empty;
            string path = "text topics//" + theme.ToString() + ".txt";
            Random rand = new Random();
            StreamReader reader = new StreamReader(path, Encoding.GetEncoding(1251));

            int i = rand.Next(1, 10), a = 0;
            while (a < i)
            {
                word = reader.ReadLine();
                a++;
            }
            reader.Close();
            return word;
        }
    }
}
