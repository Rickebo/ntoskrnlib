#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _PS_DYNAMIC_ENFORCED_ADDRESS_RANGES
    {
        [FieldOffset(0)]
        public _RTL_AVL_TREE Tree;
        [FieldOffset(8)]
        public _EX_PUSH_LOCK Lock;
    }
}