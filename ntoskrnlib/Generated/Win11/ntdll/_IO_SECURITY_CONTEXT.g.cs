#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _IO_SECURITY_CONTEXT
    {
        [FieldOffset(0)]
        public IntPtr SecurityQos;
        [FieldOffset(8)]
        public IntPtr AccessState;
        [FieldOffset(16)]
        public uint DesiredAccess;
        [FieldOffset(20)]
        public uint FullCreateOptions;
    }
}