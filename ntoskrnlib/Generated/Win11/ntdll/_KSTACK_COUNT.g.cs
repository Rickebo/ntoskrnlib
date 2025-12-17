#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _KSTACK_COUNT
    {
        [FieldOffset(0)]
        public int Value;
        [FieldOffset(0)]
        public uint State;
        [FieldOffset(0)]
        public uint StackCount;
    }
}