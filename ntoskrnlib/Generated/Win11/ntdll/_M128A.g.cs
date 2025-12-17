#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _M128A
    {
        [FieldOffset(0)]
        public ulong Low;
        [FieldOffset(8)]
        public long High;
    }
}