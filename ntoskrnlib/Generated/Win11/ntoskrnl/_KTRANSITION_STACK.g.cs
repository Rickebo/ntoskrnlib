#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 512)]
    public partial struct _KTRANSITION_STACK
    {
        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
        public byte[] Stack;
        [FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 464)]
        public byte[] IstStack;
        [FieldOffset(464)]
        public _KIST_BASE_FRAME IstFrame;
    }
}