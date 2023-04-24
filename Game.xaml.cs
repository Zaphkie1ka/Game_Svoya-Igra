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
        int sum;
        public Game(string comba1)
        {
            InitializeComponent();
            comba = comba1;
            label1.Content = comba;
        }
        private void but1_Click(object sender, RoutedEventArgs e)
        {
            Question question = new Question(Spisok.questions[0].Title, Spisok.questions[0].Answer, Spisok.questions[0].Point);
            question.Show();
        }

        private void but2_Click(object sender, RoutedEventArgs e)
        {
            Question question = new Question(Spisok.questions[1].Title, Spisok.questions[1].Answer, Spisok.questions[1].Point);
            question.Show();
        }

        private void but3_Click(object sender, RoutedEventArgs e)
        {
            Question question = new Question(Spisok.questions[2].Title, Spisok.questions[2].Answer, Spisok.questions[2].Point);
            question.Show();
        }

        private void but4_Click(object sender, RoutedEventArgs e)
        {
            Question question = new Question(Spisok.questions[3].Title, Spisok.questions[3].Answer, Spisok.questions[3].Point);
            question.Show();
        }

        private void but5_Click(object sender, RoutedEventArgs e)
        {
            Question question = new Question(Spisok.questions[4].Title, Spisok.questions[4].Answer, Spisok.questions[4].Point);
            question.Show();
        }

        private void but6_Click(object sender, RoutedEventArgs e)
        {
            Question question = new Question(Spisok.questions[5].Title, Spisok.questions[5].Answer, Spisok.questions[5].Point);
            question.Show();
        }

        private void but7_Click(object sender, RoutedEventArgs e)
        {
            Question question = new Question(Spisok.questions[6].Title, Spisok.questions[6].Answer, Spisok.questions[6].Point);
            question.Show();
        }

        private void but8_Click(object sender, RoutedEventArgs e)
        {
            Question question = new Question(Spisok.questions[7].Title, Spisok.questions[7].Answer, Spisok.questions[7].Point);
            question.Show();
        }

        private void but9_Click(object sender, RoutedEventArgs e)
        {
            Question question = new Question(Spisok.questions[8].Title, Spisok.questions[8].Answer, Spisok.questions[8].Point);
            question.Show();
        }

        private void but10_Click(object sender, RoutedEventArgs e)
        {
            Question question = new Question(Spisok.questions[9].Title, Spisok.questions[9].Answer, Spisok.questions[9].Point);
            question.Show();
        }

        private void but11_Click(object sender, RoutedEventArgs e)
        {
            Question question = new Question(Spisok.questions[10].Title, Spisok.questions[10].Answer, Spisok.questions[10].Point);
            question.Show();
        }

        private void but12_Click(object sender, RoutedEventArgs e)
        {
            Question question = new Question(Spisok.questions[11].Title, Spisok.questions[11].Answer, Spisok.questions[11].Point);
            question.Show();
        }

        private void but13_Click(object sender, RoutedEventArgs e)
        {
            Question question = new Question(Spisok.questions[12].Title, Spisok.questions[12].Answer, Spisok.questions[12].Point);
            question.Show();
        }

        private void but14_Click(object sender, RoutedEventArgs e)
        {
            Question question = new Question(Spisok.questions[13].Title, Spisok.questions[13].Answer, Spisok.questions[13].Point);
            question.Show();
        }

        private void but15_Click(object sender, RoutedEventArgs e)
        {
            Question question = new Question(Spisok.questions[14].Title, Spisok.questions[14].Answer, Spisok.questions[14].Point);
            question.Show();
        }

        private void but16_Click(object sender, RoutedEventArgs e)
        {
            Question question = new Question(Spisok.questions[15].Title, Spisok.questions[15].Answer, Spisok.questions[15].Point);
            question.Show();
        }

        private void but17_Click(object sender, RoutedEventArgs e)
        {
            Question question = new Question(Spisok.questions[16].Title, Spisok.questions[16].Answer, Spisok.questions[16].Point);
            question.Show();
        }

        private void but18_Click(object sender, RoutedEventArgs e)
        {
            Question question = new Question(Spisok.questions[17].Title, Spisok.questions[17].Answer, Spisok.questions[17].Point);
            question.Show();
        }

        private void but19_Click(object sender, RoutedEventArgs e)
        {
            Question question = new Question(Spisok.questions[18].Title, Spisok.questions[18].Answer, Spisok.questions[18].Point);
            question.Show();
        }

        private void but20_Click(object sender, RoutedEventArgs e)
        {
            Question question = new Question(Spisok.questions[19].Title, Spisok.questions[19].Answer, Spisok.questions[19].Point);
            question.Show();
        }

        private void but21_Click(object sender, RoutedEventArgs e)
        {
            Question question = new Question(Spisok.questions[20].Title, Spisok.questions[20].Answer, Spisok.questions[20].Point);
            question.Show();
        }

        private void but22_Click(object sender, RoutedEventArgs e)
        {
            Question question = new Question(Spisok.questions[21].Title, Spisok.questions[21].Answer, Spisok.questions[21].Point);
            question.Show();
        }

        private void but23_Click(object sender, RoutedEventArgs e)
        {
            Question question = new Question(Spisok.questions[22].Title, Spisok.questions[22].Answer, Spisok.questions[22].Point);
            question.Show();
        }

        private void but24_Click(object sender, RoutedEventArgs e)
        {
            Question question = new Question(Spisok.questions[23].Title, Spisok.questions[23].Answer, Spisok.questions[23].Point);
            question.Show();
        }

        private void but25_Click(object sender, RoutedEventArgs e)
        {
            Question question = new Question(Spisok.questions[24].Title, Spisok.questions[24].Answer, Spisok.questions[24].Point);
            question.Show();
        }
    }
}
