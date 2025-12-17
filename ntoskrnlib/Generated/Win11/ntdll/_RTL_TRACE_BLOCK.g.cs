#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _RTL_TRACE_BLOCK
    {
        [FieldOffset(0)]
        public uint Magic;
        [FieldOffset(4)]
        public uint Count;
        [FieldOffset(8)]
        public uint Size;
        [FieldOffset(16)]
        public ulong UserCount;
        [FieldOffset(24)]
        public ulong UserSize;
        [FieldOffset(32)]
        public IntPtr UserContext;
        [FieldOffset(40)]
        public IntPtr Next;
        [FieldOffset(48)]
        public IntPtr Trace;
    }
}