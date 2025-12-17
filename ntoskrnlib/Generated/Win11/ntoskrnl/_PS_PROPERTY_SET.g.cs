#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _PS_PROPERTY_SET
    {
        [FieldOffset(0)]
        public _LIST_ENTRY ListHead;
        [FieldOffset(16)]
        public ulong Lock;
    }
}