#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _CM_INDEX
    {
        [FieldOffset(0)]
        public uint Cell;
        [FieldOffset(4)]
        public _CM_FAST_LEAF_HINT NameHint;
        [FieldOffset(4)]
        public _CM_COMPONENT_HASH HashKey;
    }
}