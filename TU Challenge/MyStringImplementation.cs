using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyStringImplementation
    {
        public static string BazardString(string input)
        {
            string result = "";
            string temp = "";
            for(int i = 0; i < input.Length; i++)
            {
                if(i%2== 0) result += input[i]; 
                else temp += input[i];
            }
            result += temp;
            return result;
        }

        public static bool IsNullEmptyOrWhiteSpace(string input)
        {
            bool check = false;
            if (input == null || input == "") return true;
            foreach (char c in input)
            {
                if (c != ' ')
                {
                    check = false;
                }
                else check = true;
            }
            if(check) return true;
            else return false;
        }

        public static string MixString(string a, string b)
        {
            if (a == null || a == "" || b == null || b == "") throw new ArgumentException();
            string mixed = "";
            if(a.Length > b.Length)
            {
                for(int i = 0; i < a.Length; i++) 
                {
                    mixed += a[i];
                    if (i < b.Length) mixed += b[i];
                }
            }
            else
            {
                for (int i = 0; i < b.Length; i++)
                {
                    if(i < a.Length) mixed += a[i];
                    mixed += b[i];
                }
            }
            return mixed;
        }

        public static string Reverse(string a)
        {
            string result = "";
            for(int i = a.Length; i > 0; i--)
            {
                result += a[i-1];
            }
            return result;
        }

        public static string ToCesarCode(string input, int offset)
        {
            input  = ToLowerCase(input);
            string result = "";
            foreach(char c in input) 
            {
                int convToASCII = c;
                char convFromASCII = (char)convToASCII;
                if (convToASCII != 32)
                {
                    convToASCII += offset;
                    if(convToASCII > 122)
                    {
                        convToASCII -= offset;
                        int diff = 123 - convToASCII;
                        convToASCII = 97 + (offset - diff);
                    }
                    convFromASCII = (char)convToASCII;
                }
                result+= convFromASCII;
            }
            return result;
        }

        public static string ToLowerCase(string a)
        {
            string lower = "";
            foreach(char c in a)
            {
                int convToASCII = c;
                char convToChar = c;
                if(convToASCII >= 65 && convToASCII <= 90)
                {
                    convToASCII += 32;
                    convToChar = (char)convToASCII;
                    lower += convToChar;
                }
                else if (convToASCII >= 192 && convToASCII <= 221)
                {
                    convToASCII += 32;
                    convToChar = (char)convToASCII;
                    lower += convToChar;
                }
                else { lower += convToChar; }
            }
            return lower;
        }

        public static string UnBazardString(string input)
        {
            string result = "";
            int correct = input.Length/2;
            for (int i = 0; i < input.Length; i++)
            {
                if(i < input.Length / 2)
                {
                    result += input[i];
                    result += input[i+correct];
                }
            }
            return result;
        }

        public static string Voyelles(string a)
        {
            string voy = "";
            bool alreadyIn = true;
            bool stop = false;
            a = ToLowerCase(a);
            foreach (char c in a) 
            { 
                if(c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'y')
                {
                    if(voy.Length > 0)
                    {
                        foreach (char c2 in voy)
                        {
                            if (c == c2)
                            {
                                alreadyIn = true;
                                stop = true;
                            }
                            else if(stop == false) alreadyIn = false;
                        }
                        if (alreadyIn == false) voy += c;
                    }
                    else voy += c;
                }
            }
            return voy;
        }
    }
}
