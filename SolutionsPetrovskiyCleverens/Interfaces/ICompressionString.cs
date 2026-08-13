using SolutionsPetrovskiyCleverens.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsPetrovskiyCleverens.Interfaces
{
    public interface ICompressionString
    {
        public void Conpression();
        public void FormatString(List<CompressSymbolsModel> arrList);
    }
}
