#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _OBP_LOOKUP_CONTEXT
    {
        [FieldOffset(0)]
        public IntPtr Directory;
        [FieldOffset(8)]
        public IntPtr EntryLink;
        [FieldOffset(16)]
        public uint HashValue;
        [FieldOffset(20)]
        public byte HashIndex;
        [FieldOffset(21)]
        public byte LockedExclusive;
        [FieldOffset(22)]
        public byte DirectoryReferenced;
        [FieldOffset(23)]
        public byte Unused;
    }
}