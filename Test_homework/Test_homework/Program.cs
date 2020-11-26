using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Нахождение_координат_точек
{
    class Program
    {
        static void Main(string[] args)
        {
            double L, H;
            byte a;
            bool er;
            L = 0;
            H = 0;
            a = 0;

            er = false;

            while (!er)                                                    //цикл для проверки корректности введенного значения
            {
                Console.WriteLine("\tВведите длинну шарнирно-стержневой схемы");
                er = double.TryParse(Console.ReadLine(), out L);           //Ввод переменной L (Длинна шарнирной схемы)

                if (!er || L <= 0)                                               //проверка корректности введенных данных.
                {
                    Console.WriteLine("\tпожалуйста введите корректное значение");
                    Console.WriteLine("\tВ качестве разделителя дробной части используйте [,]");
                    Console.WriteLine("\tОбратите внимание, что высота не может быть отрицательной");
                    er = false;
                }
            }
            er = false;
            while (!er)                                                    //цикл для проверки корректности введенного значения
            {
                Console.WriteLine("\tВведите заданую высоту h");
                er = double.TryParse(Console.ReadLine(), out H);           //Ввод переменной h (высота заданной части)

                if (!er || H <= 0)                                               //проверка корректности введенных данных.
                {
                    Console.WriteLine("\tпожалуйста введите корректное значение");
                    Console.WriteLine("\tВ качестве разделителя дробной части используйте [,]");
                    Console.WriteLine("\tОбратите внимание, что высота не может быть отрицательной");
                    er = false;
                }
            }
            er = false;
            while (!er)                                                    //цикл для проверки корректности введенного значения
            {
                Console.WriteLine("\tВведите заданный угол a");
                er = byte.TryParse(Console.ReadLine(), out a);           //Ввод переменной а (внешний угол верхней точки фигуры)

                if (!er || a <= 0 || a > 89)                                          //проверка корректности введенных данных.
                {
                    Console.WriteLine("\tпожалуйста введите корректное значение");
                    Console.WriteLine("\tзначение угла должно иметь целое значение и не должно быть отрицательным");
                    Console.WriteLine("\tобратите внимание, что задаваемый угол должен лежать в диапазоне от 0 до 90");
                    er = false;
                }
            }

            double rad = (90 - a) * Math.PI / 180;                  // преобразование из угла в радианы и поиск искомого "внутреннего" угла
            double Tg = Math.Tan(rad);                          //поиск тангенса угла
            double G = (L / 2) / Tg;
            double F = (L / 3) / Tg;                                   //поиск y для точки G


            Console.WriteLine("вы задали следующие значения: Длинна=" + L + " ; Высота=" + H + " ; Внешний угол=" + a + ".");
            Console.WriteLine();
            Console.WriteLine("\t Точка А находиться в координатах = 0  :  0");
            Console.WriteLine("\t Точка B находиться в координатах = " + Math.Round((L / 6), 3) + "  :  " + 0);
            Console.WriteLine("\t Точка C находиться в координатах = " + Math.Round((L / 2), 3) + "  :  " + 0);
            Console.WriteLine("\t Точка D находиться в координатах = " + Math.Round((5 * L / 6), 3) + "  :  " + 0);
            Console.WriteLine("\t Точка E находиться в координатах = " + L + "  :  " + H);
            Console.WriteLine("\t Точка F находиться в координатах = " + Math.Round((2 * L / 3), 3) + "  :  " + Math.Round((H + F), 3));
            Console.WriteLine("\t Точка G находиться в координатах = " + Math.Round((L / 2), 3) + "  :  " + Math.Round((H + G), 3));
            Console.WriteLine("\t Точка J находиться в координатах = " + Math.Round((L / 3), 3) + "  :  " + Math.Round((H + F), 3));
            Console.WriteLine("\t Точка K находиться в координатах = " + 0 + "  :  " + H);
            Console.ReadLine();

        }
    }
}