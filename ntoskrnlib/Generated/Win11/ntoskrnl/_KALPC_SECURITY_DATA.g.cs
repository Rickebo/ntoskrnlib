#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 112)]
    public partial struct _KALPC_SECURITY_DATA
    {
        [FieldOffset(0)]
        public IntPtr HandleTable;
        [FieldOffset(8)]
        public IntPtr ContextHandle;
        [FieldOffset(16)]
        public IntPtr OwningProcess;
        [FieldOffset(24)]
        public IntPtr OwnerPort;
        [FieldOffset(32)]
        public _SECURITY_CLIENT_CONTEXT DynamicSecurity;
        [FieldOffset(104)]
        public _unnamed_tag_ u1;
    }
}