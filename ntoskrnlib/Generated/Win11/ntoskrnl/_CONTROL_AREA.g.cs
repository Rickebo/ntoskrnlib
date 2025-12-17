#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 128)]
    public partial struct _CONTROL_AREA
    {
        [FieldOffset(0)]
        public IntPtr Segment;
        [FieldOffset(8)]
        public _LIST_ENTRY ListHead;
        [FieldOffset(8)]
        public IntPtr AweContext;
        [FieldOffset(24)]
        public ulong NumberOfSectionReferences;
        [FieldOffset(32)]
        public ulong NumberOfPfnReferences;
        [FieldOffset(40)]
        public ulong NumberOfMappedViews;
        [FieldOffset(48)]
        public ulong NumberOfUserReferences;
        [FieldOffset(56)]
        public _unnamed_tag_ u;
        [FieldOffset(60)]
        public _unnamed_tag_ u1;
        [FieldOffset(64)]
        public _EX_FAST_REF FilePointer;
        [FieldOffset(72)]
        public int ControlAreaLock;
        [FieldOffset(76)]
        public uint ModifiedWriteCount;
        [FieldOffset(80)]
        public IntPtr WaitList;
        [FieldOffset(88)]
        public _unnamed_tag_ u2;
        [FieldOffset(104)]
        public _EX_PUSH_LOCK FileObjectLock;
        [FieldOffset(112)]
        public ulong LockedPages;
        [FieldOffset(120)]
        public _unnamed_tag_ u3;
    }
}