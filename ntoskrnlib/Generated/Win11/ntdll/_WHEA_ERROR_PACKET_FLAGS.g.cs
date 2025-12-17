#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _WHEA_ERROR_PACKET_FLAGS
    {
        [FieldOffset(0)]
        public uint PreviousError;
        [FieldOffset(0)]
        public uint CriticalEvent;
        [FieldOffset(0)]
        public uint HypervisorError;
        [FieldOffset(0)]
        public uint Simulated;
        [FieldOffset(0)]
        public uint PlatformPfaControl;
        [FieldOffset(0)]
        public uint PlatformDirectedOffline;
        [FieldOffset(0)]
        public uint AddressTranslationRequired;
        [FieldOffset(0)]
        public uint AddressTranslationCompleted;
        [FieldOffset(0)]
        public uint RecoveryOptional;
        [FieldOffset(0)]
        public uint Reserved2;
        [FieldOffset(0)]
        public uint AsULONG;
    }
}