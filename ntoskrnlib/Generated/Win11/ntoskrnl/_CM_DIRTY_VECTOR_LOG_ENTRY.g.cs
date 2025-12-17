#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial struct _CM_DIRTY_VECTOR_LOG_ENTRY
    {
        [FieldOffset(0)]
        public IntPtr Thread;
        [FieldOffset(8)]
        public uint Operation;
        [FieldOffset(12)]
        public _unnamed_tag_ Data;
        [FieldOffset(24)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public IntPtr[] Stack;
    }
}