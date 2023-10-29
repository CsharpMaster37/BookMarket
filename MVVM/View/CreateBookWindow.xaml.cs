using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BookMarket.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для CreateBookWindow.xaml
    /// </summary>
    public partial class CreateBookWindow : Window
    {
        public CreateBookWindow()
        {
            InitializeComponent();
        }
        private void Drag(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void CloseButton_MouseDown_1(object sender, MouseButtonEventArgs e) => this.Close();
    }
}
