#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _RTL_QUERY_REGISTRY_TABLE
    {
        [FieldOffset(0)]
        public IntPtr QueryRoutine;
        [FieldOffset(8)]
        public uint Flags;
        [FieldOffset(16)]
        public IntPtr Name;
        [FieldOffset(24)]
        public IntPtr EntryContext;
        [FieldOffset(32)]
        public uint DefaultType;
        [FieldOffset(40)]
        public IntPtr DefaultData;
        [FieldOffset(48)]
        public uint DefaultLength;
    }
}