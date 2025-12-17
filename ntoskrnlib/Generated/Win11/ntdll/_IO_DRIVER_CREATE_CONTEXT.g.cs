#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _IO_DRIVER_CREATE_CONTEXT
    {
        [FieldOffset(0)]
        public short Size;
        [FieldOffset(8)]
        public IntPtr ExtraCreateParameter;
        [FieldOffset(16)]
        public IntPtr DeviceObjectHint;
        [FieldOffset(24)]
        public IntPtr TxnParameters;
        [FieldOffset(32)]
        public IntPtr SiloContext;
    }
}