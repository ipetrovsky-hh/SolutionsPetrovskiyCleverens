using SolutionsPetrovskiyCleverens.Interfaces;
using SolutionsPetrovskiyCleverens.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;

namespace SolutionsPetrovskiyCleverens.Controls
{
    public class ReCompressionString: IReCompressionString
    {
        private string compression;
        public string reCompression;

        public ReCompressionString(string work)
        {
            this.compression = work;
            this.reCompression = "";
        }
                
        public void ReCompression() 
        {
           FormatString(compression);
        }

        public void FormatString(string pCompressLine) 
        {
            string pResultLine = "";

            StringBuilder resompresStr = new StringBuilder(pCompressLine);

            for (int i = 0; i < pCompressLine.Length; i++)
            {
                var matchStr = Regex.Matches(resompresStr[i].ToString(), RegularExpressionModel.numberPattern);

                if (matchStr.Count == 0)
                {
                    pResultLine += pCompressLine[i];
                }
                else
                {
                    foreach (Match match in Regex.Matches(resompresStr[i].ToString(), RegularExpressionModel.numberPattern))
                    {
                        for (int smbl = 1; smbl < Convert.ToInt32(match.Value); smbl++)
                        {
                            pResultLine += resompresStr[i - 1];
                        }
                    }
                }
            }

            reCompression = pResultLine;
        }
    }
}
