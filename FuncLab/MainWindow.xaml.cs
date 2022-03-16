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
using System.Windows.Navigation;
using System.Windows.Shapes;
using AllXFiller;
using AllYFinder;
using DataGridFiller;

namespace FuncLab
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private int[] _xMas;
        private void EnterXMenu_Click(object sender, RoutedEventArgs e)
        {
            int firstX, secondX;//Значения диапазона
            try
            {
                firstX = Convert.ToInt32(FirstX.Text);
            }
            catch
            {
                MessageBox.Show("Некорректно введено значение диапазона 1", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                FirstX.Focus();
                return;
            }
            try
            {
                secondX = Convert.ToInt32(SecondX.Text);
            }
            catch
            {
                MessageBox.Show("Некорректно введено значение диапазона 2", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                SecondX.Focus();
                return;
            }
            Table.ItemsSource = null;
            VisualArray.ClearDataTable();
            Table.ItemsSource = VisualArray.XToDataTable(_xMas = XFiller.XFill(firstX, secondX)).DefaultView;
        }

        private void FindY111Menu_Click(object sender, RoutedEventArgs e)
        {
            int a;
            try
            {
                a = Convert.ToInt32(ValueA.Text);
            }
            catch
            {
                MessageBox.Show("Некорректно введено значение 'a'", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                ValueA.Focus();
                return;
            }
            if (_xMas == null)
            {
                MessageAboutXMasIsNull();
            }
            else
            {
                Table.ItemsSource = null;
                VisualArray.GiveToColumnA(a);
                Table.ItemsSource = VisualArray.YToDataTable(YFinder11_1.YFind(_xMas, a), 1).DefaultView;
            }
        }
        private void MessageAboutXMasIsNull()
        {
            MessageBox.Show("Значения X не установлены", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            FirstX.Focus();
        }

        private void FindY112Menu_Click(object sender, RoutedEventArgs e)
        {
            if (_xMas == null)
            {
                MessageAboutXMasIsNull();
            }
            else
            {
                Table.ItemsSource = null;
                Table.ItemsSource = VisualArray.YToDataTable(YFinder11_2.YFind(_xMas), 2).DefaultView;
            }
        }

        private void ClearTable_Click(object sender, RoutedEventArgs e)
        {
            Table.ItemsSource = null;
            _xMas = null;
            VisualArray.ClearDataTable();
        }

        private void Support_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Данная программа имеет следующие возможности:\n" +
                "1) В заданном промежутке 'x' найти значения функции 'y'\n" +
                "2) Если требуется найти лишь 1 значение - ввести одинаковое число в диапазоне (например, от 24 до 24)\n" +
                "3) Имеется возможность пользоваться AccessKeys для быстрого выполнения однотипных действий (Alt+Подчеркнутая буква в меню)\n" +
                "4) Доступна возможность вводить лишь 1 значение 'a' для интервала(от x1 до x2)"
                , "Справка", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void AboutProgram_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Лопаткин Сергей ИСП-31 (HaproBishop на GitHub)"
                , "О программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
