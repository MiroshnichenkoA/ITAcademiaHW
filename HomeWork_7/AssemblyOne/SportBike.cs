using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyOne
{
    class SportBike: Motorcycle
    {
        Motorcycle moto = new Motorcycle();
        byte engineVolumeProtected = Motorcycle.EngineVolumeProtected;
        byte engineVolumePrivateProtected = Motorcycle.EngineVolumePrivateProtected;
        byte engineVolumePublic = Motorcycle.EngineVolumePublic;
        byte engineVolumeInternal = Motorcycle.EngineVolumeInternal;
        byte engineVolumeProtectedInternal = Motorcycle.EngineVolumeProtectedInternal;

        void StartEngine()
        {
            StartEngineProtected();
            StartEnginePrivateProtected();
        }
    }
}
