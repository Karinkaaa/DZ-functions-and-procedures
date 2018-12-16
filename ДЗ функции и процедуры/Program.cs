using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_функции_и_процедуры
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Рассчитать значение x, определив и использовав необходимую функцию:
            /*
            double x = ((Math.Sqrt(6) + 6) / 2 + (Math.Sqrt(13) + 13) / 2 + (Math.Sqrt(21) + 21) / 2);
            Console.WriteLine("a) x = {0}", x);
            x = ((5 + Math.Sqrt(5)) / (Math.Sqrt(7) + 7) + (12 + Math.Sqrt(12)) / (Math.Sqrt(8) + 8) + (31 + Math.Sqrt(31)) / (Math.Sqrt(2) + 2));
            Console.WriteLine("b) x = {0}", x);
            x = ((15 + Math.Sqrt(8)) / (8 + Math.Sqrt(15)) + (6 + Math.Sqrt(12)) / (12 + Math.Sqrt(6)) + (7 + Math.Sqrt(21)) / 21 + Math.Sqrt(7));
            Console.WriteLine("c) x = {0}", x);
            x = ((13 + Math.Sqrt(7)) / (7 + Math.Sqrt(13)) + (15 + Math.Sqrt(12)) / (Math.Sqrt(15) + 12) + (Math.Sqrt(21) + 32) / (Math.Sqrt(32) + 21));
            Console.WriteLine("d) x = {0}", x);
            */

            // 2. Рассчитать значение у, определив и использовав необходимую функцию:
            /*
            double y = (1 + Math.Sin(1)) / 3 + (5 + Math.Sin(5)) / 3 + (3 + Math.Sin(3)) / 3;
            Console.WriteLine("a) y = {0}", y);
            y = ((2 + Math.Sin(2)) / (Math.Sin(5) + 5) + (6 + Math.Sin(6)) / (Math.Sin(3) + 3) + (1 + Math.Sin(1)) / (Math.Sin(4) + 4));
            Console.WriteLine("b) y = {0}", y);
            y = ((1 + Math.Sin(4)) / (4 + Math.Sin(1)) + (7 + Math.Sin(5)) / (5 + Math.Sin(7)) + (3 + Math.Sin(2)) / (2 + Math.Sin(3)));
            Console.WriteLine("c) y = {0}", y);
            y = ((2 + Math.Sin(3)) / (3 + Math.Sin(2)) + (1 + Math.Sin(5)) / (Math.Sin(1) + 5) + (Math.Sin(7) + 4) / (Math.Sin(4) + 7));
            Console.WriteLine("d) y = {0}", y);
            */

            // 3. Определить значение z = max(a, 2b) * max(2a - b, b), где max(x, y) — максимальное из чисел х, у. Задачу решить двумя способами:
            /*
            int a, b, z;
            Console.WriteLine("Введите значение а:");
            int.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Введите значение b:");
            int.TryParse(Console.ReadLine(), out b);

            // не используя функцию max:
            if (a > 2 * b)
                z = a;
            else
                z = 2 * b;

            if (2 * a - b > b)
                z *= (2 * a - b);
            else
                z *= b;
            Console.WriteLine("\nz = {0}\n", z);

            // определив и использовав функцию max:
            z = Max(a, 2 * b) * Max(2 * a - b, b);
            Console.WriteLine("z = {0}\n", z);
            */

            // 4. Определить значение z = min(a, 3b) * min(2a - b, 2b), где min(x, y) — минимальное из чисел х, у. Задачу решить двумя способами:
            /*
            int a, b, z;
            Console.WriteLine("Введите значение а:");
            int.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Введите значение b:");
            int.TryParse(Console.ReadLine(), out b);

            // не используя функцию min:
            if (a < 3 * b)
                z = a;
            else
                z = 3 * b;

            if (2 * a - b < 2 * b)
                z *= (2 * a - b);
            else
                z *= (2 * b);
            Console.WriteLine("\nz = {0}\n", z);

            // определив и использовав функцию min:
            z = Min(a, 3 * b) * Min(2 * a - b, 2 * b);
            Console.WriteLine("z = {0}\n", z);
            */

            // 5. Определить значение z = sign(x) + sign(y), где sign(a) = { -1 при a < 0, 0 при a = 0, 1 при а > 0. 
            // Значения x и y вводятся с клавиатуры. Задачу решить двумя способами:
            /*
            int x, y, z = 0;
            Console.WriteLine("Введите значение x:");
            int.TryParse(Console.ReadLine(), out x);
            Console.WriteLine("Введите значение y:");
            int.TryParse(Console.ReadLine(), out y);

            // не используя функцию sign:
            if (x < 0)
                z = -1;
            else if (x > 0)
                z = 1;

            if (y < 0)
                z += -1;
            else if (y > 0)
                z += 1;
            Console.WriteLine("\nz = {0}\n", z);

            // определив и использовав функцию sign:
            z = Sign(x) + Sign(y);
            Console.WriteLine("z = {0}\n", z);
            */

            // 6. Найти периметр фигуры ABCD по заданным сторонам AB, AC и DC. Определить функцию для расчета гипотенузы прямоугольного треугольника по его катетам.
            /*
            double AB, AC, DC, hypotenuseBC, hypotenuseBD;
            Console.WriteLine("Введите значение стороны AB:");
            double.TryParse(Console.ReadLine(), out AB);
            Console.WriteLine("Введите значение стороны AC:");
            double.TryParse(Console.ReadLine(), out AC);
            Console.WriteLine("Введите значение стороны DC:");
            double.TryParse(Console.ReadLine(), out DC);

            hypotenuseBC = Math.Round(GetHypotenuseOfTriangle(AB, AC), 2);
            hypotenuseBD = Math.Round(GetHypotenuseOfTriangle(hypotenuseBC, DC), 2);
            Console.WriteLine("\nГипотенуза BC = {0} см\nГипотенуза BD = {1} см\n", hypotenuseBC, hypotenuseBD);
            Console.WriteLine("Периметр фигуры ABCD = {0} см", AB + hypotenuseBD + DC + AC);
            */

            // 7. Даны основания и высоты двух равнобедренных трапеций. Найти сумму их периметров. Определить функцию для расчета периметра равнобедренной трапеции по ее основаниям и высоте.
            /*
            int baseFirstTrapez1, baseFirstTrapez2, heightFirstTrapez, baseSecondTrapez1, baseSecondTrapez2, heightSecondTrapez;

            Console.WriteLine("Введите значения оснований первой трапеции:");
            int.TryParse(Console.ReadLine(), out baseFirstTrapez1);
            int.TryParse(Console.ReadLine(), out baseFirstTrapez2);
            Console.WriteLine("Введите значение высоты первой трапеции:");
            int.TryParse(Console.ReadLine(), out heightFirstTrapez);

            Console.WriteLine("Введите значения оснований второй трапеции:");
            int.TryParse(Console.ReadLine(), out baseSecondTrapez1);
            int.TryParse(Console.ReadLine(), out baseSecondTrapez2);
            Console.WriteLine("Введите значение высоты второй трапеции:");
            int.TryParse(Console.ReadLine(), out heightSecondTrapez);

            int perimeterFirstTrapez = GetPerimeterOfTrapeze(baseFirstTrapez1, baseFirstTrapez2, heightFirstTrapez);
            int perimeterSecondTrapez = GetPerimeterOfTrapeze(baseSecondTrapez1, baseSecondTrapez2, heightSecondTrapez);

            Console.WriteLine("\nПериметр первой трапеции = {0} см.", perimeterFirstTrapez);
            Console.WriteLine("Периметр второй трапеции = {0} см.", perimeterSecondTrapez);
            Console.WriteLine("\nСумма периметров двух трапеций = {0} см.", perimeterFirstTrapez + perimeterSecondTrapez);
            */

            // 8. Даны три квадратных уравнения: ax^2 + bx + c, bx^2 + ax + c, cx^2 + ax + b. Сколько из них имеют вещественные корни? 
            // Определить функцию, позволяющую распознавать наличие вещественных корней в квадратном уравнении.
            /*
            int a, b, c, countRealRoots = 0;
            Console.WriteLine("Введите значение a:");
            int.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Введите значение b:");
            int.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("Введите значение c:");
            int.TryParse(Console.ReadLine(), out c);

            AvailabilityOfRealRoots(a, b, c, ref countRealRoots);
            AvailabilityOfRealRoots(b, a, c, ref countRealRoots);
            AvailabilityOfRealRoots(c, a, b, ref countRealRoots);

            if (countRealRoots > 0)
                Console.WriteLine("\n{0} из трех квадратных уравнений имеет вещественные корни.", countRealRoots);
            else
                Console.WriteLine("\nНи одно из трех квадратных уравнений не имеет вещественных корней.");
            */

            // 9. Найти периметр треугольника, заданного координатами своих вершин. Определить функцию для расчета длины отрезка по координатам его вершин.
            /*
            int xa, ya, xb, yb, xc, yc;

            Console.WriteLine("Введите координаты вершины А:");
            int.TryParse(Console.ReadLine(), out xa);
            int.TryParse(Console.ReadLine(), out ya);

            Console.WriteLine("Введите координаты вершины B:");
            int.TryParse(Console.ReadLine(), out xb);
            int.TryParse(Console.ReadLine(), out yb);

            Console.WriteLine("Введите координаты вершины C:");
            int.TryParse(Console.ReadLine(), out xc);
            int.TryParse(Console.ReadLine(), out yc);

            double AB = GetLengthOfSegment(xa, ya, xb, yb);
            double AC = GetLengthOfSegment(xa, ya, xc, yc);
            double BC = GetLengthOfSegment(xb, yb, xc, yc);

            Console.WriteLine("\nAB = {0} см, АС = {1} см, ВС = {2} см\n", Math.Round(AB, 2), Math.Round(AC, 2), Math.Round(BC, 2));
            Console.WriteLine("Периметр треугольника = {0} см", Math.Round(AB + AC + BC, 2));
            */

            // 10. Даны вещественные числа a, b, c, d, e. Найти площадь пятиугольника. Определить функцию для расчета площади треугольника по трем его сторонам.
            /*
            double a, b, c, d, e, f, g;

            Console.WriteLine("Введите значения сторон пятиугольника:");
            double.TryParse(Console.ReadLine(), out a);
            double.TryParse(Console.ReadLine(), out b);
            double.TryParse(Console.ReadLine(), out c);
            double.TryParse(Console.ReadLine(), out d);
            double.TryParse(Console.ReadLine(), out e);

            Console.WriteLine("Введите значения двух сторон треугольника:");
            double.TryParse(Console.ReadLine(), out f);
            double.TryParse(Console.ReadLine(), out g);

            double areaFirstTriangle = GetAreaTriangle(a, b, g);
            double areaSecondTriangle = GetAreaTriangle(c, f, g);
            double areaThirdTriangle = GetAreaTriangle(d, e, f);

            Console.WriteLine("\nПлощадь первого треугольника = {0} см.", Math.Round(areaFirstTriangle, 2));
            Console.WriteLine("Площадь второго треугольника = {0} см.", Math.Round(areaSecondTriangle, 2));
            Console.WriteLine("Площадь третьего треугольника = {0} см.", Math.Round(areaThirdTriangle, 2));
            Console.WriteLine("\nПлощадь пятиугольника = {0} см.", Math.Round(areaFirstTriangle + areaSecondTriangle + areaThirdTriangle, 2));
            */

            // 11. Составить процедуру, "рисующую" на экране горизонтальную линию из 80 символов "*".
            /*
            int length = 80;
            ShowStarsByHorizontal(length);
            */

            // 12. Составить процедуру, "рисующую" по периметру экрана рамку из символов "*". Задачу решить двумя способами:
            /*
            int width = 50, height = 20;

            // не используя процедуру, разработанную в предыдущей задаче:
            for(int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i == 0 || i == height - 1 || j == 0 || j == width - 1)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n\n");

            // с использованием процедуры, разработанной в предыдущей задаче:
            ShowStarsByHorizontal(width);
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (j == 0 || j == width - 1)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            ShowStarsByHorizontal(width);
            */

            // 13. Составить процедуру, "рисующую" на экране горизонтальную линию из любого числа символов "*".
            /*
            int length;
            Console.WriteLine("Введите число звездочек, сколько нужно вывести на экран горизонтально: ");
            int.TryParse(Console.ReadLine(), out length);
            ShowStarsByHorizontal(length);
            */

            // 14. Составить процедуру, "рисующую" на экране вертикальную линию из любого числа символов "*".
            /*
            int length;
            Console.WriteLine("Введите число звездочек, сколько нужно вывести на экран вертикально: ");
            int.TryParse(Console.ReadLine(), out length);
            ShowStarsByVertical(length);
            */

            // 15. Составить процедуру, "рисующую" на экране прямоугольник из символов "*". Задачу решить двумя способами:
            /*
            int width = 45, height = 15;

            // не используя процедуру, разработанную в задаче 13:
            for(int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
            Console.Write("\n\n");

            // с использованием процедуры, разработанной в задаче 13:
            for (int i = 0; i < height; i++)
                ShowStarsByHorizontal(width);
            */

            // 16. Написать рекурсивную функцию для вычисления факториала натурального числа n.
            /*
            int num;
            Console.WriteLine("Введите число: ");
            int.TryParse(Console.ReadLine(), out num);
            Console.WriteLine("\nФакториал числа {0} = {1}", num, GetFactorial(num));
            */

            // 17. В некоторых языках программирования (например, в Паскале) не предусмотрена операция возведения в степень. 
            // Написать рекурсивную функцию для расчета степени n вещественного числа a(n — натуральное число).
            /*
            double num;
            int degreeOf;
            Console.WriteLine("Введите число: ");
            double.TryParse(Console.ReadLine(), out num);
            Console.WriteLine("Введите число: ");
            int.TryParse(Console.ReadLine(), out degreeOf);
            Console.WriteLine("Число {0} в {1}-й степени = {2}", num, degreeOf, DegreeCalculation(num, degreeOf));
            */

            // 18. Написать рекурсивную функцию: вычисления суммы цифр натурального числа; вычисления количества цифр натурального числа.
            /*
            int num;
            Console.WriteLine("Введите число: ");
            int.TryParse(Console.ReadLine(), out num);
            Console.WriteLine("\nСумма цифр числа {0} = {1}", num, GetSumOfDigits(num));
            Console.WriteLine("Количество цифр в числе {0} = {1}", num, GetCountOfDigits(num));
            */

            // 19. Написать рекурсивную функцию нахождения цифрового корня натурального числа. Цифровой корень данного числа получается 
            // следующим образом. Если сложить все цифры этого числа, затем все цифры найденной суммы и повторять этот процесс, то в 
            // результате будет получено однозначное число (цифра), которая и называется цифровым корнем данного числа.
            /*
            int num;
            Console.WriteLine("Введите число: ");
            int.TryParse(Console.ReadLine(), out num);
            Console.WriteLine("\nЦифровой корень числа {0} = {1}", num, GetDigitalRoot(num));
            */

            // 20. Даны первый член и разность арифметической прогрессии. Написать рекурсивную функцию для нахождения:
            /*
            int firstMember, diff, n;
            Console.WriteLine("Введите первый член арифметической прогрессии: ");
            int.TryParse(Console.ReadLine(), out firstMember);
            Console.WriteLine("Введите разницу арифметической прогрессии: ");
            int.TryParse(Console.ReadLine(), out diff);

            // n-го члена прогрессии:
            Console.WriteLine("\nКакой член арифметической прогрессии вы хотите найти?");
            int.TryParse(Console.ReadLine(), out n);
            Console.WriteLine("\nРезультат: {0}", FindMemberOfAP(firstMember, diff, n));

            // суммы n первых членов прогресси:
            Console.WriteLine("\n\nСумму скольких первых членов арифметической прогрессии вы хотите найти?");
            int.TryParse(Console.ReadLine(), out n);
            Console.WriteLine("\nРезультат: {0}", FindSumOfMembersAP(firstMember, diff, n));
            */

            // 21. Даны первый член и знаменатель геометрической прогрессии. Написать рекурсивную функцию:
            /*
            int firstMember, denominator, n;
            Console.WriteLine("Введите первый член геометрической прогрессии: ");
            int.TryParse(Console.ReadLine(), out firstMember);
            Console.WriteLine("Введите значение знаменателя геометрической прогрессии: ");
            int.TryParse(Console.ReadLine(), out denominator);

            // нахождения n-го члена прогрессии:
            Console.WriteLine("\nКакой член геометрической прогрессии вы хотите найти?");
            int.TryParse(Console.ReadLine(), out n);
            Console.WriteLine("\nРезультат: {0}", FindMemberOfGP(firstMember, denominator, n));

            // нахождения суммы n первых членов прогрессии:
            Console.WriteLine("\n\nСумму скольких первых членов геометрической прогрессии вы хотите найти?");
            int.TryParse(Console.ReadLine(), out n);
            Console.WriteLine("\nРезультат: {0}", FindSumOfMembersGP(firstMember, denominator, n));
            */

            // 22. Написать рекурсивную функцию для вычисления k-го члена последовательности Фибоначчи. Последовательность 
            // Фибоначчи f1, f2... образуется по закону: f(1) = 1; f(2) = 1; f(i) = f(i - 1) + f(i - 2), i = 3, 4...
            /*
            int k;
            Console.WriteLine("Какой член последовательности Фибоначчи вы хотите найти?");
            int.TryParse(Console.ReadLine(), out k);
            Console.WriteLine("\nРезультат: {0}", GetNumOfFebonacci(k));
            */

            // 23. Написать рекурсивную функцию для вычисления максимального элемента массива из n элементов.
            /*
            int size;
            Console.WriteLine("Введите размер массива:");
            int.TryParse(Console.ReadLine(), out size);

            int[] arr = new int[size];
            FillingRandomNumbers(arr, size);
            ShowArray(arr, size);
            Console.WriteLine("\n\nМаксимальное значение массива = {0}", MaxValueInArray(arr, size));
            */

            // 24. Написать рекурсивную функцию для вычисления индекса максимального элемента массива из n элементов.
            /*
            int size;
            Console.WriteLine("Введите размер массива:");
            int.TryParse(Console.ReadLine(), out size);

            int[] arr = new int[size];
            FillingRandomNumbers(arr, size);
            ShowArray(arr, size);
            Console.WriteLine("\n\nИндекс максимального значения массива = {0}", IndexOfMaxValueInArray(arr, size));
            */

            // 25. Написать рекурсивную функцию для вычисления значения так называемой функции Аккермана для неотрицательных чисел n и m. 
            // Функция Аккермана определяется следующим образом: A(n, m) = { (m + 1) - если n = 0; A(n - 1, 1) - ecли n != 0, m = 0; 
            // A(n - 1, A(n, m - 1)) - если n > 0, m > 0. Функцию Аккермана называют дважды рекурсивной, т.к.сама функция и один из ее 
            // аргументов определены через самих себя. Найти значение функции Аккермана для n = 1, m = 3. Примечание: Расчет значения функции 
            // Аккермана является трудоемким даже при малых аргументах n и m (проверьте это утверждение для n = 4, m = 2).
            /*
            int n = 1, m = 2;
            Console.WriteLine("Значением функции Аккермана для A({0}, {1}) является {2}.", n, m, AckermannFunction(n, m));
            */

        }

        static int Max(int num1, int num2)
        {
            return (num1 > num2) ? num1 : num2;
        }

        static int Min(int num1, int num2)
        {
            return (num1 < num2) ? num1 : num2;
        }

        static int Sign(int num)
        {
            if (num < 0)
                return -1;
            else if (num > 0)
                return 1;
            return 0;
        }

        static double GetHypotenuseOfTriangle(double cathet1, double cathet2)
        {
            return Math.Sqrt((Math.Pow(cathet1, 2) + Math.Pow(cathet2, 2)));
        }

        static int GetPerimeterOfTrapeze(int base1, int base2, int height)
        {
            return base1 + base2 + 2 * height;
        }

        static void AvailabilityOfRealRoots(int a, int b, int c, ref int count)
        {
            double discr, x1, x2;
            discr = Math.Pow(b, 2) - 4 * a * c;
            if (discr >= 0)
            {
                x1 = (-b + Math.Sqrt(discr) / (2 * a));
                x2 = (-b - Math.Sqrt(discr) / (2 * a));
                if (x1 - (int)x1 != 0 || x2 - (int)x2 != 0)
                    count++;
            }
        }

        static double GetLengthOfSegment(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
        }

        static double GetSemiPerimeter(double a, double b, double c)
        {
            return ((a + b + c) / 2);
        }

        static double GetAreaTriangle(double a, double b, double c)
        {
            double p = GetSemiPerimeter(a, b, c);
            return (Math.Sqrt(Math.Abs(p * (p - a) - (p - b) * (p - c))));
        }

        static void ShowStarsByHorizontal(int length)
        {
            for (int i = 0; i < length; i++)
                Console.Write("*");
            Console.Write("\n");
        }

        static void ShowStarsByVertical(int length)
        {
            for (int i = 0; i < length; i++)
                Console.WriteLine("*");
            Console.Write("\n");
        }

        static ulong GetFactorial(int num)
        {
            if (num <= 1)
                return 1;
            return (ulong)num * GetFactorial(num - 1);
        }

        static double DegreeCalculation(double num, int st)
        {
            if (st == 0)
                return 1;
            double res = num * DegreeCalculation(num, Math.Abs(st) - 1);
            return (st < 0) ? 1.0 / res : res;
        }

        static int GetSumOfDigits(int num)
        {
            if (num > -10 && num < 10)
                return num;
            return num % 10 + GetSumOfDigits(num / 10);
        }

        static int GetCountOfDigits(int num)
        {
            if (num > -10 && num < 10)
                return 1;
            return 1 + GetCountOfDigits(num / 10);
        }

        static int GetDigitalRoot(int num)
        {
            if (num > -10 && num < 10)
                return num;

            var sum = Math.Abs(GetSumOfDigits(num));
            return (sum < 10) ? sum : GetDigitalRoot(sum);
        }

        static int FindMemberOfAP(int first, int diff, int n)
        {
            if (n == 1)
                return first;
            return FindMemberOfAP(first + diff, diff, n - 1);
        }

        static int FindSumOfMembersAP(int num, int diff, int n)
        {
            if (n == 1)
                return num;
            return num + FindSumOfMembersAP(num + diff, diff, n - 1);
        }

        static int FindMemberOfGP(int first, int denominator, int n)
        {
            if (n == 1)
                return first;
            return FindMemberOfGP(first * denominator, denominator, n - 1);
        }

        static int FindSumOfMembersGP(int num, int denominator, int n)
        {
            if (n == 1)
                return num;
            return num + FindSumOfMembersGP(num * denominator, denominator, n - 1);
        }

        static int GetNumOfFebonacci(int k)
        {
            if (k == 1 || k == 2)
                return 1;
            return GetNumOfFebonacci(k - 1) + GetNumOfFebonacci(k - 2);
        }

        static void FillingRandomNumbers(int[] mas, int length)
        {
            Random rnd = new Random();
            for (int i = 0; i < length; i++)
                mas[i] = rnd.Next(0, 50);
        }

        static void ShowArray(int[] mas, int length)
        {
            Console.Write("\n");
            for (int i = 0; i < length; i++)
                Console.Write("{0}\t", mas[i]);
        }

        static int MaxValueInArray(int[] mas, int length)
        {
            if (length == 1)
                return mas[0];
            int max = MaxValueInArray(mas, length - 1);
            return (mas[length - 1] > max) ? mas[length - 1] : max;
        }

        static int IndexOfMaxValueInArray(int[] mas, int length)
        {
            if (length == 1)
                return 0;
            int idx = IndexOfMaxValueInArray(mas, length - 1);
            return (mas[length - 1] > mas[idx]) ? length - 1 : idx;
        }

        static int AckermannFunction(int n, int m)
        {
            int res;
            if(n == 0)
            {
                res = m + 1;
            }
            else
            {
                if (m == 0)
                    res = AckermannFunction(n - 1, 1);
                else
                    res = AckermannFunction(n - 1, AckermannFunction(n, m - 1));
            }
            return res;
        }
    }
}
