#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial struct _PS_TRUSTLET_ATTRIBUTE_TYPE
    {
        [FieldOffset(0)]
        public byte Version;
        [FieldOffset(1)]
        public byte DataCount;
        [FieldOffset(2)]
        public byte SemanticType;
        [FieldOffset(3)]
        public _PS_TRUSTLET_ATTRIBUTE_ACCESSRIGHTS AccessRights;
        [FieldOffset(0)]
        public uint AttributeType;
    }
}