#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _SEP_SID_VALUES_BLOCK
    {
        [FieldOffset(0)]
        public uint BlockLength;
        [FieldOffset(8)]
        public long ReferenceCount;
        [FieldOffset(16)]
        public uint SidCount;
        [FieldOffset(24)]
        public ulong SidValuesStart;
    }
}