#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _ARBITER_RETEST_ALLOCATION_PARAMETERS
    {
        [FieldOffset(0)]
        public IntPtr ArbitrationList;
        [FieldOffset(8)]
        public uint AllocateFromCount;
        [FieldOffset(16)]
        public IntPtr AllocateFrom;
    }
}