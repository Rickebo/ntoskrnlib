#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 2)]
    public partial struct _MI_SLAB_TYPE_IDENTIFIER
    {
        [FieldOffset(0)]
        public byte SlabType;
        [FieldOffset(1)]
        public byte SlabIdentity;
        [FieldOffset(1)]
        public byte ChargesAcquired;
    }
}