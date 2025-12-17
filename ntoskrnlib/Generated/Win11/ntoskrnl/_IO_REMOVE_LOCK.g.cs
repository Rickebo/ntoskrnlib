#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial struct _IO_REMOVE_LOCK
    {
        [FieldOffset(0)]
        public _IO_REMOVE_LOCK_COMMON_BLOCK Common;
    }
}