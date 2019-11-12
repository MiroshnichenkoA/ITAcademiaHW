using System;
using System.Collections.Generic;
using System.Text;

namespace HW_08
{
    class Passanger
    {
        string _name;
        Passport _passport;
        Tiket _tiket;
        Luggage _luggage;

        public string Name
        {
            get { return _name; }
            set{ _name = value; }
        }

        public Passport Passport
        {
            get { return _passport; }
        }

        public Tiket Tiket
        {
            get { return _tiket; }
            set { _tiket = value; }
        }

        public Luggage Luggage
        {
            get { return _luggage; }
            set { _luggage = value; }
        }

        public Passanger()
        {
           _passport = new Passport();
        }

        public Passanger(string name)
        {
            _name = name;
            _passport = new Passport(name);
        }

        public Bot GoToCheckIn()
        {
            Bot bot = new Bot();
            return bot;
        }

        public void SecurityCheck()
        {
            Security security = new Security();
            security.Check();
        }

        public void PassportControl()
        {
            Console.WriteLine("It's passport control now. Please, give me your passport");
        }

        public void GoToPlane(Tiket tiket)
        {
            Console.WriteLine($"{tiket.Name}, welcome aboard. Your seat number is {tiket.Seat}, please, take your seat and enjoy the flight");
        }
    }
}
