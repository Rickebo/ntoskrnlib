#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _HEAP_VS_SUBSEGMENT
    {
        [FieldOffset(0)]
        public _LIST_ENTRY ListEntry;
        [FieldOffset(16)]
        public ulong CommitBitmap;
        [FieldOffset(24)]
        public ulong CommitLock;
        [FieldOffset(32)]
        public ushort Size;
        [FieldOffset(34)]
        public ushort OwnerSlotRef;
        [FieldOffset(36)]
        public ushort Signature;
        [FieldOffset(36)]
        public ushort FullCommit;
    }
}