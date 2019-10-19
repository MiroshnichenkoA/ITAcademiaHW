using System;
using System.Collections.Generic;
using System.Text;

namespace HW_08
{
    class Bot
    {
        int _currentTime;

        public int Time
        {
            get { return _currentTime; }
        }

        public Bot()
        {
            _currentTime = DateTime.Now.Hour;
        }

        public void Greet(int currentTime, string passangerName, string airportName)
        {
            if (currentTime >= 6 && currentTime < 11) Console.WriteLine($"- Good morning, {passangerName}! Welocom to the Airport {airportName}!");
            else if (currentTime >= 11 && currentTime < 16) Console.WriteLine($"- Good day, {passangerName}! Welocom to the Airport {airportName}!");
            else if (currentTime >= 16 && currentTime < 24) Console.WriteLine($"- Good evening, {passangerName}! Welocom to the Airport {airportName}!");
            else Console.WriteLine($"- Good night, {passangerName}! Welcome to the Airport {airportName}!");
        }

        public string AskName()
        {
            Console.WriteLine("- Please, tell me your name");
            string name = Console.ReadLine();
            Console.WriteLine($"- Thank you, {name}");
            return name;
        }

        public void AskPassport(Passanger passanger)
        {
            string name = passanger.Name;
            Console.WriteLine($"- {name}, may I take your passport, please");
            if (passanger.Passport.Name == null)
            {
                passanger.Passport.Name = passanger.Name;
            }
        }

        public void CheckPassport(string passangerName, string nameInPassport)
        {
            bool check = passangerName.Equals(nameInPassport);
            switch (check)
            {
                case true: Console.WriteLine("Thank you, everything is OK");
                    break;
                case false: Console.WriteLine("I have to call the police");
                    break;
            }
        }

        public void PrintTiket(Passanger passanger, string airportName)
        {
            Random random = new Random();
            int seat = random.Next(1, 80);
            passanger.Tiket = new Tiket(passanger.Name, airportName, DateTime.Today, seat);
        }

        public bool AskAboutLuggage(Passanger passanger)
        {
            Console.WriteLine($"Excuse me, {passanger.Name}. Do you have any luggage?");
            string answer = Console.ReadLine();
            bool result = true;
            switch (answer)
            {
                case "YES":
                    {
                        result = true;
                        passanger.Luggage = new Luggage(passanger, 0);
                    }
                    break;
                case "NO": result = false;
                    break;
                default:
                    {
                        Console.WriteLine("Please, answer the qustion");
                        answer = Console.ReadLine();
                    }
                    break;
            }
            return result;
        }

        public int WhatIstheSizeOfLuggage()
        {
            Console.WriteLine("Enter '0' if your luggage is cabin, enter '1' if your luggage is buggage");
            string answer = Console.ReadLine();
            int size = 0;
            switch (answer)
            {
                case "0": size = 0;
                    break;
                case "1": size = 1;
                    break;
                default:
                    Console.WriteLine("Enter '0' if your luggage is cabin, enter '1' if your luggage is buggage");
                    answer = Console.ReadLine();
                    break;
            }
            return size;
        }

        public void  TakeLuggage(Luggage luggage)
        {
            if (luggage.Size == 0) Console.WriteLine($"Dear {luggage.PassangerName}, you can take your luggage to cabin");
            else Console.WriteLine($"Ok, {luggage.PassangerName}, I'will take your luggage on board. Thank you");
        }

        public void GoTOSecurityCheck(Passanger passanger)
        {
            Console.WriteLine($"{passanger.Name}, please follow to the Secutity check");
        }
    }
}