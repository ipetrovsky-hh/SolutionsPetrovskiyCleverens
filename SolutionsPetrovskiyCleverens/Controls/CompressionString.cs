using SolutionsPetrovskiyCleverens.Interfaces;
using SolutionsPetrovskiyCleverens.Model;
using SolutionsPetrovskiyCleverens.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SolutionsPetrovskiyCleverens.Controls
{
    public class CompressionString : ICompressionString
    {     
        private string inputStr = "";

        public string compressString = "";

        public CompressionString(string inputS)
        {           
            this.inputStr = inputS + " ";

            this.compressString = inputS;
        }
        
        public void Conpression() 
        {
            List<CompressSymbolsModel> arrResults = new List<CompressSymbolsModel>();

            CompressSymbolsModel symbols = new CompressSymbolsModel();

            bool found = false;

            int p1 = 1;
            int p2 = 0;

            for (int i = 0; i < inputStr.Length - 1; i++)
            {     
                // Проверяем, совпадают ли текущий символ и следующий
                if (inputStr[i] == inputStr[i + 1])
                {
                    if (i == 0)
                    {
                        p1 = i;                
                    }
                    else
                    {
                        p1 = (i - p2);
                    }

                    p2 += 1;

                    found = true;
                    // Можно добавить break, если нужно найти только первое вхождение
                }
                else
                {
                    if (p1 == 0)  
                    { 
                        p2 += 1; 
                    }
                    else 
                    {
                        p1 += 1;
                    }

                    symbols = new CompressSymbolsModel() 
                    {
                        startPosition = p1,
                        endPosition = p2,
                        symbol = inputStr[i].ToString()
                    };

                    arrResults.Add(symbols);

                    p2 = 1;
                }
            }

            FormatString(arrResults);

            if (!found)
            {
                Console.WriteLine("**** Строка без дублирубщихся символов");
                return;
            }            
        }

        private void FormatString(List<CompressSymbolsModel> arrList) 
        {
            foreach (var name in arrList)
            {
                if (name.endPosition > 1)
                {
                    compressString =
                    compressString.Replace(inputStr.Substring(name.startPosition, name.endPosition),
                    name.symbol.ToString() + name.endPosition.ToString());
                }
            }
        }

        void ICompressionString.FormatString(List<CompressSymbolsModel> arrList)
        {
            FormatString(arrList);
        }
    }
}
