#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial struct _MMPFN
    {
        [FieldOffset(0)]
        public _LIST_ENTRY ListEntry;
        [FieldOffset(0)]
        public _RTL_BALANCED_NODE TreeNode;
        [FieldOffset(0)]
        public _MIPFNFLINK u1;
        [FieldOffset(8)]
        public IntPtr PteAddress;
        [FieldOffset(8)]
        public ulong PteLong;
        [FieldOffset(16)]
        public _MMPTE OriginalPte;
        [FieldOffset(24)]
        public _MIPFNBLINK u2;
        [FieldOffset(32)]
        public _unnamed_tag_ u3;
        [FieldOffset(36)]
        public _MI_PFN_FLAGS5 u5;
        [FieldOffset(40)]
        public _MI_PFN_FLAGS4 u4;
    }
}