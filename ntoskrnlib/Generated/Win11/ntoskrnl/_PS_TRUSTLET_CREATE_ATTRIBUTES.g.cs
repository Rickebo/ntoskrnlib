#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _PS_TRUSTLET_CREATE_ATTRIBUTES
    {
        [FieldOffset(0)]
        public ulong TrustletIdentity;
        [FieldOffset(8)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
        public _PS_TRUSTLET_ATTRIBUTE_DATA[] Attributes;
    }
}