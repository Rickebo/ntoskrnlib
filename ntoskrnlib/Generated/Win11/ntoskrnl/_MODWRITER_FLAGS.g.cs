#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _MODWRITER_FLAGS
    {
        [FieldOffset(0)]
        public uint KeepForever;
        [FieldOffset(0)]
        public uint Networked;
        [FieldOffset(0)]
        public uint IoPriority;
        [FieldOffset(0)]
        public uint PfBacked;
        [FieldOffset(0)]
        public uint ModifiedStoreWrite;
    }
}