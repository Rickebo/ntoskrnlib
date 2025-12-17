#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _ARBITER_CONFLICT_INFO
    {
        [FieldOffset(0)]
        public IntPtr OwningObject;
        [FieldOffset(8)]
        public ulong Start;
        [FieldOffset(16)]
        public ulong End;
    }
}