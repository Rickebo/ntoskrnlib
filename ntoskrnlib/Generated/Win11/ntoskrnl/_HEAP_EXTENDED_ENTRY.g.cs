#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _HEAP_EXTENDED_ENTRY
    {
        [FieldOffset(0)]
        public IntPtr Reserved;
        [FieldOffset(8)]
        public ushort FunctionIndex;
        [FieldOffset(10)]
        public ushort ContextValue;
        [FieldOffset(8)]
        public uint InterceptorValue;
        [FieldOffset(12)]
        public ushort UnusedBytesLength;
        [FieldOffset(14)]
        public byte EntryOffset;
        [FieldOffset(15)]
        public byte ExtendedBlockSignature;
    }
}