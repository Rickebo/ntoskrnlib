#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _DEVICE_DATA_SET_RANGE
    {
        [FieldOffset(0)]
        public long StartingOffset;
        [FieldOffset(8)]
        public ulong LengthInBytes;
    }
}