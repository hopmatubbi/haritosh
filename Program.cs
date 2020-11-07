using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Введите тип boolean: ");
            bool tr = Convert.ToBoolean(Console.ReadLine());
            Console.Write("Введите тип byte: ");
            byte bt = Convert.ToByte(Console.ReadLine());
            Console.Write("Введите тип sbyte: ");
            sbyte sbt = Convert.ToSByte(Console.ReadLine());
            //Console.Write("Введите тип char: ");
            //char chr = Convert.ToChar(Console.ReadLine());
            Console.Write("Введите тип decimal: ");
            decimal dcml = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Введите тип double: ");
            double dbl = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите тип float: ");
            float flt = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите тип Int32: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите тип uint: ");
            uint nt = Convert.ToUInt32(Console.ReadLine());
            Console.Write("Введите тип long: ");
            long lng = Convert.ToInt64(Console.ReadLine());
            Console.Write("Введите тип ulong: ");
            ulong ulng = Convert.ToUInt64(Console.ReadLine());
            Console.Write("Введите тип short: ");
            short shrt = Convert.ToInt16(Console.ReadLine());
            Console.Write("Введите тип ushort: ");
            ushort ushrt = Convert.ToUInt16(Console.ReadLine());
            Console.Write("Введите тип string: ");
            string strng = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Тип boolean: " + tr);
            Console.WriteLine("Тип byte: " + bt);
            Console.WriteLine("Тип sbyte: " + sbt);
            //Console.WriteLine("Тип char: " + chr);
            Console.WriteLine("Тип decimal: " + dcml);
            Console.WriteLine("Тип double: " + dbl);
            Console.WriteLine("Тип float: " + flt);
            Console.WriteLine("Тип Int32: " + a);
            Console.WriteLine("Тип uint: " + nt);
            Console.WriteLine("Тип long: " + lng);
            Console.WriteLine("Тип ulong: " + ulng);
            Console.WriteLine("Тип short: " + shrt);
            Console.WriteLine("Тип ushort: " + ushrt);
            Console.WriteLine("Тип string: " + strng);
            Console.WriteLine("Введите 'y', если ходите продолжить: ");
            char v = Convert.ToChar(Console.ReadLine());
            if (v == 'y')
            {
                Console.Clear();
            }
            else
                return;
            //2zadanie
            int x = 15, y=7;
            dbl = (double)x/y;
            bt = (byte)x;
            sbt = (sbyte)y;
            flt = (float)x/y;
            lng = (long)x/y;
            Console.WriteLine("Явное привидение:");
            Console.WriteLine("Тип double: " + dbl);
            Console.WriteLine("Тип byte: " + bt);
            Console.WriteLine("Тип sbyte: " + sbt);
            Console.WriteLine("Тип float: " + flt);
            Console.WriteLine("Тип long: " + lng);
            dbl = x / y;
            flt = x / y;
            lng = x / y;
            Console.WriteLine("Неявное привидение:");
            Console.WriteLine("Тип double: " + dbl);
            Console.WriteLine("Тип float: " + flt);
            Console.WriteLine("Тип long: " + lng);
            Console.WriteLine("Введите 'y', если ходите продолжить: ");
            v = Convert.ToChar(Console.ReadLine());
            if (v == 'y')
            {
                Console.Clear();
            }
            else
                return;
            //3zadanie
            Console.Write("Введите число: ");
            int price = Convert.ToInt32(Console.ReadLine());
            //boxing
            Object obj = price;
            Console.WriteLine("Boxing: " + obj);
            //unboxing
            int price2 = (int)obj;
            Console.WriteLine("Unboxing: " + price2);
            Console.WriteLine("Введите 'y', если ходите продолжить: ");
            v = Convert.ToChar(Console.ReadLine());
            if (v == 'y')
            {
                Console.Clear();
            }
            else
                return;
            //4zadanie
            dbl = x;//Так будет работать
            Console.WriteLine("Переменная типа int стала типа double: " + dbl.GetType());
           //
            Console.WriteLine("Введите 'y', если ходите продолжить: ");
            v = Convert.ToChar(Console.ReadLine());
            if (v == 'y')
            {
                Console.Clear();
            }
            else
                return;
            //5zadanie
            int? x1 = null;
            int? x2 = null;
            System.Console.Write(x1 == x2);
            //6zadanie
            var qq = 'a';
            Console.WriteLine("Var: " + qq);
            //qq = 51;//Т.к. вар уже стал типа char
            //2ZADANIE
            //Azadanie
            string ftp1 = "HELLO MY NEIGHBOUR";
            string ftp2 = "LIVING BELARUS";
            Console.WriteLine(String.Compare(ftp2, ftp1));
            //Bzadanie
            string b= "1";
            string c = "2";
            string d = "3";
            Console.WriteLine("Concat: " + String.Concat(d, b));
            c = String.Copy(b);
            Console.WriteLine("Copy: " + d);
            string name1 = "LUCKY PERSON";
            string name2 = name1.Substring(4);
            Console.WriteLine("Substring: " + name2);
            string text = "This is a text. New string";
            char[] delims = ".,;:!?\n\xD\xA\" ".ToCharArray();
            string[] words = text.Split(delims,
            StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)
                Console.WriteLine(word);
            Console.WriteLine("Insert: "+ ftp2.Insert(5, ftp1));
            Console.WriteLine("Remove: " + ftp2.Remove(5));
            var person = new { Name = "Gary", Age = 43 };
            Console.WriteLine($"Имя: {person.Name}  Возраст: {person.Age}");
            //3zadanie
            string s1 = "";
            Console.WriteLine("Is null or empty? "+ String.IsNullOrEmpty(s1));
            string s2 = null;
            Console.WriteLine("Is null or empty? " + String.IsNullOrEmpty(s2));
            Console.WriteLine("Concat with empty: " + String.Concat(s1, name1));
            Console.WriteLine("Concat with null: " + String.Concat(s2, name1));
            //4zadanie
            StringBuilder v1 = new StringBuilder("ABC",50);
            v1 = v1.Remove(1,2);
            v1.Append("Idk");
            v1.Insert(0,"FTP");
            Console.WriteLine("{0} chars: {1}", v1.Length,v1.ToString());
            //3ZADANIE
            //Bzadanie
            string[] arr = { "I", "love", "this", "world" };
            foreach (string i in arr)
            {
                Console.Write(i + " ");
            }
            Console.Write(arr.Length);
            //Dzadanie
            var t3d1 = new[] { 1, 2, 3, 4, 5, 6 };
            var t3d2 = "text";
            Console.WriteLine();
            Console.Write("Вывод неявно типизированного массива: ");
            for (int i = 0; i < t3d1.Length; i++)
                Console.Write("{0}\t", t3d1[i]);
            Console.WriteLine();
            Console.WriteLine("Вывод неявно типизированной строки: {0} ", t3d2);
            //4zadanie
            //Azadanie
            (int first,string second,char third,string fourth,ulong fifth) namesAndAge = (19,"MIKITA",'m',"MINSK",2001);
            //Bzadanie
            Console.WriteLine("Age:"+namesAndAge.first+", Sex:" + namesAndAge.third+ ", City:" + namesAndAge.fourth);
            //Czadanie
            (int first, string second, char third, string fourth, ulong fifth) qwerty = (18, "Katya", 'f',"MOSCOW",2002);
            qwerty.CompareTo(namesAndAge);
            Console.WriteLine(qwerty.second);
          
        }
        static int[] Sort(int[] Array, int i)
        {
            int swtch=0;
            for(int x=0;x<i; x++)
            {
                if (x + 1 == i) ;
                else
                {
                    if (Array[x] > Array[x + 1])
                    {
                        swtch = Array[x];
                        Array[x] = Array[x + 1];
                        Array[x + 1] = swtch;
                        x = 0;
                    }
                }
            }
            return Array;
        }
    }
}
