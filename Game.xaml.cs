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

namespace svoya_igra
{
    /// <summary>
    /// Логика взаимодействия для Game.xaml
    /// </summary>
    public partial class Game : Window
    {
        string comba;
        public Game(string comba1)
        {
            
            InitializeComponent();
            comba = comba1;
            label1.Content = comba;
        }

        private void but6_Click(object sender, RoutedEventArgs e)
        {
            

        }

        
    }
}
