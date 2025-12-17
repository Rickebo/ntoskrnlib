#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 168)]
    public partial struct _KTMOBJECT_NAMESPACE
    {
        [FieldOffset(0)]
        public _RTL_AVL_TABLE Table;
        [FieldOffset(104)]
        public _KMUTANT Mutex;
        [FieldOffset(160)]
        public ushort LinksOffset;
        [FieldOffset(162)]
        public ushort GuidOffset;
        [FieldOffset(164)]
        public byte Expired;
    }
}