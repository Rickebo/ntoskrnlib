#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _PNP_REPLACE_PROCESSOR_LIST
    {
        [FieldOffset(0)]
        public IntPtr Affinity;
        [FieldOffset(8)]
        public uint GroupCount;
        [FieldOffset(12)]
        public uint AllocatedCount;
        [FieldOffset(16)]
        public uint Count;
        [FieldOffset(20)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public uint[] ApicIds;
    }
}