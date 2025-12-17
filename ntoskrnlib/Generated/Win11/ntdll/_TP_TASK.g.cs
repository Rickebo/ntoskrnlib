#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _TP_TASK
    {
        [FieldOffset(0)]
        public IntPtr Callbacks;
        [FieldOffset(8)]
        public uint NumaNode;
        [FieldOffset(12)]
        public byte IdealProcessor;
        [FieldOffset(16)]
        public _LIST_ENTRY ListEntry;
    }
}