#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct _HEAP_STOP_ON_VALUES
    {
        [FieldOffset(0)]
        public ulong AllocAddress;
        [FieldOffset(8)]
        public _HEAP_STOP_ON_TAG AllocTag;
        [FieldOffset(16)]
        public ulong ReAllocAddress;
        [FieldOffset(24)]
        public _HEAP_STOP_ON_TAG ReAllocTag;
        [FieldOffset(32)]
        public ulong FreeAddress;
        [FieldOffset(40)]
        public _HEAP_STOP_ON_TAG FreeTag;
    }
}