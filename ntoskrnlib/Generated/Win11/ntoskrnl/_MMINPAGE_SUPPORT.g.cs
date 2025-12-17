#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 448)]
    public partial struct _MMINPAGE_SUPPORT
    {
        [FieldOffset(0)]
        public _LIST_ENTRY ListEntry;
        [FieldOffset(0)]
        public _SLIST_ENTRY SListEntry;
        [FieldOffset(16)]
        public _LIST_ENTRY ListHead;
        [FieldOffset(32)]
        public _KEVENT Event;
        [FieldOffset(56)]
        public _KEVENT CollidedEvent;
        [FieldOffset(80)]
        public _IO_STATUS_BLOCK IoStatus;
        [FieldOffset(96)]
        public _LARGE_INTEGER ReadOffset;
        [FieldOffset(104)]
        public _unnamed_tag_ u2;
        [FieldOffset(152)]
        public IntPtr Thread;
        [FieldOffset(160)]
        public IntPtr LockedProtoPfn;
        [FieldOffset(168)]
        public _MMPTE PteContents;
        [FieldOffset(176)]
        public int WaitCount;
        [FieldOffset(180)]
        public int InjectRetry;
        [FieldOffset(184)]
        public uint ByteCount;
        [FieldOffset(188)]
        public _unnamed_tag_ u3;
        [FieldOffset(192)]
        public _unnamed_tag_ u1;
        [FieldOffset(200)]
        public IntPtr FilePointer;
        [FieldOffset(200)]
        public IntPtr PagingFile;
        [FieldOffset(208)]
        public IntPtr Subsection;
        [FieldOffset(216)]
        public IntPtr AutoBoostLock;
        [FieldOffset(224)]
        public IntPtr FaultingAddress;
        [FieldOffset(232)]
        public IntPtr PointerPte;
        [FieldOffset(240)]
        public IntPtr BasePte;
        [FieldOffset(248)]
        public IntPtr Pfn;
        [FieldOffset(256)]
        public IntPtr PrefetchMdl;
        [FieldOffset(264)]
        public long ProbeCount;
        [FieldOffset(272)]
        public _MDL Mdl;
        [FieldOffset(320)]
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public ulong[] Page;
        [FieldOffset(320)]
        public _MMINPAGE_SUPPORT_FLOW_THROUGH FlowThrough;
    }
}