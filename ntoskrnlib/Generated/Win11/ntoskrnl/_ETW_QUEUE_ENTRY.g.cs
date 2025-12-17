#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _ETW_QUEUE_ENTRY
    {
        [FieldOffset(0)]
        public _LIST_ENTRY ListEntry;
        [FieldOffset(16)]
        public IntPtr DataBlock;
        [FieldOffset(24)]
        public IntPtr RegEntry;
        [FieldOffset(32)]
        public IntPtr ReplyObject;
        [FieldOffset(40)]
        public IntPtr WakeReference;
        [FieldOffset(48)]
        public ushort RegIndex;
        [FieldOffset(50)]
        public ushort ReplyIndex;
        [FieldOffset(52)]
        public uint Flags;
    }
}