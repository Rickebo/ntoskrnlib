#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _NT_IORING_BUFFERREF
    {
        [FieldOffset(0)]
        public IntPtr Address;
        [FieldOffset(0)]
        public IORING_REGISTERED_BUFFER FixedBuffer;
    }
}