#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _HEAP_LFH_ONDEMAND_POINTER
    {
        [FieldOffset(0)]
        public ushort Invalid;
        [FieldOffset(0)]
        public ushort AllocationInProgress;
        [FieldOffset(0)]
        public ushort Spare0;
        [FieldOffset(2)]
        public ushort UsageData;
        [FieldOffset(0)]
        public IntPtr AllBits;
    }
}