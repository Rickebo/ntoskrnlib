#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _PROCESSOR_CYCLES_WORKLOAD_CLASS
    {
        [FieldOffset(0)]
        public uint Count;
        [FieldOffset(8)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public ulong[] ProcessorCyclesClass;
    }
}