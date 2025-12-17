#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _HEAP_LFH_LIST_ENTRY
    {
        [FieldOffset(0)]
        public ushort Next;
        [FieldOffset(0)]
        public ulong Preserve;
        [FieldOffset(8)]
        public uint Check;
    }
}