#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _JOBOBJECT_ENERGY_TRACKING_STATE
    {
        [FieldOffset(0)]
        public ulong Value;
        [FieldOffset(0)]
        public uint UpdateMask;
        [FieldOffset(4)]
        public uint DesiredState;
    }
}