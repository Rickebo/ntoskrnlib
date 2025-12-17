#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public partial struct _MM_PAGE_ACCESS_INFO_HEADER
    {
        [FieldOffset(0)]
        public _SINGLE_LIST_ENTRY Link;
        [FieldOffset(8)]
        public uint Type;
        [FieldOffset(12)]
        public uint EmptySequenceNumber;
        [FieldOffset(12)]
        public uint CurrentFileIndex;
        [FieldOffset(16)]
        public ulong CreateTime;
        [FieldOffset(24)]
        public ulong EmptyTime;
        [FieldOffset(24)]
        public IntPtr TempEntry;
        [FieldOffset(32)]
        public IntPtr PageEntry;
        [FieldOffset(40)]
        public IntPtr FileEntry;
        [FieldOffset(48)]
        public IntPtr FirstFileEntry;
        [FieldOffset(56)]
        public IntPtr Process;
        [FieldOffset(32)]
        public IntPtr PageFrameEntry;
        [FieldOffset(40)]
        public IntPtr LastPageFrameEntry;
    }
}