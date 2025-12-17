#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _PS_TRUSTLET_ATTRIBUTE_HEADER
    {
        [FieldOffset(0)]
        public _PS_TRUSTLET_ATTRIBUTE_TYPE AttributeType;
        [FieldOffset(4)]
        public uint InstanceNumber;
        [FieldOffset(4)]
        public uint Reserved;
    }
}