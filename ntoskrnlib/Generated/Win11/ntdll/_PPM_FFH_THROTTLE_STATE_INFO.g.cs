#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _PPM_FFH_THROTTLE_STATE_INFO
    {
        [FieldOffset(0)]
        public byte EnableLogging;
        [FieldOffset(4)]
        public uint MismatchCount;
        [FieldOffset(8)]
        public byte Initialized;
        [FieldOffset(16)]
        public ulong LastValue;
        [FieldOffset(24)]
        public _LARGE_INTEGER LastLogTickCount;
    }
}