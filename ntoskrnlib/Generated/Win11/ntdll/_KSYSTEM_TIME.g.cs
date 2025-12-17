#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial struct _KSYSTEM_TIME
    {
        [FieldOffset(0)]
        public uint LowPart;
        [FieldOffset(4)]
        public int High1Time;
        [FieldOffset(8)]
        public int High2Time;
    }
}