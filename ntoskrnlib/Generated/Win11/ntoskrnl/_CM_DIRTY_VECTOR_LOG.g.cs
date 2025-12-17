#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 1160)]
    public partial struct _CM_DIRTY_VECTOR_LOG
    {
        [FieldOffset(0)]
        public uint Next;
        [FieldOffset(4)]
        public uint Size;
        [FieldOffset(8)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public _CM_DIRTY_VECTOR_LOG_ENTRY[] Log;
    }
}