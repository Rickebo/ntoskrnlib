#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial struct _DBGKD_CONTEXT_EX
    {
        [FieldOffset(0)]
        public uint Offset;
        [FieldOffset(4)]
        public uint ByteCount;
        [FieldOffset(8)]
        public uint BytesCopied;
    }
}