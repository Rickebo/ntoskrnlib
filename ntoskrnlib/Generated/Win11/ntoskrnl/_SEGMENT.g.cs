#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial struct _SEGMENT
    {
        [FieldOffset(0)]
        public IntPtr ControlArea;
        [FieldOffset(8)]
        public uint TotalNumberOfPtes;
        [FieldOffset(12)]
        public _SEGMENT_FLAGS SegmentFlags;
        [FieldOffset(16)]
        public ulong NumberOfCommittedPages;
        [FieldOffset(24)]
        public ulong SizeOfSegment;
        [FieldOffset(32)]
        public IntPtr ExtendInfo;
        [FieldOffset(32)]
        public IntPtr BasedAddress;
        [FieldOffset(40)]
        public _EX_PUSH_LOCK SegmentLock;
        [FieldOffset(48)]
        public _unnamed_tag_ u1;
        [FieldOffset(56)]
        public _unnamed_tag_ u2;
        [FieldOffset(64)]
        public IntPtr PrototypePte;
    }
}