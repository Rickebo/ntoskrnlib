#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _OBJECT_DIRECTORY_ENTRY
    {
        [FieldOffset(0)]
        public IntPtr ChainLink;
        [FieldOffset(8)]
        public IntPtr Object;
        [FieldOffset(16)]
        public uint HashValue;
    }
}