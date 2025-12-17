#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _EVENT_FILTER_DESCRIPTOR
    {
        [FieldOffset(0)]
        public ulong Ptr;
        [FieldOffset(8)]
        public uint Size;
        [FieldOffset(12)]
        public uint Type;
    }
}