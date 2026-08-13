using SolutionsPetrovskiyCleverens.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsPetrovskiyCleverens.Properties
{
    public static class WriteIntro : Object
    {
        public static string allCorrentSimbols = "abcdefghijklmnopqrstuvwxyz";
        public static string allRUCorrentSimbols = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        public static void Writeintro()
        {
            Console.WriteLine("**************************************************************");
            Console.WriteLine("Задача 1");
            Console.WriteLine("Дана строка, содержащая n маленьких букв латинского алфавита.");
            Console.WriteLine("Требуется реализовать алгоритм компрессии этой строки, ");
            Console.WriteLine("замещающий группы последовательно идущих одинаковых букв формой 'sc' ");
            Console.WriteLine("(где 's' – символ, 'с' – количество букв в группе), ");
            Console.WriteLine("а также алгоритм декомпрессии, возвращающий исходную строку по сжатой.");
            Console.WriteLine("Если буква в группе всего одна – количество в сжатой строке не указываем,");
            Console.WriteLine("а пишем её как есть.");
            Console.WriteLine("Пример: ");
            Console.WriteLine("Исходная строка: aaabbcccdde");
            Console.WriteLine("Сжатая строка: a3b2c3d2e");
            Console.WriteLine("**************************************************************");

            Console.WriteLine("******** Информация для пользователя *******************");
            Console.WriteLine("Необходимо обрабатывать символы : " + WriteIntro.allCorrentSimbols);
            Console.WriteLine("или символы : " + WriteIntro.allRUCorrentSimbols);
            Console.WriteLine("********************************************************");
        }

        public static void WriteNewLine(string str)
        { 
            Console.WriteLine(str);
            Console.WriteLine();
        }
    }
}
