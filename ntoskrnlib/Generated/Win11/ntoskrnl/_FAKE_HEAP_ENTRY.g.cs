#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _FAKE_HEAP_ENTRY
    {
        [FieldOffset(0)]
        public ulong Size;
        [FieldOffset(8)]
        public ulong PreviousSize;
    }
}