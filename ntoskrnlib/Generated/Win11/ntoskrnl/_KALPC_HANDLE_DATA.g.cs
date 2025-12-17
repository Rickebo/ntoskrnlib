#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct _KALPC_HANDLE_DATA
    {
        [FieldOffset(0)]
        public uint ObjectType;
        [FieldOffset(4)]
        public uint Count;
        [FieldOffset(8)]
        public _OB_DUPLICATE_OBJECT_STATE DuplicateContext;
    }
}