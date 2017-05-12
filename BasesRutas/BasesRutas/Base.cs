using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasesRutas
{
    class Base
    {

        private string _name;

        public string name
        {
            set { _name = value; }
            get { return _name; }
        }

        private int _time;

        public int time
        {
            set { _time = value; }
            get { return _time; }
        }

        private Base _next;

        public Base next
        {
            set { _next = value; }
            get { return _next; }
        }

        public Base()
        {
            _name = "";
            _time = 0;
        }

        public override string ToString()
        {
            return "Name: " + _name.ToString() + "  Time: " + _time.ToString();
        }
    }
}
