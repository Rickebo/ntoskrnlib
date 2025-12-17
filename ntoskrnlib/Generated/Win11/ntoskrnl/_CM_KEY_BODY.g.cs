#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 112)]
    public partial struct _CM_KEY_BODY
    {
        [FieldOffset(0)]
        public uint Type;
        [FieldOffset(4)]
        public ushort AccessCheckedLayerHeight;
        [FieldOffset(8)]
        public IntPtr KeyControlBlock;
        [FieldOffset(16)]
        public IntPtr NotifyBlock;
        [FieldOffset(24)]
        public IntPtr ProcessID;
        [FieldOffset(32)]
        public _LIST_ENTRY KeyBodyList;
        [FieldOffset(48)]
        public uint Flags;
        [FieldOffset(48)]
        public uint HandleTags;
        [FieldOffset(56)]
        public _CM_TRANS_PTR Trans;
        [FieldOffset(64)]
        public IntPtr KtmUow;
        [FieldOffset(72)]
        public _LIST_ENTRY ContextListHead;
        [FieldOffset(88)]
        public IntPtr EnumerationResumeContext;
        [FieldOffset(96)]
        public uint RestrictedAccessMask;
        [FieldOffset(100)]
        public uint LastSearchedIndex;
        [FieldOffset(104)]
        public IntPtr LockedMemoryMdls;
    }
}