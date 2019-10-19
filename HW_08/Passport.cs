using System;
using System.Collections.Generic;
using System.Text;

namespace HW_08
{
    class Passport
    {
        string _name;
        readonly int _id;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int ID
        {
            get { return _id; }
        }

        public Passport()
        {
            _id = CreateID();
        }

        public Passport(string passangerName)
        {
            _name = passangerName;
            _id = CreateID();
        }

        int CreateID()
        {
            Random random = new Random();
            int id = random.Next(10000000, 99999999);
            return id;
        }
    }
}
