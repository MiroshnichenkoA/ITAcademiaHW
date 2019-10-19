using System;

namespace HW_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Airplane airplane = new Airplane();
            Passanger passanger = new Passanger();

            Bot bot = passanger.GoToCheckIn();

            bot.Greet(bot.Time, passanger.Name, airplane.AirportName);
            if (passanger.Name == null)
            {
               passanger.Name = bot.AskName();
            }
            bot.AskPassport(passanger);
            bot.CheckPassport(passanger.Name, passanger.Passport.Name);
            if (passanger.Tiket == null) bot.PrintTiket(passanger, airplane.AirportName);
            bool isThereAnyLuggage = bot.AskAboutLuggage(passanger);
            if (isThereAnyLuggage)
            {
                passanger.Luggage.Size = bot.WhatIstheSizeOfLuggage();
                Luggage luggage = new Luggage(passanger, passanger.Luggage.Size);
                bot.TakeLuggage(luggage);
            }
            bot.GoTOSecurityCheck(passanger);
            passanger.SecurityCheck();
            passanger.PassportControl();
            bot.CheckPassport(passanger.Name, passanger.Passport.Name);
            passanger.GoToPlane(passanger.Tiket);
        }
    }
}
