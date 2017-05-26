using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_release
{
    public class Class1
    {
        //static char []word1;
        public string word1 = String.Empty;
        //public static char []word2;
        public string word2;
        public int x = 0;

        public void setWord(string ch)
        {
            //word1 = new string(ch.ToCharArray());
            word1 = ch;
            word2 = word1;

            StringBuilder str = new StringBuilder(word1);

            for (int i = 0; i < word1.Length; i++)
            {
                str[i] = ' ';
            }

            word2 = str.ToString();
        }

        public string getWord(char ch)
        {
            x = 0;

            StringBuilder str = new StringBuilder(word2);
            //char[] s = word1.ToCharArray();
            for (int i = 0; i < word1.Length; i++)
            {
                if (word1[i] == ch)
                {
                    //word2.ToCharArray()[i] = ch;
                    str[i] = ch;
                    x = 1;
                }
            }

            word2 = str.ToString();

            return word2;
        }

        public bool rx()
        {
            if (x == 1)
                return true;
            else
                return false;
        }
    }
}
