#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial struct _ARC_DISK_INFORMATION
    {
        [FieldOffset(0)]
        public _LIST_ENTRY DiskSignatures;
    }
}