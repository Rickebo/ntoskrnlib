#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 84)]
    public partial struct _IOP_IRP_STACK_PROFILER
    {
        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
        public uint[] Profile;
        [FieldOffset(80)]
        public uint TotalIrps;
    }
}