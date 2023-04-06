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
        private void but1_Click(object sender, RoutedEventArgs e)
        {
            Question question = new Question(Spisok.questions[0].Title, Spisok.questions[0].Answer);
            question.Show();
        }

        private void but2_Click(object sender, RoutedEventArgs e)
        {
            Question question = new Question(Spisok.questions[1].Title, Spisok.questions[1].Answer);
            question.Show();
        }

        private void but3_Click(object sender, RoutedEventArgs e)
        {
            Question question = new Question(Spisok.questions[2].Title, Spisok.questions[2].Answer);
            question.Show();
        }

        private void but4_Click(object sender, RoutedEventArgs e)
        {
            Question question = new Question(Spisok.questions[3].Title, Spisok.questions[3].Answer);
            question.Show();
        }

        private void but5_Click(object sender, RoutedEventArgs e)
        {
            Question question = new Question(Spisok.questions[4].Title, Spisok.questions[4].Answer);
            question.Show();
        }

        private void but6_Click(object sender, RoutedEventArgs e)
        {
            Question question = new Question(Spisok.questions[5].Title, Spisok.questions[5].Answer);
            question.Show();
        }

        private void but7_Click(object sender, RoutedEventArgs e)
        {
            Question question = new Question(Spisok.questions[6].Title, Spisok.questions[6].Answer);
            question.Show();
        }

        private void but8_Click(object sender, RoutedEventArgs e)
        {
            Question question = new Question(Spisok.questions[7].Title, Spisok.questions[7].Answer);
            question.Show();
        }

        private void but9_Click(object sender, RoutedEventArgs e)
        {
            Question question = new Question(Spisok.questions[8].Title, Spisok.questions[8].Answer);
            question.Show();
        }

        private void but10_Click(object sender, RoutedEventArgs e)
        {
            Question question = new Question(Spisok.questions[9].Title, Spisok.questions[9].Answer);
            question.Show();
        }

        private void but11_Click(object sender, RoutedEventArgs e)
        {
            Question question = new Question(Spisok.questions[10].Title, Spisok.questions[10].Answer);
            question.Show();
        }

        private void but12_Click(object sender, RoutedEventArgs e)
        {
            Question question = new Question(Spisok.questions[11].Title, Spisok.questions[11].Answer);
            question.Show();
        }

        private void but13_Click(object sender, RoutedEventArgs e)
        {
            Question question = new Question(Spisok.questions[12].Title, Spisok.questions[12].Answer);
            question.Show();
        }

        private void but14_Click(object sender, RoutedEventArgs e)
        {
            Question question = new Question(Spisok.questions[13].Title, Spisok.questions[13].Answer);
            question.Show();
        }

        private void but15_Click(object sender, RoutedEventArgs e)
        {
            Question question = new Question(Spisok.questions[14].Title, Spisok.questions[14].Answer);
            question.Show();
        }

        private void but16_Click(object sender, RoutedEventArgs e)
        {
            Question question = new Question(Spisok.questions[15].Title, Spisok.questions[15].Answer);
            question.Show();
        }

        private void but17_Click(object sender, RoutedEventArgs e)
        {
            Question question = new Question(Spisok.questions[16].Title, Spisok.questions[16].Answer);
            question.Show();
        }

        private void but18_Click(object sender, RoutedEventArgs e)
        {
            Question question = new Question(Spisok.questions[17].Title, Spisok.questions[17].Answer);
            question.Show();
        }

        private void but19_Click(object sender, RoutedEventArgs e)
        {
            Question question = new Question(Spisok.questions[18].Title, Spisok.questions[18].Answer);
            question.Show();
        }

        private void but20_Click(object sender, RoutedEventArgs e)
        {
            Question question = new Question(Spisok.questions[19].Title, Spisok.questions[19].Answer);
            question.Show();
        }

        private void but21_Click(object sender, RoutedEventArgs e)
        {
            Question question = new Question(Spisok.questions[20].Title, Spisok.questions[20].Answer);
            question.Show();
        }

        private void but22_Click(object sender, RoutedEventArgs e)
        {
            Question question = new Question(Spisok.questions[21].Title, Spisok.questions[21].Answer);
            question.Show();
        }

        private void but23_Click(object sender, RoutedEventArgs e)
        {
            Question question = new Question(Spisok.questions[22].Title, Spisok.questions[22].Answer);
            question.Show();
        }

        private void but24_Click(object sender, RoutedEventArgs e)
        {
            Question question = new Question(Spisok.questions[23].Title, Spisok.questions[24].Answer);
            question.Show();
        }

        private void but25_Click(object sender, RoutedEventArgs e)
        {
            Question question = new Question(Spisok.questions[25].Title, Spisok.questions[25].Answer);
            question.Show();
        }
    }
}
