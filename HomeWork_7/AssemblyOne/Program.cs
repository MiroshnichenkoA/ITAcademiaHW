using System;

namespace AssemblyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle moto = new Motorcycle();
            byte engineVolume;
            engineVolume = Motorcycle.EngineVolumePublic;
            engineVolume = Motorcycle.EngineVolumeInternal;
            engineVolume = Motorcycle.EngineVolumeProtectedInternal;
            int maxSpeed;
            maxSpeed = moto.maxSpeedPublic;
            maxSpeed = moto.maxSpeedInternal;
            maxSpeed = moto.maxSpeedProtectedInternal;
            moto.StartEnginePublic();
            moto.StartEngineInternal();
            moto.StartEngineProtectedInternal();
        }
    }
}
