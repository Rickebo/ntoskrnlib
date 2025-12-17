#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _ARBITER_ORDERING
    {
        [FieldOffset(0)]
        public ulong Start;
        [FieldOffset(8)]
        public ulong End;
    }
}