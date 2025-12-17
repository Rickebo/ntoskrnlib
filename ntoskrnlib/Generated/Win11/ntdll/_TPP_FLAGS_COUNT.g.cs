#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _TPP_FLAGS_COUNT
    {
        [FieldOffset(0)]
        public ulong Count;
        [FieldOffset(0)]
        public ulong Flags;
        [FieldOffset(0)]
        public long Data;
    }
}