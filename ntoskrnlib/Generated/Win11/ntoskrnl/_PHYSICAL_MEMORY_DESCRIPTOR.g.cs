#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _PHYSICAL_MEMORY_DESCRIPTOR
    {
        [FieldOffset(0)]
        public uint NumberOfRuns;
        [FieldOffset(8)]
        public ulong NumberOfPages;
        [FieldOffset(16)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public _PHYSICAL_MEMORY_RUN[] Run;
    }
}