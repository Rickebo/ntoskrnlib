#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial struct _CM_UOW_SET_VALUE_LIST_DATA
    {
        [FieldOffset(0)]
        public uint RefCount;
        [FieldOffset(4)]
        public _CHILD_LIST ValueList;
    }
}