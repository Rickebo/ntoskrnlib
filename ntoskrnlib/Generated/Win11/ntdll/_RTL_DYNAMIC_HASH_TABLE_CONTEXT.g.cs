#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _RTL_DYNAMIC_HASH_TABLE_CONTEXT
    {
        [FieldOffset(0)]
        public IntPtr ChainHead;
        [FieldOffset(8)]
        public IntPtr PrevLinkage;
        [FieldOffset(16)]
        public ulong Signature;
    }
}