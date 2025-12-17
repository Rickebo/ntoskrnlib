#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _FILE_STANDARD_INFORMATION
    {
        [FieldOffset(0)]
        public _LARGE_INTEGER AllocationSize;
        [FieldOffset(8)]
        public _LARGE_INTEGER EndOfFile;
        [FieldOffset(16)]
        public uint NumberOfLinks;
        [FieldOffset(20)]
        public byte DeletePending;
        [FieldOffset(21)]
        public byte Directory;
    }
}