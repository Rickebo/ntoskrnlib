#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _HANDLE_TABLE_ENTRY_INFO
    {
        [FieldOffset(0)]
        public uint AuditMask;
        [FieldOffset(4)]
        public uint MaxRelativeAccessMask;
    }
}