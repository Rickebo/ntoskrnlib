#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial struct _IOP_IRP_EXTENSION_STATUS
    {
        [FieldOffset(0)]
        public uint Flags;
        [FieldOffset(4)]
        public uint ActivityId;
        [FieldOffset(8)]
        public uint IoTracking;
    }
}