using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace Lern_sharp
{
    class Program
    {
        //public static bool IsValidWalk(string[] walk)
        //{
        //    int SN = (from i in walk where i == "n" || i == "e" select i).Count();
        //    int WE = (from i in walk where i == "s" || i == "w" select i).Count();

        //    if (walk.Length == 10 && SN - WE == 0)
        //        return true;
        //    else 
        //        return false;
        //}
        //public static string Problem(String a)
        //{
        //    if (int.TryParse(a, out int result))
        //    {
        //        result = result * 50 + 6;
        //        return Convert.ToString(result);

        //    }
        //    else
        //    {
        //        return "Error";
        //    }
        //}
        //public static string bonus_time(int salary, bool bonus)
        //{
        //    string z = bonus == true ? "$" + Convert.ToString(salary) + "0" : Convert.ToString(salary) ;
        //    return z;
        //}
        //public static object FirstNonConsecutive(int[] arr)
        //{
        //    var count = arr[1] - arr[0];
        //    for (int i = 1; i < arr.Length; i++)
        //    {
        //        if(arr[i-1] + count != arr[i])
        //        {
        //            return arr[i];
        //        }
        //    }
        //    return null;
        //}
        public static int Grow(int[] x)
        {
            return x.Aggregate((a, b) => a * b);
        }
        //public static int Maps(int[] x)
        public static int[] Maps(int[] x)
        {
            return (from i in x where i < 10000 select i * 2).ToArray();
        }
        public static string BreakCamelCase(string str) => new Regex("([A-Z])").Replace(str, " $1");

        static void Main(string[] args)
        {

            
            string ghj = "cacoiToBomjGuliatPoUlitse";
            string kok = "kak1dela2";
            var regexx = new Regex("([1-9])").Replace(kok, " zaika ");
            var reegularka = new Regex(@"^\d*\D+\d+$");
            //Console.WriteLine(reegularka.IsMatch("asd123"));
            //Console.WriteLine(Regex.Replace("test123aaa4x56bbb789ccc", // строка
              //                                   @"\d+", // шаблончик ркгулярочки
               //                                  " ")); // символ для заммены
            Console.WriteLine(Regex.Replace("12/34/5678",
                                             @"(?<день>\d{1,2})\/(?<месяц>\d{1,2})\/(?<год>\d{2,4})",
                                             "${день}-${месяц}-${год}"));
            Console.WriteLine(Regex.Replace("123456",
                                            @"\d",
                                            x => (int.Parse(x.Value)+1).ToString()));

            //Console.WriteLine(regexx);
            //Console.WriteLine(BreakCamelCase(ghj)); 

            int[] xx = new int[] { 1, 2, 3, 4, 5, 6 };
            var mom = xx.Aggregate((a, b) => a * b);
            //foreach (var i in xx)
            //Console.WriteLine(i); 


            string s = "Бык тупогуб, тупогубенький бычок, у быка губа бела была тупа";
            Regex regex = new Regex(@"туп(\w*)");
            MatchCollection matches = regex.Matches(s);
            //if (matches.Count > 0)
            //{
            //    foreach (Match match in matches)
            //        Console.WriteLine(match.Value);
            //}
            //else
            //{
            //    Console.WriteLine("Совпадений не найдено");
            //}



            string x = "zxcqwe";
            string[] zxc = x.Split();
            int[] kak = new int[] { };
            for(int i = 0; i < zxc.Length; i++)
            {
               // Console.WriteLine(kak[i]);
            }
            int[] kakak = new int[] { 1, 2, 3, 4, 5 };
            //Console.WriteLine(Grow(kakak));
            var segod = kakak.Select(x => x * 7);
            var qwe = kakak.Select(x => x * 2);

             //foreach(var i in segod)
                //Console.WriteLine(i);
            
            //foreach (int i in mom)
            //    Console.WriteLine(i);
            //IEnumerable<int> evens = from i in numbers
            //                         where i % 2 == 0 && i < 100
            //                         select i;

            //Console.BackgroundColor = ConsoleColor.Red;
            //int[] arr = new int[] { 1, 2, 5, 4, 6 };
            //Console.WriteLine(FirstNonConsecutive(arr));
            //Console.ForegroundColor = ConsoleColor.Magenta;
            //int[] numbers = { -3, -2, -1, 0, 1, 2, 3 };
            //var result = numbers.Take(3);



            //var resultit = numbers.Skip(3);
            ////foreach (int i in resultit)
            //    //Console.WriteLine(i);

            //int[] qwe = { 1, 7, 3, 3, 3, 3, 3, 1 };
            ////Console.WriteLine($"Количество повторений: {qwe.Length - qwe.Distinct().Count()}");


            //int[] num = { 1, 2, 3, 4, 10, 34, 55, 66, 77, 88 };
            //int size = (from i in num where i % 2 == 0 && i > 10 select i).Count();
            ////Console.WriteLine(size);
            //int sizeq = num.Count(i => i % 2 == 0 && i > 10);
            ////Console.WriteLine(sizeq);

            //string[] lll = new string[] { "n", "s", "n", "s", "n", "s", "n", "s", "n", "s" };
            //int SN =  (from i in lll where i == "n" || i =="e" select i).Count();
            //int WE = (from i in lll where i == "s" || i == "w" select i).Count();
            //Console.WriteLine();   
            //string text = "И поэтому все так произошло";
            //string[] words = text.Split(new char[] { ' ' });
            //foreach (string s in words)
            //{
            //    //Console.WriteLine(s);
            //}
            //string[] words1 = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //foreach (string s in words1)
            //{
            //    //Console.WriteLine(s);
            //}
            //string textzxc = " hello world ";
            //textzxc = textzxc.Trim();
            //textzxc = textzxc.Trim(new char[] { 'd', 'h' });
            //textzxc = textzxc.Trim(new char[] { 'e', 'l' });
            ////Console.WriteLine(textzxc);
            //string zxc = "Хороший день";
            //string subString = "замечательный ";

            //zxc = zxc.Insert(8, subString);
            //Console.WriteLine(zxc);

            //string zxc = "12";
            //int i = Convert.ToInt32(zxc);
            //Console.WriteLine(i); ;


            //string ss = "true";
            //bool b = Convert.ToBoolean(ss);
            //Console.WriteLine(b);

            //if(int.TryParse("123",out int result))
            //{
            //    Console.WriteLine(result);
            //}
            //Console.WriteLine(bonus_time(10000, true));
            //Console.ResetColor();
        }
    }
}
