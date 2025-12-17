#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _HMAP_ENTRY
    {
        [FieldOffset(0)]
        public ulong BlockOffset;
        [FieldOffset(8)]
        public ulong PermanentBinAddress;
        [FieldOffset(16)]
        public uint MemAlloc;
    }
}