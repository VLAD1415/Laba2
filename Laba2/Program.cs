using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    class Program
    {
        static void Main(string[] args)
        {
            int main_num = 10;
            // Types(a)
            int i7 = -2000000;
            Console.WriteLine(i7);
            int i2 = 0b101;// бинарный
            Console.WriteLine(i2);
            int i3 = 0xFF;// шестнадцатиричный
            Console.WriteLine(i3);

            uint ui = 435463485;
            Console.WriteLine(ui);

            string st = "Приветули";
            Console.WriteLine(st);

            bool bo = false;
            Console.WriteLine(bo);

            byte by = 254;
            Console.WriteLine(by);

            sbyte sby = -97;
            Console.WriteLine(sby);

            short sh = -15000;
            Console.WriteLine(sh);

            ushort ush = 50000;
            Console.WriteLine(ush);

            long lg = 0xFF;
            Console.WriteLine(lg);

            ulong ulg = 478584848484444;
            Console.WriteLine(ulg);

            float fl = 2.56565656F;
            Console.WriteLine(fl);

            double df = 1.644545544544554545545455;
            Console.WriteLine(df);

            decimal de;
            de = 0.00007m;
            Console.WriteLine(de);

            char ch = '%';
            Console.WriteLine(ch);
            //Types(b)

            //implicit conversion
            int num = 100;
            long numL = num;//1
            float numF = num;//2
            decimal numDe = numL;//3
            double numD = numF;//4
            byte b = 120;
            int inB = b;//5

            //explicit conversion
            int inC = 10;
            byte C = (byte)inC;//1

            long lgB = 10;
            int B = (int)lgB;//2

            sbyte sb1 = (sbyte)inC;//3

            byte by1 = (byte)lgB;//4

            float fl1 = (float)df;//5

            //Convert
            string str;
            int n1, n2;
            Console.WriteLine("Ввод n1: ");
            str = Console.ReadLine();
            n1 = Convert.ToInt32(str);
            Console.WriteLine("Ввод n2: ");
            str = Console.ReadLine(); ;
            n2 = Convert.ToInt32(str);
            int summ = n1 + n2;
            Console.WriteLine("Сумма чисел = " + summ);
            //Types(c)
            int zn = 10;//zn находится в стеке
            object znO = zn;//boxing теперь zn находится в управляемой куче
            int zn_New = (int)zn;//unboxing 
                                 //Types(d)
            var td = main_num + 5;
            Console.WriteLine("Рвбота с неявно типизорованной переменной: " + td);
            //Types(e)

            int? nub = null;
            int? nub2 = 100;
            Console.WriteLine(nub.HasValue);
            Console.WriteLine(nub2.Value);
            //Types(f)
            /*
                        var myName = "Vlad";
                        myName = 2;// Ошибка тк тип переменной myName неявно выводится как string, а мы пытаемся присвоить ей целочисленное значение(компилятор обязывает переменную сохранять первоначальный тип)
            */

            //Strings(a,b)
            Console.WriteLine("This is string");
            string str1 = "Button ";
            string str2 = "Vladislav";
            string str3 = "Can ikk jump now";
            Console.WriteLine(str1 + " " + str2);// Обьединение двух строк сп1
            Console.WriteLine(String.Concat(str1, " ", str2));// Обьединение двух строк сп2
            string str4 = String.Copy(str3);// копирование строки
            Console.WriteLine(str4);

            int stIndex = 8, length = 4;

            Console.WriteLine(str3.Substring(stIndex, length));//выделение подстроки

            //по словам
            string text = "Бесплатный сервис Google позволяет мгновенно переводить слова";
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string gg in words) {
                Console.WriteLine($"Отдельно: {gg}");
            }

            //Вставка подстроки на заданную позицию
            Console.WriteLine(str1.Insert(7, str2));

            //Удаление подстроки 
            Console.WriteLine(str3.Remove(4, 3));

            //Интерполяция строк(пример)
            int x = 100, y = 5;
            Console.WriteLine($"{x}+{y}={x + y}");
            //Strings(c)
            string nst1 = "helllo";
            string nst2 = "";
            string nst3 = null;
            Console.WriteLine(string.IsNullOrEmpty(nst1));// Проверяет нулевую или пустую строку(true) else(false)
            Console.WriteLine(string.IsNullOrEmpty(nst2));
            Console.WriteLine(string.IsNullOrEmpty(nst3));

            //Strings(d)
            StringBuilder new_str = new StringBuilder("Бесплатный сервис Google позволяет");
            Console.WriteLine(new_str);
            Console.WriteLine(new_str.Remove(0, 11));//Удаление 
            Console.WriteLine(new_str.Insert(0, "Абсолютно "));//Вставка в начало
            Console.WriteLine(new_str.Insert(33, " многое"));//В конец
            Console.WriteLine(new_str.AppendFormat(" рхрхрхрхрх"));// Только в конец

            //Arrays(a)
            int[,] MyArray = new int[2, 3]// Создаем двумерный массив
           {
                { 1, 2, 3 },
                { 4, 5, 6 }
           };
            for (int i = 0; i < MyArray.GetLength(0); i++)
            {
                for (int j = 0; j < MyArray.GetLength(1); j++)
                {
                    Console.Write(MyArray[i, j] + "\t");
                }
                Console.WriteLine();
            }
            //Arrays(b)
            string[] str_ar = new string[4] { "My", "name", "is", "Vlad" };
            //Вывод содержимого
            foreach (string po in str_ar) {
                Console.Write(po + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Длинна массива: " + str_ar.Length);

            //Изменение элемента массива 
            str_ar[3] = "neVlad";
            foreach (string izm in str_ar) {
                Console.Write(izm + " ");
            }
            Console.WriteLine();
 //Arrays(c)
            int tr = int.Parse(Console.ReadLine());
            int tr1 = int.Parse(Console.ReadLine());
            int tr2 = int.Parse(Console.ReadLine());
            int tr3 = int.Parse(Console.ReadLine());
            int tr4 = int.Parse(Console.ReadLine());
            int tr5 = int.Parse(Console.ReadLine());
            int tr6 = int.Parse(Console.ReadLine());
            int tr7 = int.Parse(Console.ReadLine());
            int tr8 = int.Parse(Console.ReadLine());
            int[][] zub_ar = new int[3][];

            zub_ar[0] = new int[2] { tr, tr1 };
            zub_ar[1] = new int[3] { tr2,tr3,tr4 };
            zub_ar[2] = new int[4] { tr5, tr6, tr7,tr8 };

            for (int i12 = 0; i12 < zub_ar.Length; i12++)
            {
                for (int j12 = 0; j12 < zub_ar[i12].Length; j12++)
                {

                    Console.Write($"{zub_ar[i12][j12]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine(zub_ar);
//Arrays(d)
            //Создайте неявно типизированные переменные для хранения массива и строки
            var arre2 = new[] { 1, 2, 3, 4, 5, 6, 7 };
            foreach(var nev in arre2) {
                Console.Write(nev + " ");
            }
            Console.WriteLine();


//Кортежи(a)
            (int, string, char, string, ulong) kort1 = (100, "srting", '%', "one more string", 256);
//Кортежи(b)
            Console.WriteLine(kort1);//Целиком
            Console.WriteLine($"Выведем 1й,3й и 5й элементы:  {kort1.Item1}, {kort1.Item3}, {kort1.Item5}");//Выборочно
//Кортежи(c)
            (int, string, char, string, ulong) kort2 = ((int, string, char, string, ulong))kort1;// Распаковка кортежа??


            Func<int[], string, Tuple<int, int, int, char>> fun = (arr, strrr) => arr.Aggregate(Tuple.Create(Int32.MinValue, Int32.MaxValue, 0, strrr[0]), (y1, x1) => Tuple.Create(Math.Max(y1.Item1, x), Math.Min(y1.Item2, x1), y1.Item3 + x1, y1.Item4));
            Console.WriteLine(fun(new int[] { 1, -2, 3, -4, 5, -6, 7, -8, 9, 0 }, "Takoe"));

            void checkedFunction()
            {
                int che = checked(int.MaxValue);
            }

            void uncheckedFunction()
            {
                int unche = checked(int.MinValue);

            }




































        }
    }
}
