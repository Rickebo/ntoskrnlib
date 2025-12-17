#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _LOCK_HEADER
    {
        [FieldOffset(0)]
        public _RTL_AVL_TREE LockTree;
        [FieldOffset(8)]
        public _RTL_AVL_TREE LockMdlSwitchedTree;
        [FieldOffset(16)]
        public ulong Count;
        [FieldOffset(24)]
        public int Lock;
        [FieldOffset(28)]
        public uint Valid;
    }
}