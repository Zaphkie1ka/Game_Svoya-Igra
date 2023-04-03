using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace svoya_igra
{
    internal class Questions
    {
        private string _handler;
        private string _title;
        private int _point;
        private string _answer;
        public string Title
        {
            get {return _title;}
            set {_title = value;}
        }
        public int Point
        {
            get {return _point;}
            set {_point = value;}
        }
        public string Answer
        {
            get {return _answer;}
            set {_answer = value;}
        }
    }
}
