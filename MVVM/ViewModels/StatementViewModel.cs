using BookMarket.MVVM.Model;
using BookMarket.MVVM.Model.Books;
using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BookMarket.MVVM.ViewModels
{
    public class StatementViewModel : ViewModelBase
    {
        public Visibility _statementVisibility { get; set; } = Visibility.Hidden;
        public ObservableCollection<Statement> Statement { get; set; }
        public StatementViewModel()
        {
            Statement = new ObservableCollection<Statement>();
        }
        public void Add(Book book, int deliverytime, int count)
        {
            Statement.Add(new Statement(book, deliverytime, count));
        }
        public void Remove(Statement book)
        {
            Statement.Remove(book);
        }
    }
}
