#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _EVENT_PAYLOAD_PREDICATE
    {
        [FieldOffset(0)]
        public ushort FieldIndex;
        [FieldOffset(2)]
        public ushort CompareOp;
        [FieldOffset(8)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public ulong[] Value;
    }
}