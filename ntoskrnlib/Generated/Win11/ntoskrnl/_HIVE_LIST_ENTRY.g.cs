#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 184)]
    public partial struct _HIVE_LIST_ENTRY
    {
        [FieldOffset(0)]
        public IntPtr FileName;
        [FieldOffset(8)]
        public IntPtr BaseName;
        [FieldOffset(16)]
        public IntPtr RegRootName;
        [FieldOffset(24)]
        public IntPtr CmHive;
        [FieldOffset(32)]
        public uint HHiveFlags;
        [FieldOffset(36)]
        public uint CmHiveFlags;
        [FieldOffset(40)]
        public uint CmKcbCacheSize;
        [FieldOffset(48)]
        public IntPtr CmHive2;
        [FieldOffset(56)]
        public byte HiveMounted;
        [FieldOffset(57)]
        public byte ThreadFinished;
        [FieldOffset(58)]
        public byte ThreadStarted;
        [FieldOffset(59)]
        public byte Allocate;
        [FieldOffset(60)]
        public byte WinPERequired;
        [FieldOffset(64)]
        public _KEVENT StartEvent;
        [FieldOffset(88)]
        public _KEVENT FinishedEvent;
        [FieldOffset(112)]
        public _KEVENT MountLock;
        [FieldOffset(136)]
        public _EX_PUSH_LOCK MountCallbackLock;
        [FieldOffset(144)]
        public _EX_PUSH_LOCK CallbackListLock;
        [FieldOffset(152)]
        public _LIST_ENTRY CallbackListHead;
        [FieldOffset(168)]
        public _UNICODE_STRING FilePath;
    }
}