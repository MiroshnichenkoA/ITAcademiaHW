using System;
using System.Collections.Generic;
using System.Text;

namespace HW_08
{
    class Luggage
    {
        string _passangerName;
        int _size;

        public string PassangerName
        {
            get { return _passangerName; }
        }
        public int Size
        {
            get { return _size; }
            set { _size = value; }
        }

        public Luggage(Passanger passanger, int size)
        {
            _passangerName = passanger.Name;
            _size = size;
        }
    }
}
