#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _EXT_SET_PARAMETERS_V0
    {
        [FieldOffset(0)]
        public uint Version;
        [FieldOffset(4)]
        public uint Reserved;
        [FieldOffset(8)]
        public long NoWakeTolerance;
    }
}