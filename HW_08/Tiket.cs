using System;
using System.Collections.Generic;
using System.Text;

namespace HW_08
{
    class Tiket
    {
        string _name;
        string _airportname;
        DateTime _data;
        int _seat;

        public string Name
        {
            get { return _name; }
        }

        public int Seat
        {
            get { return _seat; }
        }

        public Tiket(string name, string airport, DateTime date, int seat)
        {
            _name = name;
            _airportname = airport;
            _data = date;
            _seat = seat;
        }
    }
}
