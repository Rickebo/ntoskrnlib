#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial struct _SEP_CACHED_HANDLES_ENTRY
    {
        [FieldOffset(0)]
        public _RTL_DYNAMIC_HASH_TABLE_ENTRY HashEntry;
        [FieldOffset(24)]
        public long ReferenceCount;
        [FieldOffset(32)]
        public _SEP_CACHED_HANDLES_ENTRY_DESCRIPTOR EntryDescriptor;
        [FieldOffset(56)]
        public uint HandleCount;
        [FieldOffset(64)]
        public IntPtr Handles;
    }
}