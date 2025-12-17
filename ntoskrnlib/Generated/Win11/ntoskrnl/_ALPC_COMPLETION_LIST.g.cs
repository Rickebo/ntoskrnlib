#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 160)]
    public partial struct _ALPC_COMPLETION_LIST
    {
        [FieldOffset(0)]
        public _LIST_ENTRY Entry;
        [FieldOffset(16)]
        public IntPtr OwnerProcess;
        [FieldOffset(24)]
        public _EX_PUSH_LOCK CompletionListLock;
        [FieldOffset(32)]
        public IntPtr Mdl;
        [FieldOffset(40)]
        public IntPtr UserVa;
        [FieldOffset(48)]
        public IntPtr UserLimit;
        [FieldOffset(56)]
        public IntPtr DataUserVa;
        [FieldOffset(64)]
        public IntPtr SystemVa;
        [FieldOffset(72)]
        public ulong TotalSize;
        [FieldOffset(80)]
        public IntPtr Header;
        [FieldOffset(88)]
        public IntPtr List;
        [FieldOffset(96)]
        public ulong ListSize;
        [FieldOffset(104)]
        public IntPtr Bitmap;
        [FieldOffset(112)]
        public ulong BitmapSize;
        [FieldOffset(120)]
        public IntPtr Data;
        [FieldOffset(128)]
        public ulong DataSize;
        [FieldOffset(136)]
        public uint BitmapLimit;
        [FieldOffset(140)]
        public uint BitmapNextHint;
        [FieldOffset(144)]
        public uint ConcurrencyCount;
        [FieldOffset(148)]
        public uint AttributeFlags;
        [FieldOffset(152)]
        public uint AttributeSize;
    }
}