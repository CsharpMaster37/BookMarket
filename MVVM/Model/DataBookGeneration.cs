using BookMarket.MVVM.Model.Interfaces;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMarket.MVVM.Model.Books;

namespace BookMarket.MVVM.Model
{
    public class DataBookGeneration : IDataBookGeneration
    {
        public void CreateArrayForGenerateBook(List<string[]> ArrayGenerate)
        {
            StreamReader sr = new StreamReader("../../FileGenerate.txt");
            while (!sr.EndOfStream)
                ArrayGenerate.Add(sr.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries));
        }
        public void Generation(int countType, HashSet<int> unique)
        {
            Random rd = new Random();
            int index;
            for (int i = 0; i < countType; i++)
            {
                if (unique.Count == 100)
                    return;
                index = rd.Next(0, App.ArrayGenerate.Count - 1);
                if (unique.Contains(index))
                {
                    for (int j = 0; j < 100; j++)
                    {
                        if (!unique.Contains(index)) { unique.Add(index); index = j; break; }
                    }
                }
                else
                {
                    unique.Add(index);
                }
                string[] element = App.ArrayGenerate[index];
                App._market.AddBook(new Book(element[0], element[1], element[2], int.Parse(element[3]), int.Parse(element[4]), element[5], element[6], int.Parse(element[7])), rd.Next(1, 15));
            }
        }
    }
}
