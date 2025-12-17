#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct IORING_REGISTERED_BUFFER
    {
        [FieldOffset(0)]
        public uint BufferIndex;
        [FieldOffset(4)]
        public uint Offset;
    }
}