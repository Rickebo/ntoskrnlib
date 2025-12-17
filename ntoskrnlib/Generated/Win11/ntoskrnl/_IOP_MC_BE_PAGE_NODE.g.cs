#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _IOP_MC_BE_PAGE_NODE
    {
        [FieldOffset(0)]
        public _RTL_BALANCED_NODE Node;
        [FieldOffset(24)]
        public uint PageIndex;
    }
}