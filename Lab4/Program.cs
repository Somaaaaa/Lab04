using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. feladat
            /*
            int letters = 0;
            int numbers = 0;
            int countVowels = 0;
            char[] vowels = {'a','e','i','o','u'}

            string testString = "sad2e32jfásfkhfsb294ncá32ölg9ó54ldgüh8h54őkfdbhbáü659j";
            char[] testCharArray = testString.ToCharArray();
            foreach(var c in testCharArray)
            {
                if (char.IsDigit(c)) letters++;
                if (char.IsLetter(c)) numbers++;
                foreach(var c in vowels)
                {
                    if(char.toLower(c) == vowel) countVowels++;
                }
            }
            Console.WriteLine(letters);
            Console.WriteLine(numbers);
            */
            #endregion
            #region 2. feladat
            /*
            string setence = "Géza kék az ég.";
            string formatedSetence = setence.Substring(0, setence.Length - 1).Replace(" ", "").ToLower();
            string reversedSetence = "";
            for(int i = formatedSetence.Length-1; i>=0; i--)
            {
                reversedSetence += formatedSetence[i].ToString(); ;
            }
            if(formatedSetence == reversedSetence) Console.WriteLine("Palidrom");
            else Console.WriteLine("Nem palidrom");
            */
            #endregion
            #region 3. feladat
            /*
            string example = "a a B c-1 2 3";
            string result = "";
            result = example.Trim().Replace(" ", "").Replace("-", "").ToUpper();
            result = string.Concat(example.Substring(0, 2)," ", example.Substring(2, 2),"-",example.Substring(4, 3));
            Console.WriteLine(result);
            */
            #endregion
            #region 4. feladat
            /*
            Random rnd = new Random();
            string answer = "";
            string neptunKod = "JQ8Z8Z";
            int attempts = 0;
            do
            {
                answer = "";
                for (int i = 0; i < 7; i++)
                {
                    if (i == 0)
                    {
                        answer += (char)rnd.Next((int)'A', (int)'Z');
                    }
                    else
                    {
                        if (rnd.Next(0, 2) % 2 == 0)
                        {
                            answer += (char)rnd.Next((int)'A', (int)'Z');
                        }
                        else
                        {
                            answer += (char)rnd.Next((int)'1', (int)'9');
                        }
                    }
                }
                attempts++;
                Console.WriteLine(answer);
            } while (answer != neptunKod);
            */
            #endregion
            #region  7. feladat
            /*
            Random rnd = new Random();
            string baseString = "Well, a Big Mac's a Big Mac, but they call it le Big-Mac";
            char[] charbaseString = baseString.ToCharArray();
            string result = "";
            foreach(var c in charbaseString)
            {
                if (rnd.Next(0, 2) == 0) result += char.ToUpper(c);
                else result += char.ToLower(c);
            }
            Console.WriteLine(result);
            */
            #endregion
            #region 8. feladat
            /*
            string testString = "Vincent;Vega;Vince\nMarsellus;Wallace;Big Man\nWinston;Wolf;The Wolf";
            string[] sorok = testString.Split('\n');
            int sorokSzama = sorok.Length;
            int oszlopokSzama = sorok[0].Split(';').Length;
            string[] oszlopok = new string[oszlopokSzama];
            string[,] eredmeny = new string[sorokSzama,oszlopokSzama];

            for(int i = 0; i < sorokSzama; i++)
            {
                oszlopok = sorok[i].Split(';');
                for(int  j = 0; j < oszlopok.Length; j++)
                {
                    eredmeny[i,j] = oszlopok[j];
                }
            }
            for(int i = 0;i< eredmeny.GetLength(0); i++)
            {
                for(int j = 0; j< eredmeny.GetLength(1); j++)
                {
                    Console.Write(eredmeny[i,j] + "\t");
                }
                Console.Write   ("\n");
            }
            */
            #endregion
            Console.ReadKey();
        }
    }
}
