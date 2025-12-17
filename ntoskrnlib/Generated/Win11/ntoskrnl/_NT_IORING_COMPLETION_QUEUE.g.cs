#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _NT_IORING_COMPLETION_QUEUE
    {
        [FieldOffset(0)]
        public uint Head;
        [FieldOffset(4)]
        public uint Tail;
        [FieldOffset(8)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public _NT_IORING_CQE[] Entries;
    }
}