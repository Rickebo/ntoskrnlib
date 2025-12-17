#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _KALPC_DIRECT_EVENT
    {
        [FieldOffset(0)]
        public ulong Value;
        [FieldOffset(0)]
        public ulong DirectType;
        [FieldOffset(0)]
        public ulong EventReferenced;
        [FieldOffset(0)]
        public ulong EventObjectBits;
    }
}