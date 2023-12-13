using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMarket.MVVM.Model.Interfaces
{
    public interface IDataBookGeneration
    {
        void CreateArrayForGenerateBook(List<string[]> ArrayGenerate);
        void Generation(int countType, HashSet<int> unique);
    }
}
