using System;
using System.Linq;
namespace Stringg
{
    class Program
    {
        static void SortByAlfavit(string massege)
        {
            
            string[] words = massege.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Array.Sort(words, (x, y) => x.CompareTo(y));
            Console.WriteLine($"First->{words[0]}");
            Console.WriteLine($"Last->{words[words.Length-1]}");
        }
        static void FindMax(string massege)
        {
            string[] words = massege.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(words, (x, y) => x.Length.CompareTo(y.Length));
            Console.WriteLine($"Min->{words[0]}");
            Console.WriteLine($"Max->{words[words.Length-1]}");
        }
        static void FindSumbol(string massege,char sumbol)
        {
            int lastInd=-1;
            int index = massege.IndexOf(sumbol);
            while (index != -1)
            {
                lastInd = index;
                Console.WriteLine(index);
                index = massege.IndexOf(sumbol, index + 1);
            }
            if (lastInd != -1&&lastInd!=massege.Length-1)
            {
                massege=massege.Remove(lastInd+1);
            }

            Console.WriteLine(massege.Replace(sumbol,char.ToUpper(sumbol)));
        }
        static void DelSumbol(string massege, char[] sumbol)
        {

            for (int i = 0; i < sumbol.Length; i++)
            {
                for (int j = 0; j < massege.Length; j++)
                {
                    if (massege[j] == sumbol[i])
                    {
                        massege=massege.Replace(sumbol[i], ' ');
                    }
                }
            }
            Console.WriteLine(massege);
            
        }
        static void PrintStars(int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write('*');
            }
            Console.WriteLine();
        }
        static void Diagram(string massege)
        {

            int count=0;
            for (int i = 'a'; i < 'z'; i++)
            {
                for (int j = 0; j < massege.Length; j++)
                {
                    if (massege[j] == (char)i)
                    {
                        ++count;
                    }
                }
                
                
                Console.Write($"{(char)i} [{count}]");
                PrintStars(count);
                count = 0;
            }
           
            
        }
        static void FindWords(string massege, string[] wordsC)
        {
            string[] words = massege.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int count = 0;
            for (int i = 0; i < wordsC.Length; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    if (words[j] == wordsC[i])
                    {
                        ++count;
                    }
                }
                Console.WriteLine($"{wordsC[i]}  count={count}");
                count = 0;
            }
        }
        static void Main(string[] args)
        {
            string[] wordsC = new string[] { "Split", "Count", "Sort" };
            string Ctext = "Split Count Sort Split Sort";
            string newText = "I don’t know whether to delete this or rewrite it";
            string text = " Jeph stive Name zer";
            char[] sumbol = new char[] { 'a', 'e' };
            //SortByAlfavit(text);
            //FindMax(text);
            //FindSumbol(text, 'e');
            //DelSumbol(text, sumbol);
            //Console.WriteLine(newText);
            //Diagram(newText);
            FindWords(Ctext, wordsC);
        }
    }
}
