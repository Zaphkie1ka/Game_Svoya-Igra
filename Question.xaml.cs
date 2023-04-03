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
    /// Логика взаимодействия для Question.xaml
    /// </summary>
    public partial class Question : Window
    {
        int Handler;
        public Question(int handler)
        {
            InitializeComponent();
            Handler = handler;
        }
        List<Questions> questions = new List<Questions>
        {
            new Questions{Title="Какое основное число используют программисты?", Point = 100, Answer="2"},
            new Questions{Title="Кто создал программы, установленные на вашем компьютере?", Point = 200, Answer="Человек"},
            new Questions{Title="Какая наука занимается изучением всевозможных способов получения, передачи, хранения и обработки информации?", Point = 300, Answer="Информатика"},
            new Questions{Title="Для длительного хранения информации в компьютере используется", Point = 400, Answer="Жесткий диск"},
            new Questions{Title="Кто такой программист?", Point = 500, Answer="Человек-человечек"},
            new Questions{Title="Что передает интернет по помещению?", Point = 100, Answer="Модем"},
            new Questions{Title="Без чего не работает компьютер?", Point = 200, Answer="Процессор"},
            new Questions{Title="Что будет, если вытащить оперативную память из работающего компьютера?", Point = 300, Answer="Изображение покроется рябью"},
            new Questions{Title="Без какого устройства нельзя работать в современном мире", Point = 400, Answer="Руки"},
            new Questions{Title="Для чего работает компьютер в ночное время?", Point = 500, Answer="Чтобы скачать объемную игру"},
            new Questions{Title="Кто в свое время создал яблоко?", Point = 100, Answer="Стив Джобс"},
            new Questions{Title="Основатель интел?", Point = 200, Answer="Гордон Мур"},
            new Questions{Title="Кто создал первый ПК?", Point = 300, Answer="Конрад Цузе"},
            new Questions{Title="Кто сделал Dr. Web?", Point = 400, Answer="И. А. Данилов"},
            new Questions{Title="В какой стране появился первый ПК?", Point = 500, Answer="Германия"},
            new Questions{Title="Язык программирования, который учат в школе", Point = 100, Answer="PascalABC"},
            new Questions{Title="Это приложение написано на языке", Point = 200, Answer="C#"},
            new Questions{Title="Сколько бы времени не прошло, он будет востребован всегда", Point = 300, Answer="Python"},
            new Questions{Title="На нем написаны сайты", Point = 400, Answer="HTML"},
            new Questions{Title="После языков группы С был разработана группа языков", Point = 500, Answer="F"},
            new Questions{Title="Халавные баллы", Point = 100, Answer="Сюда"},
            new Questions{Title="Еще халавных баллов", Point = 200, Answer="Сюда"},
            new Questions{Title="Ого, еще халява", Point = 300, Answer="Сюда"},
            new Questions{Title="Не, уже не смешно", Point = 400, Answer="Сюда"},
            new Questions{Title="Последняя раздача", Point = 500, Answer="Сюда"}
        };
    }
}
