#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _MM_STORE_SUB_KEY_DESCRIPTOR
    {
        [FieldOffset(0)]
        public _unnamed_tag_ Flags;
        [FieldOffset(0)]
        public IntPtr VirtualAddress;
    }
}