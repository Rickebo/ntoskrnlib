#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 1)]
    public partial struct _PS_TRUSTLET_ATTRIBUTE_ACCESSRIGHTS
    {
        [FieldOffset(0)]
        public byte Trustlet;
        [FieldOffset(0)]
        public byte Ntos;
        [FieldOffset(0)]
        public byte WriteHandle;
        [FieldOffset(0)]
        public byte ReadHandle;
        [FieldOffset(0)]
        public byte Reserved;
        [FieldOffset(0)]
        public byte AccessRights;
    }
}