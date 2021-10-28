using System;

namespace cs_pracrics
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string s1 = "a";
            string s2 = null;

            string s3 = new String('a', 6); //result - 'aaaaaa'
            string s4 = new String(new char[]{'w','o','r','l', 'd'});
            */


            /*
            string s = "МИРЭА";
            Console.WriteLine(s[1]); //И
            //1
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }
            //2
            foreach(char q in s)
            {
                Console.WriteLine(q);
            }
            string s0 = null;
            for (int i = 0; i < s.Length; i++)
            {
                s0 += s[i] + " ";
            }
            Console.WriteLine(s0);
            */


            /*Конкатенация №1
            string a = "Hello";
            string b = "World";
            string c = a + " " + b;
            string s = String.Concat(c, " !!!");

            Console.WriteLine(s);
            */


            /*Конкатенация №2
            string s1 = "apple";
            string s2 = "a day";
            string s3 = "keeps";
            string s4 = "a doctor";
            string s5 = "away";
            string[] values = new string[] { s1, s2, s3, s4, s5 };

            string s6 = String.Join(" ", values);
            Console.WriteLine(s6);
            */


            //Сравнение строк
            /*
            string s1 = null;
            s1 = Convert.ToString(Console.ReadLine());
            string s2 = null;
            s2 = Convert.ToString(Console.ReadLine());
            int result = String.Compare(s1, s2);
            if (result < 0)
            {
                Console.WriteLine("1 -> 2");
                string s3 = s1 + " " + s2;
                Console.WriteLine(s3);
            }
            else if(result > 0) 
            {
                Console.WriteLine("2 -> 1");
                string s3 = s2 + " " + s1;
                Console.WriteLine(s3);
            }
            else
            {
                Console.WriteLine("1 == 2");
                string s3 = s2 + " " + s1;
                string s4 = s1 + " " + s2;
                Console.WriteLine($"{s3} ili {s4}");
                
            }
            */


            //Поиск в строке
            /*
            string s1 = "Hello World";
            char s2 = 'o';
            int index = s1.IndexOf(s2);
            
            Console.WriteLine(index);

            string s3 = "Wor";
            int index2 = s1.IndexOf(s3);

            Console.WriteLine(index2);

            int y = 0;
            for (int i = s1.Length-1; i >= 0; i--)
            {
                if (s1[i] == 'o')
                {
                    y = i;
                    break;
                } 
            }
            Console.WriteLine(y);
            */


            //Обрезка строки Trim
            /*
            string text = " hello world ";
            text = text.Trim(); //hello world
            text = text.Trim(new char[] {'h', 'e', 'l', 'o', ' '}); //world
            Console.WriteLine(text);
            */


            //Обрезка строки Substring
            /*
            string text = "lovesomemama";
            text = text.Substring(2); // vesomemama
            text = text.Substring(0, text.Length - 2); //vesomema

            Console.WriteLine(text);
            */


            //Разделение строк (Split)
            /*
            string text = "that's why we fell apart";
            string[] words = text.Split(new char[] { ' ' });

            foreach (string q in words)
            {
                Console.WriteLine(q);
                //that's
                //why
                //we
                //fell
                //apart
            }
            */


            //Вставка
            /*
            string text1 = "we can overcome it";
            string text2 = "simply ";

            text1 = text1.Insert(7, text2);
            Console.WriteLine(text1);
            */


            //Удаление строк (Remove)
            /*
            string text = "What a beitiful day!";
            int a = text.Length-1;
            text = text.Remove(a);
            Console.WriteLine(text); // What a beitiful day
            */


            //Замена (Replace)
            /*
            string text = "what a beautiful day!";

            text = text.Replace("a beautiful", "an awful");
            Console.WriteLine(text);
            */


            //Смена регистра (ToUpper() / ToLower())
            /*
            string text = "You know, sometimes i can't simply realize what you're talking about...";

            Console.WriteLine(text.ToLower());
            Console.WriteLine(text.ToUpper());

            */
        }
    }
}
