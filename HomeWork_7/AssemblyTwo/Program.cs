using System;

namespace AssemblyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            AssemblyOne.Motorcycle moto = new AssemblyOne.Motorcycle();
            int maxSpeed = moto.maxSpeedPublic;
            int engineVolume = moto.maxSpeedPublic;
            moto.StartEnginePublic();
        }
    }
}
