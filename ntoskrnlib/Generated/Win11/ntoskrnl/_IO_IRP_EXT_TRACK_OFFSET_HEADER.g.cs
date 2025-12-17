#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _IO_IRP_EXT_TRACK_OFFSET_HEADER
    {
        [FieldOffset(0)]
        public ushort Validation;
        [FieldOffset(2)]
        public ushort Flags;
        [FieldOffset(8)]
        public IntPtr TrackedOffsetCallback;
    }
}