#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _MI_COMBINE_STATE
    {
        [FieldOffset(0)]
        public int ActiveSpinLock;
        [FieldOffset(4)]
        public uint CombiningThreadCount;
        [FieldOffset(8)]
        public _RTL_AVL_TREE ActiveThreadTree;
        [FieldOffset(16)]
        public ulong CommonPageCombineDomain;
        [FieldOffset(24)]
        public uint CommonCombineDomainAssigned;
        [FieldOffset(28)]
        public int CombineSequence;
    }
}