#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _OBJECT_REF_INFO
    {
        [FieldOffset(0)]
        public IntPtr ObjectHeader;
        [FieldOffset(8)]
        public IntPtr NextRef;
        [FieldOffset(16)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] ImageFileName;
        [FieldOffset(32)]
        public ushort NextPos;
        [FieldOffset(34)]
        public ushort MaxStacks;
        [FieldOffset(36)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 0)]
        public _OBJECT_REF_STACK_INFO[] StackInfo;
    }
}