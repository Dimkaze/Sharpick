using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
namespace Lern_sharp
{
    class Program
    {

        public int[] convertStrToArr(string patern)
        {
            string copy = patern;
            var poplka = new Regex(@"\D").Replace(patern, " ").Replace("  ", " ");
            int zeroCount = 0;
            var polucop = new Regex(@"\D").Replace(copy, "");
            int[] uno = new int[polucop.Length];
            int size = 0;
            for (int i = 0, jjj = 0; i < poplka.Length; i++)
            {
                int count = 0;
                if (poplka[i] == '0')
                    zeroCount += 1;
                while (poplka[i] != ' ')
                {
                    uno[jjj] += (poplka[i] - '0') * (int)Math.Pow(10, count);
                    i++;
                    count++;
                }
                jjj++;
            }
            for (int i = 0; i < uno.Length; i++)
            {
                if (uno[i] != 0)
                    size++;
            }
            int[] copyuno = new int[size + zeroCount];
            for (int i = 0; i < size + zeroCount; i++)
            {
                copyuno[i] = uno[i];
            }
            foreach (var item in copyuno)
            {
                Console.WriteLine(item);
            }
            return copyuno;
        }
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
        public static int Multiply(int a, int b) => a * b;
        public static int Persistenceee(long n)
        {
            var count = (int)Math.Ceiling(Math.Log10(Math.Abs(n) + 0.5));
            if (n < 10)
                return (int)n; 
            var loopcount = count;
            long[] zxc = new long[count];
            long recursia = 1;
            for (int i = 0; i < count; i++)
            {
                zxc[i] = n / (long)Math.Pow(10, loopcount-1)%10;
                loopcount--;
                recursia *= zxc[i];
            }
            return Persistenceee(recursia);
        }
        public static int rofel(long n)
        {
            int counter = 0;
            while (n > 0)
            {
                var count = (int)Math.Ceiling(Math.Log10(Math.Abs(n) + 0.5));
                if (n < 10)
                    return counter;
                var loopcount = count;
                long[] zxc = new long[count];
                long recursia = 1;
                for (int i = 0; i < count; i++)
                {
                    zxc[i] = n / (long)Math.Pow(10, loopcount - 1) % 10;
                    loopcount--;
                    recursia *= zxc[i];
                }
                counter++;
                n = recursia;
            }
            return counter;
        }
        public static int getCountsOfDigits(long number)
        {
            return (number == 0) ? 1 : (int)Math.Ceiling(Math.Log10(Math.Abs(number) + 0.5));
        }
        public static int RentalCarCost(int d)
        {
            return d >= 7 ? d * 40 + 50 : d < 2 ? d * 40 : d * 40 + 20;
        }
        public static int[] PreFizz(int n) => Enumerable.Range(1, n).ToArray();
        public static int[] MoveZeroess(int[] arr)
        {
            int[] zxc = new int[arr.Length];
            for(int i = 0,k = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    zxc[k] = arr[i];
                    k++;
                }
            }
            foreach(var i in zxc)
                Console.WriteLine(i);
            return zxc;
            
        }
        public static int[] MoveZeroes(int[] arr) => arr.OrderBy(x => x == 0).ToArray();


        public static string Switcheroo(string x)
        {

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == 'a')
                {
                    x = new Regex("([a])").Replace(x, "1");

                }
                if (x[i] == 'b')
                {
                    x = new Regex("([b])").Replace(x, "2");
                }
            }
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == '1')
                {
                    x = new Regex("([1])").Replace(x, "b");

                } 
                if (x[i] == 'b')
                {
                    x = new Regex("([2])").Replace(x, "a");
                }
            }
            return x;
        }
        
        public static string OddOrEven(int[] array) => array.Length == 0 ? "even": array.Aggregate((a, b) => a + b) % 2 == 0  ? "even" : "odd";
        public static string OddOrEvenn(int[] array)
        {
            if(array.Length == 0)
            {
                string zxc = "even";
                return zxc;
            }
           string x = array.Aggregate((a, b) => a + b) % 2 == 0 ? "even" :  "odd";
            return x;
        }
        //public static string ToCamelCase(string str)
        //{
        //    var regexx = new Regex("([-])" || "([_])").Replace(str, "");
        //}
        public static string MakeUpperCase(string str) => str.ToUpper();
        public static string GetPlanetName(int id)
        {
            string[] planets = new string[] { "", "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };
            return planets[id];
        }
        public static string repeatStr(int n, string s) =>  String.Concat(Enumerable.Repeat(s, n));

        public static int DescendingOrder(int num)
        {
            var count = (int)Math.Ceiling(Math.Log10(Math.Abs(num) + 0.5)); 
            var loopcount = count;
            int[] zxc = new int[count];
            
            for (int i = 0; i < count; i++)
            {
                zxc[i] = num / (int)Math.Pow(10, loopcount - 1) % 10;
                loopcount--;
            }
            Array.Sort(zxc);
            num = 0;
            for (int i = 0; i < count; i++)
            {
                num += zxc[i] * (int)Math.Pow(10, i);
            }
            foreach (var item in zxc)
            {
                Console.WriteLine(item);  
            }
            return num;
        }
        public static string UefaEuro2016(string[] teams, int[] scores)=>
        
             scores[0] > scores[1] ? $"At match {teams[0]} - {teams[1]}, {teams[0]} won!" : scores[0] == scores[1] ? "At match " + teams[0].ToString() + " - " + teams[1].ToString() + ", teams played draw." : "At match " + teams[0].ToString() + " - " + teams[1].ToString() + ", " + teams[1].ToString() + " won!";

        public static double basicOp(char operation, double value1, double value2) =>
            operation == '+' ? value1 + value2 : operation == '-' ? value1 - value2 : operation == '*' ? value1 * value2 : value1 / value2;
        //public static string AbbrevName(string name)
        //=> new Regex("([a-z])").Replace(name, "").Insert(1, ".").Replace(" ", "");
        //public static string AbbrevName(string name)
        //{
        //    //return name.ToUpper().Split(' ').Select(x => x[0]).Join(name)
                 
        //}
        public static int loverc(int[] qwe)
        {
            int zxc = qwe[0];
            for (int i = 1; i < qwe.Length; i++)
            {
                if(zxc > qwe[i])
                {
                    zxc = qwe[i];
                }
            }
            return zxc;
        }


        static void Main(string[] args)
        {
            //Console.WriteLine(AbbrevName("S Kdf"));
            //Console.WriteLine(UefaEuro2016(new [] { "Germany", "Ukraine"}, new [] { 2, 0 }));
            //Console.WriteLine(DescendingOrder(12345)); 
            //prop
            //ctor
            //2 constructora : this(10,20,30)
            //ctr rr
            //string koka = "111111234211111234";

            var qdr = "55x5 (1,45)(4,43)(58,q)zxc";
            var poplka = new Regex(@"\D").Replace(qdr, " ").Replace("  ", " ");
            int[] uno = new int[poplka.Length];
            int[] copyuno = new int[poplka.Length];
            //for (int i = 0,jjj = 0; i < poplka.Length; i++)
            //{
                
            //    if(poplka[i] != ' ')
            //    {
            //        uno[jjj] = poplka[i] - '0';
            //        jjj++;
            //    }
            //    //Console.WriteLine(poplka[i]);
            //}
            Console.WriteLine();
            for (int i = 0, jjj = 0; i < poplka.Length; i++)
            {
                int count = 0;
                while(poplka[i] != ' ')
                {
                    copyuno[jjj] += (poplka[i] - '0' )* (int)Math.Pow(10,count);
                    i++;
                    count++;
                }
                jjj++;

            }
            foreach (var item in copyuno)
            {
              // Console.WriteLine(item);
            }
            //Console.WriteLine(int.Parse(lkl));
            //int[] lpl = new int[lkl.Length];
            //for (int i = 0, loop = 0; i < lkl.Length; i++)
            //{
            //    try
            //    {

            //    }
            //    catch
            //    {
            //        Console.WriteLine("Несработало");
            //    }

            //}
            //foreach (var item in lpl)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(new Regex(@"\d{1}x\d{1} [\(+\d{1},\d{1}\)]{2,}").Replace(qdr, "0"));
            //Console.WriteLine(repeatStr(6,koka));

            string kok = "the_stealth_warrior";
            char first = kok[0];
           // Console.WriteLine(first);
            kok = kok.Replace("_", "-");
            var regexx = new Regex(@"\W").Replace(kok, " ");
            regexx = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(regexx).Replace(" ", "").Replace(regexx[0], first);
            //Console.WriteLine(regexx);
            //var str = "ивнов ывам ивановИц";
            //var result = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str);
            //Console.WriteLine(kok);

            //foreach (string i in regexx)
             //   Console.WriteLine(i);
            
            //Console.WriteLine(regexx);
            // string popka = "aaacccbbbab";
            //Console.WriteLine(Switcheroo(popka));
            int[] qerrr = new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 };
            //Console.WriteLine(loverc(qerrr));
            //Console.WriteLine();
            //Console.WriteLine(MoveZeroes(qerrr));
            //Console.WriteLine(Persistenceee(999)); 
            //Console.WriteLine(Persistence(12345));
            //Console.WriteLine(getCountsOfDigits(1234567));
            //Console.WriteLine(Persistences(123,0)); 
            int a = 3;
            int b = (int)Math.Pow(a, 2);
            
            string ghj = "cacoiToBomjGuliatPoUlitse";
            
            var reegularka = new Regex(@"^\d*\D+\d+$");
            //Console.WriteLine(reegularka.IsMatch("asd123"));
            //Console.WriteLine(Regex.Replace("test123aaa4x56bbb789ccc", // строка
              //                                   @"\d+", // шаблончик ркгулярочки
               //                                  " ")); // символ для заммены
            //Console.WriteLine(Regex.Replace("12/34/5678",
            //                                 @"(?<день>\d{1,2})\/(?<месяц>\d{1,2})\/(?<год>\d{2,4})",
            //                                 "${день}-${месяц}-${год}"));
            //Console.WriteLine(Regex.Replace("123456",
            //                                @"\d",
            //                                x => (int.Parse(x.Value)+1).ToString()));

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
