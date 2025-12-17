#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _ETW_PROVIDER_TRAITS
    {
        [FieldOffset(0)]
        public _RTL_BALANCED_NODE Node;
        [FieldOffset(24)]
        public uint ReferenceCount;
        [FieldOffset(28)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public byte[] Traits;
    }
}