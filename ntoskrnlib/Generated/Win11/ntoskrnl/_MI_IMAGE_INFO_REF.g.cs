#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _MI_IMAGE_INFO_REF
    {
        [FieldOffset(0)]
        public int LongValue;
        [FieldOffset(0)]
        public ulong FullValue;
        [FieldOffset(0)]
        public IntPtr PointerValue;
        [FieldOffset(0)]
        public ulong AllFlags;
        [FieldOffset(0)]
        public ulong DebugRecordsPresent;
    }
}