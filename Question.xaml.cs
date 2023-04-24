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
    
    public partial class Question : Window
    {
        private string Vopros {get;set;}
        private string Answer {get;set;}
        private int Point { get;set;}
        public Question(string vopros, string answer, int point)
        {
            InitializeComponent();
            Titl.Text = vopros;
            Answer = answer;
            Point = point;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            point.Content = Point;
            Otvet.Content = Answer;
        }
    }
}
