#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public partial struct _WHEAP_ERROR_SOURCE_TABLE
    {
        [FieldOffset(0)]
        public uint Signature;
        [FieldOffset(4)]
        public int Count;
        [FieldOffset(8)]
        public uint NextId;
        [FieldOffset(16)]
        public _LIST_ENTRY Items;
        [FieldOffset(32)]
        public _KEVENT InsertLock;
    }
}