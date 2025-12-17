#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _RTL_CHASH_TABLE
    {
        [FieldOffset(0)]
        public IntPtr Table;
        [FieldOffset(8)]
        public uint EntrySizeShift;
        [FieldOffset(12)]
        public uint EntryMax;
        [FieldOffset(16)]
        public uint EntryCount;
    }
}