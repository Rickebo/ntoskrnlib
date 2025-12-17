#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 256)]
    public partial struct _HEAP_LFH_HEAT_MAP
    {
        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 126)]
        public ushort[] Counts;
        [FieldOffset(252)]
        public uint LastDecayPeriod;
    }
}