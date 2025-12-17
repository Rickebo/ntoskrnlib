#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial struct _CM_PARTIAL_RESOURCE_DESCRIPTOR
    {
        [FieldOffset(0)]
        public byte Type;
        [FieldOffset(1)]
        public byte ShareDisposition;
        [FieldOffset(2)]
        public ushort Flags;
        [FieldOffset(4)]
        public _unnamed_tag_ u;
    }
}