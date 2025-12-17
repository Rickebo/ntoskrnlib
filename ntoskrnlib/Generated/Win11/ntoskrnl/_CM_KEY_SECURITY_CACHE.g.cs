#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _CM_KEY_SECURITY_CACHE
    {
        [FieldOffset(0)]
        public uint Cell;
        [FieldOffset(4)]
        public uint ConvKey;
        [FieldOffset(8)]
        public _LIST_ENTRY List;
        [FieldOffset(24)]
        public uint DescriptorLength;
        [FieldOffset(28)]
        public uint RealRefCount;
        [FieldOffset(32)]
        public _SECURITY_DESCRIPTOR_RELATIVE Descriptor;
    }
}