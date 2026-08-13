using SolutionsPetrovskiyCleverens.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SolutionsPetrovskiyCleverens.Properties
{
    public class Mistakes : AbstractMistakes
    {
        public Mistakes() 
        {
        }

        public override string GetMistakes(string inputStr)
        {
            Dictionary<string, string> mistakeList = new Dictionary<string, string>()
            {
                { "1", "Ошибка: Есть заглавная буква. Строка " },
                { "2", "Ошибка: Есть число. Строка " },
                { "3", "Ошибка: Есть символ не буква. Строка" },
                { "4", "Ошибка: В строке нет букв. Строка" },
            };

            foreach (Match match in Regex.Matches(inputStr, RegularExpressionModel.upperPattern))
            {
                return mistakeList["1"] + inputStr;
            }

            foreach (Match match in Regex.Matches(inputStr, RegularExpressionModel.numberPattern))
            {
                return mistakeList["2"] + inputStr;
            }

            if (!inputStr.All(c => char.IsLetter(c)))
            {
                return mistakeList["3"] + inputStr;
            }

            return "OK";
        }       
    }
}
