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

namespace Thisshiit
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Button[] buttons;
        public MainWindow()
        {
            InitializeComponent();
            buttons = new Button[9] { _1, _2, _3, _4, _5, _6, _7, _8, _9 };
        }
    private void _1_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).Content = "X";
            (sender as Button).IsEnabled = false;

            Random random = new Random();
            int nomerKnopki = random.Next(0, 9);

            while (buttons[nomerKnopki].IsEnabled == false)
            {
                nomerKnopki = random.Next(0, 9);
                if (buttons[0].IsEnabled == false && buttons[1].IsEnabled == false && buttons[2].IsEnabled == false && buttons[3].IsEnabled == false && buttons[4].IsEnabled == false && buttons[5].IsEnabled == false && buttons[6].IsEnabled == false && buttons[7].IsEnabled == false && buttons[8].IsEnabled == false)
                {
                    break;
                }
            }
            buttons[nomerKnopki].Content = "O";
            buttons[nomerKnopki].IsEnabled = false;
        }
        private void reset_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }

}
