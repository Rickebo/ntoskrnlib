#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _KTMOBJECT_NAMESPACE_LINK
    {
        [FieldOffset(0)]
        public _RTL_BALANCED_LINKS Links;
        [FieldOffset(32)]
        public byte Expired;
    }
}