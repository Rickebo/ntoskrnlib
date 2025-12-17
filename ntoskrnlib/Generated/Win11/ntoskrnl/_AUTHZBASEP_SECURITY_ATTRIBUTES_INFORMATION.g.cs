#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct _AUTHZBASEP_SECURITY_ATTRIBUTES_INFORMATION
    {
        [FieldOffset(0)]
        public uint SecurityAttributeCount;
        [FieldOffset(8)]
        public _LIST_ENTRY SecurityAttributesList;
        [FieldOffset(24)]
        public uint WorkingSecurityAttributeCount;
        [FieldOffset(32)]
        public _LIST_ENTRY WorkingSecurityAttributesList;
    }
}