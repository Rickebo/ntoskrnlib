#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 216)]
    public partial struct _FILE_OBJECT
    {
        [FieldOffset(0)]
        public short Type;
        [FieldOffset(2)]
        public short Size;
        [FieldOffset(8)]
        public IntPtr DeviceObject;
        [FieldOffset(16)]
        public IntPtr Vpb;
        [FieldOffset(24)]
        public IntPtr FsContext;
        [FieldOffset(32)]
        public IntPtr FsContext2;
        [FieldOffset(40)]
        public IntPtr SectionObjectPointer;
        [FieldOffset(48)]
        public IntPtr PrivateCacheMap;
        [FieldOffset(56)]
        public int FinalStatus;
        [FieldOffset(64)]
        public IntPtr RelatedFileObject;
        [FieldOffset(72)]
        public byte LockOperation;
        [FieldOffset(73)]
        public byte DeletePending;
        [FieldOffset(74)]
        public byte ReadAccess;
        [FieldOffset(75)]
        public byte WriteAccess;
        [FieldOffset(76)]
        public byte DeleteAccess;
        [FieldOffset(77)]
        public byte SharedRead;
        [FieldOffset(78)]
        public byte SharedWrite;
        [FieldOffset(79)]
        public byte SharedDelete;
        [FieldOffset(80)]
        public uint Flags;
        [FieldOffset(88)]
        public _UNICODE_STRING FileName;
        [FieldOffset(104)]
        public _LARGE_INTEGER CurrentByteOffset;
        [FieldOffset(112)]
        public uint Waiters;
        [FieldOffset(116)]
        public uint Busy;
        [FieldOffset(120)]
        public IntPtr LastLock;
        [FieldOffset(128)]
        public _KEVENT Lock;
        [FieldOffset(152)]
        public _KEVENT Event;
        [FieldOffset(176)]
        public IntPtr CompletionContext;
        [FieldOffset(184)]
        public ulong IrpListLock;
        [FieldOffset(192)]
        public _LIST_ENTRY IrpList;
        [FieldOffset(208)]
        public IntPtr FileObjectExtension;
    }
}