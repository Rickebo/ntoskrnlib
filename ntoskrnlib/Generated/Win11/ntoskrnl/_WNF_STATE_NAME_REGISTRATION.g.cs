#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _WNF_STATE_NAME_REGISTRATION
    {
        [FieldOffset(0)]
        public uint MaxStateSize;
        [FieldOffset(8)]
        public IntPtr TypeId;
        [FieldOffset(16)]
        public IntPtr SecurityDescriptor;
    }
}