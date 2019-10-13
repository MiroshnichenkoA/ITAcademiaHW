using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyOne
{
    public class Motorcycle
    {
        public const byte EngineVolumePublic = 43;
        protected const byte EngineVolumeProtected = 43;
        internal const byte EngineVolumeInternal = 43;
        protected internal const byte EngineVolumeProtectedInternal = 43;
        private const byte EngineVolumePrivate = 43;
        private protected const byte EngineVolumePrivateProtected = 43;
        public ushort maxSpeedPublic = 180;
        protected ushort maxSpeedProtected = 180;
        internal ushort maxSpeedInternal = 180;
        protected internal ushort maxSpeedProtectedInternal = 180;
        private ushort maxSpeedPrivate = 180;
        private protected ushort maxSpeedPrivateProtected = 180;

        public void StartEnginePublic()
        {
        }

        protected void StartEngineProtected()
        {
        }

        internal void StartEngineInternal()
        {
        }

        protected internal void StartEngineProtectedInternal()
        {
        }

        private void StartEnginePrivate()
        {
        }

        private protected void StartEnginePrivateProtected()
        {
        }
    }
}
