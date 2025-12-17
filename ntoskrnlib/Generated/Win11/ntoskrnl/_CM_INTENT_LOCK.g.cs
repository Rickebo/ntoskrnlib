#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _CM_INTENT_LOCK
    {
        [FieldOffset(0)]
        public uint OwnerCount;
        [FieldOffset(8)]
        public IntPtr OwnerTable;
    }
}