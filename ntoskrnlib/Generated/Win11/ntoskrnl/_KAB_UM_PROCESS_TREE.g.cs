#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _KAB_UM_PROCESS_TREE
    {
        [FieldOffset(0)]
        public _RTL_RB_TREE Tree;
        [FieldOffset(16)]
        public ulong TreeLock;
    }
}