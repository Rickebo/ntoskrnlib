#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _CM_KEY_SECURITY
    {
        [FieldOffset(0)]
        public ushort Signature;
        [FieldOffset(2)]
        public ushort Reserved;
        [FieldOffset(4)]
        public uint Flink;
        [FieldOffset(8)]
        public uint Blink;
        [FieldOffset(12)]
        public uint ReferenceCount;
        [FieldOffset(16)]
        public uint DescriptorLength;
        [FieldOffset(20)]
        public _SECURITY_DESCRIPTOR_RELATIVE Descriptor;
    }
}