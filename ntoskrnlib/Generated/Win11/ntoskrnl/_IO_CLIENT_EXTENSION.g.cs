#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _IO_CLIENT_EXTENSION
    {
        [FieldOffset(0)]
        public IntPtr NextExtension;
        [FieldOffset(8)]
        public IntPtr ClientIdentificationAddress;
    }
}